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
    public partial class FiyatIslemleri : Form
    {
        public FiyatIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader dr;
        List<int> markaIDList = new List<int>();
        List<int> modelIDList = new List<int>();
        int markaID = 0,modelID=0;
        String yol;

        public void lbxYilDoldur()
        {
            
            lbxYil.Items.Clear();
            cmbxID.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select marka,model,uretimyili,fiyat,resim,yilID from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID inner join ArabaYil on ArabaModeli.modelID = ArabaYil.modelID where ArabaMarka.marka = @marka and ArabaModeli.model = @model", baglanti);
            komut.Parameters.AddWithValue("@marka", cmbxMarka.Text.ToString());
            komut.Parameters.AddWithValue("@model", cmbxModel.Text.ToString());

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbxYil.Items.Add(dr[5]+"  "+dr[2]+"  "+dr[3]+"TL");
                cmbxID.Items.Add(Convert.ToInt32(dr[5]));
            }
            //MessageBox.Show(modelID.ToString());
            baglanti.Close();
        }
        private void FiyatIslemleri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaMarka", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                markaIDList.Add(Convert.ToInt32(dr[0]));
                cmbxMarka.Items.Add(dr[1]);
            }
            baglanti.Close();
        }

        private void cmbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            markaID = markaIDList[cmbxMarka.SelectedIndex];
            cmbxModel.Items.Clear();
            lbxYil.Items.Clear();
            cmbxID.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select marka,model,ArabaModeli.modelID from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID where ArabaMarka.marka ='" + cmbxMarka.Text.ToString() + "'", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                modelIDList.Add(Convert.ToInt32(dr[2]));
                cmbxModel.Items.Add(dr[1]);
            }
            //MessageBox.Show(markaID.ToString());
            baglanti.Close();
        }
        private void cmbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelID = modelIDList[cmbxModel.SelectedIndex];
            lbxYilDoldur();
            
        }
        private void btnArabaSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pcbxAraba.ImageLocation = openFileDialog1.FileName;
                yol = openFileDialog1.FileName.ToString();
            }
        }
        
    private void btnKayit_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                komut = new SqlCommand("Insert Into ArabaYil (markaID,modelID,uretimyili,fiyat,resim) values(" + markaID + "," +modelID+",'"+ txtYilKayit.Text.ToString() +"','"+txtFiyatKayit.Text.ToString()+"','"+yol+ "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(txtYilKayit.Text.ToString() + " yılı kayıt edildi.");
                txtYilKayit.Text = "";
                txtFiyatKayit.Text = "";
                lblResim.Text = "";
                lbxYilDoldur();
            
        }

        private void btnFiyatSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Delete From ArabaYil where yilID= '" + txtIDSil.Text.ToString() + "'", baglanti);
            if (komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(txtIDSil.Text.ToString() + " ID silindi.");
                baglanti.Close();
                txtIDSil.Text = "";
                lbxYilDoldur();
            }
            else
            {
                MessageBox.Show("Böyle bir ID bulunmamaktadır.");
                baglanti.Close();
            }
        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcbxAraba.ImageLocation = openFileDialog1.FileName;
                yol = openFileDialog1.FileName.ToString();
            }
        }

        private void btnYiFiyatGuncelle_Click(object sender, EventArgs e)
        {
            
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("Update ArabaYil set uretimyili='" + txtYilGuncelle.Text.ToString()+"',fiyat='"+txtFiyatGuncelle.Text.ToString()+"',resim='"+lblResim.Text.ToString() + "' where yilID='" + cmbxID.Text.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                //MessageBox.Show(txtEskiModel.Text.ToString() + " modeli " + txtModelGuncelle.Text.ToString() + " olarak güncellendi.");
                txtYilGuncelle.Text = "";
                txtFiyatGuncelle.Text = "";
                lblResim.Text = "";
                baglanti.Close();
                lbxYilDoldur();
            
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Yonetici yon = new Yonetici();
            yon.Show();
            this.Visible = false;
        }

        private void cmbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYilGuncelle.Text = "";
            txtFiyatGuncelle.Text = "";
            lblResim.Text = "";
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaYil where yilID="+cmbxID.Text.ToString(), baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtYilGuncelle.Text = dr["uretimyili"].ToString();
                txtFiyatGuncelle.Text = dr["fiyat"].ToString();
                lblResim.Text = dr["resim"].ToString();
            }
            baglanti.Close();
        }

    }
}
