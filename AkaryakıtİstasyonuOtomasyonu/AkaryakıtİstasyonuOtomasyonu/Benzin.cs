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
    public partial class Benzin : Form
    {
        public Benzin()
        {
            InitializeComponent();
            Listele();
            miktarListele();
            lblLitreFiyat.Text = litre_Fiyat.ToString();
            
           
        }
        public string plaka;
        public double verilen_para;
        Baglanti bag = new Baglanti();

        public void miktarListele()
        {
            SqlDataAdapter sda = new SqlDataAdapter(bag.litreMiktarTransfer(), bag.Connection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            benzinMiktarDb.DataSource = dt;
        }
        public void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter(bag.Transfer(), bag.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTablosu.DataSource = dt;

        }

        public double litre_Fiyat =7.3;
       
        public void Hesapla()
        {
            double litreFiyat = Convert.ToDouble(litre_Fiyat);
            Doldurulacak_Miktar = verilen_para / litreFiyat;
            string doldur= Doldurulacak_Miktar.ToString();
            doldur.Substring(0, 3);
            lblDoldurMiktar.Text = doldur.Substring(0,4); 

        }
        public double Hesap()
        {
            return Doldurulacak_Miktar = verilen_para / litre_Fiyat;
        }
        public double kalan;
        public double Doldurulacak_Miktar;
        public void KalanLitre()
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.litreMiktarTransfer(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                kalan = Convert.ToDouble(sdr[0]);
                kalan -= Hesap();
                SqlCommand komut = new SqlCommand(bag.Update(), bag.Connection());
                komut.Parameters.AddWithValue("@p1", kalan.ToString());
                komut.ExecuteNonQuery();
                miktarListele();
            }
            bag.Disconnect();
            
        }


        private void Benzin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLoginDataSet1.Yakıt' table. You can move, or remove it, as needed.
            this.yakıtTableAdapter1.Fill(this.dbLoginDataSet1.Yakıt);
            // TODO: This line of code loads data into the 'dbLoginDataSet.Yakıt' table. You can move, or remove it, as needed.
            this.yakıtTableAdapter.Fill(this.dbLoginDataSet.Yakıt);

        }

        

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            plaka = txtPlaka.Text;
        }

        private void txtPara_TextChanged(object sender, EventArgs e)
        {
            verilen_para =Convert.ToInt32(txtPara.Text);
           
        }

        private void miktariHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void DataTable_Click(object sender, EventArgs e)
        {

        }

        private void ekleButonu_Click_1(object sender, EventArgs e)
        {
            

            bag.Connection();
            string komut = bag.Ekle();
            SqlCommand komut_gönder = new SqlCommand(komut, bag.Connection());
            komut_gönder.Parameters.AddWithValue("@p1", plaka);
            komut_gönder.Parameters.AddWithValue("@p2", verilen_para.ToString());
            komut_gönder.Parameters.AddWithValue("@p3", litre_Fiyat.ToString());
            komut_gönder.Parameters.AddWithValue("@p4",lblDoldurMiktar.Text);
            komut_gönder.Parameters.AddWithValue("@p5","Benzin");
            komut_gönder.ExecuteNonQuery();
            bag.Disconnect();
            Listele();
            KalanLitre();
            paraHesapla();

        }
        double toplam;


        public void paraHesapla()
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.toplamParaHesapla(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                toplam = Convert.ToDouble(sdr[0]);
                toplam += verilen_para;
                SqlCommand com = new SqlCommand(bag.paraUpdate(), bag.Connection());
                com.Parameters.AddWithValue("@p1", toplam.ToString());
                com.ExecuteNonQuery();

            }
            bag.Disconnect();
        }

        private void txtPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
