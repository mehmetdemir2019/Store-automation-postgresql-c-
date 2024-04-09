using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreMagazaProje
{
    public partial class sofor : Form
    {
        public sofor()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void sofor_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from Arac", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ComboSoforArac.DisplayMember = "aracmarka";
            ComboSoforArac.ValueMember = "aracid";
            ComboSoforArac.DataSource = dt;
            baglanti.Close();
        }

        private void Temsilciden_Calisana_Click(object sender, EventArgs e)
        {
            Calisanlar f2 = new Calisanlar();
            f2.Show();
            this.Hide();
        }

        private void SoforListele_Click(object sender, EventArgs e)
        {

            String sorgu = "SELECT * FROM calisan.surucu ORDER BY calisanno";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SoforEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"Calisan\".\"Calisan\" (\"adi\",\"soyadi\",\"calisanTipi\",\"calisanYas\",\"calisanDeneyim\",\"calisanMaas\")\r\nvalues\r\n(@p1,@p2,@p3,@p4,@p5,@p6);", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSoforAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoforSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoforTipi.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(NUDSoforYas.Value.ToString()));
            komut.Parameters.AddWithValue("@p5", int.Parse(NUDSoforDeneyim.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", int.Parse(TxtSoforMaas.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into \"Calisan\".\"Sürücü\" (\"calisanNo\",\"SürücüTipi\",\"SürücüAracID\")\r\nvalues\r\n(@p1,@p2,@p3);", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtSoforID.Text));
            komut2.Parameters.AddWithValue("@p2", TxtSoforKategorisi.Text);
            komut2.Parameters.AddWithValue("@p3", int.Parse(ComboSoforArac.SelectedValue.ToString()));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sürücü kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtSoforAd.Text = null;
            TxtSoforID.Text= null;
            TxtSoforKategorisi.Text= null;
            TxtSoforMaas.Text= null;
            TxtSoforTipi.Text= null;
            NUDSoforDeneyim.Value = 0;
            NUDSoforYas.Value = 0;
        }
        void sil()
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from \"Calisan\".\"Calisan\"\r\n\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtSoforID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sürücü silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void SoforSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sil();
            TxtSoforID.Text = null;
        }

        private void SoforAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Sürücü\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Sürücü\".\"calisanNo\"\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtSoforID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void SoforGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut3 = new NpgsqlCommand(" update \"Calisan\".\"Calisan\" \r\nset \"adi\" = @p2 ,\r\n\t\"soyadi\" = @p3,\r\n\t\"calisanTipi\" = @p4 ,\r\n\t\"calisanYas\" =@p5,\r\n\t\"calisanDeneyim\" = @p6,\r\n\t\"calisanMaas\" = @p7\t\r\nwhere \r\n\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(TxtSoforID.Text));
            komut3.Parameters.AddWithValue("@p2", TxtSoforAd.Text);
            komut3.Parameters.AddWithValue("@p3", TxtSoforSoyad.Text);
            komut3.Parameters.AddWithValue("@p4", TxtSoforTipi.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(NUDSoforYas.Value.ToString()));
            komut3.Parameters.AddWithValue("@p6", int.Parse(NUDSoforDeneyim.Value.ToString()));
            komut3.Parameters.AddWithValue("@p7", int.Parse(TxtSoforMaas.Text));

            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtSoforTipi.Text = null;
            TxtSoforAd.Text = null;
            TxtSoforSoyad.Text = null;
            TxtSoforMaas.Text = null;
            NUDSoforYas.Value = 0;
            NUDSoforDeneyim.Value = 0;
            TxtSoforID.Text = null;
            TxtSoforKategorisi.Text = null;
        }
    }
}
