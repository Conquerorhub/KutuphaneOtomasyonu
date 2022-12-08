
namespace _192113035
{
    partial class Grafik
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
            this.Geri_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Geri_btn
            // 
            this.Geri_btn.Location = new System.Drawing.Point(24, 96);
            this.Geri_btn.Name = "Geri_btn";
            this.Geri_btn.Size = new System.Drawing.Size(140, 41);
            this.Geri_btn.TabIndex = 2;
            this.Geri_btn.Text = "GERİ";
            this.Geri_btn.UseVisualStyleBackColor = true;
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 715);
            this.Controls.Add(this.Geri_btn);
            this.Name = "Grafik";
            this.Text = "Grafik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Geri_btn;
    }
}