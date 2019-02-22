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
    public partial class Bolumler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public Bolumler()
        {
            InitializeComponent();
        }

        private void Bolumler_Load(object sender, EventArgs e)
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
                komut.CommandText = "select * from Bolumler";
                SqlDataAdapter adpr = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Bolumler");
                dataGridView1.DataSource = ds.Tables["Bolumler"];
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
                komut.CommandText = "INSERT INTO Bolumler(BolumAd,Fakulte) VALUES ('" + txtBolumAd.Text + "','" + txtFakulte.Text + "')";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Bölüm Eklendi.");
            }
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            ekle();
        }
    }
}
