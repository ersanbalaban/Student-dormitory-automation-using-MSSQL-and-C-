namespace VeriTabaniProje
{
    partial class Bankalar
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
            this.btnBankaSil = new System.Windows.Forms.Button();
            this.btnBankaEkle = new System.Windows.Forms.Button();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtBankaAdi = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnBankaSil);
            this.groupBox1.Controls.Add(this.btnBankaEkle);
            this.groupBox1.Controls.Add(this.txtOgrID);
            this.groupBox1.Controls.Add(this.txtHesapNo);
            this.groupBox1.Controls.Add(this.txtBankaAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banka Bilgileri";
            // 
            // btnBankaSil
            // 
            this.btnBankaSil.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBankaSil.Location = new System.Drawing.Point(180, 104);
            this.btnBankaSil.Name = "btnBankaSil";
            this.btnBankaSil.Size = new System.Drawing.Size(75, 34);
            this.btnBankaSil.TabIndex = 7;
            this.btnBankaSil.Text = "Banka Sil";
            this.btnBankaSil.UseVisualStyleBackColor = false;
            this.btnBankaSil.Click += new System.EventHandler(this.btnBankaSil_Click);
            // 
            // btnBankaEkle
            // 
            this.btnBankaEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBankaEkle.Location = new System.Drawing.Point(99, 104);
            this.btnBankaEkle.Name = "btnBankaEkle";
            this.btnBankaEkle.Size = new System.Drawing.Size(75, 34);
            this.btnBankaEkle.TabIndex = 6;
            this.btnBankaEkle.Text = "Banka Ekle";
            this.btnBankaEkle.UseVisualStyleBackColor = false;
            this.btnBankaEkle.Click += new System.EventHandler(this.btnBankaEkle_Click);
            // 
            // txtOgrID
            // 
            this.txtOgrID.Location = new System.Drawing.Point(99, 78);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(100, 20);
            this.txtOgrID.TabIndex = 5;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(99, 51);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 4;
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(99, 23);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtBankaAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Bankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.Bankalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtBankaAdi;
        private System.Windows.Forms.Button btnBankaEkle;
        private System.Windows.Forms.Button btnBankaSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}