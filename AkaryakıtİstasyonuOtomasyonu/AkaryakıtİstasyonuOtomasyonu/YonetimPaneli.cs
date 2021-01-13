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
    public partial class YonetimPaneli : Form
    {
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void YonetimPaneli_Load(object sender, EventArgs e)
        {

        }
        Baglanti bag = new Baglanti();
        SqlDataReader sdr;
        SqlCommand cmd;

        private void loginButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string username = userText.Text;
            string password = passText.Text;
            bag.Connection();
            cmd.Connection = bag.Connection();
            cmd.CommandText = (bag.userGiris(username, password));
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
               
                Yonetim yonet = new Yonetim();
                yonet.Show();
                this.Hide();
                

            }
            else { MessageBox.Show("Kullanıcı adı ve Şifrenizi kontrol edin...", "Başarısız..."); }


            bag.Disconnect();
            

        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            AnaGiris ana = new AnaGiris();
            ana.Show();
            this.Hide();
        }
    }
}
