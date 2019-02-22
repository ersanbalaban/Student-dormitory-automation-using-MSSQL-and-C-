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
    public partial class Ogrenci : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Odalar Where OdaDurum=0";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                    cBoxOdalar.Items.Add(oku["OdaNumarasi"]);
            }
            baglanti.Close();
            listeleme();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
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
                komut.CommandText = "INSERT INTO Ogrenci(OgrAd,OgrSoyad,OgrTc,OgrTel,OgrVeliAdSoyad,OgrKayitTarihi,OgrAdresID,OgrOdaNumarasi,OgrBolumID,OgrYurtID) VALUES ('" + txtOgrAd.Text + "','" + txtOgrSoyad.Text + "','" + txtOgrTc.Text + "','" + txtOgrTelefon.Text + "','" + txtVeliAdSoyad.Text + "','" + txtOgrKayitTarihi.Text + "','" + txtOgrAdresID.Text + "','" + cBoxOdalar.Text + "','" + txtOgrBolumID.Text + "','" + txtOgrYurtID.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Öğrenci Kaydedildi.");
            }
        }
        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select * from Ogrenci";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Ogrenci");
                dataGridView1.DataSource = ds.Tables["Ogrenci"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            sil();
        }

        void sil()
        {
            try
            {
                if (MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "delete from Ogrenci where OgrID=@numara";
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
            catch (SqlException e)
            {
                MessageBox.Show("Bu Öğrenciyi Silemezsiniz! Silmeniz için öncelikle Banka Bilgilerini Silmeniz Gereklidir.");
            }
        }
        void kayitGuncelle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Ogrenci SET OgrAd='" + txtOgrAd.Text + "',OgrSoyad='" + txtOgrSoyad.Text + "',OgrTc='" + txtOgrTc.Text + "',OgrTel='" + txtOgrTelefon.Text + "',OgrVeliAdSoyad='" + txtVeliAdSoyad.Text + "',OgrKayitTarihi='" + txtOgrKayitTarihi.Text + "', OgrAdresID='"+txtOgrAdresID.Text+ "',OgrOdaNumarasi='" + cBoxOdalar.Text + "',OgrBolumID='" + txtOgrBolumID.Text + "',OgrYurtID='" + txtOgrYurtID.Text + "' where OgrID=@numara";
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
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            txtOgrTc.Text = "";
            txtOgrTelefon.Text = "";
            txtVeliAdSoyad.Text = "";
            txtOgrKayitTarihi.Text = "";
            txtOgrAdresID.Text = "";
            txtOgrBolumID.Text = "";
            cBoxOdalar.Text = "";
            txtOgrYurtID.Text = "";
        }
        private void btn_degistir_Click(object sender, EventArgs e)
        {
            kayitGuncelle();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrSoyad.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOgrTc.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtOgrTelefon.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtVeliAdSoyad.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOgrKayitTarihi.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtOgrAdresID.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cBoxOdalar.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtOgrBolumID.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtOgrYurtID.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
