
namespace _192113035
{
    partial class KitapEmanetListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEmanetListe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.kitapBilgi_txt = new System.Windows.Forms.TextBox();
            this.kitap_bilgi_lbl = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.kategori_lbl = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.Kayit_Listesi_dg = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kayit_Listesi_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.btnArama);
            this.groupBox1.Controls.Add(this.kitapBilgi_txt);
            this.groupBox1.Controls.Add(this.kitap_bilgi_lbl);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.kategori_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(195, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMANET- İADE EDİLEN KİTAP";
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.Beige;
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Location = new System.Drawing.Point(27, 165);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(446, 29);
            this.btnArama.TabIndex = 4;
            this.btnArama.Text = "KİTAP ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // kitapBilgi_txt
            // 
            this.kitapBilgi_txt.BackColor = System.Drawing.Color.Beige;
            this.kitapBilgi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapBilgi_txt.Location = new System.Drawing.Point(211, 120);
            this.kitapBilgi_txt.Name = "kitapBilgi_txt";
            this.kitapBilgi_txt.Size = new System.Drawing.Size(262, 27);
            this.kitapBilgi_txt.TabIndex = 3;
            // 
            // kitap_bilgi_lbl
            // 
            this.kitap_bilgi_lbl.AutoSize = true;
            this.kitap_bilgi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_bilgi_lbl.Location = new System.Drawing.Point(24, 127);
            this.kitap_bilgi_lbl.Name = "kitap_bilgi_lbl";
            this.kitap_bilgi_lbl.Size = new System.Drawing.Size(103, 20);
            this.kitap_bilgi_lbl.TabIndex = 2;
            this.kitap_bilgi_lbl.Text = "Kitap Bilgisi:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 20;
            this.cmbKategori.Items.AddRange(new object[] {
            "YazarAdi",
            "KitapAdi",
            "KitapTuru",
            "KitapID",
            "YayinEvi"});
            this.cmbKategori.Location = new System.Drawing.Point(207, 66);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(266, 28);
            this.cmbKategori.TabIndex = 1;
            // 
            // kategori_lbl
            // 
            this.kategori_lbl.AutoSize = true;
            this.kategori_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_lbl.Location = new System.Drawing.Point(23, 73);
            this.kategori_lbl.Name = "kategori_lbl";
            this.kategori_lbl.Size = new System.Drawing.Size(151, 20);
            this.kategori_lbl.TabIndex = 0;
            this.kategori_lbl.Text = "Aranacak Kategori:";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Beige;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(626, 299);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(182, 36);
            this.btnKayit.TabIndex = 3;
            this.btnKayit.Text = "KAYITLAR";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // Kayit_Listesi_dg
            // 
            this.Kayit_Listesi_dg.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.Kayit_Listesi_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kayit_Listesi_dg.Location = new System.Drawing.Point(277, 337);
            this.Kayit_Listesi_dg.Name = "Kayit_Listesi_dg";
            this.Kayit_Listesi_dg.RowHeadersWidth = 51;
            this.Kayit_Listesi_dg.RowTemplate.Height = 24;
            this.Kayit_Listesi_dg.Size = new System.Drawing.Size(831, 366);
            this.Kayit_Listesi_dg.TabIndex = 4;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Beige;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Location = new System.Drawing.Point(12, 49);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(140, 41);
            this.btnGeri.TabIndex = 120;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // KitapEmanetListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 715);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.Kayit_Listesi_dg);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "KitapEmanetListe";
            this.Text = "KitapEmanetListe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kayit_Listesi_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox kitapBilgi_txt;
        private System.Windows.Forms.Label kitap_bilgi_lbl;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label kategori_lbl;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView Kayit_Listesi_dg;
        private System.Windows.Forms.Button btnGeri;
    }
}