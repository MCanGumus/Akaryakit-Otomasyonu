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
    public partial class iscigiris : Form
    {
        public iscigiris()
        {
            InitializeComponent();
            timer1.Interval=1000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string user = txtKullanıcı.Text;
            string pass = txtSifre.Text;

            Baglanti bagla = new Baglanti();
            if (user == "işçi" && pass == "1245")
            {
                    timer1.Enabled = true;
               
                    bagla.Connection();
                if (timer1.Interval != 3000)
                {
                    lblBaglanti.Text = "Bağlandı.Giriş Yapılıyor...";
                    lblBaglanti.ForeColor = Color.LightGreen;
                    
                
                }
                
                    IsciPaneli isci = new IsciPaneli();
                    isci.Show();
                    this.Hide();

       
            }
            else
            {
                lblBaglanti.Text = "Bağlanmadı.Kullanıcı Adı Şifrenizi Kontrol Edin";
                lblBaglanti.ForeColor = Color.Red;
            }




        }

        private void iscigiris_Load(object sender, EventArgs e)
        {

        }
    }
}
