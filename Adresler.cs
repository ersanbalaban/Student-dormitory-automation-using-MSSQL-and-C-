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
    public partial class Adresler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Adresler()
        {
            InitializeComponent();
        }

        private void Adresler_Load(object sender, EventArgs e)
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
                komut.CommandText = "select * from Adresler";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Adresler");
                dataGridView1.DataSource = ds.Tables["Adresler"];
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
                komut.CommandText = "INSERT INTO Adresler(Cadde,BinaNo,Sehir,PostaKodu,Ulke) VALUES ('" + txtCadde.Text + "','" + txtBinaNo.Text + "','" + txtSehir.Text + "','" + txtPostaKodu.Text + "','" + txtUlke.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Adres Kaydedildi.");
            }
        }

        private void btnAdresEkle_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void btnAdresDegistir_Click(object sender, EventArgs e)
        {
            adresGuncelle();
        }
        void adresGuncelle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Adresler SET Cadde='" +txtCadde.Text + "',BinaNo='" + txtBinaNo.Text + "',Sehir='" + txtSehir.Text + "',PostaKodu='" + txtPostaKodu.Text + "',Ulke='" + txtUlke.Text + "' where AdresID=@numara";
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
           
            txtCadde.Text = "";
            txtBinaNo.Text = "";
            txtSehir.Text = "";
            txtPostaKodu.Text = "";
            txtUlke.Text = "";
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCadde.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBinaNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPostaKodu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtUlke.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }
    }
}
