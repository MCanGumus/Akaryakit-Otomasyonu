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
    public partial class LPG : Form
    {
        public LPG()
        {
            InitializeComponent();
            miktarListele();
            Listele();
            lblLitreFiyat.Text = litre_fiyat.ToString();
        }
        Baglanti bag = new Baglanti();
        public void miktarListele()
        {
            SqlDataAdapter sda = new SqlDataAdapter(bag.lpgLitreTransfer(), bag.Connection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lpgMiktarDb.DataSource=dt;
        }
        public void Listele()
        {
            SqlDataAdapter sda = new SqlDataAdapter(bag.Transfer(), bag.Connection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gelenAracListesi.DataSource = dt;
        }
        public string plaka;
        public double verilen_para;
        public double litre_fiyat = 3.2;
        public double kalan;
        public double Doldurulacak_Miktar;
        public void Hesapla()
        {
            double litreFiyat = Convert.ToDouble(litre_fiyat);
            Doldurulacak_Miktar = verilen_para / litreFiyat;
            string doldur = Doldurulacak_Miktar.ToString();
            doldur.Substring(0, 3);
            lblDoldurMiktar.Text = doldur.Substring(0, 4);

        }
        private void ekleButonu_Click(object sender, EventArgs e)
        {
           

            bag.Connection();
            string komut = bag.Ekle();
            SqlCommand komut_gönder = new SqlCommand(komut, bag.Connection());
            komut_gönder.Parameters.AddWithValue("@p1", plaka);
            komut_gönder.Parameters.AddWithValue("@p2", verilen_para.ToString());
            komut_gönder.Parameters.AddWithValue("@p3", litre_fiyat.ToString());
            komut_gönder.Parameters.AddWithValue("@p4", lblDoldurMiktar.Text);
            komut_gönder.Parameters.AddWithValue("@p5", "LPG");
            komut_gönder.ExecuteNonQuery();
            bag.Disconnect();
            Listele();
            KalanLitre();
            paraHesapla();
        }
        public double Hesap()
        {
            return Doldurulacak_Miktar = verilen_para / litre_fiyat;
        }
        public void KalanLitre()
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.lpgLitreTransfer(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                kalan = Convert.ToDouble(sdr[0]);
                kalan -= Hesap();
                SqlCommand komut = new SqlCommand(bag.lpgUpdate(), bag.Connection());
                komut.Parameters.AddWithValue("@p1", kalan.ToString());
                komut.ExecuteNonQuery();
                miktarListele();
            }
            bag.Disconnect();

        }
        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            plaka = txtPlaka.Text;
        }

        private void txtPara_TextChanged(object sender, EventArgs e)
        {
            verilen_para = Convert.ToInt32(txtPara.Text);

        }

        private void miktariHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
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

        private void LPG_Load(object sender, EventArgs e)
        {

        }

        private void txtPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
