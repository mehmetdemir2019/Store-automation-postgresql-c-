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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        void sil()
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from \"Calisan\".\"Calisan\"\r\n\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtPersonelNo.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void Personelden_Calisana_Click(object sender, EventArgs e)
        {
            Calisanlar f2 = new Calisanlar();
            f2.Show();
            this.Hide();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");

        private void PersonelEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into \"Calisan\".\"Calisan\" (\"adi\",\"soyadi\",\"calisanTipi\",\"calisanYas\",\"calisanDeneyim\",\"calisanMaas\")\r\nvalues\r\n(@p1,@p2,@p3,@p4,@p5,@p6);", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonel.Text);
            komut.Parameters.AddWithValue("@p4", int.Parse(NUDPersonelYas.Value.ToString()));
            komut.Parameters.AddWithValue("@p5", int.Parse(NUDPersonelDeneyim.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", int.Parse(TxtPersonelMaas.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into \"Calisan\".\"Personel\" (\"calisanNo\",\"PersonelTipi\")\r\nvalues\r\n(@p1,@p2);", baglanti);
            komut2.Parameters.AddWithValue("@p1",int.Parse(TxtPersonelNo.Text));
            komut2.Parameters.AddWithValue("@p2", TxtPersonelTipi.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtPersonelTipi.Text = null;
             TxtPersonelAd.Text = null;
             TxtPersonelSoyad.Text= null;
             TxtPersonelMaas.Text=null;
             NUDPersonelYas.Value = 0;
            NUDPersonelDeneyim.Value = 0;         
             TxtPersonelNo.Text = null;       
             TxtPersonel.Text= null;    
        }

        private void PersonelListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Personel\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Personel\".\"calisanNo\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PersonelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sil();
            TxtPersonelNo.Text = null; 
        }

        private void PersonelAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from \"Calisan\".\"Calisan\"\r\ninner join\r\n\"Calisan\".\"Personel\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Personel\".\"calisanNo\"\r\nwhere\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtPersonelNo.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            NpgsqlCommand komut3 = new NpgsqlCommand(" update \"Calisan\".\"Calisan\" \r\nset \"adi\" = @p2 ,\r\n\t\"soyadi\" = @p3,\r\n\t\"calisanTipi\" = @p4 ,\r\n\t\"calisanYas\" =@p5,\r\n\t\"calisanDeneyim\" = @p6,\r\n\t\"calisanMaas\" = @p7\t\r\nwhere \r\n\"Calisan\".\"calisanNo\" = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(TxtPersonelNo.Text));
            komut3.Parameters.AddWithValue("@p2", TxtPersonelAd.Text);
            komut3.Parameters.AddWithValue("@p3", TxtPersonelSoyad.Text);
            komut3.Parameters.AddWithValue("@p4", TxtPersonel.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(NUDPersonelYas.Value.ToString()));
            komut3.Parameters.AddWithValue("@p6", int.Parse(NUDPersonelDeneyim.Value.ToString()));
            komut3.Parameters.AddWithValue("@p7", int.Parse(TxtPersonelMaas.Text));

            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtPersonelTipi.Text = null;
            TxtPersonelAd.Text = null;
            TxtPersonelSoyad.Text = null;
            TxtPersonelMaas.Text = null;
            NUDPersonelYas.Value = 0;
            NUDPersonelDeneyim.Value = 0;
            TxtPersonelNo.Text = null;
            TxtPersonel.Text = null;
        }
    }
}
