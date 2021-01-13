namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class Ekonomi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekonomi));
            this.plakaDb = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hesaplaButon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.benzinPrg = new System.Windows.Forms.ProgressBar();
            this.dizelPrg = new System.Windows.Forms.ProgressBar();
            this.euroDizelPrg = new System.Windows.Forms.ProgressBar();
            this.lpgPrg = new System.Windows.Forms.ProgressBar();
            this.kursunluBenzinPrg = new System.Windows.Forms.ProgressBar();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.benzinDoldur = new DevExpress.XtraEditors.SimpleButton();
            this.dizelDoldur = new DevExpress.XtraEditors.SimpleButton();
            this.euroDizelDoldur = new DevExpress.XtraEditors.SimpleButton();
            this.lpgDoldur = new DevExpress.XtraEditors.SimpleButton();
            this.kursunluBenzinDoldur = new DevExpress.XtraEditors.SimpleButton();
            this.txtBenz = new DevExpress.XtraEditors.TextEdit();
            this.txtDizel = new DevExpress.XtraEditors.TextEdit();
            this.txtEurDizel = new DevExpress.XtraEditors.TextEdit();
            this.txtLpg = new DevExpress.XtraEditors.TextEdit();
            this.txtKursBenzin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.harcamalar = new DevExpress.XtraEditors.TextEdit();
            this.lblHesap = new DevExpress.XtraEditors.LabelControl();
            this.cikisButon = new DevExpress.XtraEditors.SimpleButton();
            this.geriButon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.plakaDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBenz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDizel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEurDizel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLpg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKursBenzin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // plakaDb
            // 
            this.plakaDb.Location = new System.Drawing.Point(13, 13);
            this.plakaDb.MainView = this.gridView1;
            this.plakaDb.Name = "plakaDb";
            this.plakaDb.Size = new System.Drawing.Size(443, 265);
            this.plakaDb.TabIndex = 0;
            this.plakaDb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.plakaDb;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // hesaplaButon
            // 
            this.hesaplaButon.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesaplaButon.Appearance.Options.UseFont = true;
            this.hesaplaButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hesaplaButon.ImageOptions.Image")));
            this.hesaplaButon.Location = new System.Drawing.Point(518, 124);
            this.hesaplaButon.Name = "hesaplaButon";
            this.hesaplaButon.Size = new System.Drawing.Size(204, 37);
            this.hesaplaButon.TabIndex = 1;
            this.hesaplaButon.Text = "Kar Miktarı";
            this.hesaplaButon.Click += new System.EventHandler(this.hesaplaButon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(650, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "111111111";
            // 
            // benzinPrg
            // 
            this.benzinPrg.Location = new System.Drawing.Point(168, 327);
            this.benzinPrg.Maximum = 5000;
            this.benzinPrg.Name = "benzinPrg";
            this.benzinPrg.Size = new System.Drawing.Size(265, 23);
            this.benzinPrg.TabIndex = 3;
            // 
            // dizelPrg
            // 
            this.dizelPrg.Location = new System.Drawing.Point(168, 356);
            this.dizelPrg.Maximum = 5000;
            this.dizelPrg.Name = "dizelPrg";
            this.dizelPrg.Size = new System.Drawing.Size(265, 23);
            this.dizelPrg.TabIndex = 3;
            // 
            // euroDizelPrg
            // 
            this.euroDizelPrg.Location = new System.Drawing.Point(168, 385);
            this.euroDizelPrg.Maximum = 5000;
            this.euroDizelPrg.Name = "euroDizelPrg";
            this.euroDizelPrg.Size = new System.Drawing.Size(265, 23);
            this.euroDizelPrg.TabIndex = 3;
            // 
            // lpgPrg
            // 
            this.lpgPrg.Location = new System.Drawing.Point(168, 414);
            this.lpgPrg.Maximum = 5000;
            this.lpgPrg.Name = "lpgPrg";
            this.lpgPrg.Size = new System.Drawing.Size(265, 23);
            this.lpgPrg.TabIndex = 3;
            // 
            // kursunluBenzinPrg
            // 
            this.kursunluBenzinPrg.Location = new System.Drawing.Point(168, 443);
            this.kursunluBenzinPrg.Maximum = 5000;
            this.kursunluBenzinPrg.Name = "kursunluBenzinPrg";
            this.kursunluBenzinPrg.Size = new System.Drawing.Size(265, 23);
            this.kursunluBenzinPrg.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(92, 327);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "BENZIN :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(104, 356);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "DIZEL :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(60, 385);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 17);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "EURO DIZEL :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(120, 414);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 17);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "LPG :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 443);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(156, 17);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "KURSUNLU BENZIN :";
            // 
            // benzinDoldur
            // 
            this.benzinDoldur.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benzinDoldur.Appearance.Options.UseFont = true;
            this.benzinDoldur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("benzinDoldur.ImageOptions.Image")));
            this.benzinDoldur.Location = new System.Drawing.Point(601, 327);
            this.benzinDoldur.Name = "benzinDoldur";
            this.benzinDoldur.Size = new System.Drawing.Size(118, 23);
            this.benzinDoldur.TabIndex = 5;
            this.benzinDoldur.Text = "Doldur";
            this.benzinDoldur.Click += new System.EventHandler(this.benzinDoldur_Click);
            // 
            // dizelDoldur
            // 
            this.dizelDoldur.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dizelDoldur.Appearance.Options.UseFont = true;
            this.dizelDoldur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dizelDoldur.ImageOptions.Image")));
            this.dizelDoldur.Location = new System.Drawing.Point(601, 356);
            this.dizelDoldur.Name = "dizelDoldur";
            this.dizelDoldur.Size = new System.Drawing.Size(118, 23);
            this.dizelDoldur.TabIndex = 5;
            this.dizelDoldur.Text = "Doldur";
            this.dizelDoldur.Click += new System.EventHandler(this.dizelDoldur_Click);
            // 
            // euroDizelDoldur
            // 
            this.euroDizelDoldur.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euroDizelDoldur.Appearance.Options.UseFont = true;
            this.euroDizelDoldur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("euroDizelDoldur.ImageOptions.Image")));
            this.euroDizelDoldur.Location = new System.Drawing.Point(601, 385);
            this.euroDizelDoldur.Name = "euroDizelDoldur";
            this.euroDizelDoldur.Size = new System.Drawing.Size(118, 23);
            this.euroDizelDoldur.TabIndex = 5;
            this.euroDizelDoldur.Text = "Doldur";
            this.euroDizelDoldur.Click += new System.EventHandler(this.euroDizelDoldur_Click);
            // 
            // lpgDoldur
            // 
            this.lpgDoldur.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpgDoldur.Appearance.Options.UseFont = true;
            this.lpgDoldur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lpgDoldur.ImageOptions.Image")));
            this.lpgDoldur.Location = new System.Drawing.Point(601, 414);
            this.lpgDoldur.Name = "lpgDoldur";
            this.lpgDoldur.Size = new System.Drawing.Size(118, 23);
            this.lpgDoldur.TabIndex = 5;
            this.lpgDoldur.Text = "Doldur";
            this.lpgDoldur.Click += new System.EventHandler(this.lpgDoldur_Click);
            // 
            // kursunluBenzinDoldur
            // 
            this.kursunluBenzinDoldur.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kursunluBenzinDoldur.Appearance.Options.UseFont = true;
            this.kursunluBenzinDoldur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kursunluBenzinDoldur.ImageOptions.Image")));
            this.kursunluBenzinDoldur.Location = new System.Drawing.Point(601, 443);
            this.kursunluBenzinDoldur.Name = "kursunluBenzinDoldur";
            this.kursunluBenzinDoldur.Size = new System.Drawing.Size(118, 23);
            this.kursunluBenzinDoldur.TabIndex = 5;
            this.kursunluBenzinDoldur.Text = "Doldur";
            this.kursunluBenzinDoldur.Click += new System.EventHandler(this.kursunluBenzinDoldur_Click);
            // 
            // txtBenz
            // 
            this.txtBenz.Location = new System.Drawing.Point(463, 324);
            this.txtBenz.Name = "txtBenz";
            this.txtBenz.Size = new System.Drawing.Size(132, 20);
            this.txtBenz.TabIndex = 6;
            this.txtBenz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekonomi_KeyPress);
            // 
            // txtDizel
            // 
            this.txtDizel.Location = new System.Drawing.Point(463, 356);
            this.txtDizel.Name = "txtDizel";
            this.txtDizel.Size = new System.Drawing.Size(132, 20);
            this.txtDizel.TabIndex = 6;
            this.txtDizel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekonomi_KeyPress);
            // 
            // txtEurDizel
            // 
            this.txtEurDizel.Location = new System.Drawing.Point(463, 385);
            this.txtEurDizel.Name = "txtEurDizel";
            this.txtEurDizel.Size = new System.Drawing.Size(132, 20);
            this.txtEurDizel.TabIndex = 6;
            this.txtEurDizel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekonomi_KeyPress);
            // 
            // txtLpg
            // 
            this.txtLpg.Location = new System.Drawing.Point(463, 414);
            this.txtLpg.Name = "txtLpg";
            this.txtLpg.Size = new System.Drawing.Size(132, 20);
            this.txtLpg.TabIndex = 6;
            this.txtLpg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekonomi_KeyPress);
            // 
            // txtKursBenzin
            // 
            this.txtKursBenzin.Location = new System.Drawing.Point(463, 443);
            this.txtKursBenzin.Name = "txtKursBenzin";
            this.txtKursBenzin.Size = new System.Drawing.Size(132, 20);
            this.txtKursBenzin.TabIndex = 6;
            this.txtKursBenzin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekonomi_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(472, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(172, 21);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Kasaya Giren Para :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(516, 84);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(109, 21);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Harcamalar :";
            // 
            // harcamalar
            // 
            this.harcamalar.Location = new System.Drawing.Point(642, 87);
            this.harcamalar.Name = "harcamalar";
            this.harcamalar.Size = new System.Drawing.Size(72, 20);
            this.harcamalar.TabIndex = 7;
            this.harcamalar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harcamalar_KeyPress);
            // 
            // lblHesap
            // 
            this.lblHesap.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHesap.Appearance.Options.UseFont = true;
            this.lblHesap.LineVisible = true;
            this.lblHesap.Location = new System.Drawing.Point(527, 188);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(172, 21);
            this.lblHesap.TabIndex = 2;
            this.lblHesap.Text = "Kasaya Giren Para :";
            // 
            // cikisButon
            // 
            this.cikisButon.Appearance.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold);
            this.cikisButon.Appearance.Options.UseFont = true;
            this.cikisButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cikisButon.ImageOptions.Image")));
            this.cikisButon.Location = new System.Drawing.Point(703, 515);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(39, 34);
            this.cikisButon.TabIndex = 8;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // geriButon
            // 
            this.geriButon.Appearance.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold);
            this.geriButon.Appearance.Options.UseFont = true;
            this.geriButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("geriButon.ImageOptions.Image")));
            this.geriButon.Location = new System.Drawing.Point(16, 515);
            this.geriButon.Name = "geriButon";
            this.geriButon.Size = new System.Drawing.Size(38, 34);
            this.geriButon.TabIndex = 9;
            this.geriButon.Click += new System.EventHandler(this.geriButon_Click);
            // 
            // Ekonomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 561);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.geriButon);
            this.Controls.Add(this.harcamalar);
            this.Controls.Add(this.txtKursBenzin);
            this.Controls.Add(this.txtLpg);
            this.Controls.Add(this.txtEurDizel);
            this.Controls.Add(this.txtDizel);
            this.Controls.Add(this.txtBenz);
            this.Controls.Add(this.kursunluBenzinDoldur);
            this.Controls.Add(this.lpgDoldur);
            this.Controls.Add(this.euroDizelDoldur);
            this.Controls.Add(this.dizelDoldur);
            this.Controls.Add(this.benzinDoldur);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.kursunluBenzinPrg);
            this.Controls.Add(this.lpgPrg);
            this.Controls.Add(this.euroDizelPrg);
            this.Controls.Add(this.dizelPrg);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.benzinPrg);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.hesaplaButon);
            this.Controls.Add(this.plakaDb);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ekonomi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekonomi";
            this.Load += new System.EventHandler(this.Ekonomi_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekonomi_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.plakaDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBenz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDizel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEurDizel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLpg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKursBenzin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcamalar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl plakaDb;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton hesaplaButon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ProgressBar benzinPrg;
        private System.Windows.Forms.ProgressBar dizelPrg;
        private System.Windows.Forms.ProgressBar euroDizelPrg;
        private System.Windows.Forms.ProgressBar lpgPrg;
        private System.Windows.Forms.ProgressBar kursunluBenzinPrg;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton benzinDoldur;
        private DevExpress.XtraEditors.SimpleButton dizelDoldur;
        private DevExpress.XtraEditors.SimpleButton euroDizelDoldur;
        private DevExpress.XtraEditors.SimpleButton lpgDoldur;
        private DevExpress.XtraEditors.SimpleButton kursunluBenzinDoldur;
        private DevExpress.XtraEditors.TextEdit txtBenz;
        private DevExpress.XtraEditors.TextEdit txtDizel;
        private DevExpress.XtraEditors.TextEdit txtEurDizel;
        private DevExpress.XtraEditors.TextEdit txtLpg;
        private DevExpress.XtraEditors.TextEdit txtKursBenzin;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit harcamalar;
        private DevExpress.XtraEditors.LabelControl lblHesap;
        private DevExpress.XtraEditors.SimpleButton cikisButon;
        private DevExpress.XtraEditors.SimpleButton geriButon;
    }
}