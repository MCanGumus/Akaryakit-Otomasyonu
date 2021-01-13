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
    public partial class Mudur : Form
    {
        public Mudur()
        {
            InitializeComponent();
            Listele();
        }
        Baglanti bag;
        private void Mudur_Load(object sender, EventArgs e)
        {

        }
        private void Listele()
        {
            bag = new Baglanti();
            SqlDataAdapter sda = new SqlDataAdapter(bag.yonetimListele(), bag.Connection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridYonetListele.DataSource = dt;
            bag.Disconnect();

        }
        private void Temizle()
        {

        }
        private void Kaydet()
        {
            bag = new Baglanti();
            SqlCommand cmd = new SqlCommand(bag.yonetimKayıt(),bag.Connection());
            cmd.Parameters.AddWithValue("@p3", nameTxt.Text);
            cmd.Parameters.AddWithValue("@p4", snameTxt.Text);
            cmd.Parameters.AddWithValue("@p1", userTxt.Text);
            cmd.Parameters.AddWithValue("@p2", passTxt.Text);
            cmd.ExecuteNonQuery();
            bag.Disconnect();
            Listele();
        }
        public string username;
        
        private void Guncelle()
        {
            string ad, soyad, user, pass;
            ad = gncAdTxt.Text;
            soyad = gncSoyadTxt.Text;
            string user1 = gncUserTxt.Text;
            pass = gncPassTxt.Text;
            if (username == user1)
            {
                bag = new Baglanti();
                SqlCommand cmd = new SqlCommand(bag.yonetGuncelle(ad, soyad, user1, pass), bag.Connection());
                cmd.ExecuteNonQuery();
                bag.Disconnect();
                Listele();
            }
            else { MessageBox.Show("Kullanıcı Adı DEĞİŞTİRİLEMEZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        public void bilgileriGetir(string adi,string soyadi,string user,string pass)
        {
            gncAdTxt.Text = adi;
            gncSoyadTxt.Text = soyadi;
            gncUserTxt.Text = user;
            gncPassTxt.Text = pass;

            username = gncUserTxt.Text;

        }

        private void saveButon_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                string ad, soyad, user, pass;
                ad = dr[2].ToString();
                soyad = dr[3].ToString();
                user = dr[0].ToString();
                pass = dr[1].ToString();
                bilgileriGetir(ad, soyad, user, pass);

            }

        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void yonetimGirisButon_Click(object sender, EventArgs e)
        {
            Yonetim yonet = new Yonetim();
            yonet.Show();
            this.Hide();
        }

        private void geriButon_Click(object sender, EventArgs e)
        {
            AnaGiris ana = new AnaGiris();
            ana.Show();
            this.Hide();
        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Uygulama kapatılacak.Emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            bag = new Baglanti();
            SqlCommand cmd = new SqlCommand(bag.yonetSil(), bag.Connection());
            cmd.ExecuteNonQuery();
            bag.Disconnect();
            Listele();
        }
    }
}
