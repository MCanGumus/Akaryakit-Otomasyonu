﻿namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class LPG
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.miktariHesapla = new DevExpress.XtraEditors.SimpleButton();
            this.lblLitreFiyat = new DevExpress.XtraEditors.LabelControl();
            this.lblDoldurMiktar = new DevExpress.XtraEditors.LabelControl();
            this.ekleButonu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPara = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.lpgMiktarDb = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gelenAracListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpgMiktarDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelenAracListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.miktariHesapla);
            this.groupControl1.Controls.Add(this.lblLitreFiyat);
            this.groupControl1.Controls.Add(this.lblDoldurMiktar);
            this.groupControl1.Controls.Add(this.ekleButonu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtPara);
            this.groupControl1.Controls.Add(this.txtPlaka);
            this.groupControl1.Location = new System.Drawing.Point(350, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(335, 232);
            this.groupControl1.TabIndex = 2;
            // 
            // miktariHesapla
            // 
            this.miktariHesapla.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miktariHesapla.Appearance.Options.UseFont = true;
            this.miktariHesapla.Location = new System.Drawing.Point(128, 167);
            this.miktariHesapla.Name = "miktariHesapla";
            this.miktariHesapla.Size = new System.Drawing.Size(75, 23);
            this.miktariHesapla.TabIndex = 17;
            this.miktariHesapla.Text = "Hesapla";
            this.miktariHesapla.Click += new System.EventHandler(this.miktariHesapla_Click);
            // 
            // lblLitreFiyat
            // 
            this.lblLitreFiyat.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitreFiyat.Appearance.Options.UseFont = true;
            this.lblLitreFiyat.Location = new System.Drawing.Point(211, 91);
            this.lblLitreFiyat.Name = "lblLitreFiyat";
            this.lblLitreFiyat.Size = new System.Drawing.Size(86, 17);
            this.lblLitreFiyat.TabIndex = 24;
            this.lblLitreFiyat.Text = "lblLitreFiyat";
            // 
            // lblDoldurMiktar
            // 
            this.lblDoldurMiktar.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoldurMiktar.Appearance.Options.UseFont = true;
            this.lblDoldurMiktar.Location = new System.Drawing.Point(251, 117);
            this.lblDoldurMiktar.Name = "lblDoldurMiktar";
            this.lblDoldurMiktar.Size = new System.Drawing.Size(0, 17);
            this.lblDoldurMiktar.TabIndex = 23;
            // 
            // ekleButonu
            // 
            this.ekleButonu.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButonu.Appearance.Options.UseFont = true;
            this.ekleButonu.Location = new System.Drawing.Point(222, 167);
            this.ekleButonu.Name = "ekleButonu";
            this.ekleButonu.Size = new System.Drawing.Size(75, 23);
            this.ekleButonu.TabIndex = 18;
            this.ekleButonu.Text = "Ekle";
            this.ekleButonu.Click += new System.EventHandler(this.ekleButonu_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(78, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 17);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Verilen Para";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(139, 17);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Doldurulacak Miktar";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(81, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 17);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Litre Fiyatı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Araç Plakası";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(168, 58);
            this.txtPara.Name = "txtPara";
            this.txtPara.Properties.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Properties.Appearance.Options.UseFont = true;
            this.txtPara.Size = new System.Drawing.Size(129, 24);
            this.txtPara.TabIndex = 16;
            this.txtPara.TextChanged += new System.EventHandler(this.txtPara_TextChanged);
            this.txtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPara_KeyPress);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(168, 28);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Properties.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaka.Properties.Appearance.Options.UseFont = true;
            this.txtPlaka.Size = new System.Drawing.Size(129, 24);
            this.txtPlaka.TabIndex = 15;
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            this.txtPlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaka_KeyPress);
            // 
            // lpgMiktarDb
            // 
            this.lpgMiktarDb.Location = new System.Drawing.Point(1, 0);
            this.lpgMiktarDb.MainView = this.gridView1;
            this.lpgMiktarDb.Name = "lpgMiktarDb";
            this.lpgMiktarDb.Size = new System.Drawing.Size(351, 232);
            this.lpgMiktarDb.TabIndex = 3;
            this.lpgMiktarDb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Olive;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.lpgMiktarDb;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gelenAracListesi
            // 
            this.gelenAracListesi.Location = new System.Drawing.Point(1, 229);
            this.gelenAracListesi.MainView = this.gridView2;
            this.gelenAracListesi.Name = "gelenAracListesi";
            this.gelenAracListesi.Size = new System.Drawing.Size(684, 200);
            this.gelenAracListesi.TabIndex = 4;
            this.gelenAracListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.Red;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gelenAracListesi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // LPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.gelenAracListesi);
            this.Controls.Add(this.lpgMiktarDb);
            this.Controls.Add(this.groupControl1);
            this.Name = "LPG";
            this.Text = "LPG";
            this.Load += new System.EventHandler(this.LPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpgMiktarDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelenAracListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton miktariHesapla;
        private DevExpress.XtraEditors.LabelControl lblLitreFiyat;
        private DevExpress.XtraEditors.LabelControl lblDoldurMiktar;
        private DevExpress.XtraEditors.SimpleButton ekleButonu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPara;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraGrid.GridControl lpgMiktarDb;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gelenAracListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}