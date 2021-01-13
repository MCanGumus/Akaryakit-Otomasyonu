namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class AnaGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            this.isciGirisButonu = new DevExpress.XtraEditors.SimpleButton();
            this.yoneticiGirisButonu = new DevExpress.XtraEditors.SimpleButton();
            this.adminButon = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // isciGirisButonu
            // 
            this.isciGirisButonu.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isciGirisButonu.Appearance.Options.UseFont = true;
            this.isciGirisButonu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.isciGirisButonu.Location = new System.Drawing.Point(24, 27);
            this.isciGirisButonu.Name = "isciGirisButonu";
            this.isciGirisButonu.Size = new System.Drawing.Size(105, 90);
            this.isciGirisButonu.TabIndex = 0;
            this.isciGirisButonu.Text = "Personel Girişi";
            this.isciGirisButonu.Click += new System.EventHandler(this.isciGirisButonu_Click);
            // 
            // yoneticiGirisButonu
            // 
            this.yoneticiGirisButonu.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiGirisButonu.Appearance.Options.UseFont = true;
            this.yoneticiGirisButonu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.yoneticiGirisButonu.Location = new System.Drawing.Point(256, 27);
            this.yoneticiGirisButonu.Name = "yoneticiGirisButonu";
            this.yoneticiGirisButonu.Size = new System.Drawing.Size(90, 90);
            this.yoneticiGirisButonu.TabIndex = 0;
            this.yoneticiGirisButonu.Text = "Yönetici Girişi";
            this.yoneticiGirisButonu.Click += new System.EventHandler(this.yoneticiGirisButonu_Click);
            // 
            // adminButon
            // 
            this.adminButon.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminButon.Appearance.Options.UseFont = true;
            this.adminButon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.adminButon.Location = new System.Drawing.Point(149, 143);
            this.adminButon.Name = "adminButon";
            this.adminButon.Size = new System.Drawing.Size(85, 90);
            this.adminButon.TabIndex = 0;
            this.adminButon.Text = "Müdür Girişi";
            this.adminButon.Click += new System.EventHandler(this.adminButon_Click);
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 289);
            this.Controls.Add(this.adminButon);
            this.Controls.Add(this.yoneticiGirisButonu);
            this.Controls.Add(this.isciGirisButonu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaGiris";
            this.Load += new System.EventHandler(this.AnaGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton isciGirisButonu;
        private DevExpress.XtraEditors.SimpleButton yoneticiGirisButonu;
        private DevExpress.XtraEditors.SimpleButton adminButon;
    }
}