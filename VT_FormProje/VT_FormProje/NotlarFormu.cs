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
    public partial class NotlarFormu : Form
    {
     
        public NotlarFormu()
        {
            InitializeComponent();
        }
        
        DataTable tablo= new DataTable();
        private void NotlarFormu_Load(object sender, EventArgs e)
        {
            //BURADA SQL SORGUSU İLE LEFT JOİNLE TABLO OLUŞTUURP TABLOYA AKTARMA
            SqlConnection con = new SqlConnection(@"Data Source=Enes;Initial Catalog=UniDB;Integrated Security=True");
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT TblNot.OgrNo, TblDers.DersAd, TblDers.DersKredi, TblNot.VizeNotu, TblNot.FinalNotu FROM TblNot INNER JOIN TblDers ON TblNot.DersID = TblDers.DersID WHERE OgrNo= '" + OgrenciGirisi._ogrencino + "' ORDER BY TblDers.DersAd", con);
            adtr.Fill(tablo);
            dataGridViewNotlar.DataSource = tablo;
            con.Close();
        }

    }
}
