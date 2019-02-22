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
    public partial class Personel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
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
                komut.CommandText = "select * from Personel";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
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
                komut.CommandText = "INSERT INTO Personel(PersonelAdSoyad,PersonelBirim,YurtID) VALUES ('" + txtAdSoyad.Text + "','" + txtBirim.Text + "','" + txtYurtID.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Personel Kaydedildi.");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            personelGuncelle();
        }
        void personelGuncelle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Personel SET PersonelAdSoyad='" + txtAdSoyad.Text + "',PersonelBirim='" + txtBirim.Text + "',YurtID='" + txtYurtID.Text + "' where PersonelID=@numara";
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
            txtAdSoyad.Text = "";
            txtBirim.Text = "";
            txtYurtID.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil();
        }
        void sil()
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from Personel where PersonelID=@numara";
                    komut.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Silindi!");
                    temizleme();
                    listeleme();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBirim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYurtID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
