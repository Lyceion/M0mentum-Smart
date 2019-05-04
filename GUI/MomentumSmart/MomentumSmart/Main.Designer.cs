namespace MomentumSmart
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.headTEXT = new System.Windows.Forms.Label();
            this.homepage = new System.Windows.Forms.Panel();
            this.loginPage = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.connect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.portCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.infoButton = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.krkb = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.homepage.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Cursor = System.Windows.Forms.Cursors.Default;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Enabled = false;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.header.ForeColor = System.Drawing.Color.Red;
            this.header.HintForeColor = System.Drawing.Color.Empty;
            this.header.HintText = "";
            this.header.isPassword = false;
            this.header.LineFocusedColor = System.Drawing.Color.Red;
            this.header.LineIdleColor = System.Drawing.Color.Red;
            this.header.LineMouseHoverColor = System.Drawing.Color.Red;
            this.header.LineThickness = 3;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(869, 49);
            this.header.TabIndex = 0;
            this.header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headTEXT
            // 
            this.headTEXT.AutoSize = true;
            this.headTEXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.headTEXT.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headTEXT.ForeColor = System.Drawing.Color.Red;
            this.headTEXT.Location = new System.Drawing.Point(353, 9);
            this.headTEXT.Name = "headTEXT";
            this.headTEXT.Size = new System.Drawing.Size(171, 23);
            this.headTEXT.TabIndex = 1;
            this.headTEXT.Text = "M0mentum SmarT";
            // 
            // homepage
            // 
            this.homepage.Controls.Add(this.loginPage);
            this.homepage.Controls.Add(this.infoButton);
            this.homepage.Controls.Add(this.bunifuThinButton25);
            this.homepage.Controls.Add(this.bunifuThinButton24);
            this.homepage.Controls.Add(this.bunifuThinButton23);
            this.homepage.Controls.Add(this.bunifuThinButton22);
            this.homepage.Controls.Add(this.krkb);
            this.homepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepage.Location = new System.Drawing.Point(0, 49);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(869, 470);
            this.homepage.TabIndex = 6;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.container);
            this.loginPage.Location = new System.Drawing.Point(3, 21);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(854, 446);
            this.loginPage.TabIndex = 0;
            // 
            // container
            // 
            this.container.Controls.Add(this.bunifuCustomLabel1);
            this.container.Controls.Add(this.connect);
            this.container.Controls.Add(this.portCombo);
            this.container.ForeColor = System.Drawing.Color.Red;
            this.container.Location = new System.Drawing.Point(304, 71);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(274, 207);
            this.container.TabIndex = 0;
            this.container.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 28);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(196, 48);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Lütfen Cihazın Bağlı Olduğu\r\n             Noktayı Seçin\r\n(Genellikle COM3 - COM4)" +
    "";
            // 
            // connect
            // 
            this.connect.Activecolor = System.Drawing.Color.Red;
            this.connect.BackColor = System.Drawing.Color.DarkRed;
            this.connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connect.BorderRadius = 0;
            this.connect.ButtonText = "Giriş Yap";
            this.connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect.DisabledColor = System.Drawing.Color.Gray;
            this.connect.Iconcolor = System.Drawing.Color.Transparent;
            this.connect.Iconimage = ((System.Drawing.Image)(resources.GetObject("connect.Iconimage")));
            this.connect.Iconimage_right = null;
            this.connect.Iconimage_right_Selected = null;
            this.connect.Iconimage_Selected = null;
            this.connect.IconMarginLeft = 0;
            this.connect.IconMarginRight = 0;
            this.connect.IconRightVisible = true;
            this.connect.IconRightZoom = 0D;
            this.connect.IconVisible = true;
            this.connect.IconZoom = 90D;
            this.connect.IsTab = false;
            this.connect.Location = new System.Drawing.Point(71, 153);
            this.connect.Name = "connect";
            this.connect.Normalcolor = System.Drawing.Color.DarkRed;
            this.connect.OnHovercolor = System.Drawing.Color.Red;
            this.connect.OnHoverTextColor = System.Drawing.Color.White;
            this.connect.selected = false;
            this.connect.Size = new System.Drawing.Size(133, 48);
            this.connect.TabIndex = 8;
            this.connect.Text = "Giriş Yap";
            this.connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connect.Textcolor = System.Drawing.Color.White;
            this.connect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // portCombo
            // 
            this.portCombo.BackColor = System.Drawing.Color.Transparent;
            this.portCombo.BorderRadius = 3;
            this.portCombo.DisabledColor = System.Drawing.Color.Gray;
            this.portCombo.ForeColor = System.Drawing.Color.White;
            this.portCombo.Items = new string[0];
            this.portCombo.Location = new System.Drawing.Point(6, 107);
            this.portCombo.Name = "portCombo";
            this.portCombo.NomalColor = System.Drawing.Color.DarkRed;
            this.portCombo.onHoverColor = System.Drawing.Color.Red;
            this.portCombo.selectedIndex = -1;
            this.portCombo.Size = new System.Drawing.Size(262, 35);
            this.portCombo.TabIndex = 7;
            // 
            // infoButton
            // 
            this.infoButton.Image = global::MomentumSmart.Properties.Resources.Button_help_icon;
            this.infoButton.Location = new System.Drawing.Point(810, 413);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(47, 45);
            this.infoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoButton.TabIndex = 6;
            this.infoButton.TabStop = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Kendini Kalibre Et!";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton25.Location = new System.Drawing.Point(14, 413);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton25.TabIndex = 5;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "180 Derecelik Açı Yap!";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton24.Location = new System.Drawing.Point(338, 21);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(98, 101);
            this.bunifuThinButton24.TabIndex = 4;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "135 Derecelik Açı Yap!";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton23.Location = new System.Drawing.Point(230, 21);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(98, 101);
            this.bunifuThinButton23.TabIndex = 3;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "90 Derecelik Açı Yap!";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.Location = new System.Drawing.Point(122, 21);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(98, 101);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // krkb
            // 
            this.krkb.ActiveBorderThickness = 1;
            this.krkb.ActiveCornerRadius = 20;
            this.krkb.ActiveFillColor = System.Drawing.Color.Red;
            this.krkb.ActiveForecolor = System.Drawing.Color.White;
            this.krkb.ActiveLineColor = System.Drawing.Color.Red;
            this.krkb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.krkb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("krkb.BackgroundImage")));
            this.krkb.ButtonText = "45 Derecelik Açı Yap!";
            this.krkb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krkb.ForeColor = System.Drawing.Color.SeaGreen;
            this.krkb.IdleBorderThickness = 1;
            this.krkb.IdleCornerRadius = 20;
            this.krkb.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.krkb.IdleForecolor = System.Drawing.Color.Red;
            this.krkb.IdleLineColor = System.Drawing.Color.DarkRed;
            this.krkb.Location = new System.Drawing.Point(14, 21);
            this.krkb.Margin = new System.Windows.Forms.Padding(5);
            this.krkb.Name = "krkb";
            this.krkb.Size = new System.Drawing.Size(98, 101);
            this.krkb.TabIndex = 1;
            this.krkb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.krkb.Click += new System.EventHandler(this.krkb_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exit.Location = new System.Drawing.Point(836, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Red;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimize.Location = new System.Drawing.Point(810, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 20);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(869, 519);
            this.Controls.Add(this.homepage);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.headTEXT);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M0mentum SmarT";
            this.homepage.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox header;
        private System.Windows.Forms.Label headTEXT;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel homepage;
        private System.Windows.Forms.Panel loginPage;
        private System.Windows.Forms.GroupBox container;
        private Bunifu.Framework.UI.BunifuDropdown portCombo;
        private Bunifu.Framework.UI.BunifuFlatButton connect;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 krkb;
        private System.Windows.Forms.PictureBox infoButton;
    }
}

