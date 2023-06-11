namespace DBMSProject
{
    partial class ConfirmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPayment));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_resend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_otp = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_verify = new DBMSProject.RoundedButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(86)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.lbl_time);
            this.guna2Panel1.Controls.Add(this.btn_resend);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel2);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel1);
            this.guna2Panel1.Controls.Add(this.btn_verify);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel8);
            this.guna2Panel1.Controls.Add(this.txt_otp);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(86)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(481, 377);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_time.Location = new System.Drawing.Point(201, 260);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(97, 36);
            this.lbl_time.TabIndex = 228;
            this.lbl_time.Text = "00:00";
            // 
            // btn_resend
            // 
            this.btn_resend.ActiveBorderThickness = 1;
            this.btn_resend.ActiveCornerRadius = 20;
            this.btn_resend.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_resend.ActiveForecolor = System.Drawing.Color.Red;
            this.btn_resend.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_resend.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_resend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_resend.BackgroundImage")));
            this.btn_resend.ButtonText = "RESEND OTP";
            this.btn_resend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resend.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resend.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_resend.IdleBorderThickness = 1;
            this.btn_resend.IdleCornerRadius = 20;
            this.btn_resend.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_resend.IdleForecolor = System.Drawing.Color.Black;
            this.btn_resend.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_resend.Location = new System.Drawing.Point(163, 309);
            this.btn_resend.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_resend.Name = "btn_resend";
            this.btn_resend.Size = new System.Drawing.Size(163, 43);
            this.btn_resend.TabIndex = 227;
            this.btn_resend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_resend.Click += new System.EventHandler(this.btn_resend_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(126, 96);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(99, 28);
            this.bunifuCustomLabel2.TabIndex = 226;
            this.bunifuCustomLabel2.Text = "Enter Otp";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 13);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(353, 28);
            this.bunifuCustomLabel1.TabIndex = 225;
            this.bunifuCustomLabel1.Text = "Secure Payment Verification Window ";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(158, 41);
            this.bunifuCustomLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(147, 28);
            this.bunifuCustomLabel8.TabIndex = 223;
            this.bunifuCustomLabel8.Text = "~ By SAB Bank";
            // 
            // txt_otp
            // 
            this.txt_otp.AcceptsReturn = false;
            this.txt_otp.AcceptsTab = false;
            this.txt_otp.AnimationSpeed = 200;
            this.txt_otp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_otp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_otp.BackColor = System.Drawing.Color.Transparent;
            this.txt_otp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_otp.BackgroundImage")));
            this.txt_otp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_otp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_otp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_otp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.txt_otp.BorderRadius = 20;
            this.txt_otp.BorderThickness = 1;
            this.txt_otp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_otp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_otp.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_otp.DefaultText = "";
            this.txt_otp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_otp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_otp.HideSelection = true;
            this.txt_otp.IconLeft = null;
            this.txt_otp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_otp.IconPadding = 10;
            this.txt_otp.IconRight = null;
            this.txt_otp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_otp.Lines = new string[0];
            this.txt_otp.Location = new System.Drawing.Point(121, 128);
            this.txt_otp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_otp.MaxLength = 32767;
            this.txt_otp.MinimumSize = new System.Drawing.Size(133, 43);
            this.txt_otp.Modified = false;
            this.txt_otp.Multiline = false;
            this.txt_otp.Name = "txt_otp";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_otp.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_otp.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_otp.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_otp.OnIdleState = stateProperties4;
            this.txt_otp.PasswordChar = '\0';
            this.txt_otp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_otp.PlaceholderText = "Enter text";
            this.txt_otp.ReadOnly = false;
            this.txt_otp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_otp.SelectedText = "";
            this.txt_otp.SelectionLength = 0;
            this.txt_otp.SelectionStart = 0;
            this.txt_otp.ShortcutsEnabled = true;
            this.txt_otp.Size = new System.Drawing.Size(267, 43);
            this.txt_otp.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_otp.TabIndex = 222;
            this.txt_otp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_otp.TextMarginBottom = 0;
            this.txt_otp.TextMarginLeft = 5;
            this.txt_otp.TextMarginTop = 0;
            this.txt_otp.TextPlaceholder = "Enter text";
            this.txt_otp.UseSystemPasswordChar = false;
            this.txt_otp.WordWrap = true;
            // 
            // btn_verify
            // 
            this.btn_verify.Active = false;
            this.btn_verify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(86)))));
            this.btn_verify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verify.BorderRadius = 0;
            this.btn_verify.ButtonText = "VERIFY";
            this.btn_verify.CornerRadius = 10;
            this.btn_verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verify.DisabledColor = System.Drawing.Color.Gray;
            this.btn_verify.ForeColor = System.Drawing.Color.White;
            this.btn_verify.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_verify.Iconimage = null;
            this.btn_verify.Iconimage_right = null;
            this.btn_verify.Iconimage_right_Selected = null;
            this.btn_verify.Iconimage_Selected = null;
            this.btn_verify.IconMarginLeft = 0;
            this.btn_verify.IconMarginRight = 0;
            this.btn_verify.IconRightVisible = false;
            this.btn_verify.IconRightZoom = 0D;
            this.btn_verify.IconVisible = false;
            this.btn_verify.IconZoom = 90D;
            this.btn_verify.IsTab = false;
            this.btn_verify.Location = new System.Drawing.Point(152, 189);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(142)))), ((int)(((byte)(86)))));
            this.btn_verify.OnHovercolor = System.Drawing.Color.BurlyWood;
            this.btn_verify.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_verify.selected = false;
            this.btn_verify.Size = new System.Drawing.Size(193, 57);
            this.btn_verify.TabIndex = 224;
            this.btn_verify.Text = "VERIFY";
            this.btn_verify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_verify.Textcolor = System.Drawing.Color.White;
            this.btn_verify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(485, 378);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ConfirmPayment";
            this.Text = "ConfirmPayment";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        public RoundedButton btn_verify;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_otp;
        public System.Windows.Forms.Label lbl_time;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_resend;
    }
}