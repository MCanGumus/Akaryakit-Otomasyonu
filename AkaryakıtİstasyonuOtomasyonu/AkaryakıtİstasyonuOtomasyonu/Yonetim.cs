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
    public partial class Yonetim : Form
    {
        public Yonetim()
        {
            InitializeComponent();
            
            Listele();
            

            comboMesai.Items.Add("8.00-22.00");
            comboMesai.Items.Add("22.00-8.00");

            comboGncMesai.Items.Add("8.00-22.00");
            comboGncMesai.Items.Add("22.00-8.00");
            
        }
        Calısanlar calıs;
        Baglanti bag;
        SqlDataAdapter sda;
        public void Listele()
        {
            bag = new Baglanti();
            sda = new SqlDataAdapter(bag.isciListesi(), bag.Connection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            isciDb.DataSource = dt;
            bag.Disconnect();
        }
        public string tc, ad, soyad, mesai;

        private void ekleButon_Click(object sender, EventArgs e)
        {
        
            try
            {
                
                Ekle();
                Temizle();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Temizle()
        {
            textTc.Text = "";
            textAd.Text = "";
            textSoyad.Text = "";
            comboMesai.Text = "";

        }
        public void güncelleTemizle()
        {
            txtGncTc.Text = "";
            txtGncAd.Text = "";
            txtGncSoyad.Text = "";
            comboGncMesai.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                   
                    string tc, ad, soyad, mesai;
                    tc = dr[0].ToString();
                    ad = dr[1].ToString();
                    soyad = dr[2].ToString();
                    mesai = dr[3].ToString();
                    bilgileriGetir(tc, ad, soyad, mesai);
                }
        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            bag = new Baglanti();
            string tc1 = txtGncTc.Text;
            ad = txtGncAd.Text;
            soyad = txtGncSoyad.Text;
            mesai = comboGncMesai.Text;
            if (tc != tc1)
            {
                MessageBox.Show("TC DEĞİŞTİRİLEMEZ...", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmd = new SqlCommand(bag.isciGuncelle(tc,ad,soyad,mesai), bag.Connection());
            cmd.ExecuteNonQuery();
            bag.Disconnect();
            Listele();
        }

        private void deleteAllButon_Click(object sender, EventArgs e)
        {
            bag = new Baglanti();
            DialogResult res = MessageBox.Show("Tüm kayıtlar silinecek emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand(bag.tumnKayitSil(), bag.Connection());
                cmd.ExecuteNonQuery();
                bag.Disconnect();
                Listele();
            }
            
        }

        private void deleteButon_Click(object sender, EventArgs e)
        {
            bag = new Baglanti();
            tc = txtGncTc.Text;
            DialogResult res = MessageBox.Show("Seçili kayıt silinecek emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {

                SqlCommand cmd = new SqlCommand(bag.seciliKayitSil(tc), bag.Connection());
                cmd.ExecuteNonQuery();
                bag.Disconnect();
                Listele();
            }
        }

        private void temizleButon_Click(object sender, EventArgs e)
        {
            güncelleTemizle();
        }

        public void Ekle()
        {
            bag = new Baglanti();
            tc = textTc.Text;
            ad = textAd.Text;
            soyad = textSoyad.Text;
            mesai = comboMesai.Text;
            int addaSayiVarMi = adKontrol(ad);
            int soyaddaSayiVarMi = soyadKontrol(soyad);
             
            if (((tc.Length == 11) && (addaSayiVarMi==-1)) && (soyaddaSayiVarMi==-1))
            {
                SqlCommand cmd = new SqlCommand(bag.isciEkle(), bag.Connection());
                cmd.Parameters.AddWithValue("@p1", tc);
                cmd.Parameters.AddWithValue("@p2", ad);
                cmd.Parameters.AddWithValue("@p3", soyad);
                cmd.Parameters.AddWithValue("@p4", mesai);
                cmd.ExecuteNonQuery();
                bag.Disconnect();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen TC'nizin 11 haneli olmasına,isim ve soyisimde de sayısal değer olmamasına dikkat ediniz.", "HATALI GİRİŞ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void bilgileriGetir(string tc,string ad,string soyad,string mesai)
        {
            txtGncTc.Text = tc;
            txtGncAd.Text = ad;
            txtGncSoyad.Text = soyad;
            comboGncMesai.Text =mesai;
        }

        private void ekonomiButon_Click(object sender, EventArgs e)
        {
            Ekonomi eko = new Ekonomi();
            eko.Show();
            this.Hide();
        }

        private void geriButon_Click(object sender, EventArgs e)
        {
            AnaGiris ana = new AnaGiris();
            ana.Show();
            this.Hide();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Program Kapatılsın Mı?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void textTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGncTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboMesai_StyleChanged(object sender, EventArgs e)
        {
        }

        private void Yonetim_Load(object sender, EventArgs e)
        {
        }
        public int adKontrol(string ad)
        {
            int sonuc = 0;
            for (int i = 1; i < 10; i++)
            {
                string aranan = i.ToString();
                sonuc = ad.IndexOf(aranan, 0);
                if (sonuc != -1)
                {

                    return sonuc;
                }
            }

            return sonuc;
        }
        public int soyadKontrol(string soyad)
        {
            int sonuc =0; 
            for(int i = 1; i < 10; i++)
            {
                string aranan = i.ToString();
                sonuc = soyad.IndexOf(aranan, 0);
                if (sonuc != -1)
                {
                    
                    return sonuc;
                }
            }
            
            return sonuc;
        }
    }
}
