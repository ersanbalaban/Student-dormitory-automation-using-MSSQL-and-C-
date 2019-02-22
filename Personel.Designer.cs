namespace VeriTabaniProje
{
    partial class Personel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.txtYurtID = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.txtYurtID);
            this.groupBox1.Controls.Add(this.txtBirim);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSil.Location = new System.Drawing.Point(179, 112);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 36);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDegistir.Location = new System.Drawing.Point(97, 112);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 36);
            this.btnDegistir.TabIndex = 7;
            this.btnDegistir.Text = "Güncelleştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPersonelEkle.Location = new System.Drawing.Point(16, 112);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(75, 36);
            this.btnPersonelEkle.TabIndex = 6;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // txtYurtID
            // 
            this.txtYurtID.Location = new System.Drawing.Point(119, 83);
            this.txtYurtID.Name = "txtYurtID";
            this.txtYurtID.Size = new System.Drawing.Size(119, 20);
            this.txtYurtID.TabIndex = 5;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(119, 55);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(119, 20);
            this.txtBirim.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(119, 27);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(119, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yurt ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persone Birim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad Soyad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 182);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(525, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYurtID;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}