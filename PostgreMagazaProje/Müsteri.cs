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
    public partial class Müsteri : Form
    {
        public Müsteri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void MüsteriListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from musteri order by musteriid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void MüşteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into musteri(musteriid,musteriadsoyad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtMusteriid.Text));
            komut.Parameters.AddWithValue("@p2", TxtMusteriad.Text);
           
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müsteri kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtMusteriid.Text = null;
            TxtMusteriad.Text = null;
           
            
        }

        private void MüşteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from musteri where musteriid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtMusteriid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtMusteriid.Text = null;
            TxtMusteriad.Text = null;
            
        }

        private void MüşteriAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from musteri where musteriid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtMusteriid.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtMusteriid.Text = null;
            TxtMusteriad.Text = null;
           
        }

        private void MüsteriGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update musteri set musteriadsoyad=@p1 where musteriid= @p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtMusteriad.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtMusteriid.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtMusteriid.Text = null;
            TxtMusteriad.Text = null;
        }

        private void MüsteridenMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }
    }
}
