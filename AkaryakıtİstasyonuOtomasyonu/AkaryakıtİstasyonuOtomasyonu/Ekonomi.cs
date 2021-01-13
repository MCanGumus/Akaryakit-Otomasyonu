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
    public partial class Ekonomi : Form
    {
        public Ekonomi()
        {
            InitializeComponent();
            Listele();
            yakitMiktari();
            kasadakiPara();
        }
        Baglanti bag;

        private void Ekonomi_Load(object sender, EventArgs e)
        {

        }
        public void Listele()
        {
            bag = new Baglanti();
            SqlDataAdapter da = new SqlDataAdapter(bag.Transfer(), bag.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            plakaDb.DataSource = dt;

        }
        public int top;
        public void Hesap(int a)
        {
           
        }
        public void kasadakiPara()
        {

            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.toplamParaHesapla(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                labelControl1.Text = sdr[0].ToString();
            }
            bag.Disconnect();
        }
        public void yeniPara(double hesap)
        {
            SqlCommand cmd = new SqlCommand(bag.paraUpdate(), bag.Connection());
            cmd.Parameters.AddWithValue("@p1", hesap.ToString());
            cmd.ExecuteNonQuery();
        }

        private void hesaplaButon_Click(object sender, EventArgs e)
        {
            double hesap;
            hesap = Convert.ToDouble(labelControl1.Text) - Convert.ToDouble(harcamalar.Text);

            if(hesap > Convert.ToDouble(labelControl1.Text) / 2)
            {
                lblHesap.Text = "Eldeki Para :"+hesap.ToString();
                lblHesap.ForeColor = Color.Green;
            }else if (hesap <= Convert.ToDouble(labelControl1.Text) / 2)
            {
                lblHesap.Text ="Eldeki Para :"+hesap.ToString();
                lblHesap.ForeColor = Color.Red;
            }
            yeniPara(hesap);
            kasadakiPara();
        }
        public void yakitMiktari()
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.tumYakitlariGetir(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                double benz = Convert.ToDouble(sdr[0]);
                double dizel = Convert.ToDouble(sdr[1]);
                double lpg = Convert.ToDouble(sdr[2]);
                double euro = Convert.ToDouble(sdr[3]);
                double kursun = Convert.ToDouble(sdr[4]);

                benzinPrg.Value = Convert.ToInt32(benz);
                dizelPrg.Value= Convert.ToInt32(dizel);
                lpgPrg.Value= Convert.ToInt32(lpg);
                euroDizelPrg.Value= Convert.ToInt32(euro);
                kursunluBenzinPrg.Value= Convert.ToInt32(kursun);
            }
            bag.Disconnect();
        }

        private void benzinDoldur_Click(object sender, EventArgs e)
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.tumYakitlariGetir(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (Convert.ToDouble(sdr[0]) < 5000)
                {
                    double miktar = Convert.ToDouble(txtBenz.Text);
                    double toplam = miktar + Convert.ToDouble(sdr[0]);
                    if (toplam > 5000)
                    {
                        toplam = 5000;
                    }
                    SqlCommand com = new SqlCommand(bag.Update(), bag.Connection());
                    com.Parameters.AddWithValue("@p1", toplam.ToString());
                    com.ExecuteNonQuery();
                }
                else if(Convert.ToDouble(sdr[0]) >= 5000)
                {
                    MessageBox.Show( "TANK SINIRI 5000 LİTREDİR.EKLEMEYE ÇALIŞTIĞINIZ DEĞERİ AZALTARAK DENEYİN...", "FAZLA DOLDURUNUZ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
            bag.Disconnect();
            yakitMiktari();
        }

        private void dizelDoldur_Click(object sender, EventArgs e)
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.tumYakitlariGetir(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (Convert.ToDouble(sdr[1]) < 5000)
                {
                    double miktar = Convert.ToDouble(txtDizel.Text);
                    double toplam = miktar + Convert.ToDouble(sdr[1]);
                    if (toplam > 5000)
                    {
                        toplam = 5000;
                    }
                    SqlCommand com = new SqlCommand(bag.DizelUpdate(), bag.Connection());
                    com.Parameters.AddWithValue("@p1", toplam.ToString());
                    com.ExecuteNonQuery();
                }
                else if (Convert.ToDouble(sdr[1]) >= 5000)
                {
                    MessageBox.Show("TANK SINIRI 5000 LİTREDİR.EKLEMEYE ÇALIŞTIĞINIZ DEĞERİ AZALTARAK DENEYİN...", "FAZLA DOLDURUNUZ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bag.Disconnect();
            yakitMiktari();
        }

        private void euroDizelDoldur_Click(object sender, EventArgs e)
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.tumYakitlariGetir(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (Convert.ToDouble(sdr[3]) < 5000)
                {
                    double miktar = Convert.ToDouble(txtEurDizel.Text);
                    double toplam = miktar + Convert.ToDouble(sdr[3]);
                    if (toplam > 5000)
                    {
                        toplam = 5000;
                    }
                    SqlCommand com = new SqlCommand(bag.euroDizelUpdate(), bag.Connection());
                    com.Parameters.AddWithValue("@p1", toplam.ToString());
                    com.ExecuteNonQuery();
                }
                else if (Convert.ToDouble(sdr[3]) >= 5000)
                {
                    MessageBox.Show("TANK SINIRI 5000 LİTREDİR.EKLEMEYE ÇALIŞTIĞINIZ DEĞERİ AZALTARAK DENEYİN...", "FAZLA DOLDURUNUZ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bag.Disconnect();
            yakitMiktari();
        }

        private void lpgDoldur_Click(object sender, EventArgs e)
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.tumYakitlariGetir(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (Convert.ToDouble(sdr[2]) < 5000)
                {
                    double miktar = Convert.ToDouble(txtLpg.Text);
                    double toplam = miktar + Convert.ToDouble(sdr[2]);
                    if (toplam > 5000)
                    {
                        toplam = 5000;
                    }
                    SqlCommand com = new SqlCommand(bag.lpgUpdate(), bag.Connection());
                    com.Parameters.AddWithValue("@p1", toplam.ToString());
                    com.ExecuteNonQuery();
                }
                else if (Convert.ToDouble(sdr[2]) >= 5000)
                {
                    MessageBox.Show("TANK SINIRI 5000 LİTREDİR.EKLEMEYE ÇALIŞTIĞINIZ DEĞERİ AZALTARAK DENEYİN...", "FAZLA DOLDURUNUZ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bag.Disconnect();
            yakitMiktari();
        }

        private void kursunluBenzinDoldur_Click(object sender, EventArgs e)
        {
            bag.Connection();
            SqlCommand cmd = new SqlCommand(bag.tumYakitlariGetir(), bag.Connection());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (Convert.ToDouble(sdr[4]) < 5000)
                {
                    double miktar = Convert.ToDouble(txtKursBenzin.Text);
                    double toplam = miktar + Convert.ToDouble(sdr[4]);
                    if (toplam > 5000)
                    {
                        toplam = 5000;
                    }
                    SqlCommand com = new SqlCommand(bag.kursunluBenzinUpdate(), bag.Connection());
                    com.Parameters.AddWithValue("@p1", toplam.ToString());
                    com.ExecuteNonQuery();
                }
                else if (Convert.ToDouble(sdr[4]) >= 5000)
                {
                    MessageBox.Show("TANK SINIRI 5000 LİTREDİR.EKLEMEYE ÇALIŞTIĞINIZ DEĞERİ AZALTARAK DENEYİN...", "FAZLA DOLDURUNUZ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bag.Disconnect();
            yakitMiktari();
        }

        private void geriButon_Click(object sender, EventArgs e)
        {
            Yonetim yonet = new Yonetim();
            yonet.Show();
            this.Hide();

        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Program Kapatılsın Mı?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void harcamalar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Ekonomi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

