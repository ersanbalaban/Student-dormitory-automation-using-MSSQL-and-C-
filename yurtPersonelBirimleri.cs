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
using System.IO;

namespace VeriTabaniProje
{
    public partial class yurtPersonelBirimleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=ogrenciYurtDb;Integrated Security=True");
        public yurtPersonelBirimleri()
        {
            InitializeComponent();
        }

        private void yurtPersonelBirimleri_Load(object sender, EventArgs e)
        {

        }
        void listelee()
        {
            try { 
            lstKayitListele.Items.Clear();
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select PersonelAdSoyad,YurtAdi from Personel INNER JOIN Yurt ON Personel.YurtID = Yurt.YurtID", baglanti);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                lstKayitListele.Items.Add(tablo.Rows[i][0] + "    "+ tablo.Rows[i][1] + "    ");
            }
            baglanti.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Dikkat");
            }
        }

        void listele2()
        {
            try
            {
                lstKayitListele.Items.Clear();
                baglanti.Open();
                SqlDataAdapter komut = new SqlDataAdapter("select PersonelAdSoyad,PersonelBirim,YurtAdi from Personel LEFT OUTER JOIN Yurt ON Personel.YurtID = Yurt.YurtID", baglanti);
                DataTable tablo = new DataTable();
                komut.Fill(tablo);
                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    lstKayitListele.Items.Add(tablo.Rows[i][0] + "    " + tablo.Rows[i][1] + "    "+tablo.Rows[i][2] + "    ");
                }
                baglanti.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Dikkat");
            }
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            listelee();
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            listele2();
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            dosyayaYaz();
        }
        void dosyayaYaz()
        {
            FileStream metin = new FileStream("C:/Users/Lenovo/Documents/Visual Studio 2015/Projects/kayitlar.txt", FileMode.Create, FileAccess.Write);
            StreamWriter metin2 = new StreamWriter(metin);
            for (int j = 0; j < lstKayitListele.Items.Count; j++)
            {
                metin2.WriteLine(lstKayitListele.Items[j].ToString());
            }
            metin.Close();
            metin2.Close();
        }
    }
}
