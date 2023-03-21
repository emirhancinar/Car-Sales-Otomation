
namespace ArabaSatisOtomasyonu
{
    partial class Yonetici
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
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnFiyat = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(94, 57);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(240, 52);
            this.btnMarka.TabIndex = 0;
            this.btnMarka.Text = "MARKA İŞLEMLERİ";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(94, 127);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(240, 52);
            this.btnModel.TabIndex = 1;
            this.btnModel.Text = "MODEL İŞLEMLERİ";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnFiyat
            // 
            this.btnFiyat.Location = new System.Drawing.Point(94, 195);
            this.btnFiyat.Name = "btnFiyat";
            this.btnFiyat.Size = new System.Drawing.Size(240, 52);
            this.btnFiyat.TabIndex = 2;
            this.btnFiyat.Text = "FİYAT İŞLEMLERİ";
            this.btnFiyat.UseVisualStyleBackColor = true;
            this.btnFiyat.Click += new System.EventHandler(this.btnFiyat_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.Location = new System.Drawing.Point(94, 268);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(240, 52);
            this.btnSatislar.TabIndex = 3;
            this.btnSatislar.Text = "SATIŞ İSTATİSTİKLERİ";
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(94, 341);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(240, 52);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 479);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnFiyat);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.btnMarka);
            this.Name = "Yonetici";
            this.Text = "Yonetici";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnFiyat;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnGeri;
    }
}