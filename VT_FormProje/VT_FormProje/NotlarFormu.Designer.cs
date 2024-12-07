namespace VT_FormProje
{
    partial class NotlarFormu
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
            this.dataGridViewNotlar = new System.Windows.Forms.DataGridView();
            this.OgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersKredi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VizeNotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalNotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotlar
            // 
            this.dataGridViewNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgrNo,
            this.DersAd,
            this.DersKredi,
            this.VizeNotu,
            this.FinalNotu});
            this.dataGridViewNotlar.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewNotlar.Name = "dataGridViewNotlar";
            this.dataGridViewNotlar.Size = new System.Drawing.Size(776, 394);
            this.dataGridViewNotlar.TabIndex = 0;
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
            // VizeNotu
            // 
            this.VizeNotu.DataPropertyName = "VizeNotu";
            this.VizeNotu.HeaderText = "Vize";
            this.VizeNotu.Name = "VizeNotu";
            // 
            // FinalNotu
            // 
            this.FinalNotu.DataPropertyName = "FinalNotu";
            this.FinalNotu.HeaderText = "Final";
            this.FinalNotu.Name = "FinalNotu";
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNot.Location = new System.Drawing.Point(7, 409);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(785, 32);
            this.labelNot.TabIndex = 8;
            this.labelNot.Text = "NOT:  \'0\' olan değerler daha sınava girilmedi anlamındadır.";
            this.labelNot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.dataGridViewNotlar);
            this.Name = "NotlarFormu";
            this.Text = "Notlar Sayfası";
            this.Load += new System.EventHandler(this.NotlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersKredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VizeNotu;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalNotu;
        private System.Windows.Forms.Label labelNot;
    }
}