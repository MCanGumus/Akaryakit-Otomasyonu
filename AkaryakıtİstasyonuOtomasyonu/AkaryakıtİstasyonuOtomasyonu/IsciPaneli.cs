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
    public partial class IsciPaneli : Form
    {
        public IsciPaneli()
        {
            InitializeComponent();
        }

        private void cksButonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IsciPaneli_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        Benzin benz;
        Dizel dizel;
        LPG lpg;
        EuroDizel euro;
        KursunluBenzin kursun;
        private void benzinButonu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (benz == null)
            {
                benz = new Benzin();
                benz.MdiParent = this;
                benz.Show();
            }
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

        private void dizelButonu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dizel == null)
            {
                dizel = new Dizel();
                dizel.MdiParent = this;
                dizel.Show();
            }
        }

        private void lpgButonu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lpg == null)
            {
                lpg = new LPG();
                lpg.MdiParent = this;
                lpg.Show();
            }
        }

        private void euroDizelButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (euro == null)
            {
                euro = new EuroDizel();
                euro.MdiParent = this;
                euro.Show();
            }
        }

        private void kursunluBenzinButon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kursun == null)
            {
                kursun = new KursunluBenzin();
                kursun.MdiParent = this;
                kursun.Show();
            }  
        }
    }
}
