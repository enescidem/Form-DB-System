namespace VT_FormProje
{
    partial class AyarlarFormu
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
            this.labelSehir = new System.Windows.Forms.Label();
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.labelAyarlar = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.labelAyarGuncelleme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSehir
            // 
            this.labelSehir.AutoSize = true;
            this.labelSehir.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSehir.Location = new System.Drawing.Point(232, 151);
            this.labelSehir.Name = "labelSehir";
            this.labelSehir.Size = new System.Drawing.Size(83, 32);
            this.labelSehir.TabIndex = 8;
            this.labelSehir.Text = "Şehir";
            this.labelSehir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSehir.FormattingEnabled = true;
            this.comboBoxSehir.Location = new System.Drawing.Point(345, 151);
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.Size = new System.Drawing.Size(210, 39);
            this.comboBoxSehir.TabIndex = 9;
            // 
            // labelAyarlar
            // 
            this.labelAyarlar.AutoSize = true;
            this.labelAyarlar.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyarlar.Location = new System.Drawing.Point(245, 44);
            this.labelAyarlar.Name = "labelAyarlar";
            this.labelAyarlar.Size = new System.Drawing.Size(292, 80);
            this.labelAyarlar.TabIndex = 10;
            this.labelAyarlar.Text = "AYARLAR";
            this.labelAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.Location = new System.Drawing.Point(204, 218);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(111, 32);
            this.labelTelefon.TabIndex = 11;
            this.labelTelefon.Text = "Telefon";
            this.labelTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTelefon.Location = new System.Drawing.Point(345, 218);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(210, 38);
            this.textBoxTelefon.TabIndex = 12;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(259, 357);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(266, 66);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifre.Location = new System.Drawing.Point(240, 288);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(75, 32);
            this.labelSifre.TabIndex = 14;
            this.labelSifre.Text = "Şifre";
            this.labelSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(345, 284);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(210, 38);
            this.textBoxSifre.TabIndex = 15;
            // 
            // labelAyarGuncelleme
            // 
            this.labelAyarGuncelleme.AutoSize = true;
            this.labelAyarGuncelleme.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAyarGuncelleme.Location = new System.Drawing.Point(596, 9);
            this.labelAyarGuncelleme.Name = "labelAyarGuncelleme";
            this.labelAyarGuncelleme.Size = new System.Drawing.Size(168, 18);
            this.labelAyarGuncelleme.TabIndex = 16;
            this.labelAyarGuncelleme.Text = "Ayar Güncelleme Sayın";
            this.labelAyarGuncelleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AyarlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAyarGuncelleme);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAyarlar);
            this.Controls.Add(this.comboBoxSehir);
            this.Controls.Add(this.labelSehir);
            this.Name = "AyarlarFormu";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.AyarlarFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSehir;
        private System.Windows.Forms.ComboBox comboBoxSehir;
        private System.Windows.Forms.Label labelAyarlar;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label labelAyarGuncelleme;
    }
}