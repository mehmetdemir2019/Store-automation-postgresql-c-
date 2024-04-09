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
    public partial class Tedarikci : Form
    {
        public Tedarikci()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void TedarikListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from tedarikci";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TedarikEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into tedarikci(tedarikciid,tedarikciad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtTedarikciID.Text));
            komut.Parameters.AddWithValue("@p2", TxtTedarikciAd.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tedarikci kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtTedarikciID.Text = null;
            TxtTedarikciAd.Text = null;
        }

        private void TedarikSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from tedarikci where tedarikciid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtTedarikciID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tedarikci silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtTedarikciID.Text = null;
            TxtTedarikciAd.Text = null;
        }

        private void TedarikAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from tedarikci where tedarikciid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtTedarikciID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtTedarikciID.Text = null;
            TxtTedarikciAd.Text = null;
        }

        private void TedarikcidenMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void TedarikGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update tedarikci set tedarikciad=@p1 where tedarikciid= @p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtTedarikciAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtTedarikciID.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tedarikci güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtTedarikciAd.Text = null;
            TxtTedarikciID.Text = null;
        }
    }
}