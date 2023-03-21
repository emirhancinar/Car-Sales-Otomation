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
    public partial class MarkaIslemleri : Form
    {
        public MarkaIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader dr;

        public void lbxMarkaDoldur()
        {
            lbxMarka.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("Select * From ArabaMarka", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbxMarka.Items.Add(dr[1]);
            }
            baglanti.Close();
        }

        private void MarkaIslemleri_Load(object sender, EventArgs e)
        {
            lbxMarkaDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaMarka where marka='"+txtMarkaKayit.Text.ToString()+"'",baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                MessageBox.Show("Girilen marka kayıtlı farklı bir marka giriniz. ");
            }
            else
            {
                baglanti.Close();//Bağlantıyı kapattık.Kapatmazsak açık DataReader hatası alırız.
                baglanti.Open();
                komut = new SqlCommand("Insert Into ArabaMarka (marka) values ('"+txtMarkaKayit.Text.ToString()+"')",baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show( txtMarkaKayit.Text.ToString() + " markası kayıt edildi");
                txtMarkaKayit.Text = "";
                baglanti.Close();
                lbxMarkaDoldur();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Delete From ArabaMarka where marka= '"+txtMarkaSil.Text.ToString()+"'",baglanti );
            if (komut.ExecuteNonQuery()==1)
            {
                MessageBox.Show(txtMarkaSil.Text.ToString() + " markası silindi.");
                baglanti.Close();
                txtMarkaSil.Text = "";
                lbxMarkaDoldur();
            }
            else
            {
                MessageBox.Show("Böyle bir marka bulunmamaktadır.");
                baglanti.Close();
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaMarka where marka='" + txtMarkaGuncelle.Text.ToString() + "'", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                MessageBox.Show("Girilen marka kayıtlı farklı bir model giriniz.");
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("Update ArabaMarka set marka='" + txtMarkaGuncelle.Text.ToString() + "' where marka='" + txtEskiMarka.Text.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show(txtEskiMarka.Text.ToString() + " markası " + txtMarkaGuncelle.Text.ToString() + " olarak güncellendi.");
                txtEskiMarka.Text = "";
                txtMarkaGuncelle.Text = "";
                baglanti.Close();
                lbxMarkaDoldur();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Yonetici yon = new Yonetici();
            yon.Show();
            this.Visible = false;
        }
    }
}
