
namespace ArabaSatisOtomasyonu
{
    partial class ArabaSatisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbxMarka = new System.Windows.Forms.ComboBox();
            this.cmbxModel = new System.Windows.Forms.ComboBox();
            this.cmbxYil = new System.Windows.Forms.ComboBox();
            this.lblMusteriAdiSoyadi = new System.Windows.Forms.Label();
            this.pcbxArabaFoto = new System.Windows.Forms.PictureBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMusteri = new System.Windows.Forms.Panel();
            this.panelSecim = new System.Windows.Forms.Panel();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxArabaFoto)).BeginInit();
            this.panelMusteri.SuspendLayout();
            this.panelSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxMarka
            // 
            this.cmbxMarka.FormattingEnabled = true;
            this.cmbxMarka.Location = new System.Drawing.Point(21, 53);
            this.cmbxMarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxMarka.Name = "cmbxMarka";
            this.cmbxMarka.Size = new System.Drawing.Size(151, 24);
            this.cmbxMarka.TabIndex = 0;
            this.cmbxMarka.SelectedIndexChanged += new System.EventHandler(this.cmbxMarka_SelectedIndexChanged);
            // 
            // cmbxModel
            // 
            this.cmbxModel.FormattingEnabled = true;
            this.cmbxModel.Location = new System.Drawing.Point(216, 53);
            this.cmbxModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxModel.Name = "cmbxModel";
            this.cmbxModel.Size = new System.Drawing.Size(180, 24);
            this.cmbxModel.TabIndex = 1;
            this.cmbxModel.SelectedIndexChanged += new System.EventHandler(this.cmbxModel_SelectedIndexChanged);
            // 
            // cmbxYil
            // 
            this.cmbxYil.FormattingEnabled = true;
            this.cmbxYil.Location = new System.Drawing.Point(441, 53);
            this.cmbxYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxYil.Name = "cmbxYil";
            this.cmbxYil.Size = new System.Drawing.Size(139, 24);
            this.cmbxYil.TabIndex = 2;
            this.cmbxYil.SelectedIndexChanged += new System.EventHandler(this.cmbxYil_SelectedIndexChanged);
            // 
            // lblMusteriAdiSoyadi
            // 
            this.lblMusteriAdiSoyadi.AutoSize = true;
            this.lblMusteriAdiSoyadi.Location = new System.Drawing.Point(113, 12);
            this.lblMusteriAdiSoyadi.Name = "lblMusteriAdiSoyadi";
            this.lblMusteriAdiSoyadi.Padding = new System.Windows.Forms.Padding(5);
            this.lblMusteriAdiSoyadi.Size = new System.Drawing.Size(10, 27);
            this.lblMusteriAdiSoyadi.TabIndex = 3;
            // 
            // pcbxArabaFoto
            // 
            this.pcbxArabaFoto.Location = new System.Drawing.Point(672, 18);
            this.pcbxArabaFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbxArabaFoto.Name = "pcbxArabaFoto";
            this.pcbxArabaFoto.Size = new System.Drawing.Size(308, 266);
            this.pcbxArabaFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxArabaFoto.TabIndex = 7;
            this.pcbxArabaFoto.TabStop = false;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(32, 157);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Padding = new System.Windows.Forms.Padding(5);
            this.lblFiyat.Size = new System.Drawing.Size(10, 27);
            this.lblFiyat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marka Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Üretim Yılını Seçiniz";
            // 
            // panelMusteri
            // 
            this.panelMusteri.Controls.Add(this.lblMusteriAdiSoyadi);
            this.panelMusteri.Controls.Add(this.label1);
            this.panelMusteri.Location = new System.Drawing.Point(0, 0);
            this.panelMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.panelMusteri.Name = "panelMusteri";
            this.panelMusteri.Size = new System.Drawing.Size(1000, 53);
            this.panelMusteri.TabIndex = 13;
            // 
            // panelSecim
            // 
            this.panelSecim.Controls.Add(this.btnGeri);
            this.panelSecim.Controls.Add(this.btnSatinAl);
            this.panelSecim.Controls.Add(this.label2);
            this.panelSecim.Controls.Add(this.cmbxMarka);
            this.panelSecim.Controls.Add(this.lblFiyat);
            this.panelSecim.Controls.Add(this.label4);
            this.panelSecim.Controls.Add(this.pcbxArabaFoto);
            this.panelSecim.Controls.Add(this.cmbxModel);
            this.panelSecim.Controls.Add(this.label3);
            this.panelSecim.Controls.Add(this.cmbxYil);
            this.panelSecim.Location = new System.Drawing.Point(0, 61);
            this.panelSecim.Margin = new System.Windows.Forms.Padding(4);
            this.panelSecim.Name = "panelSecim";
            this.panelSecim.Size = new System.Drawing.Size(1000, 331);
            this.panelSecim.TabIndex = 14;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(174, 216);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(133, 35);
            this.btnSatinAl.TabIndex = 13;
            this.btnSatinAl.Text = "SATIN AL";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(355, 216);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(133, 35);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ArabaSatisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 384);
            this.Controls.Add(this.panelSecim);
            this.Controls.Add(this.panelMusteri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArabaSatisEkrani";
            this.Text = "Araba Satış Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxArabaFoto)).EndInit();
            this.panelMusteri.ResumeLayout(false);
            this.panelMusteri.PerformLayout();
            this.panelSecim.ResumeLayout(false);
            this.panelSecim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxMarka;
        private System.Windows.Forms.ComboBox cmbxModel;
        private System.Windows.Forms.ComboBox cmbxYil;
        private System.Windows.Forms.Label lblMusteriAdiSoyadi;
        private System.Windows.Forms.PictureBox pcbxArabaFoto;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMusteri;
        private System.Windows.Forms.Panel panelSecim;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnGeri;
    }
}

