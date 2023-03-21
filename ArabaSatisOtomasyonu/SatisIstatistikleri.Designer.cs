
namespace ArabaSatisOtomasyonu
{
    partial class SatisIstatistikleri
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
            this.lbxMHarcama = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxPahalıMarka = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxBugun = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxMHarcama
            // 
            this.lbxMHarcama.FormattingEnabled = true;
            this.lbxMHarcama.ItemHeight = 16;
            this.lbxMHarcama.Location = new System.Drawing.Point(48, 67);
            this.lbxMHarcama.Name = "lbxMHarcama";
            this.lbxMHarcama.Size = new System.Drawing.Size(223, 164);
            this.lbxMHarcama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Müşteri Harcamaları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Markaların En Pahalı Araba Fiyatları";
            // 
            // lbxPahalıMarka
            // 
            this.lbxPahalıMarka.FormattingEnabled = true;
            this.lbxPahalıMarka.ItemHeight = 16;
            this.lbxPahalıMarka.Location = new System.Drawing.Point(341, 67);
            this.lbxPahalıMarka.Name = "lbxPahalıMarka";
            this.lbxPahalıMarka.Size = new System.Drawing.Size(223, 164);
            this.lbxPahalıMarka.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bugün Alışveriş Yapan Müşteriler";
            // 
            // lbxBugun
            // 
            this.lbxBugun.FormattingEnabled = true;
            this.lbxBugun.ItemHeight = 16;
            this.lbxBugun.Location = new System.Drawing.Point(634, 67);
            this.lbxBugun.Name = "lbxBugun";
            this.lbxBugun.Size = new System.Drawing.Size(223, 164);
            this.lbxBugun.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SatisIstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxBugun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxPahalıMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxMHarcama);
            this.Name = "SatisIstatistikleri";
            this.Text = "Satis İstatistikleri";
            this.Load += new System.EventHandler(this.SatisIstatistikleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMHarcama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxPahalıMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxBugun;
        private System.Windows.Forms.Button button1;
    }
}