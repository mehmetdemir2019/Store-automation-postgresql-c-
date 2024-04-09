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
    public partial class Arac : Form
    {
        public Arac()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=dbmagaza;user ID=postgres; password=235689");
        private void Arac_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from aractedarik", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboAracTedarik.DisplayMember = "aractedarikad";
            comboAracTedarik.ValueMember = "aractedarikid";
            comboAracTedarik.DataSource = dt;
            baglanti.Close();
        }
       
        private void AracdanMenüye_Click(object sender, EventArgs e)
        {
            Menü f2 = new Menü();
            f2.Show();
            this.Hide();
        }

        private void AracListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from arac order by aracid";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AracEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into arac(aracid,aracmarka,aracmodelyili,aractedarikciid) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtAracıd.Text));
            komut.Parameters.AddWithValue("@p2", TxtAracMarka.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(TxtAracModel.Text));
            komut.Parameters.AddWithValue("@p4", int.Parse(comboAracTedarik.SelectedValue.ToString()));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Arac kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtAracıd.Text = null;
            TxtAracMarka.Text= null;
            TxtAracModel.Text= null;
            
        }

        private void AracSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from arac where aracid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtAracıd.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtAracıd.Text = null;
            TxtAracMarka.Text = null;
            TxtAracModel.Text = null;
        }

        private void AracAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("SELECT * FROM public.arac where aracid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtAracıd.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtAracıd.Text = null;
            TxtAracMarka.Text = null;
            TxtAracModel.Text = null;
        }

        private void AracGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update arac set aracmarka=@p1,aracmodelyili=@p2,aractedarikciid=@p3  where aracid=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p4", int.Parse(TxtAracıd.Text));
            komut3.Parameters.AddWithValue("@p1", TxtAracMarka.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtAracModel.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(comboAracTedarik.SelectedValue.ToString()));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtAracıd.Text = null;
            TxtAracMarka.Text = null;
            TxtAracModel.Text = null;
        }

        private void FiloListele_Click(object sender, EventArgs e)
        {
            String sorgu = "select * from aractedarik";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void FiloEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into aractedarik(aractedarikid,aractedarikad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtAracFiloID.Text));
            komut.Parameters.AddWithValue("@p2", TxtAracFiloMarka.Text);   
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Filo kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtAracFiloID.Text = null;
            TxtAracFiloMarka.Text = null;
        }

        private void FİloSİl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from aractedarik where aractedarikid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtAracFiloID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Filo silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtAracFiloID.Text = null;
            TxtAracFiloMarka.Text = null;
        }

        private void FiloAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from aractedarik where aractedarikid=@p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtAracFiloID.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
            TxtAracFiloID.Text = null;
            TxtAracFiloMarka.Text = null;
        }

        private void FiloGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update aractedarik set aractedarikad=@p1 where aractedarikid= @p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAracFiloMarka.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtAracFiloID.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Tedarikci güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            TxtAracFiloMarka.Text = null;
            TxtAracFiloID.Text = null;
        }
    }
}
