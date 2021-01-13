namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class IsciPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsciPaneli));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.cksButonu = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.benzinButonu = new DevExpress.XtraBars.BarButtonItem();
            this.dizelButonu = new DevExpress.XtraBars.BarButtonItem();
            this.euroDizelButon = new DevExpress.XtraBars.BarButtonItem();
            this.lpgButonu = new DevExpress.XtraBars.BarButtonItem();
            this.kursunluBenzinButon = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.geriButon = new DevExpress.XtraEditors.SimpleButton();
            this.cikisButon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cksButonu
            // 
            this.cksButonu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cksButonu.ImageOptions.Image")));
            this.cksButonu.Location = new System.Drawing.Point(679, 0);
            this.cksButonu.Name = "cksButonu";
            this.cksButonu.Size = new System.Drawing.Size(75, 23);
            this.cksButonu.TabIndex = 0;
            this.cksButonu.Text = "Çıkış";
            this.cksButonu.Click += new System.EventHandler(this.cksButonu_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.benzinButonu,
            this.dizelButonu,
            this.euroDizelButon,
            this.lpgButonu,
            this.kursunluBenzinButon});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(684, 141);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // benzinButonu
            // 
            this.benzinButonu.Caption = "Benzin";
            this.benzinButonu.Id = 1;
            this.benzinButonu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("benzinButonu.ImageOptions.Image")));
            this.benzinButonu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("benzinButonu.ImageOptions.LargeImage")));
            this.benzinButonu.Name = "benzinButonu";
            toolTipTitleItem1.Text = "BENZIN";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.benzinButonu.SuperTip = superToolTip1;
            this.benzinButonu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.benzinButonu_ItemClick);
            // 
            // dizelButonu
            // 
            this.dizelButonu.Caption = "Dizel";
            this.dizelButonu.Id = 2;
            this.dizelButonu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dizelButonu.ImageOptions.LargeImage")));
            this.dizelButonu.Name = "dizelButonu";
            this.dizelButonu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dizelButonu_ItemClick);
            // 
            // euroDizelButon
            // 
            this.euroDizelButon.Caption = "Euro Dizel";
            this.euroDizelButon.Id = 3;
            this.euroDizelButon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("euroDizelButon.ImageOptions.LargeImage")));
            this.euroDizelButon.Name = "euroDizelButon";
            this.euroDizelButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.euroDizelButon_ItemClick);
            // 
            // lpgButonu
            // 
            this.lpgButonu.Caption = "LPG";
            this.lpgButonu.Id = 4;
            this.lpgButonu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("lpgButonu.ImageOptions.LargeImage")));
            this.lpgButonu.Name = "lpgButonu";
            this.lpgButonu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lpgButonu_ItemClick);
            // 
            // kursunluBenzinButon
            // 
            this.kursunluBenzinButon.Caption = "Kurşunlu Benzin";
            this.kursunluBenzinButon.Id = 5;
            this.kursunluBenzinButon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("kursunluBenzinButon.ImageOptions.LargeImage")));
            this.kursunluBenzinButon.Name = "kursunluBenzinButon";
            this.kursunluBenzinButon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.kursunluBenzinButon_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Yakıt Sekmesi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ImageOptions.ImageUri.Uri = "Add";
            this.ribbonPageGroup1.ItemLinks.Add(this.benzinButonu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "    Benzin Paneli                                      ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.dizelButonu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "DİZEL Paneli                        ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.euroDizelButon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "        EURO DİZEL Paneli                                   ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.lpgButonu);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "          LPG Paneli                                  ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.kursunluBenzinButon, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "   Kurşunlu Benzin Paneli                           ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // geriButon
            // 
            this.geriButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("geriButon.ImageOptions.Image")));
            this.geriButon.Location = new System.Drawing.Point(499, 619);
            this.geriButon.Name = "geriButon";
            this.geriButon.Size = new System.Drawing.Size(75, 30);
            this.geriButon.TabIndex = 3;
            this.geriButon.Text = "Geri";
            this.geriButon.Click += new System.EventHandler(this.geriButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cikisButon.ImageOptions.Image")));
            this.cikisButon.Location = new System.Drawing.Point(597, 619);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(75, 30);
            this.cikisButon.TabIndex = 4;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // IsciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.geriButon);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.cksButonu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "IsciPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IsciPaneli";
            this.Load += new System.EventHandler(this.IsciPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cksButonu;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem benzinButonu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem dizelButonu;
        private DevExpress.XtraBars.BarButtonItem euroDizelButon;
        private DevExpress.XtraBars.BarButtonItem lpgButonu;
        private DevExpress.XtraBars.BarButtonItem kursunluBenzinButon;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.SimpleButton cikisButon;
        private DevExpress.XtraEditors.SimpleButton geriButon;
    }
}