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
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void YönetiicdenCalisana_Click(object sender, EventArgs e)
        {
            Calisanlar f2 = new Calisanlar();
            f2.Show();
            this.Hide();
        }

        private void YöneticiListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Yönetici\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Yönetici\".\"calisanNo\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void YöneticiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"Calisan\".\"Calisan\" (\"adi\",\"soyadi\",\"calisanTipi\",\"calisanYas\",\"calisanDeneyim\",\"calisanMaas\")\r\nvalues\r\n(@p1,@p2,@p3,@p4,@p5,@p6);", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtYöneticiAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYöneticiSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtYönetici.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(NUDYöneticiYas.Value.ToString()));
            komut.Parameters.AddWithValue("@p5", int.Parse(NUDYöneticiDeneyim.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", int.Parse(TxtYöneticiMaas.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into \"Calisan\".\"Yönetici\" (\"calisanNo\",\"YöneticiTipi\")\r\nvalues\r\n(@p1,@p2);", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtYöneticiNo.Text));
            komut2.Parameters.AddWithValue("@p2", TxtYöneticiTipi.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Temsilci kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtYöneticiTipi.Text = null;
            TxtYöneticiAd.Text = null;
            TxtYöneticiSoyad.Text = null;
            TxtYöneticiMaas.Text = null;
            NUDYöneticiYas.Value = 0;
            NUDYöneticiDeneyim.Value = 0;
            TxtYöneticiNo.Text = null;
            TxtYönetici.Text = null;
        }
        void sil()
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from \"Calisan\".\"Calisan\"\r\n\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtYöneticiNo.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void YöneticiSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sil();
            TxtYöneticiNo.Text = null;
        }

        private void YöneticiAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Yönetici\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Yönetici\".\"calisanNo\"\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtYöneticiNo.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close(); 
        }

        private void YöneticiGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut3 = new NpgsqlCommand(" update \"Calisan\".\"Calisan\" \r\nset \"adi\" = @p2 ,\r\n\t\"soyadi\" = @p3,\r\n\t\"calisanTipi\" = @p4 ,\r\n\t\"calisanYas\" =@p5,\r\n\t\"calisanDeneyim\" = @p6,\r\n\t\"calisanMaas\" = @p7\t\r\nwhere \r\n\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(TxtYöneticiNo.Text));
            komut3.Parameters.AddWithValue("@p2", TxtYöneticiAd.Text);
            komut3.Parameters.AddWithValue("@p3", TxtYöneticiSoyad.Text);
            komut3.Parameters.AddWithValue("@p4", TxtYönetici.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(NUDYöneticiYas.Value.ToString()));
            komut3.Parameters.AddWithValue("@p6", int.Parse(NUDYöneticiDeneyim.Value.ToString()));
            komut3.Parameters.AddWithValue("@p7", int.Parse(TxtYöneticiMaas.Text));

            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtYönetici.Text = null;
            TxtYöneticiAd.Text = null;
            TxtYöneticiSoyad.Text = null;
            TxtYöneticiMaas.Text = null;
            NUDYöneticiYas.Value = 0;
            NUDYöneticiDeneyim.Value = 0;
            TxtYöneticiNo.Text = null;
            TxtYöneticiTipi.Text = null;
        }
    }
}
