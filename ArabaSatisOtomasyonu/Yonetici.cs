using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaSatisOtomasyonu
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            MarkaIslemleri marka = new MarkaIslemleri();
            marka.Show();
            this.Visible = false;
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            ModelIslemleri model = new ModelIslemleri();
            model.Show();
            this.Visible = false;
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            FiyatIslemleri fiyat = new FiyatIslemleri();
            fiyat.Show();
            this.Visible = false;
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            SatisIstatistikleri satis = new SatisIstatistikleri();
            satis.Show();
            this.Visible = false;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Acilis ac = new Acilis();
            ac.Show();
            this.Visible = false;
        }
    }
}
