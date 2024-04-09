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
    public partial class temsilci : Form
    {
        public temsilci()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");

        void sil()
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from \"Calisan\".\"Calisan\"\r\n\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtTemsilciNo.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Temsilci silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void TemsilciListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Temsilci\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Temsilci\".\"calisanNo\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TemsilciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"Calisan\".\"Calisan\" (\"adi\",\"soyadi\",\"calisanTipi\",\"calisanYas\",\"calisanDeneyim\",\"calisanMaas\")\r\nvalues\r\n(@p1,@p2,@p3,@p4,@p5,@p6);", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtTemsilciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtTemsilciSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTemsilci.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(NUDTemsilciYas.Value.ToString()));
            komut.Parameters.AddWithValue("@p5", int.Parse(NUDTemsilciDeneyim.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", int.Parse(TxtTemsilciMaas.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into \"Calisan\".\"Temsilci\" (\"calisanNo\",\"TemsilciTipi\")\r\nvalues\r\n(@p1,@p2);", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtTemsilciNo.Text));
            komut2.Parameters.AddWithValue("@p2", TxtTemsilciTipi.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Temsilci kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtTemsilciTipi.Text = null;
            TxtTemsilciAd.Text = null;
            TxtTemsilciSoyad.Text = null;
            TxtTemsilciMaas.Text = null;
            NUDTemsilciYas.Value = 0;
            NUDTemsilciDeneyim.Value = 0;
            TxtTemsilciNo.Text = null;
            TxtTemsilci.Text = null;
        }

        private void TemsilciSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sil();
            TxtTemsilciNo.Text = null;
        }

        private void TemsilciAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Temsilci\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Temsicli\".\"calisanNo\"\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtTemsilciNo.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void Temsilciden_Calisana_Click(object sender, EventArgs e)
        {
            Calisanlar f2 = new Calisanlar();
            f2.Show();
            this.Hide();
        }

        private void TemsilciGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut3 = new NpgsqlCommand(" update \"Calisan\".\"Calisan\" \r\nset \"adi\" = @p2 ,\r\n\t\"soyadi\" = @p3,\r\n\t\"calisanTipi\" = @p4 ,\r\n\t\"calisanYas\" =@p5,\r\n\t\"calisanDeneyim\" = @p6,\r\n\t\"calisanMaas\" = @p7\t\r\nwhere \r\n\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(TxtTemsilciNo.Text));
            komut3.Parameters.AddWithValue("@p2", TxtTemsilciAd.Text);
            komut3.Parameters.AddWithValue("@p3", TxtTemsilciSoyad.Text);
            komut3.Parameters.AddWithValue("@p4", TxtTemsilci.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(NUDTemsilciYas.Value.ToString()));
            komut3.Parameters.AddWithValue("@p6", int.Parse(NUDTemsilciDeneyim.Value.ToString()));
            komut3.Parameters.AddWithValue("@p7", int.Parse(TxtTemsilciMaas.Text));

            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtTemsilciTipi.Text = null;
            TxtTemsilciAd.Text = null;
            TxtTemsilciSoyad.Text = null;
            TxtTemsilciMaas.Text = null;
            NUDTemsilciDeneyim.Value = 0;
            NUDTemsilciYas.Value = 0;
            TxtTemsilciNo.Text = null;
            TxtTemsilci.Text = null;
        }
    }
}
