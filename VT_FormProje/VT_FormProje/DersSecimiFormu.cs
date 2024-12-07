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
    public partial class DersSecimiFormu : Form
    {
        
        private void DersSecimiFormu_Load(object sender, EventArgs e)
        {
            //ALMADIĞIN DERSLERİ İÇ İÇE SORGU İLE COMBOBOXA ATMA BURADA
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT DersAd FROM TblDers LEFT JOIN (SELECT * FROM TblNot WHERE OgrNo='"+OgrenciGirisi._ogrencino+"') AS TblNotOgrNo ON TblNotOgrNo.DersID=TblDers.DersID WHERE TblNotOgrNo.DersID IS NULL";
            SqlDataReader read1 = cmd1.ExecuteReader();
            while (read1.Read())
            {
                comboBoxDersler.Items.Add(read1["DersAd"]);
            }
            con1.Close();
            Listele();
        }
        DataTable tablo = new DataTable();
        //Aldığın Derslerin bilgilerinin gözüktüğü tabloyu sql sorgusu ile çağıran method
        private void Listele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT TblNot.OgrNo, TblDers.DersAd, TblDers.DersKredi, TblOgretmen.Ad, TblOgretmen.Soyad, TblOgretmen.Tel FROM TblNot, TblDers, TblOgretmen WHERE TblNot.OgrNo ='" + OgrenciGirisi._ogrencino + "'AND TblOgretmen.OgretmenID = TblDers.OgretmenID AND TblNot.DersID = TblDers.DersID", con);
            adtr.Fill(tablo);
            dataGridViewDersler.DataSource = tablo;
            con.Close();
        }

        public DersSecimiFormu()
        {
            InitializeComponent();
        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            //comboboxtan seçilen dersin Ders ID'sini Bulma SQL Sorgusu
            string _secilenders = comboBoxDersler.Text;
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT DersID FROM TblDers WHERE DersAd='" + _secilenders+ "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            int _dersID = (int)read1["DersID"];
            con1.Close();

            //DERSİ ÖĞRENCİNİN DERSLERİNE DAHİL ETME
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO TblNot(OgrNo, DersID) values('"+int.Parse(OgrenciGirisi._ogrencino)+"','"+_dersID+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        { 
            //Tablodan seçilen dersin Ders ID'sini Bulma SQL Sorgusu
            string _secilenders = dataGridViewDersler.CurrentRow.Cells[1].Value.ToString();//GridViewdan dersin adını çekme
            SqlConnection con1 = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT DersID FROM TblDers WHERE DersAd='" + _secilenders + "'";
            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            int _dersID = (int)read1["DersID"];
            con1.Close();

            //silme işlemi
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM TblNot WHERE OgrNo='"+ dataGridViewDersler.CurrentRow.Cells[0].Value.ToString()+"' AND DersID='"+_dersID+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
            MessageBox.Show("Silme Başarılı");
        }
    }
}
