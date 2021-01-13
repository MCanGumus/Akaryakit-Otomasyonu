namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class YonetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetimPaneli));
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.cıkısButon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.loginButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.ImageOptions.Image")));
            this.loginButton.Location = new System.Drawing.Point(385, 306);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Giriş";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userText
            // 
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userText.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userText.Location = new System.Drawing.Point(230, 167);
            this.userText.Multiline = true;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(247, 38);
            this.userText.TabIndex = 4;
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passText.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passText.Location = new System.Drawing.Point(230, 233);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '#';
            this.passText.Size = new System.Drawing.Size(247, 38);
            this.passText.TabIndex = 5;
            // 
            // cıkısButon
            // 
            this.cıkısButon.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısButon.Appearance.Options.UseFont = true;
            this.cıkısButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cıkısButon.ImageOptions.Image")));
            this.cıkısButon.Location = new System.Drawing.Point(178, 306);
            this.cıkısButon.Name = "cıkısButon";
            this.cıkısButon.Size = new System.Drawing.Size(118, 41);
            this.cıkısButon.TabIndex = 6;
            this.cıkısButon.Text = "Ana Sayfa";
            this.cıkısButon.Click += new System.EventHandler(this.cıkısButon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Aqua;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(214, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 32);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Yönetim Giriş Paneli";
            // 
            // YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 432);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cıkısButon);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YonetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YonetimPaneli";
            this.Load += new System.EventHandler(this.YonetimPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private DevExpress.XtraEditors.SimpleButton cıkısButon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}