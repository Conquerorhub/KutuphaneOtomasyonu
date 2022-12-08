
namespace _192113035
{
    partial class KitapIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslem));
            this.btnArama = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.kitapKayitlar = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.kitapTur_txt = new System.Windows.Forms.TextBox();
            this.KitapTur_lbl = new System.Windows.Forms.Label();
            this.sayfaSayi_txt = new System.Windows.Forms.TextBox();
            this.SayfaSayısı_lbl = new System.Windows.Forms.Label();
            this.yazarAdi_txt = new System.Windows.Forms.TextBox();
            this.YazarAdı_lbl = new System.Windows.Forms.Label();
            this.kitapAdi_txt = new System.Windows.Forms.TextBox();
            this.KitapAdı_lbl = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.KitapID_lbl = new System.Windows.Forms.Label();
            this.Ogrencibilgileri = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kitap_txt = new System.Windows.Forms.TextBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kitapKayitlar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.Beige;
            this.btnArama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArama.Location = new System.Drawing.Point(853, 235);
            this.btnArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(208, 24);
            this.btnArama.TabIndex = 116;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackColor = System.Drawing.Color.Beige;
            this.btnKitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitaplar.Location = new System.Drawing.Point(941, 346);
            this.btnKitaplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(173, 30);
            this.btnKitaplar.TabIndex = 111;
            this.btnKitaplar.Text = "KİTAPLAR";
            this.btnKitaplar.UseVisualStyleBackColor = false;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // kitapKayitlar
            // 
            this.kitapKayitlar.BackgroundColor = System.Drawing.Color.Beige;
            this.kitapKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapKayitlar.Location = new System.Drawing.Point(616, 390);
            this.kitapKayitlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitapKayitlar.Name = "kitapKayitlar";
            this.kitapKayitlar.RowHeadersWidth = 51;
            this.kitapKayitlar.RowTemplate.Height = 24;
            this.kitapKayitlar.Size = new System.Drawing.Size(700, 282);
            this.kitapKayitlar.TabIndex = 110;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Beige;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Location = new System.Drawing.Point(30, 32);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(140, 41);
            this.btnGeri.TabIndex = 119;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.kitapTur_txt);
            this.panel2.Controls.Add(this.KitapTur_lbl);
            this.panel2.Controls.Add(this.sayfaSayi_txt);
            this.panel2.Controls.Add(this.SayfaSayısı_lbl);
            this.panel2.Controls.Add(this.yazarAdi_txt);
            this.panel2.Controls.Add(this.YazarAdı_lbl);
            this.panel2.Controls.Add(this.kitapAdi_txt);
            this.panel2.Controls.Add(this.KitapAdı_lbl);
            this.panel2.Controls.Add(this.ID_txt);
            this.panel2.Controls.Add(this.KitapID_lbl);
            this.panel2.Controls.Add(this.Ogrencibilgileri);
            this.panel2.Location = new System.Drawing.Point(30, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 362);
            this.panel2.TabIndex = 120;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Beige;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(180, 307);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 39);
            this.btnSil.TabIndex = 123;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Beige;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Location = new System.Drawing.Point(312, 307);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 39);
            this.btnGuncelle.TabIndex = 122;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Beige;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(44, 307);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 39);
            this.btnEkle.TabIndex = 121;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // kitapTur_txt
            // 
            this.kitapTur_txt.Location = new System.Drawing.Point(171, 254);
            this.kitapTur_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitapTur_txt.Name = "kitapTur_txt";
            this.kitapTur_txt.Size = new System.Drawing.Size(201, 22);
            this.kitapTur_txt.TabIndex = 120;
            // 
            // KitapTur_lbl
            // 
            this.KitapTur_lbl.AutoSize = true;
            this.KitapTur_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapTur_lbl.Location = new System.Drawing.Point(58, 256);
            this.KitapTur_lbl.Name = "KitapTur_lbl";
            this.KitapTur_lbl.Size = new System.Drawing.Size(91, 20);
            this.KitapTur_lbl.TabIndex = 119;
            this.KitapTur_lbl.Text = "Kitap Türü:";
            // 
            // sayfaSayi_txt
            // 
            this.sayfaSayi_txt.Location = new System.Drawing.Point(171, 219);
            this.sayfaSayi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sayfaSayi_txt.Name = "sayfaSayi_txt";
            this.sayfaSayi_txt.Size = new System.Drawing.Size(201, 22);
            this.sayfaSayi_txt.TabIndex = 118;
            // 
            // SayfaSayısı_lbl
            // 
            this.SayfaSayısı_lbl.AutoSize = true;
            this.SayfaSayısı_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SayfaSayısı_lbl.Location = new System.Drawing.Point(58, 219);
            this.SayfaSayısı_lbl.Name = "SayfaSayısı_lbl";
            this.SayfaSayısı_lbl.Size = new System.Drawing.Size(106, 20);
            this.SayfaSayısı_lbl.TabIndex = 117;
            this.SayfaSayısı_lbl.Text = "Sayfa Sayısı:";
            // 
            // yazarAdi_txt
            // 
            this.yazarAdi_txt.Location = new System.Drawing.Point(171, 185);
            this.yazarAdi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yazarAdi_txt.Name = "yazarAdi_txt";
            this.yazarAdi_txt.Size = new System.Drawing.Size(201, 22);
            this.yazarAdi_txt.TabIndex = 116;
            // 
            // YazarAdı_lbl
            // 
            this.YazarAdı_lbl.AutoSize = true;
            this.YazarAdı_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YazarAdı_lbl.Location = new System.Drawing.Point(58, 185);
            this.YazarAdı_lbl.Name = "YazarAdı_lbl";
            this.YazarAdı_lbl.Size = new System.Drawing.Size(86, 20);
            this.YazarAdı_lbl.TabIndex = 115;
            this.YazarAdı_lbl.Text = "Yazar Adı:";
            // 
            // kitapAdi_txt
            // 
            this.kitapAdi_txt.Location = new System.Drawing.Point(171, 155);
            this.kitapAdi_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kitapAdi_txt.Name = "kitapAdi_txt";
            this.kitapAdi_txt.Size = new System.Drawing.Size(201, 22);
            this.kitapAdi_txt.TabIndex = 114;
            // 
            // KitapAdı_lbl
            // 
            this.KitapAdı_lbl.AutoSize = true;
            this.KitapAdı_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapAdı_lbl.Location = new System.Drawing.Point(58, 153);
            this.KitapAdı_lbl.Name = "KitapAdı_lbl";
            this.KitapAdı_lbl.Size = new System.Drawing.Size(81, 20);
            this.KitapAdı_lbl.TabIndex = 113;
            this.KitapAdı_lbl.Text = "Kitap Adı:";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(171, 123);
            this.ID_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(201, 22);
            this.ID_txt.TabIndex = 112;
            // 
            // KitapID_lbl
            // 
            this.KitapID_lbl.AutoSize = true;
            this.KitapID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapID_lbl.Location = new System.Drawing.Point(59, 123);
            this.KitapID_lbl.Name = "KitapID_lbl";
            this.KitapID_lbl.Size = new System.Drawing.Size(63, 18);
            this.KitapID_lbl.TabIndex = 111;
            this.KitapID_lbl.Text = "Kitap ID:";
            // 
            // Ogrencibilgileri
            // 
            this.Ogrencibilgileri.AutoSize = true;
            this.Ogrencibilgileri.BackColor = System.Drawing.Color.Transparent;
            this.Ogrencibilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrencibilgileri.Location = new System.Drawing.Point(77, 73);
            this.Ogrencibilgileri.Name = "Ogrencibilgileri";
            this.Ogrencibilgileri.Size = new System.Drawing.Size(270, 29);
            this.Ogrencibilgileri.TabIndex = 110;
            this.Ogrencibilgileri.Text = "KİTAPA AİT BİLGİLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.kitap_txt);
            this.panel1.Controls.Add(this.cmbKitap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(393, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 307);
            this.panel1.TabIndex = 121;
            // 
            // kitap_txt
            // 
            this.kitap_txt.Location = new System.Drawing.Point(101, 262);
            this.kitap_txt.Name = "kitap_txt";
            this.kitap_txt.Size = new System.Drawing.Size(253, 22);
            this.kitap_txt.TabIndex = 122;
            // 
            // cmbKitap
            // 
            this.cmbKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Items.AddRange(new object[] {
            "YazarAdi",
            "KitapAdi",
            "KitapTuru",
            "KitapID",
            "YayinEvi"});
            this.cmbKitap.Location = new System.Drawing.Point(101, 217);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(253, 24);
            this.cmbKitap.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 120;
            this.label1.Text = "KİTAP ARA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(122, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 145);
            this.panel3.TabIndex = 119;
            // 
            // KitapIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnKitaplar);
            this.Controls.Add(this.kitapKayitlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "KitapIslem";
            this.Text = "KitapIslem";
            ((System.ComponentModel.ISupportInitialize)(this.kitapKayitlar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.DataGridView kitapKayitlar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox kitapTur_txt;
        private System.Windows.Forms.Label KitapTur_lbl;
        private System.Windows.Forms.TextBox sayfaSayi_txt;
        private System.Windows.Forms.Label SayfaSayısı_lbl;
        private System.Windows.Forms.TextBox yazarAdi_txt;
        private System.Windows.Forms.Label YazarAdı_lbl;
        private System.Windows.Forms.TextBox kitapAdi_txt;
        private System.Windows.Forms.Label KitapAdı_lbl;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label KitapID_lbl;
        private System.Windows.Forms.Label Ogrencibilgileri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kitap_txt;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}