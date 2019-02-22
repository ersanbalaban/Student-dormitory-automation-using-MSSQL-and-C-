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
    public partial class Odemeler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Odemeler()
        {
            InitializeComponent();
        }

        private void Odemeler_Load(object sender, EventArgs e)
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
                komut.CommandText = "select * from Odemeler";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Odemeler");
                dataGridView1.DataSource = ds.Tables["Odemeler"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
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
                komut.CommandText = "INSERT INTO Odemeler(YurtOdemeTutar,YurtOdemeTarih,OgrID) VALUES ('" + txtTutar.Text + "','" + txtOdemeTarihi.Text + "','" + txtOgrID.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("İzin Alındı.");
                temizleme();
            }
        }
        void temizleme()
        {
            txtTutar.Text = "";
            txtOdemeTarihi.Text = "";
            txtOgrID.Text = "";

        }
    }
}
