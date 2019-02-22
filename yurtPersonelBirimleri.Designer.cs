namespace VeriTabaniProje
{
    partial class yurtPersonelBirimleri
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
            this.lstKayitListele = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnListele2 = new System.Windows.Forms.Button();
            this.btnDosyayaYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKayitListele
            // 
            this.lstKayitListele.FormattingEnabled = true;
            this.lstKayitListele.Location = new System.Drawing.Point(12, 12);
            this.lstKayitListele.Name = "lstKayitListele";
            this.lstKayitListele.Size = new System.Drawing.Size(354, 199);
            this.lstKayitListele.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnListele.Location = new System.Drawing.Point(372, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 55);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Yurtlardaki Personeller";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnListele2
            // 
            this.btnListele2.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnListele2.Location = new System.Drawing.Point(372, 86);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(75, 58);
            this.btnListele2.TabIndex = 2;
            this.btnListele2.Text = "Personellerin Çalıştığı Birimler";
            this.btnListele2.UseVisualStyleBackColor = false;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // btnDosyayaYaz
            // 
            this.btnDosyayaYaz.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDosyayaYaz.Location = new System.Drawing.Point(372, 159);
            this.btnDosyayaYaz.Name = "btnDosyayaYaz";
            this.btnDosyayaYaz.Size = new System.Drawing.Size(75, 52);
            this.btnDosyayaYaz.TabIndex = 3;
            this.btnDosyayaYaz.Text = "Dosyaya Aktar";
            this.btnDosyayaYaz.UseVisualStyleBackColor = false;
            this.btnDosyayaYaz.Click += new System.EventHandler(this.btnDosyayaYaz_Click);
            // 
            // yurtPersonelBirimleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(482, 249);
            this.Controls.Add(this.btnDosyayaYaz);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lstKayitListele);
            this.Name = "yurtPersonelBirimleri";
            this.Text = "Yurtlardaki Personel Birimleri";
            this.Load += new System.EventHandler(this.yurtPersonelBirimleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKayitListele;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnListele2;
        private System.Windows.Forms.Button btnDosyayaYaz;
    }
}