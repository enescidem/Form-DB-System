namespace VT_FormProje
{
    partial class DersSecimiFormu
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
            this.dataGridViewDersler = new System.Windows.Forms.DataGridView();
            this.labelDerslerin = new System.Windows.Forms.Label();
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.labelDersler = new System.Windows.Forms.Label();
            this.buttonDersEkle = new System.Windows.Forms.Button();
            this.labelSil = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.OgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersKredi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDersler
            // 
            this.dataGridViewDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgrNo,
            this.DersAd,
            this.DersKredi,
            this.Ad,
            this.Soyad,
            this.Tel});
            this.dataGridViewDersler.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewDersler.Name = "dataGridViewDersler";
            this.dataGridViewDersler.Size = new System.Drawing.Size(776, 272);
            this.dataGridViewDersler.TabIndex = 1;
            // 
            // labelDerslerin
            // 
            this.labelDerslerin.AutoSize = true;
            this.labelDerslerin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDerslerin.Location = new System.Drawing.Point(309, 9);
            this.labelDerslerin.Name = "labelDerslerin";
            this.labelDerslerin.Size = new System.Drawing.Size(173, 32);
            this.labelDerslerin.TabIndex = 9;
            this.labelDerslerin.Text = "DERSLERİN";
            this.labelDerslerin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Location = new System.Drawing.Point(12, 354);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(365, 39);
            this.comboBoxDersler.TabIndex = 10;
            // 
            // labelDersler
            // 
            this.labelDersler.AutoSize = true;
            this.labelDersler.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDersler.Location = new System.Drawing.Point(51, 319);
            this.labelDersler.Name = "labelDersler";
            this.labelDersler.Size = new System.Drawing.Size(298, 32);
            this.labelDersler.TabIndex = 11;
            this.labelDersler.Text = "Eklenebilecek Dersler";
            this.labelDersler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDersEkle
            // 
            this.buttonDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDersEkle.Location = new System.Drawing.Point(80, 399);
            this.buttonDersEkle.Name = "buttonDersEkle";
            this.buttonDersEkle.Size = new System.Drawing.Size(231, 39);
            this.buttonDersEkle.TabIndex = 14;
            this.buttonDersEkle.Text = "DERS EKLE";
            this.buttonDersEkle.UseVisualStyleBackColor = true;
            this.buttonDersEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
            // 
            // labelSil
            // 
            this.labelSil.AutoSize = true;
            this.labelSil.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSil.Location = new System.Drawing.Point(470, 319);
            this.labelSil.Name = "labelSil";
            this.labelSil.Size = new System.Drawing.Size(318, 32);
            this.labelSil.TabIndex = 15;
            this.labelSil.Text = "Tabloda Seçili Dersi Sil";
            this.labelSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(522, 357);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(231, 39);
            this.buttonSil.TabIndex = 16;
            this.buttonSil.Text = "DERSİ SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // OgrNo
            // 
            this.OgrNo.DataPropertyName = "OgrNo";
            this.OgrNo.HeaderText = "Öğrenci No";
            this.OgrNo.Name = "OgrNo";
            // 
            // DersAd
            // 
            this.DersAd.DataPropertyName = "DersAd";
            this.DersAd.HeaderText = "Ders";
            this.DersAd.Name = "DersAd";
            // 
            // DersKredi
            // 
            this.DersKredi.DataPropertyName = "DersKredi";
            this.DersKredi.HeaderText = "Kredi";
            this.DersKredi.Name = "DersKredi";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Öğretmen Adı";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Öğretmen Soyadı";
            this.Soyad.Name = "Soyad";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Öğretmen Telefon";
            this.Tel.Name = "Tel";
            // 
            // DersSecimiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.labelSil);
            this.Controls.Add(this.buttonDersEkle);
            this.Controls.Add(this.labelDersler);
            this.Controls.Add(this.comboBoxDersler);
            this.Controls.Add(this.labelDerslerin);
            this.Controls.Add(this.dataGridViewDersler);
            this.Name = "DersSecimiFormu";
            this.Text = "Ders Seçim";
            this.Load += new System.EventHandler(this.DersSecimiFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.Label labelDerslerin;
        private System.Windows.Forms.ComboBox comboBoxDersler;
        private System.Windows.Forms.Label labelDersler;
        private System.Windows.Forms.Button buttonDersEkle;
        private System.Windows.Forms.Label labelSil;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersKredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
    }
}