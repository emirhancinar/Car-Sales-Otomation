using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ArabaSatisOtomasyonu
{
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
                
        }
        //Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader oku;
        private void btnYonGirYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * From Yonetici where kAdi='"+txt_YonKulAdi.Text.ToString()+"'and sifre='"+ txtYonSifre.Text.ToString()+"'", baglanti);
            oku= komut.ExecuteReader();
            if (oku.Read())
            {
                baglanti.Close();
                Yonetici yonetici = new Yonetici();
                yonetici.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            baglanti.Close();

        }

        private void btnMusGirYap_Click(object sender, EventArgs e)
        {
            int id;
            baglanti.Open();
            komut = new SqlCommand("Select * From Musteriler where mKAdi='"+txtMusKulAdi.Text.ToString()+"' and sifre="+Convert.ToInt32(txtMusSifre.Text),baglanti);
            oku = komut.ExecuteReader();
            if(oku.Read())
            {
                id = Convert.ToInt32(oku[0]);
                ArabaSatisEkrani satis = new ArabaSatisEkrani(id,txtMusKulAdi.Text.ToString());
                satis.Show();
                this.Visible = false;
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            baglanti.Close();
        }

        private void btnMKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Insert Into Musteriler (mKAdi,sifre,adres,ceptel,e_posta) values('"+txtKayitAd.Text.ToString()+"',"+Convert.ToInt32(txtKayitSifre.Text) +",'"+txtKayitAdres.Text.ToString()+"','"+txtKayitTel.Text.ToString()+"','"+txtKayitEPosta.Text.ToString()+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Başarıyla Yapıldı","Kayıt Bilgilendirme");
        }
    }
}
