namespace VT_FormProje
{
    partial class OgrenciGirisi
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
            this.labelOgrenciNo = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBoxOgrenciNo = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.labelOgrenciGirisi = new System.Windows.Forms.Label();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonSifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOgrenciNo
            // 
            this.labelOgrenciNo.AutoSize = true;
            this.labelOgrenciNo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrenciNo.Location = new System.Drawing.Point(170, 204);
            this.labelOgrenciNo.Name = "labelOgrenciNo";
            this.labelOgrenciNo.Size = new System.Drawing.Size(163, 32);
            this.labelOgrenciNo.TabIndex = 0;
            this.labelOgrenciNo.Text = "Öğrenci No";
            this.labelOgrenciNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifre.Location = new System.Drawing.Point(258, 273);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(75, 32);
            this.labelSifre.TabIndex = 2;
            this.labelSifre.Text = "Şifre";
            this.labelSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOgrenciNo
            // 
            this.textBoxOgrenciNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrenciNo.Location = new System.Drawing.Point(339, 204);
            this.textBoxOgrenciNo.Name = "textBoxOgrenciNo";
            this.textBoxOgrenciNo.Size = new System.Drawing.Size(208, 38);
            this.textBoxOgrenciNo.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(339, 273);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(208, 38);
            this.textBoxSifre.TabIndex = 4;
            // 
            // labelOgrenciGirisi
            // 
            this.labelOgrenciGirisi.AutoSize = true;
            this.labelOgrenciGirisi.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrenciGirisi.Location = new System.Drawing.Point(180, 65);
            this.labelOgrenciGirisi.Name = "labelOgrenciGirisi";
            this.labelOgrenciGirisi.Size = new System.Drawing.Size(390, 80);
            this.labelOgrenciGirisi.TabIndex = 5;
            this.labelOgrenciGirisi.Text = "Öğrenci Girişi";
            this.labelOgrenciGirisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(339, 330);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(208, 44);
            this.buttonGiris.TabIndex = 6;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonSifremiUnuttum
            // 
            this.buttonSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSifremiUnuttum.Location = new System.Drawing.Point(389, 382);
            this.buttonSifremiUnuttum.Name = "buttonSifremiUnuttum";
            this.buttonSifremiUnuttum.Size = new System.Drawing.Size(98, 56);
            this.buttonSifremiUnuttum.TabIndex = 7;
            this.buttonSifremiUnuttum.Text = "Şifremi Unuttum";
            this.buttonSifremiUnuttum.UseVisualStyleBackColor = true;
            this.buttonSifremiUnuttum.Click += new System.EventHandler(this.buttonSifremiUnuttum_Click);
            // 
            // OgrenciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSifremiUnuttum);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.labelOgrenciGirisi);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxOgrenciNo);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelOgrenciNo);
            this.Name = "OgrenciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Giriş";
            this.Load += new System.EventHandler(this.OgrenciGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOgrenciNo;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBoxOgrenciNo;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label labelOgrenciGirisi;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonSifremiUnuttum;
    }
}

