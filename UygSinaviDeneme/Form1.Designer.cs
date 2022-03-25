namespace UygSinaviDeneme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblUrunaAdi = new System.Windows.Forms.Label();
            this.lblUreticiFirma = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtureticifirma = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UreticiFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(374, 304);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(87, 22);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(224, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(360, 22);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(646, 22);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblUrunaAdi
            // 
            this.lblUrunaAdi.AutoSize = true;
            this.lblUrunaAdi.Location = new System.Drawing.Point(84, 95);
            this.lblUrunaAdi.Name = "lblUrunaAdi";
            this.lblUrunaAdi.Size = new System.Drawing.Size(64, 16);
            this.lblUrunaAdi.TabIndex = 2;
            this.lblUrunaAdi.Text = "Urun Adı: ";
            // 
            // lblUreticiFirma
            // 
            this.lblUreticiFirma.AutoSize = true;
            this.lblUreticiFirma.Location = new System.Drawing.Point(84, 147);
            this.lblUreticiFirma.Name = "lblUreticiFirma";
            this.lblUreticiFirma.Size = new System.Drawing.Size(82, 16);
            this.lblUreticiFirma.TabIndex = 3;
            this.lblUreticiFirma.Text = "Uretici Firma";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(84, 196);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(36, 16);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(84, 236);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(80, 16);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "Kategori Adi";
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(224, 92);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(100, 22);
            this.txturunadi.TabIndex = 7;
            // 
            // txtureticifirma
            // 
            this.txtureticifirma.Location = new System.Drawing.Point(224, 147);
            this.txtureticifirma.Name = "txtureticifirma";
            this.txtureticifirma.Size = new System.Drawing.Size(100, 22);
            this.txtureticifirma.TabIndex = 8;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(224, 190);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtfiyat.TabIndex = 9;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(224, 236);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 24);
            this.cmbkategori.TabIndex = 10;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UrunAdi,
            this.UreticiFirma,
            this.Fiyat,
            this.KategoriAdi});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 503);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1377, 204);
            this.Liste.TabIndex = 11;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "UrunAdi";
            this.UrunAdi.MinimumWidth = 6;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Width = 125;
            // 
            // UreticiFirma
            // 
            this.UreticiFirma.HeaderText = "UreticiFirma";
            this.UreticiFirma.MinimumWidth = 6;
            this.UreticiFirma.Name = "UreticiFirma";
            this.UreticiFirma.Width = 125;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 125;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.HeaderText = "KategoriAdi";
            this.KategoriAdi.MinimumWidth = 6;
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 707);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtureticifirma);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUreticiFirma);
            this.Controls.Add(this.lblUrunaAdi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblUrunaAdi;
        private System.Windows.Forms.Label lblUreticiFirma;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtureticifirma;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UreticiFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
    }
}

