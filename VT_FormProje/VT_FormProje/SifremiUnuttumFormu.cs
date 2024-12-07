using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT_FormProje
{
    public partial class SifremiUnuttumFormu : Form
    {
        private void buttonSifreyiDegistir_Click(object sender, EventArgs e)
        {
            int _ogrno = Convert.ToInt32(textBoxOgrNo.Text);
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE TblOgrenci SET Sifre='" + textBoxYeniSifre.Text +"' WHERE OgrNo='" + _ogrno + "' AND OgrenciAd='"+textBoxOgrAd.Text+"' AND OgrSoyad='"+textBoxOgrSoyad.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Şifre Değiştirme Başarılı");
        }
        public SifremiUnuttumFormu()
        {
            InitializeComponent();
        }
        private void SifremiUnuttumFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
