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
    public partial class OgretmenIletisimFormu : Form
    {
        DataTable tablo = new DataTable();
        private void OgretmenIletisimFormu_Load(object sender, EventArgs e)
        {
            //BURADA WİEW KULLANIMI VARDIR
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM OgretmenListesi", con);
            adtr.Fill(tablo);
            dataGridViewOgretmen.DataSource = tablo;
            con.Close();
        }
         public OgretmenIletisimFormu()
        {
            InitializeComponent();
        }
        private void textBoxOgrenciNo_TextChanged(object sender, EventArgs e)
        {
            //WİEW KULLANARAK TEXTBOXTAKİ VERİYE GÖRE TABLOYU DEĞİŞTİRME
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM OgretmenListesi WHERE Ad LIKE '" + textBoxAra.Text+"%'", con);
            adtr.Fill(tablo);
            dataGridViewOgretmen.DataSource = tablo;
            con.Close();
        }
    }
    
}
