namespace AkaryakıtİstasyonuOtomasyonu
{
    partial class MudurGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MudurGirisPaneli));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cıkısButon = new DevExpress.XtraEditors.SimpleButton();
            this.passText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(227, 32);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Müdür Giriş Paneli";
            // 
            // cıkısButon
            // 
            this.cıkısButon.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkısButon.Appearance.Options.UseFont = true;
            this.cıkısButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cıkısButon.ImageOptions.Image")));
            this.cıkısButon.Location = new System.Drawing.Point(164, 273);
            this.cıkısButon.Name = "cıkısButon";
            this.cıkısButon.Size = new System.Drawing.Size(118, 41);
            this.cıkısButon.TabIndex = 11;
            this.cıkısButon.Text = "Ana Sayfa";
            this.cıkısButon.Click += new System.EventHandler(this.cıkısButon_Click);
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passText.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passText.Location = new System.Drawing.Point(236, 205);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '#';
            this.passText.Size = new System.Drawing.Size(220, 38);
            this.passText.TabIndex = 10;
            // 
            // userText
            // 
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userText.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userText.Location = new System.Drawing.Point(236, 148);
            this.userText.Multiline = true;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(220, 38);
            this.userText.TabIndex = 9;
            // 
            // loginButton
            // 
            this.loginButton.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Appearance.Options.UseFont = true;
            this.loginButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.loginButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.ImageOptions.Image")));
            this.loginButton.Location = new System.Drawing.Point(362, 273);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 41);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Giriş";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MudurGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 390);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cıkısButon);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MudurGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MudurGirisPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cıkısButon;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userText;
        private DevExpress.XtraEditors.SimpleButton loginButton;
    }
}