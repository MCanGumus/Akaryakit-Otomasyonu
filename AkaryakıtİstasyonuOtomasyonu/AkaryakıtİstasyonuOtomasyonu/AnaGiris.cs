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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }
        IsciPaneli pnl;
        YonetimPaneli yonet;

        private void isciGirisButonu_Click(object sender, EventArgs e)
        {
            pnl = new IsciPaneli();
            pnl.Show();
            this.Hide();
        }

        private void yoneticiGirisButonu_Click(object sender, EventArgs e)
        {
            yonet = new YonetimPaneli();
            yonet.Show();
            this.Hide();
        }

        private void adminButon_Click(object sender, EventArgs e)
        {
            MudurGirisPaneli admin = new MudurGirisPaneli();
            admin.Show();
            this.Hide();
        }

        private void AnaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
