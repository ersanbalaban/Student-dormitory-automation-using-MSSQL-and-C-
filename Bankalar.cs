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
    
    public partial class Bankalar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Bankalar()
        {
            InitializeComponent();
        }

        private void Bankalar_Load(object sender, EventArgs e)
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
                komut.CommandText = "select * from Banka";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Banka");
                dataGridView1.DataSource = ds.Tables["Banka"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }
        void ekle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Banka(BankaAdi,BankaHesapNo,OgrID) VALUES ('" + txtBankaAdi.Text + "','" + txtHesapNo.Text + "','" + txtOgrID.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Banka Bilgileri Eklendi.");
            }
        }

        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            ekle();
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
                    komut.CommandText = "delete from Banka where BankaID=@numara";
                    komut.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Silindi!");
                    listeleme();
                }
            }
        }

        private void btnBankaSil_Click(object sender, EventArgs e)
        {
            sil();
        }
    }
}
