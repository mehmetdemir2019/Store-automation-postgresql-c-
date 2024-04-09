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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void KategoriListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from kategori";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void KategoriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kategori(kategoriid,kategoriad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtKategoriID.Text));
            komut.Parameters.AddWithValue("@p2", TxtKategoriAd.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtKategoriID.Text = null;
            TxtKategoriAd.Text = null;  
        }

        private void KategoriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from kategori where kategoriid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtKategoriID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtKategoriID.Text = null;
            TxtKategoriAd.Text = null;
        }

        private void KategoriAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from kategori where kategoriid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtKategoriID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtKategoriID.Text = null;
            TxtKategoriID.Text = null;
        }

        private void KategorilerdenUrune_Click(object sender, EventArgs e)
        {
            Menü  f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void KategoriGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update kategori set kategoriad=@p1 where kategoriid= @p2",baglanti);
            komut3.Parameters.AddWithValue("@p1",TxtKategoriAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtKategoriID.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtKategoriID.Text = null;
            TxtKategoriAd.Text = null;
        }
    }
}