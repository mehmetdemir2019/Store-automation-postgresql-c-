using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreMagazaProje
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void Menüden_Urunlere_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void Menüden_Kategorilere_Click(object sender, EventArgs e)
        {
            Kategoriler f2 = new Kategoriler();
            f2.Show();
            this.Hide();
        }

        private void Menüden_Tedarikçilere_Click(object sender, EventArgs e)
        {
            Tedarikci f2 = new Tedarikci();
            f2.Show();
            this.Hide();
        }

        private void MenüdenCalisana_Click(object sender, EventArgs e)
        {
            Calisanlar f2 = new Calisanlar();
            f2.Show();
            this.Hide();
        }

        private void Kampanya_Click(object sender, EventArgs e)
        {
            Kampanya f2 = new Kampanya();
            f2.Show();
            this.Hide();
        }

        /*private void button4_Click(object sender, EventArgs e)
        {
            Arac f2 = new Arac();
            f2.Show();
            this.Hide();
        }
        */

        private void MenüdenMuster_Click(object sender, EventArgs e)
        {
            Müsteri f2 = new Müsteri();
            f2.Show();
            this.Hide();
        }

        private void MenüdenSiparişe_Click(object sender, EventArgs e)
        {
            Siparis f2 = new  Siparis();
            f2.Show();
            this.Hide();
        }

        private void MenüdenVerilere_Click(object sender, EventArgs e)
        {
            Veri f2 = new Veri();
            f2.Show();
            this.Hide();
        }
    }
}
