
namespace ArabaSatisOtomasyonu
{
    partial class FiyatIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbxMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxID = new System.Windows.Forms.ComboBox();
            this.btnResimGuncelle = new System.Windows.Forms.Button();
            this.lblResim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.txtYilGuncelle = new System.Windows.Forms.TextBox();
            this.btnYiFiyatGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDSil = new System.Windows.Forms.TextBox();
            this.btnFiyatSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbxAraba = new System.Windows.Forms.PictureBox();
            this.btnArabaSec = new System.Windows.Forms.Button();
            this.txtFiyatKayit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYilKayit = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lbxYil = new System.Windows.Forms.ListBox();
            this.cmbxModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAraba)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxMarka
            // 
            this.cmbxMarka.FormattingEnabled = true;
            this.cmbxMarka.Location = new System.Drawing.Point(102, 31);
            this.cmbxMarka.Name = "cmbxMarka";
            this.cmbxMarka.Size = new System.Drawing.Size(176, 24);
            this.cmbxMarka.TabIndex = 22;
            this.cmbxMarka.SelectedIndexChanged += new System.EventHandler(this.cmbxMarka_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marka Seç";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbxID);
            this.groupBox3.Controls.Add(this.btnResimGuncelle);
            this.groupBox3.Controls.Add(this.lblResim);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFiyatGuncelle);
            this.groupBox3.Controls.Add(this.txtYilGuncelle);
            this.groupBox3.Controls.Add(this.btnYiFiyatGuncelle);
            this.groupBox3.Location = new System.Drawing.Point(316, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 229);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yıl-Fiyat Güncelle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID Seç";
            // 
            // cmbxID
            // 
            this.cmbxID.FormattingEnabled = true;
            this.cmbxID.Location = new System.Drawing.Point(18, 70);
            this.cmbxID.Name = "cmbxID";
            this.cmbxID.Size = new System.Drawing.Size(121, 24);
            this.cmbxID.TabIndex = 10;
            this.cmbxID.SelectedIndexChanged += new System.EventHandler(this.cmbxID_SelectedIndexChanged);
            // 
            // btnResimGuncelle
            // 
            this.btnResimGuncelle.Location = new System.Drawing.Point(169, 115);
            this.btnResimGuncelle.Name = "btnResimGuncelle";
            this.btnResimGuncelle.Size = new System.Drawing.Size(122, 29);
            this.btnResimGuncelle.TabIndex = 9;
            this.btnResimGuncelle.Text = "Resim Guncelle";
            this.btnResimGuncelle.UseVisualStyleBackColor = true;
            this.btnResimGuncelle.Click += new System.EventHandler(this.btnResimGuncelle_Click);
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(309, 121);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(0, 17);
            this.lblResim.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yıl";
            // 
            // txtFiyatGuncelle
            // 
            this.txtFiyatGuncelle.Location = new System.Drawing.Point(371, 67);
            this.txtFiyatGuncelle.Name = "txtFiyatGuncelle";
            this.txtFiyatGuncelle.Size = new System.Drawing.Size(177, 22);
            this.txtFiyatGuncelle.TabIndex = 5;
            // 
            // txtYilGuncelle
            // 
            this.txtYilGuncelle.Location = new System.Drawing.Point(371, 28);
            this.txtYilGuncelle.Name = "txtYilGuncelle";
            this.txtYilGuncelle.Size = new System.Drawing.Size(177, 22);
            this.txtYilGuncelle.TabIndex = 3;
            // 
            // btnYiFiyatGuncelle
            // 
            this.btnYiFiyatGuncelle.Location = new System.Drawing.Point(535, 172);
            this.btnYiFiyatGuncelle.Name = "btnYiFiyatGuncelle";
            this.btnYiFiyatGuncelle.Size = new System.Drawing.Size(149, 33);
            this.btnYiFiyatGuncelle.TabIndex = 4;
            this.btnYiFiyatGuncelle.Text = "GÜNCELLE";
            this.btnYiFiyatGuncelle.UseVisualStyleBackColor = true;
            this.btnYiFiyatGuncelle.Click += new System.EventHandler(this.btnYiFiyatGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIDSil);
            this.groupBox2.Controls.Add(this.btnFiyatSil);
            this.groupBox2.Location = new System.Drawing.Point(316, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 106);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yıl-Fiyat Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Araba ID";
            // 
            // txtIDSil
            // 
            this.txtIDSil.Location = new System.Drawing.Point(132, 44);
            this.txtIDSil.Name = "txtIDSil";
            this.txtIDSil.Size = new System.Drawing.Size(177, 22);
            this.txtIDSil.TabIndex = 3;
            // 
            // btnFiyatSil
            // 
            this.btnFiyatSil.Location = new System.Drawing.Point(341, 39);
            this.btnFiyatSil.Name = "btnFiyatSil";
            this.btnFiyatSil.Size = new System.Drawing.Size(149, 33);
            this.btnFiyatSil.TabIndex = 3;
            this.btnFiyatSil.Text = "SİL";
            this.btnFiyatSil.UseVisualStyleBackColor = true;
            this.btnFiyatSil.Click += new System.EventHandler(this.btnFiyatSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbxAraba);
            this.groupBox1.Controls.Add(this.btnArabaSec);
            this.groupBox1.Controls.Add(this.txtFiyatKayit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtYilKayit);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Location = new System.Drawing.Point(316, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 284);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yıl-Fiyat Kayıt";
            // 
            // pcbxAraba
            // 
            this.pcbxAraba.Location = new System.Drawing.Point(358, 14);
            this.pcbxAraba.Name = "pcbxAraba";
            this.pcbxAraba.Size = new System.Drawing.Size(287, 248);
            this.pcbxAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxAraba.TabIndex = 7;
            this.pcbxAraba.TabStop = false;
            // 
            // btnArabaSec
            // 
            this.btnArabaSec.Location = new System.Drawing.Point(132, 120);
            this.btnArabaSec.Name = "btnArabaSec";
            this.btnArabaSec.Size = new System.Drawing.Size(149, 33);
            this.btnArabaSec.TabIndex = 6;
            this.btnArabaSec.Text = "RESİM SEÇ";
            this.btnArabaSec.UseVisualStyleBackColor = true;
            this.btnArabaSec.Click += new System.EventHandler(this.btnArabaSec_Click);
            // 
            // txtFiyatKayit
            // 
            this.txtFiyatKayit.Location = new System.Drawing.Point(104, 79);
            this.txtFiyatKayit.Name = "txtFiyatKayit";
            this.txtFiyatKayit.Size = new System.Drawing.Size(177, 22);
            this.txtFiyatKayit.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Araba Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Araba Yılı";
            // 
            // txtYilKayit
            // 
            this.txtYilKayit.Location = new System.Drawing.Point(104, 32);
            this.txtYilKayit.Name = "txtYilKayit";
            this.txtYilKayit.Size = new System.Drawing.Size(177, 22);
            this.txtYilKayit.TabIndex = 1;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(132, 170);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(149, 33);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "KAYDET";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(118, 460);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(149, 33);
            this.btnGeri.TabIndex = 17;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lbxYil
            // 
            this.lbxYil.FormattingEnabled = true;
            this.lbxYil.ItemHeight = 16;
            this.lbxYil.Location = new System.Drawing.Point(15, 138);
            this.lbxYil.Name = "lbxYil";
            this.lbxYil.Size = new System.Drawing.Size(263, 292);
            this.lbxYil.TabIndex = 16;
            // 
            // cmbxModel
            // 
            this.cmbxModel.FormattingEnabled = true;
            this.cmbxModel.Location = new System.Drawing.Point(102, 88);
            this.cmbxModel.Name = "cmbxModel";
            this.cmbxModel.Size = new System.Drawing.Size(176, 24);
            this.cmbxModel.TabIndex = 24;
            this.cmbxModel.SelectedIndexChanged += new System.EventHandler(this.cmbxModel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Model Seç";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FiyatIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 689);
            this.Controls.Add(this.cmbxModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbxMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lbxYil);
            this.Name = "FiyatIslemleri";
            this.Text = "Fiyat İşlemleri";
            this.Load += new System.EventHandler(this.FiyatIslemleri_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxAraba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyatGuncelle;
        private System.Windows.Forms.TextBox txtYilGuncelle;
        private System.Windows.Forms.Button btnYiFiyatGuncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDSil;
        private System.Windows.Forms.Button btnFiyatSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYilKayit;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListBox lbxYil;
        private System.Windows.Forms.ComboBox cmbxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pcbxAraba;
        private System.Windows.Forms.Button btnArabaSec;
        private System.Windows.Forms.TextBox txtFiyatKayit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnResimGuncelle;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxID;
    }
}