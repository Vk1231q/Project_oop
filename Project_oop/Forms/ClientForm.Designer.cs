namespace Project_oop.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            ClientName = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            LblMoneyClient = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new System.Windows.Forms.Panel();
            BtnConfirmClient = new MaterialSkin.Controls.MaterialButton();
            DGVParcels = new System.Windows.Forms.DataGridView();
            tabPage4 = new System.Windows.Forms.TabPage();
            imageList1 = new System.Windows.Forms.ImageList(components);
            ParcelsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsDispatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsDelievery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            materialTabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVParcels).BeginInit();
            SuspendLayout();
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
            materialTabControl2.Size = new System.Drawing.Size(1280, 442);
            materialTabControl2.TabIndex = 7;
            materialTabControl2.SelectedIndexChanged += materialTabControl2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.White;
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(DGVParcels);
            tabPage3.ImageKey = "home_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage3.Location = new System.Drawing.Point(4, 39);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Size = new System.Drawing.Size(1272, 399);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Main";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(654, 3);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(614, 393);
            panel1.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(ClientName);
            panel3.Controls.Add(materialLabel1);
            panel3.Controls.Add(materialLabel2);
            panel3.Controls.Add(LblMoneyClient);
            panel3.Location = new System.Drawing.Point(23, 24);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(437, 275);
            panel3.TabIndex = 2;
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Depth = 0;
            ClientName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            ClientName.Location = new System.Drawing.Point(69, 39);
            ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            ClientName.Name = "ClientName";
            ClientName.Size = new System.Drawing.Size(1, 0);
            ClientName.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(20, 39);
            materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(41, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Hello!";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(20, 106);
            materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(53, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Money:";
            // 
            // LblMoneyClient
            // 
            LblMoneyClient.AutoSize = true;
            LblMoneyClient.Depth = 0;
            LblMoneyClient.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            LblMoneyClient.Location = new System.Drawing.Point(81, 106);
            LblMoneyClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblMoneyClient.MouseState = MaterialSkin.MouseState.HOVER;
            LblMoneyClient.Name = "LblMoneyClient";
            LblMoneyClient.Size = new System.Drawing.Size(1, 0);
            LblMoneyClient.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnConfirmClient);
            panel2.Location = new System.Drawing.Point(23, 309);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(437, 51);
            panel2.TabIndex = 0;
            // 
            // BtnConfirmClient
            // 
            BtnConfirmClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnConfirmClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnConfirmClient.Depth = 0;
            BtnConfirmClient.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnConfirmClient.HighEmphasis = true;
            BtnConfirmClient.Icon = null;
            BtnConfirmClient.Location = new System.Drawing.Point(0, 0);
            BtnConfirmClient.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnConfirmClient.MouseState = MaterialSkin.MouseState.HOVER;
            BtnConfirmClient.Name = "BtnConfirmClient";
            BtnConfirmClient.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnConfirmClient.Size = new System.Drawing.Size(437, 51);
            BtnConfirmClient.TabIndex = 0;
            BtnConfirmClient.Text = "Confirm your parcel";
            BtnConfirmClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnConfirmClient.UseAccentColor = false;
            BtnConfirmClient.UseVisualStyleBackColor = true;
            // 
            // DGVParcels
            // 
            DGVParcels.AllowUserToAddRows = false;
            DGVParcels.AllowUserToDeleteRows = false;
            DGVParcels.AllowUserToResizeColumns = false;
            DGVParcels.AllowUserToResizeRows = false;
            DGVParcels.BackgroundColor = System.Drawing.SystemColors.Control;
            DGVParcels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DGVParcels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DGVParcels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DGVParcels.ColumnHeadersHeight = 45;
            DGVParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVParcels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ParcelsId, ParcelsWage, ParcelsDispatch, ParcelsDelievery, ParcelsCost });
            DGVParcels.Dock = System.Windows.Forms.DockStyle.Left;
            DGVParcels.EnableHeadersVisualStyles = false;
            DGVParcels.GridColor = System.Drawing.SystemColors.Control;
            DGVParcels.Location = new System.Drawing.Point(4, 3);
            DGVParcels.Margin = new System.Windows.Forms.Padding(0);
            DGVParcels.MultiSelect = false;
            DGVParcels.Name = "DGVParcels";
            DGVParcels.ReadOnly = true;
            DGVParcels.RowHeadersVisible = false;
            DGVParcels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGVParcels.Size = new System.Drawing.Size(646, 393);
            DGVParcels.TabIndex = 10;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = System.Drawing.Color.White;
            tabPage4.ImageKey = "logout_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage4.Location = new System.Drawing.Point(4, 39);
            tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Size = new System.Drawing.Size(1272, 399);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Logout";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "home_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(1, "logout_FILL0_wght600_GRAD0_opsz48.ico");
            // 
            // ParcelsId
            // 
            ParcelsId.HeaderText = "Id";
            ParcelsId.Name = "ParcelsId";
            ParcelsId.ReadOnly = true;
            ParcelsId.Width = 60;
            // 
            // ParcelsWage
            // 
            ParcelsWage.FillWeight = 23.64963F;
            ParcelsWage.HeaderText = "Wage";
            ParcelsWage.Name = "ParcelsWage";
            ParcelsWage.ReadOnly = true;
            ParcelsWage.Width = 120;
            // 
            // ParcelsDispatch
            // 
            ParcelsDispatch.FillWeight = 30F;
            ParcelsDispatch.HeaderText = "Dispatch";
            ParcelsDispatch.Name = "ParcelsDispatch";
            ParcelsDispatch.ReadOnly = true;
            ParcelsDispatch.Width = 120;
            // 
            // ParcelsDelievery
            // 
            ParcelsDelievery.HeaderText = "Delievery";
            ParcelsDelievery.Name = "ParcelsDelievery";
            ParcelsDelievery.ReadOnly = true;
            // 
            // ParcelsCost
            // 
            ParcelsCost.HeaderText = "Cost";
            ParcelsCost.Name = "ParcelsCost";
            ParcelsCost.ReadOnly = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1288, 519);
            Controls.Add(materialTabControl2);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl2;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ClientForm";
            Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            Sizable = false;
            Text = "Client";
            Load += ClientForm_Load;
            materialTabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVParcels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVParcels;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton BtnConfirmClient;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel LblMoneyClient;
        private MaterialSkin.Controls.MaterialLabel ClientName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsDispatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsDelievery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsCost;
    }
}