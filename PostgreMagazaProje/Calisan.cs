using Npgsql;
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
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void CalisanListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from \"Calisan\".\"Calisan\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void CalisandanMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void Calisandan_Personele_Click(object sender, EventArgs e)
        {
            Personel f2 = new Personel();
            f2.Show();
            this.Hide();
        }

        private void CalisandanYöneticiye_Click(object sender, EventArgs e)
        {
            Yönetici f2 = new Yönetici();
            f2.Show();
            this.Hide();
        }

        private void CalisandanTemsilcilere_Click(object sender, EventArgs e)
        {
            temsilci f2 = new temsilci();
            f2.Show();
            this.Hide();
        }

        private void CalisandanSoforlere_Click(object sender, EventArgs e)
        {

            sofor f2 = new sofor();
            f2.Show();
            this.Hide();
        }
    }
}
