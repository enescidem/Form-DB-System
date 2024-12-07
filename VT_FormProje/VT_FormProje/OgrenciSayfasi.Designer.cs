namespace VT_FormProje
{
    partial class OgrenciSayfasi
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
        /// "Hoşgeldin " + OgrenciGirisi._ogrenciad + " " + OgrenciGirisi._ogrsoyad;
        private void InitializeComponent()
        {
            this.labelHosgeldinOgrenci = new System.Windows.Forms.Label();
            this.labelSınıf = new System.Windows.Forms.Label();
            this.buttonNotlar = new System.Windows.Forms.Button();
            this.buttonAyarlar = new System.Windows.Forms.Button();
            this.labelBolum = new System.Windows.Forms.Label();
            this.buttonDersSecimi = new System.Windows.Forms.Button();
            this.buttonOgretmenIletisim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHosgeldinOgrenci
            // 
            this.labelHosgeldinOgrenci.AutoSize = true;
            this.labelHosgeldinOgrenci.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHosgeldinOgrenci.Location = new System.Drawing.Point(12, 9);
            this.labelHosgeldinOgrenci.Name = "labelHosgeldinOgrenci";
            this.labelHosgeldinOgrenci.Size = new System.Drawing.Size(321, 80);
            this.labelHosgeldinOgrenci.TabIndex = 6;
            this.labelHosgeldinOgrenci.Text = "Hoşgeldin  ";
            this.labelHosgeldinOgrenci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSınıf
            // 
            this.labelSınıf.AutoSize = true;
            this.labelSınıf.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSınıf.Location = new System.Drawing.Point(20, 89);
            this.labelSınıf.Name = "labelSınıf";
            this.labelSınıf.Size = new System.Drawing.Size(117, 32);
            this.labelSınıf.TabIndex = 7;
            this.labelSınıf.Text = "Sınıfın: ";
            this.labelSınıf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNotlar
            // 
            this.buttonNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNotlar.Location = new System.Drawing.Point(12, 270);
            this.buttonNotlar.Name = "buttonNotlar";
            this.buttonNotlar.Size = new System.Drawing.Size(173, 168);
            this.buttonNotlar.TabIndex = 8;
            this.buttonNotlar.Text = "NOTLAR";
            this.buttonNotlar.UseVisualStyleBackColor = true;
            this.buttonNotlar.Click += new System.EventHandler(this.buttonNotlar_Click);
            // 
            // buttonAyarlar
            // 
            this.buttonAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAyarlar.Location = new System.Drawing.Point(191, 270);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(200, 168);
            this.buttonAyarlar.TabIndex = 9;
            this.buttonAyarlar.Text = "AYARLAR";
            this.buttonAyarlar.UseVisualStyleBackColor = true;
            this.buttonAyarlar.Click += new System.EventHandler(this.buttonAyarlar_Click);
            // 
            // labelBolum
            // 
            this.labelBolum.AutoSize = true;
            this.labelBolum.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBolum.Location = new System.Drawing.Point(20, 141);
            this.labelBolum.Name = "labelBolum";
            this.labelBolum.Size = new System.Drawing.Size(154, 32);
            this.labelBolum.TabIndex = 10;
            this.labelBolum.Text = "Bölümün: ";
            this.labelBolum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDersSecimi
            // 
            this.buttonDersSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDersSecimi.Location = new System.Drawing.Point(397, 270);
            this.buttonDersSecimi.Name = "buttonDersSecimi";
            this.buttonDersSecimi.Size = new System.Drawing.Size(186, 168);
            this.buttonDersSecimi.TabIndex = 11;
            this.buttonDersSecimi.Text = "DERS SEÇİMİ";
            this.buttonDersSecimi.UseVisualStyleBackColor = true;
            this.buttonDersSecimi.Click += new System.EventHandler(this.buttonDersSecimi_Click);
            // 
            // buttonOgretmenIletisim
            // 
            this.buttonOgretmenIletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgretmenIletisim.Location = new System.Drawing.Point(589, 270);
            this.buttonOgretmenIletisim.Name = "buttonOgretmenIletisim";
            this.buttonOgretmenIletisim.Size = new System.Drawing.Size(199, 168);
            this.buttonOgretmenIletisim.TabIndex = 12;
            this.buttonOgretmenIletisim.Text = "Öğretmen İletişim";
            this.buttonOgretmenIletisim.UseVisualStyleBackColor = true;
            this.buttonOgretmenIletisim.Click += new System.EventHandler(this.buttonOgretmenIletisim_Click);
            // 
            // OgrenciSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOgretmenIletisim);
            this.Controls.Add(this.buttonDersSecimi);
            this.Controls.Add(this.labelBolum);
            this.Controls.Add(this.buttonAyarlar);
            this.Controls.Add(this.buttonNotlar);
            this.Controls.Add(this.labelSınıf);
            this.Controls.Add(this.labelHosgeldinOgrenci);
            this.Name = "OgrenciSayfasi";
            this.Text = "Öğrenci Sayfası";
            this.Load += new System.EventHandler(this.OgrenciSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHosgeldinOgrenci;
        private System.Windows.Forms.Label labelSınıf;
        private System.Windows.Forms.Button buttonNotlar;
        private System.Windows.Forms.Button buttonAyarlar;
        private System.Windows.Forms.Label labelBolum;
        private System.Windows.Forms.Button buttonDersSecimi;
        private System.Windows.Forms.Button buttonOgretmenIletisim;
    }
}