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
    public partial class AyarlarFormu : Form
    {
        public AyarlarFormu()
        {
            InitializeComponent();
        }
        public string AyarGuncellemeSayisi()
        {
            string _deger;
            //TblOgrenci Tablosundaki AyarGuncellemeSayisi verisini çekme
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT * FROM TblOgrenci WHERE OgrNo='" + OgrenciGirisi._ogrencino + "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            _deger = Convert.ToString(read1["AyarGuncellemeSayisi"]);
            con1.Close();
            return _deger;
        }
        private void AyarlarFormu_Load(object sender, EventArgs e)
        {
            textBoxSifre.Text = OgrenciGirisi._sifre;
            textBoxTelefon.Text = OgrenciGirisi._tel;
            //ilID sını kullanarak SQL Sorgusu ile Şehiri Bulup comboboxa atma
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT ilAd FROM Tblil WHERE ilID='" +OgrenciGirisi._ilID+ "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            comboBoxSehir.Text= Convert.ToString(read1["ilAd"]);
            con1.Close();

            //Veritabanındaki İlleri SAKLI YORDAM İLE ComboBoxa atma
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "EXEC SakliYordam";
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBoxSehir.Items.Add(read["ilAd"]);
            }
            con.Close();
        }


        
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //TRİGGER İLE AYAR GUNCELLEMEYİ SÜREKLİ GÜNCELLİYORUZ
            labelAyarGuncelleme.Text = "Ayar Güncelleme Sayınız: " + AyarGuncellemeSayisi();

            //comboboxtan seçilen ilin Şehir ID'sini Bulma SQL Sorgusu
            string _sehir = comboBoxSehir.Text;
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT ilID FROM Tblil WHERE ilAd='"+ _sehir + "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            int _ilID = (int)read1["ilID"];
            con1.Close();
            
            //Şehir ve Telefon Bilgisini Güncelleme SQL Sorgusu
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE TblOgrenci SET Tel='"+textBoxTelefon.Text+"', ilID='"+_ilID+"', Sifre='"+textBoxSifre.Text+"' WHERE OgrNo='"+Convert.ToInt32(OgrenciGirisi._ogrencino)+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
