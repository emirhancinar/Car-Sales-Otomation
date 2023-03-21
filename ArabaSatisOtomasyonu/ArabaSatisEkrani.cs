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
    public partial class ArabaSatisEkrani : Form 
    {
        int musteriID, yilID = 0;
        string name;
        public ArabaSatisEkrani(int musteriID,String name)
        {
            this.musteriID = musteriID;
            this.name = name;
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader dr;
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            renklendir();
            lblMusteriAdiSoyadi.Text = name;
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaMarka", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbxMarka.Items.Add(dr[1]); 
            }
            baglanti.Close();

        }
        
        
        private void cmbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiyat.Text ="";
            cmbxModel.Items.Clear();
            cmbxYil.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select marka,model from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID where ArabaMarka.marka = @marka", baglanti);
            komut.Parameters.AddWithValue("@marka",cmbxMarka.Text.ToString());
                
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbxModel.Items.Add(dr[1]);

            }
            baglanti.Close();
           
            
        }
        private void cmbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiyat.Text = "";
            cmbxYil.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select marka,model,uretimyili,fiyat from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID inner join ArabaYil on ArabaModeli.modelID = ArabaYil.modelID where ArabaMarka.marka = @marka and ArabaModeli.model = @model",baglanti);
            komut.Parameters.AddWithValue("@marka", cmbxMarka.Text.ToString());
            komut.Parameters.AddWithValue("@model",cmbxModel.Text.ToString());
            
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbxYil.Items.Add(dr[2]);
            }
            baglanti.Close();
        }

        private void cmbxYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            baglanti.Open();
            komut = new SqlCommand("select marka,model,uretimyili,fiyat,resim,yilID from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID inner join ArabaYil on ArabaModeli.modelID = ArabaYil.modelID where ArabaMarka.marka = @marka and ArabaModeli.model = @model and ArabaYil.uretimyili=@yil", baglanti);
            komut.Parameters.AddWithValue("@marka", cmbxMarka.Text.ToString());
            komut.Parameters.AddWithValue("@model", cmbxModel.Text.ToString());
            komut.Parameters.AddWithValue("@yil", cmbxYil.Text.ToString());
            dr = komut.ExecuteReader();   
            if (dr.Read())
            {
                lblFiyat.Text= cmbxMarka.Text.ToString() + " Marka " + cmbxModel.Text.ToString() + cmbxYil.Text.ToString() + " Model  aracın Fiyatı :"+dr[3].ToString()+" TL";
                pcbxArabaFoto.ImageLocation=dr["resim"].ToString();
                yilID = Convert.ToInt32(dr["yilID"]);
            }
            baglanti.Close();
        }
        
        public void renklendir()
        {
            panelMusteri.BackColor = System.Drawing.ColorTranslator.FromHtml("#118ab2");
            panelSecim.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff6b6b");
            label1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffd166");
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ef476f");
            lblMusteriAdiSoyadi.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffd166");
            lblMusteriAdiSoyadi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ef476f");
            lblFiyat.BackColor = System.Drawing.ColorTranslator.FromHtml("#4ecdc4");
            lblFiyat.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1a535c5");

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Acilis ac = new Acilis();
            ac.Show();
            this.Visible = false;
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Insert Into Satislar (musteriID,yilID) values(" + musteriID + "," + yilID + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(cmbxMarka.Text.ToString() + " Marka " + cmbxModel.Text.ToString() + cmbxYil.Text.ToString() + " Model  aracın "+name+" kullanıcısına satıldı.","Satış Bilgisi");
            lblFiyat.Text = "";
            
        }
    }
}
