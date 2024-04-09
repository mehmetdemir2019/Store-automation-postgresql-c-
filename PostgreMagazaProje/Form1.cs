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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void sil()
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from urunler where urunid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtUrunID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kategori", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboUrunKategori.DisplayMember = "kategoriad";
            comboUrunKategori.ValueMember = "kategoriid";
            comboUrunKategori.DataSource = dt;
            baglanti.Close();
            baglanti.Open();
            NpgsqlDataAdapter a = new NpgsqlDataAdapter("select * from kategori", baglanti);
            DataTable z = new DataTable();
            a.Fill(z);
            comboBox1.DisplayMember = "kategoriad";
            comboBox1.ValueMember = "kategoriid";
            comboBox1.DataSource = z;
            baglanti.Close();
            baglanti.Open();
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter("select * from tedarikci ", baglanti);
            DataTable td = new DataTable();
            ad.Fill(td);
            comboUrunTedarikci.DisplayMember = "tedarikciad";
            comboUrunTedarikci.ValueMember = "tedarikciid";
            comboUrunTedarikci.DataSource = td;
            baglanti.Close();

            baglanti.Open();
            NpgsqlDataAdapter k = new NpgsqlDataAdapter("select * from beden ", baglanti);
            DataTable s = new DataTable();
            k.Fill(s);
            comboBeden.DisplayMember = "bedenad";
            comboBeden.ValueMember = "bedenid";
            comboBeden.DataSource = s;
            baglanti.Close();
           
            baglanti.Open();
            NpgsqlDataAdapter y = new NpgsqlDataAdapter("select * from beden ", baglanti);
            DataTable x = new DataTable();
            y.Fill(x);
            comboBox2.DisplayMember = "bedenad";
            comboBox2.ValueMember = "bedenid";
            comboBox2.DataSource = x;
           baglanti.Close();
           
            baglanti.Open();
            NpgsqlDataAdapter t = new NpgsqlDataAdapter("select * from ürüngaranti ", baglanti);
            DataTable m = new DataTable();
            t.Fill(m);
            comboSigorta.DisplayMember = "garantisüre";
            comboSigorta.ValueMember = "garantiid";
            comboSigorta.DataSource = m;
            baglanti.Close();
        }

        private void UrunListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from urunler order by urunid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into urunler(urunid,urunad,urunstok,urunalis,urunsatis,urunkategori,uruntedarikci,urunbeden) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtUrunID.Text));
            komut.Parameters.AddWithValue("@p2", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(TxtUrunStok.Text));
            komut.Parameters.AddWithValue("@p4", double.Parse(TxtUrunAlıs.Text));
            komut.Parameters.AddWithValue("@p5", double.Parse(TxtUrunSatıs.Text));
            komut.Parameters.AddWithValue("@p6", int.Parse(comboUrunKategori.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p7", int.Parse(comboUrunTedarikci.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p8", int.Parse(comboBeden.SelectedValue.ToString()));
            //komut.Parameters.AddWithValue("@p9", int.Parse(comboSigorta.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtUrunID.Text = null;
            TxtUrunAd.Text = null;
            TxtUrunSatıs.Text = null;
            TxtUrunAlıs.Text = null;
            TxtUrunStok.Text = null;
        }

        private void UrunSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sil();
            TxtUrunID.Text = null;
        }

        private void UrunAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from urunler where urunid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtUrunID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtUrunID.Text = null;
            TxtUrunAd.Text = null;
            TxtUrunSatıs.Text = null;
            TxtUrunAlıs.Text = null;
            TxtUrunStok.Text = null;
        }

        private void UrunGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("update urunler set urunad=@p2,urunstok=@p3,urunalis=@p4,urunsatis=@p5,urunkategori=@p6,uruntedarikci=@p7,urunbeden=@p8,urunsigorta=@p9 where urunid= @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtUrunID.Text));
            komut2.Parameters.AddWithValue("@p2", TxtUrunAd.Text);
            komut2.Parameters.AddWithValue("@p3", int.Parse(TxtUrunStok.Text));
            komut2.Parameters.AddWithValue("@p4", double.Parse(TxtUrunAlıs.Text));
            komut2.Parameters.AddWithValue("@p5", double.Parse(TxtUrunSatıs.Text));
            komut2.Parameters.AddWithValue("@p6", int.Parse(comboUrunKategori.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p7", int.Parse(comboUrunTedarikci.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p8", int.Parse(comboBeden.SelectedValue.ToString()));
            komut2.Parameters.AddWithValue("@p9", int.Parse(comboSigorta.SelectedValue.ToString()));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtUrunID.Text = null;
            TxtUrunAd.Text = null;
            TxtUrunSatıs.Text = null;
            TxtUrunAlıs.Text = null;
            TxtUrunStok.Text = null;
        }

        private void UrundenUrune_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           String sorgu = "select urunid,urunad,urunsatis,kategori.kategoriad,tedarikci.tedarikciad,\r\nbeden.bedenad,ürüngaranti.garantisüre from urunler\r\ninner join kategori\r\non\r\nkategori.kategoriid =urunler.urunkategori\r\ninner join tedarikci\r\non\r\ntedarikci.tedarikciid = urunler.uruntedarikci\r\ninner join beden\r\non\r\nbeden.bedenid = urunler.urunbeden\r\ninner join ürüngaranti\r\non\r\nürüngaranti.garantiid = urunler.urunsigorta";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sorgu = "select secilikategoridekiürünsayısı (" +int.Parse(comboBox1.SelectedValue.ToString())+")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sorgu = "select secilibedendekiürünsayısı (" + int.Parse(comboBox2.SelectedValue.ToString()) + ")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}