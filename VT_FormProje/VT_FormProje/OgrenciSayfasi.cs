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
    public partial class OgrenciSayfasi : Form
    {
        public OgrenciSayfasi()
        {
            InitializeComponent();
        }

        private void buttonNotlar_Click(object sender, EventArgs e)
        {
            NotlarFormu notlarFormu = new NotlarFormu();
            notlarFormu.Show();
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarFormu ayarlarFormu = new AyarlarFormu();
            ayarlarFormu.Show();
        }

        private void OgrenciSayfasi_Load(object sender, EventArgs e)
        {
            labelHosgeldinOgrenci.Text = "Hoşgeldin "+OgrenciGirisi._ogrenciad+" "+ OgrenciGirisi._ogrsoyad;
            labelSınıf.Text = "Sınıfın: "+OgrenciGirisi._sinif;

            //SQL Sorgu ile Bölümünü bulma
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT BolumAd FROM TblBolum WHERE BolumID='" + OgrenciGirisi._bolumID + "'";
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            labelBolum.Text = "Bölümünüz: " +Convert.ToString(read["BolumAd"]);
            con.Close();

        }

        private void buttonDersSecimi_Click(object sender, EventArgs e)
        {
            DersSecimiFormu dersSecimiFormu = new DersSecimiFormu();
            dersSecimiFormu.Show();
        }

        private void buttonOgretmenIletisim_Click(object sender, EventArgs e)
        {
            OgretmenIletisimFormu ogretmenIletisimFormu = new OgretmenIletisimFormu();
            ogretmenIletisimFormu.Show();
        }
    }
}
