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
    public partial class login : Form
    {
        private NpgsqlConnection baglanti = new NpgsqlConnection("Host=localhost;Port=5432;Database=dbmagaza;Username=postgres;Password=235689");

        public login()
        {
            InitializeComponent();
        }

        private void kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void gris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciadi.Text;
            string sifre = sifree.Text;

            if (KullaniciDogrula(kullaniciAdi, sifre))
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Giriş ekranını gizle

                Menü menuForm = new Menü();
                menuForm.ShowDialog(); // Menü formunu göster
                //this.Close(); // Uygulamayı kapat
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT COUNT(*) FROM kullanicilar WHERE kullaniciadi = @kullaniciAdi AND sifre = @sifre";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                int kullaniciSayisi = Convert.ToInt32(komut.ExecuteScalar());
                return kullaniciSayisi == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void kayıtol_Click(object sender, EventArgs e)
        {

        }

        private void sifremiunuttum_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void sifree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
