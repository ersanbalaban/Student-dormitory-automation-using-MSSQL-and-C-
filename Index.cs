using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniProje
{
    public partial class OgrenciYurt : Form
    {
        public OgrenciYurt()
        {
            InitializeComponent();
        }

        private void btn_Ogrenci_Click(object sender, EventArgs e)
        {
            Ogrenci frm = new Ogrenci();
            frm.ShowDialog();
        }

        private void btn_Adres_Click(object sender, EventArgs e)
        {
            Adresler frm = new Adresler();
            frm.ShowDialog();
        }

        private void btn_Banka_Click(object sender, EventArgs e)
        {
            Bankalar frm = new Bankalar();
            frm.ShowDialog();
        }

        private void btn_bolumler_Click(object sender, EventArgs e)
        {
            Bolumler frm = new Bolumler();
            frm.ShowDialog();
        }

        private void btn_izinler_Click(object sender, EventArgs e)
        {
            Izinler frm = new Izinler();
            frm.ShowDialog();
        }

        private void btn_odemeler_Click(object sender, EventArgs e)
        {
            Odemeler frm = new Odemeler();
            frm.ShowDialog();
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            Personel frm = new Personel();
            frm.ShowDialog();
        }

        private void btn_yurt_Click(object sender, EventArgs e)
        {
            Yurt frm = new Yurt();
            frm.ShowDialog();
        }
    }
}
