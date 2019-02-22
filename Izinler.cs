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
    public partial class Izinler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Izinler()
        {
            InitializeComponent();
        }

        private void Izinler_Load(object sender, EventArgs e)
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
                komut.CommandText = "select * from Izinler";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Izinler");
                dataGridView1.DataSource = ds.Tables["Izinler"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }
        void ekle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "INSERT INTO Izinler(IzinBaslangicTarihi,IzinBitisTarihi,OgrID) VALUES ('" + txtIzinBas.Text + "','" + txtIzinBitis.Text + "','" + txtOgrID.Text + "')";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    listeleme();
                    MessageBox.Show("İzin Alındı.");
                    temizleme();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("İzin tarihinizi kontrol ediniz!");
            }
        }
        void izinDegistir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Izinler SET IzinBaslangicTarihi='" + txtIzinBas.Text + "',IzinBitisTarihi='" + txtIzinBitis.Text + "',OgrID='" + txtOgrID.Text + "' where IzinID=@numara";
                komut.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("İzin Değişikliği Yapıldı.");
                temizleme();
                listeleme();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            izinDegistir();
        }
        void temizleme()
        {
            txtIzinBas.Text = "";
            txtIzinBitis.Text = "";
            txtOgrID.Text = "";
          
        }

        private void button3_Click(object sender, EventArgs e)
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
                    komut.CommandText = "delete from Izinler where IzinID=@numara";
                    komut.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("İzin İptal Edildi.");
                    temizleme();
                    listeleme();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIzinBas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtIzinBitis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOgrID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
        }
    }
}
