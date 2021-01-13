namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class Benzin
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
            this.yakıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLoginDataSet = new AkaryakıtİstasyonuOtomasyonu.dbLoginDataSet();
            this.yakıtTableAdapter = new AkaryakıtİstasyonuOtomasyonu.dbLoginDataSetTableAdapters.YakıtTableAdapter();
            this.yakıtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbLoginDataSet1 = new AkaryakıtİstasyonuOtomasyonu.dbLoginDataSet1();
            this.yakıtTableAdapter1 = new AkaryakıtİstasyonuOtomasyonu.dbLoginDataSet1TableAdapters.YakıtTableAdapter();
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
            this.DataTablosu = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.benzinMiktarDb = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.yakıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakıtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benzinMiktarDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yakıtBindingSource
            // 
            this.yakıtBindingSource.DataMember = "Yakıt";
            this.yakıtBindingSource.DataSource = this.dbLoginDataSet;
            // 
            // dbLoginDataSet
            // 
            this.dbLoginDataSet.DataSetName = "dbLoginDataSet";
            this.dbLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakıtTableAdapter
            // 
            this.yakıtTableAdapter.ClearBeforeFill = true;
            // 
            // yakıtBindingSource1
            // 
            this.yakıtBindingSource1.DataMember = "Yakıt";
            this.yakıtBindingSource1.DataSource = this.dbLoginDataSet1;
            // 
            // dbLoginDataSet1
            // 
            this.dbLoginDataSet1.DataSetName = "dbLoginDataSet1";
            this.dbLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakıtTableAdapter1
            // 
            this.yakıtTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
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
            this.groupControl1.Location = new System.Drawing.Point(344, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(409, 232);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // miktariHesapla
            // 
            this.miktariHesapla.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miktariHesapla.Appearance.Options.UseFont = true;
            this.miktariHesapla.Location = new System.Drawing.Point(106, 162);
            this.miktariHesapla.Name = "miktariHesapla";
            this.miktariHesapla.Size = new System.Drawing.Size(75, 23);
            this.miktariHesapla.TabIndex = 2;
            this.miktariHesapla.Text = "Hesapla";
            this.miktariHesapla.Click += new System.EventHandler(this.miktariHesapla_Click);
            // 
            // lblLitreFiyat
            // 
            this.lblLitreFiyat.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitreFiyat.Appearance.Options.UseFont = true;
            this.lblLitreFiyat.Location = new System.Drawing.Point(217, 99);
            this.lblLitreFiyat.Name = "lblLitreFiyat";
            this.lblLitreFiyat.Size = new System.Drawing.Size(86, 17);
            this.lblLitreFiyat.TabIndex = 14;
            this.lblLitreFiyat.Text = "lblLitreFiyat";
            // 
            // lblDoldurMiktar
            // 
            this.lblDoldurMiktar.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoldurMiktar.Appearance.Options.UseFont = true;
            this.lblDoldurMiktar.Location = new System.Drawing.Point(247, 130);
            this.lblDoldurMiktar.Name = "lblDoldurMiktar";
            this.lblDoldurMiktar.Size = new System.Drawing.Size(0, 17);
            this.lblDoldurMiktar.TabIndex = 13;
            // 
            // ekleButonu
            // 
            this.ekleButonu.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleButonu.Appearance.Options.UseFont = true;
            this.ekleButonu.Location = new System.Drawing.Point(187, 162);
            this.ekleButonu.Name = "ekleButonu";
            this.ekleButonu.Size = new System.Drawing.Size(75, 23);
            this.ekleButonu.TabIndex = 3;
            this.ekleButonu.Text = "Ekle";
            this.ekleButonu.Click += new System.EventHandler(this.ekleButonu_Click_1);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(63, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Verilen Para";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(139, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Doldurulacak Miktar";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(66, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Litre Fiyatı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(64, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Araç Plakası";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(154, 69);
            this.txtPara.Name = "txtPara";
            this.txtPara.Properties.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Properties.Appearance.Options.UseFont = true;
            this.txtPara.Size = new System.Drawing.Size(129, 24);
            this.txtPara.TabIndex = 1;
            this.txtPara.TextChanged += new System.EventHandler(this.txtPara_TextChanged);
            this.txtPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPara_KeyPress);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(154, 39);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Properties.Appearance.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaka.Properties.Appearance.Options.UseFont = true;
            this.txtPlaka.Size = new System.Drawing.Size(129, 24);
            this.txtPlaka.TabIndex = 0;
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // DataTablosu
            // 
            this.DataTablosu.Location = new System.Drawing.Point(-4, 231);
            this.DataTablosu.MainView = this.gridView2;
            this.DataTablosu.Name = "DataTablosu";
            this.DataTablosu.Size = new System.Drawing.Size(696, 198);
            this.DataTablosu.TabIndex = 2;
            this.DataTablosu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.DataTablosu.Click += new System.EventHandler(this.DataTable_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView2.Appearance.Row.BorderColor = System.Drawing.Color.Tomato;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2.GridControl = this.DataTablosu;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // benzinMiktarDb
            // 
            this.benzinMiktarDb.Location = new System.Drawing.Point(-4, 0);
            this.benzinMiktarDb.MainView = this.gridView1;
            this.benzinMiktarDb.Name = "benzinMiktarDb";
            this.benzinMiktarDb.Size = new System.Drawing.Size(352, 232);
            this.benzinMiktarDb.TabIndex = 3;
            this.benzinMiktarDb.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Silver;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.benzinMiktarDb;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Benzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.benzinMiktarDb);
            this.Controls.Add(this.DataTablosu);
            this.Controls.Add(this.groupControl1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Benzin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benzin";
            this.Load += new System.EventHandler(this.Benzin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yakıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakıtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benzinMiktarDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dbLoginDataSet dbLoginDataSet;
        private System.Windows.Forms.BindingSource yakıtBindingSource;
        private dbLoginDataSetTableAdapters.YakıtTableAdapter yakıtTableAdapter;
        private dbLoginDataSet1 dbLoginDataSet1;
        private System.Windows.Forms.BindingSource yakıtBindingSource1;
        private dbLoginDataSet1TableAdapters.YakıtTableAdapter yakıtTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton ekleButonu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPara;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraGrid.GridControl DataTablosu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl benzinMiktarDb;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblLitreFiyat;
        private DevExpress.XtraEditors.LabelControl lblDoldurMiktar;
        private DevExpress.XtraEditors.SimpleButton miktariHesapla;
    }
}