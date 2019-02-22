namespace VeriTabaniProje
{
    partial class Yurt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYurtAd = new System.Windows.Forms.TextBox();
            this.txtYurtTelefon = new System.Windows.Forms.TextBox();
            this.txtYurtAdres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYurtIslemleri = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYurtEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yurt Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yurt Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yurt Adresi:";
            // 
            // txtYurtAd
            // 
            this.txtYurtAd.Location = new System.Drawing.Point(81, 19);
            this.txtYurtAd.Name = "txtYurtAd";
            this.txtYurtAd.Size = new System.Drawing.Size(135, 20);
            this.txtYurtAd.TabIndex = 4;
            // 
            // txtYurtTelefon
            // 
            this.txtYurtTelefon.Location = new System.Drawing.Point(81, 47);
            this.txtYurtTelefon.Name = "txtYurtTelefon";
            this.txtYurtTelefon.Size = new System.Drawing.Size(135, 20);
            this.txtYurtTelefon.TabIndex = 5;
            // 
            // txtYurtAdres
            // 
            this.txtYurtAdres.Location = new System.Drawing.Point(82, 74);
            this.txtYurtAdres.Name = "txtYurtAdres";
            this.txtYurtAdres.Size = new System.Drawing.Size(134, 20);
            this.txtYurtAdres.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnYurtIslemleri);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnYurtEkle);
            this.groupBox1.Controls.Add(this.txtYurtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYurtAdres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYurtTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yurt Bilgileri";
            // 
            // btnYurtIslemleri
            // 
            this.btnYurtIslemleri.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnYurtIslemleri.Location = new System.Drawing.Point(186, 109);
            this.btnYurtIslemleri.Name = "btnYurtIslemleri";
            this.btnYurtIslemleri.Size = new System.Drawing.Size(90, 34);
            this.btnYurtIslemleri.TabIndex = 10;
            this.btnYurtIslemleri.Text = "Yurt İşlemleri";
            this.btnYurtIslemleri.UseVisualStyleBackColor = false;
            this.btnYurtIslemleri.Click += new System.EventHandler(this.btnYurtIslemleri_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnGuncelle.Location = new System.Drawing.Point(102, 109);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 34);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYurtEkle
            // 
            this.btnYurtEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnYurtEkle.Location = new System.Drawing.Point(20, 109);
            this.btnYurtEkle.Name = "btnYurtEkle";
            this.btnYurtEkle.Size = new System.Drawing.Size(75, 34);
            this.btnYurtEkle.TabIndex = 8;
            this.btnYurtEkle.Text = "Ekle";
            this.btnYurtEkle.UseVisualStyleBackColor = false;
            this.btnYurtEkle.Click += new System.EventHandler(this.btnYurtEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 183);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Yurt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(575, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Yurt";
            this.Text = "Yurt";
            this.Load += new System.EventHandler(this.Yurt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYurtAd;
        private System.Windows.Forms.TextBox txtYurtTelefon;
        private System.Windows.Forms.TextBox txtYurtAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYurtEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYurtIslemleri;
    }
}