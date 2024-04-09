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
    public partial class Kampanya : Form
    {
        public Kampanya()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void Kampanya_Load(object sender, EventArgs e)
        {
           
        }

        private void CalisandanMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void CalisanListele_Click(object sender, EventArgs e)
        {
            String sorgu = "SELECT * FROM public.kampanya";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Calisandan_Personele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kampanya (kampanyaid,kampanyalıurunid,kampanyaindirimoranı) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtKampanyaID.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtKampanyalıUrunID.Text));
            komut.Parameters.AddWithValue("@p3", double.Parse(TxtKampanyaOran.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kampanya kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtKampanyaOran.Text = null;
            TxtKampanyaID.Text = null;
            TxtKampanyalıUrunID.Text= null;
        }

        private void CalisandanYöneticiye_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from kampanya where kampanyaid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtKampanyaID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kampanya silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void CalisandanTemsilcilere_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select urunad,urunstok,urunsatis,kampanya.kampanyaindirimoranı,kampanyalı(kampanya.kampanyaindirimoranı,urunler.urunsatis) from urunler inner join kampanya on urunler.urunid=kampanya.kampanyalıurunid where kampanyaid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtKampanyaID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void ÜrünleriListele_Click(object sender, EventArgs e)
        {
            //String sorgu2 = "SELECT * FROM public.kampanya\nORDER BY kampanyaid";
            String sorgu2 = "select * from urunler order by urunid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void CalisandanSoforlere_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update  kampanya set kampanyalıurunid=@p2,kampanyaindirimoranı=@p3 where kampanyaid = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtKampanyaID.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtKampanyalıUrunID.Text));
            komut.Parameters.AddWithValue("@p3", double.Parse(TxtKampanyaOran.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kampanya kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtKampanyaOran.Text = null;
            TxtKampanyaID.Text = null;
            TxtKampanyalıUrunID.Text = null;
        }
    }
}