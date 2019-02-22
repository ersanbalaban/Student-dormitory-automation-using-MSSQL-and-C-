using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeriTabaniProje
{

    public partial class Yurt : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Yurt()
        {
            InitializeComponent();
        }

        private void Yurt_Load(object sender, EventArgs e)
        {
            listeleme();
        }
        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select * from Yurt";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Yurt");
                dataGridView1.DataSource = ds.Tables["Yurt"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }

        private void btnYurtEkle_Click(object sender, EventArgs e)
        {
            ekle();
        }
        void ekle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Yurt(YurtAdi,YurtTelefon,YurtAdresi) VALUES ('" + txtYurtAd.Text + "','" + txtYurtTelefon.Text + "','" + txtYurtAdres.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Yurt Kaydedildi.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            yurtGuncelle();
        }
        void yurtGuncelle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Yurt SET YurtAdi='" + txtYurtAd.Text + "',YurtTelefon='" + txtYurtTelefon.Text + "',YurtAdresi='" + txtYurtAdres.Text + "' where YurtID=@numara";
                komut.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Güncelleştirme yapıldı.");
                temizleme();
                listeleme();
            }
        }
        void temizleme()
        {
            txtYurtAd.Text = "";
            txtYurtTelefon.Text = "";
            txtYurtAdres.Text = "";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYurtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYurtTelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYurtAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnYurtIslemleri_Click(object sender, EventArgs e)
        {
            yurtPersonelBirimleri form = new yurtPersonelBirimleri();
            form.ShowDialog();
        }
    }
}
