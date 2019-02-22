namespace VeriTabaniProje
{
    partial class Bolumler
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
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.txtFakulte = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnBolumEkle);
            this.groupBox1.Controls.Add(this.txtFakulte);
            this.groupBox1.Controls.Add(this.txtBolumAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bölüm Bilgileri";
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBolumEkle.Location = new System.Drawing.Point(108, 94);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(75, 39);
            this.btnBolumEkle.TabIndex = 8;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = false;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // txtFakulte
            // 
            this.txtFakulte.Location = new System.Drawing.Point(108, 62);
            this.txtFakulte.Name = "txtFakulte";
            this.txtFakulte.Size = new System.Drawing.Size(120, 20);
            this.txtFakulte.TabIndex = 4;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(108, 33);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(120, 20);
            this.txtBolumAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fakülte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // Bolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(500, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.Bolumler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFakulte;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Button btnBolumEkle;
    }
}