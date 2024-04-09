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
    public partial class Veri : Form
    {
        public Veri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");

        private void VeridenMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void VeriMaasOrtalama_Click(object sender, EventArgs e)
        {
            String sorgu = "select bakiyeortalama() as Şirketin_Ortalama_Maaşı";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
