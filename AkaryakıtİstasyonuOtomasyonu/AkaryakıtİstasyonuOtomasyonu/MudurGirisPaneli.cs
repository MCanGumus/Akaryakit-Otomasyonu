using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaryakıtİstasyonuOtomasyonu
{
    public partial class MudurGirisPaneli : Form
    {
        public MudurGirisPaneli()
        {
            InitializeComponent();
        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            AnaGiris ana = new AnaGiris();
            ana.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e) //Müdürden bir tane olacağı için sadece c#üzerinden giriş yaptırıyorum...
        {
            string username = "admin";
            string password = "admin12";

            if (userText.Text == username && passText.Text == password)
            {
                Mudur admin = new Mudur();
                admin.Show();
                this.Hide();
            }
            else { MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Hatalı giriş...", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }
    }
}
