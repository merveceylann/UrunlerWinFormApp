using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UygSinaviDeneme.DataAccess;
using UygSinaviDeneme.Entity;

namespace UygSinaviDeneme
{
    public partial class Form1 : Form
    {
        UrunlerDenemeDbContext db = new UrunlerDenemeDbContext();
        public int secimId = -1;
        public Urun urunler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            var kategori = db.Kategoriler.ToList();
            cmbkategori.DataSource = kategori;
            cmbkategori.ValueMember = "kategoriAdi";
            cmbkategori.SelectedIndex = -1;
            cmbkategori.DisplayMember = "kategori";


        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.Urunler
                       select new
                       {
                           Id=s.Id,
                           UrunAdi = s.UrunAdi,
                           UreticiFirma = s.UreticiFirma,
                           Fiyat = s.Fiyat,
                           KategoriAdi = s.Kategori.KategoriAdi
                       }).ToList();

            foreach (var liste in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = liste.Id;
                Liste.Rows[i].Cells[1].Value = liste.UrunAdi;
                Liste.Rows[i].Cells[2].Value = liste.UreticiFirma;
                Liste.Rows[i].Cells[3].Value = liste.Fiyat;
                Liste.Rows[i].Cells[4].Value = liste.KategoriAdi;
                sira++; i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            Urun urn = new Urun();
            urn.UrunAdi = txturunadi.Text;
            urn.UreticiFirma = txtureticifirma.Text;
            urn.Fiyat = txtfiyat.Text;
            if (cmbkategori.SelectedValue != null)
            {
                urn.KategoriId = cmbkategori.SelectedIndex;

            }
            db.Urunler.Add(urn);
            db.SaveChanges();
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtfiyat.Clear();
            txtureticifirma.Clear();
            txturunadi.Clear();
            cmbkategori.SelectedIndex = -1;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            Urun urn = urunler;
            urn.UrunAdi = txturunadi.Text;
            urn.UreticiFirma = txtureticifirma.Text;
            urn.Fiyat = txtfiyat.Text;
            if (cmbkategori.SelectedValue != null)
            {
                urn.KategoriId = cmbkategori.SelectedIndex;

            }

            db.SaveChanges();
            Listele();
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {

            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void Ac(int i)
        {
            secimId = i;
            urunler = db.Urunler.Find(i);
            try
            {
                Urun urun = urunler;
                txtfiyat.Text = urun.Fiyat;
                txtureticifirma.Text = urun.UreticiFirma;
                txturunadi.Text = urun.UrunAdi;
                cmbkategori.Text = urun.Kategori.KategoriAdi;
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                Urun urun = urunler;
                db.Urunler.Remove(urun);
                db.SaveChanges();
            }
            Listele();
            Temizle();
        }
    }
}

