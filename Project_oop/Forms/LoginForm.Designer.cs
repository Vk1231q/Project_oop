namespace Project_oop.Forms
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            imageList1 = new System.Windows.Forms.ImageList(components);
            panel1 = new System.Windows.Forms.Panel();
            BtnLogin = new MaterialSkin.Controls.MaterialButton();
            PasswordParcels = new MaterialSkin.Controls.MaterialTextBox();
            LoginParcels = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            panel1.SuspendLayout();
            materialTabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "login_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(1, "logout_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(2, "add_FILL0_wght400_GRAD0_opsz48.ico");
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnLogin);
            panel1.Location = new System.Drawing.Point(64, 220);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(326, 40);
            panel1.TabIndex = 5;
            // 
            // BtnLogin
            // 
            BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnLogin.Depth = 0;
            BtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnLogin.HighEmphasis = true;
            BtnLogin.Icon = null;
            BtnLogin.Location = new System.Drawing.Point(0, 0);
            BtnLogin.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            BtnLogin.Name = "BtnLogin";
            BtnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnLogin.Size = new System.Drawing.Size(326, 40);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Enter";
            BtnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnLogin.UseAccentColor = false;
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // PasswordParcels
            // 
            PasswordParcels.AnimateReadOnly = false;
            PasswordParcels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PasswordParcels.Depth = 0;
            PasswordParcels.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            PasswordParcels.LeadingIcon = null;
            PasswordParcels.Location = new System.Drawing.Point(150, 122);
            PasswordParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PasswordParcels.MaxLength = 50;
            PasswordParcels.MouseState = MaterialSkin.MouseState.OUT;
            PasswordParcels.Multiline = false;
            PasswordParcels.Name = "PasswordParcels";
            PasswordParcels.Password = true;
            PasswordParcels.Size = new System.Drawing.Size(239, 50);
            PasswordParcels.TabIndex = 3;
            PasswordParcels.Text = "";
            PasswordParcels.TrailingIcon = null;
            // 
            // LoginParcels
            // 
            LoginParcels.AnimateReadOnly = false;
            LoginParcels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LoginParcels.Depth = 0;
            LoginParcels.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            LoginParcels.LeadingIcon = null;
            LoginParcels.Location = new System.Drawing.Point(150, 47);
            LoginParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LoginParcels.MaxLength = 50;
            LoginParcels.MouseState = MaterialSkin.MouseState.OUT;
            LoginParcels.Multiline = false;
            LoginParcels.Name = "LoginParcels";
            LoginParcels.Size = new System.Drawing.Size(239, 50);
            LoginParcels.TabIndex = 2;
            LoginParcels.Text = "";
            LoginParcels.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(71, 141);
            materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(71, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(71, 64);
            materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(72, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Username";
            // 
            // materialTabControl2
            // 
            materialTabControl2.Controls.Add(tabPage3);
            materialTabControl2.Controls.Add(tabPage4);
            materialTabControl2.Depth = 0;
            materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            materialTabControl2.ImageList = imageList1;
            materialTabControl2.Location = new System.Drawing.Point(4, 74);
            materialTabControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl2.Multiline = true;
            materialTabControl2.Name = "materialTabControl2";
            materialTabControl2.SelectedIndex = 0;
            materialTabControl2.Size = new System.Drawing.Size(510, 358);
            materialTabControl2.TabIndex = 6;
            materialTabControl2.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.White;
            tabPage3.Controls.Add(PasswordParcels);
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(materialLabel2);
            tabPage3.Controls.Add(materialLabel1);
            tabPage3.Controls.Add(LoginParcels);
            tabPage3.ImageKey = "login_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage3.Location = new System.Drawing.Point(4, 39);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Size = new System.Drawing.Size(502, 315);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Login";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = System.Drawing.Color.White;
            tabPage4.ImageKey = "logout_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage4.Location = new System.Drawing.Point(4, 39);
            tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Size = new System.Drawing.Size(502, 315);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Logout";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(518, 435);
            Controls.Add(materialTabControl2);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl2;
            DrawerUseColors = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialTabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton BtnLogin;
        private MaterialSkin.Controls.MaterialTextBox PasswordParcels;
        private MaterialSkin.Controls.MaterialTextBox LoginParcels;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}