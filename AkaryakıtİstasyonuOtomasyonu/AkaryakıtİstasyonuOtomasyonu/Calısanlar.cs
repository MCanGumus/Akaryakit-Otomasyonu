using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AkaryakıtİstasyonuOtomasyonu
{
    public partial class Calısanlar : Form
    {
        public Calısanlar()
        {
            InitializeComponent();
            isciListe();
        }
        Baglanti bag = new Baglanti();
        private void Calısanlar_Load(object sender, EventArgs e)
        {

        }
        public void isciListe()
        {
            SqlDataAdapter sda = new SqlDataAdapter(bag.isciListesi(), bag.Connection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            isciDb.DataSource = dt;
            bag.Disconnect();
        }
        Yonetim yonet;
        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                yonet = new Yonetim();
                string tc, ad, soyad, mesai;
                tc = dr[0].ToString();
                ad = dr[1].ToString();
                soyad = dr[2].ToString();
                mesai = dr[3].ToString();
                yonet.bilgileriGetir(tc, ad, soyad, mesai);
            }
        }
    }
}
