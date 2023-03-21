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
    public partial class ModelIslemleri : Form
    {
        public ModelIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-37H7N8V; Initial Catalog=ArabaSatis;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader dr;
        List<int> markaIDList = new List<int>();
        int markaID = 0;
        public void lbxModelDoldur()
        {
            
            lbxModel.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("select marka,model from ArabaMarka inner join ArabaModeli on ArabaMarka.markaID=ArabaModeli.markaID where ArabaMarka.marka ='" + cmbxMarka.Text.ToString()+"'", baglanti) ;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbxModel.Items.Add(dr[1]);
            }
            baglanti.Close();
            //MessageBox.Show(markaID.ToString());
        }
        private void ModelIslemleri_Load(object sender, EventArgs e)
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
            lbxModelDoldur();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaModeli where model='"+txtModelKayit.Text.ToString()+"'",baglanti);
            dr= komut.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                MessageBox.Show("Girilen model kayıtlı farklı bir model giriniz.");
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("Insert Into ArabaModeli (markaID,model) values("+markaID+",'"+txtModelKayit.Text.ToString()+"')",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(txtModelKayit.Text.ToString()+" modeli kayıt edildi.");
                txtModelKayit.Text = "";
                lbxModelDoldur();
            }
        }

        private void btnModelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Delete From ArabaModeli where model= '" + txtModelSil.Text.ToString() + "'", baglanti);
            if (komut.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(txtModelSil.Text.ToString() + " modeli silindi.");
                baglanti.Close();
                txtModelSil.Text = "";
                lbxModelDoldur();
            }
            else
            {
                MessageBox.Show("Böyle bir model bulunmamaktadır.");
                baglanti.Close();
            }
        }

        private void btnModelGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select * from ArabaModeli where model='" + txtModelGuncelle.Text.ToString() + "'", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                MessageBox.Show("Girilen model kayıtlı farklı bir model giriniz.");
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("Update ArabaModeli set model='" + txtModelGuncelle.Text.ToString() + "' where model='" + txtEskiModel.Text.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show(txtEskiModel.Text.ToString() + " modeli " + txtModelGuncelle.Text.ToString() + " olarak güncellendi.");
                txtEskiModel.Text = "";
                txtModelGuncelle.Text = "";
                baglanti.Close();
                lbxModelDoldur();
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
