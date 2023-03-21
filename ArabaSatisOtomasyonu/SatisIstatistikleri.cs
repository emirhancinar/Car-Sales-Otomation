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
    public partial class SatisIstatistikleri : Form
    {
        public SatisIstatistikleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader dr;
        private void SatisIstatistikleri_Load(object sender, EventArgs e)
        {
            Toplam();
            enPahali();
            bugun();
        }
        public void Toplam()
        {
            baglanti.Open();
            komut = new SqlCommand("Select  Musteriler.mKAdi,Sum(fiyat) as [Toplam Müşteri Harcamaları] from Satislar Inner Join Musteriler on Musteriler.musteriID=Satislar.musteriID inner join ArabaYil on ArabaYil.yilID = Satislar.yilID GROUP BY mKAdi ", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbxMHarcama.Items.Add(dr[0] + " " + dr[1] + " TL");
            }
            baglanti.Close();
        }
        public void enPahali()
        {
            baglanti.Open();
            komut = new SqlCommand("select marka,MAX(fiyat)as [En Pahalı Araba] from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID inner join ArabaYil on ArabaModeli.modelID = ArabaYil.modelID Group by marka", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbxPahalıMarka.Items.Add(dr[0] + " " + dr[1] + " TL");
            }
            baglanti.Close();
        }
        public void bugun()
        {
            baglanti.Open();
            komut = new SqlCommand("Select mKAdi from Satislar inner join Musteriler on Musteriler.musteriID=Satislar.musteriID where satistarihi=CONVERT(varchar, getdate(), 23)", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbxBugun.Items.Add(dr[0] );
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yonetici yon = new Yonetici();
            yon.Show();
            this.Visible = false;
        }
    }
}
