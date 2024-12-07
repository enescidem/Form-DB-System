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
    public partial class OgrenciGirisi : Form
    {
        public static string _ogrencino, _sifre, _ogrenciad, _ogrsoyad, _tel, _ilID, _bolumID, _sinif, _ayarguncelleme;

        private void buttonSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumFormu sifremiUnuttumFormu = new SifremiUnuttumFormu();
            sifremiUnuttumFormu.Show();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            //TEXTBOXA GİRİLEN DEĞERLERİ SELECT VERİTABANI SORGUSU İLE KONTROL ETME
            _ogrencino = textBoxOgrenciNo.Text;
            _sifre = textBoxSifre.Text;
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + _ogrencino + "' AND Sifre LIKE'" + _sifre + "'";
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                //TblOgrenci Tablosundaki verilere diğer classlardan erişebilmek için değişkenlere atama
                SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
                SqlCommand cmd1 = new SqlCommand();
                con1.Open();
                cmd1.Connection = con1;
                cmd1.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + _ogrencino + "'";
                SqlDataReader read1 = cmd1.ExecuteReader();
                read1.Read();
                _ogrenciad = (string)read1["OgrenciAd"];
                _ogrsoyad = (string)read1["OgrSoyad"];
                _tel = (string)read1["Tel"];
                _ilID = Convert.ToString(read1["ilID"]);
                _bolumID = Convert.ToString(read1["BolumID"]);
                _sinif = Convert.ToString(read1["Sinif"]);
                _ayarguncelleme = Convert.ToString(read1["AyarGuncellemeSayisi"]);
                con1.Close();
                
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                OgrenciSayfasi ogrenciSayfasi = new OgrenciSayfasi();
                ogrenciSayfasi.Show();
            }
            else
            {
                MessageBox.Show("Hatalı öğrenci no veya şifre. Kontrol edip dekrar deneyiniz!");
            }
            con.Close();
        }

        public OgrenciGirisi()
        {
            InitializeComponent();
        }

        private void OgrenciGirisi_Load(object sender, EventArgs e)
        {

        }




       
    }
}
