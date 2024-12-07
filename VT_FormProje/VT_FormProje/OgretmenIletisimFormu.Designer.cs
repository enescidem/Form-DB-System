namespace VT_FormProje
{
    partial class OgretmenIletisimFormu
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
            this.dataGridViewOgretmen = new System.Windows.Forms.DataGridView();
            this.OgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersKredi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.labelOgretmenAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgretmen
            // 
            this.dataGridViewOgretmen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgretmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgrNo,
            this.DersAd,
            this.DersKredi});
            this.dataGridViewOgretmen.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewOgretmen.Name = "dataGridViewOgretmen";
            this.dataGridViewOgretmen.Size = new System.Drawing.Size(776, 341);
            this.dataGridViewOgretmen.TabIndex = 1;
            // 
            // OgrNo
            // 
            this.OgrNo.DataPropertyName = "Ad";
            this.OgrNo.HeaderText = "Öğretmen Adı";
            this.OgrNo.Name = "OgrNo";
            // 
            // DersAd
            // 
            this.DersAd.DataPropertyName = "Soyad";
            this.DersAd.HeaderText = "Öğretmen Soyadı";
            this.DersAd.Name = "DersAd";
            // 
            // DersKredi
            // 
            this.DersKredi.DataPropertyName = "Tel";
            this.DersKredi.HeaderText = "Öğretmen Telefonu";
            this.DersKredi.Name = "DersKredi";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAra.Location = new System.Drawing.Point(590, 22);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(198, 38);
            this.textBoxAra.TabIndex = 4;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxOgrenciNo_TextChanged);
            // 
            // labelOgretmenAra
            // 
            this.labelOgretmenAra.AutoSize = true;
            this.labelOgretmenAra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgretmenAra.Location = new System.Drawing.Point(377, 28);
            this.labelOgretmenAra.Name = "labelOgretmenAra";
            this.labelOgretmenAra.Size = new System.Drawing.Size(207, 32);
            this.labelOgretmenAra.TabIndex = 5;
            this.labelOgretmenAra.Text = "Öğretmen Ara:";
            this.labelOgretmenAra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgretmenIletisimFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOgretmenAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.dataGridViewOgretmen);
            this.Name = "OgretmenIletisimFormu";
            this.Text = "OgretmenIletisimFormu";
            this.Load += new System.EventHandler(this.OgretmenIletisimFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOgretmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersKredi;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label labelOgretmenAra;
    }
}