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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void Siparis_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter("select * from musteri", baglanti);
            DataTable td = new DataTable();
            ad.Fill(td);
            comboSiparisMusteri.DisplayMember = "musteriadsoyad";
            comboSiparisMusteri.ValueMember = "musteriid";
            comboSiparisMusteri.DataSource = td;
            baglanti.Close();
            
          
        }

        private void SiparişteKuryeListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select \"Calisan\".\"Calisan\".\"calisanNo\",\"Calisan\".\"Calisan\".\"adi\",\"Calisan\".\"Calisan\".\"soyadi\" from \"Calisan\".\"Calisan\"\r\ninner join \"Calisan\".\"Sürücü\"\r\non\r\n\"Calisan\".\"Calisan\".\"calisanNo\" = \"Calisan\".\"Sürücü\".\"calisanNo\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SiparişListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select siparisid,urunler.urunad,beden.bedenad,musteri.musteriadsoyad,\"Calisan\".\"Calisan\".\"adi\",\"Calisan\".\"Calisan\".\"soyadi\"\r\nfrom siparis \r\ninner join urunler\r\non urunler.urunid = siparis.siparisurunid\r\ninner join beden\r\non urunler.urunbeden=beden.bedenid\r\ninner join musteri \r\non musteri.musteriid=siparis.siparismusteriid\r\ninner join \"Calisan\".\"Calisan\"\r\non \"Calisan\".\"Calisan\".\"calisanNo\" = siparis.sipariskuryeid\r\n";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SiparisEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into siparis(siparisid,siparisurunid,sipariskuryeid,siparismusteriid) values (@p1,@p2,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtSiparisID.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtSiparisUrunID.Text));
            
            komut.Parameters.AddWithValue("@p4", int.Parse(TxtSiparisKuryeID.Text));
            komut.Parameters.AddWithValue("@p5", int.Parse(comboSiparisMusteri.SelectedValue.ToString()));
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtSiparisID.Text= null;
            TxtSiparisKuryeID.Text= null;
            TxtSiparisUrunID.Text = null;
            
        }
        void sil()
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from siparis where siparisid = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtSiparisID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtSiparisID.Text = null;
            TxtSiparisKuryeID.Text = null;
            TxtSiparisUrunID.Text = null;
        }
        private void SiparisSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sil();
            TxtSiparisID.Text= string.Empty;
        }

        private void SiparişAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from siparis where siparisid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtSiparisID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtSiparisID.Text = null;
            TxtSiparisKuryeID.Text = null;
            TxtSiparisUrunID.Text = null;
        }

        private void SiparişGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update siparis set siparisurunid=@p2,sipariskuryeid=@p3,siparismusteriid = @p4 where siparisid = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtSiparisID.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(TxtSiparisUrunID.Text));

            komut.Parameters.AddWithValue("@p3", int.Parse(TxtSiparisKuryeID.Text));
            komut.Parameters.AddWithValue("@p4", int.Parse(comboSiparisMusteri.SelectedValue.ToString()));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtSiparisID.Text = null;
            TxtSiparisKuryeID.Text = null;
            TxtSiparisUrunID.Text = null;
        }

        private void SiparistenMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select urunid,urunad,beden.bedenad from urunler \r\ninner join beden\r\non\r\nurunler.urunbeden = beden.bedenid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
