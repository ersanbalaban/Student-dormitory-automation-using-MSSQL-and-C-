namespace VeriTabaniProje
{
    partial class Odemeler
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
            this.btnOdeme = new System.Windows.Forms.Button();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.txtOdemeTarihi = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnOdeme);
            this.groupBox1.Controls.Add(this.txtOgrID);
            this.groupBox1.Controls.Add(this.txtOdemeTarihi);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnOdeme.Location = new System.Drawing.Point(95, 118);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(75, 31);
            this.btnOdeme.TabIndex = 6;
            this.btnOdeme.Text = "Ödeme Ekle";
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // txtOgrID
            // 
            this.txtOgrID.Location = new System.Drawing.Point(95, 89);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(125, 20);
            this.txtOgrID.TabIndex = 5;
            // 
            // txtOdemeTarihi
            // 
            this.txtOdemeTarihi.Location = new System.Drawing.Point(96, 58);
            this.txtOdemeTarihi.Name = "txtOdemeTarihi";
            this.txtOdemeTarihi.Size = new System.Drawing.Size(124, 20);
            this.txtOdemeTarihi.TabIndex = 4;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(96, 27);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(124, 20);
            this.txtTutar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ödeme Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Tutarı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(487, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Odemeler";
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.Odemeler_Load);
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
        private System.Windows.Forms.TextBox txtOdemeTarihi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}