
namespace _192113035
{
    partial class ogrenciEmanetListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciEmanetListe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.ogrenciNumara_txt = new System.Windows.Forms.TextBox();
            this.Ogrenci_Numarası_lbl = new System.Windows.Forms.Label();
            this.btnKayitlar = new System.Windows.Forms.Button();
            this.kayit_dg = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.btnArama);
            this.groupBox1.Controls.Add(this.ogrenciNumara_txt);
            this.groupBox1.Controls.Add(this.Ogrenci_Numarası_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(261, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMANET İADE EDİLEN KİTAPLAR ";
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.Beige;
            this.btnArama.Location = new System.Drawing.Point(16, 115);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(521, 32);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // ogrenciNumara_txt
            // 
            this.ogrenciNumara_txt.BackColor = System.Drawing.Color.Beige;
            this.ogrenciNumara_txt.Location = new System.Drawing.Point(225, 62);
            this.ogrenciNumara_txt.Name = "ogrenciNumara_txt";
            this.ogrenciNumara_txt.Size = new System.Drawing.Size(312, 27);
            this.ogrenciNumara_txt.TabIndex = 1;
            // 
            // Ogrenci_Numarası_lbl
            // 
            this.Ogrenci_Numarası_lbl.AutoSize = true;
            this.Ogrenci_Numarası_lbl.Location = new System.Drawing.Point(15, 69);
            this.Ogrenci_Numarası_lbl.Name = "Ogrenci_Numarası_lbl";
            this.Ogrenci_Numarası_lbl.Size = new System.Drawing.Size(167, 20);
            this.Ogrenci_Numarası_lbl.TabIndex = 0;
            this.Ogrenci_Numarası_lbl.Text = "Öğrenci Numarası:";
            // 
            // btnKayitlar
            // 
            this.btnKayitlar.BackColor = System.Drawing.Color.Beige;
            this.btnKayitlar.Location = new System.Drawing.Point(706, 259);
            this.btnKayitlar.Name = "btnKayitlar";
            this.btnKayitlar.Size = new System.Drawing.Size(178, 50);
            this.btnKayitlar.TabIndex = 5;
            this.btnKayitlar.Text = "KAYITLAR";
            this.btnKayitlar.UseVisualStyleBackColor = false;
            this.btnKayitlar.Click += new System.EventHandler(this.btnKayitlar_Click);
            // 
            // kayit_dg
            // 
            this.kayit_dg.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.kayit_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayit_dg.Location = new System.Drawing.Point(261, 335);
            this.kayit_dg.Name = "kayit_dg";
            this.kayit_dg.RowHeadersWidth = 51;
            this.kayit_dg.RowTemplate.Height = 24;
            this.kayit_dg.Size = new System.Drawing.Size(997, 321);
            this.kayit_dg.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Beige;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.Location = new System.Drawing.Point(12, 27);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(140, 41);
            this.btnGeri.TabIndex = 121;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ogrenciEmanetListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 715);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.kayit_dg);
            this.Controls.Add(this.btnKayitlar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ogrenciEmanetListe";
            this.Text = "ogrenciEmanetListe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.TextBox ogrenciNumara_txt;
        private System.Windows.Forms.Label Ogrenci_Numarası_lbl;
        private System.Windows.Forms.Button btnKayitlar;
        private System.Windows.Forms.DataGridView kayit_dg;
        private System.Windows.Forms.Button btnGeri;
    }
}