using Project_oop.Forms;

namespace Project_oop
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tabPage6 = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            TxtBoxZipCode = new MaterialSkin.Controls.MaterialTextBox();
            LblZipCode = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxCountryCities = new MaterialSkin.Controls.MaterialTextBox();
            LblCountryCities = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxNameCities = new MaterialSkin.Controls.MaterialTextBox();
            LblNameCities = new MaterialSkin.Controls.MaterialLabel();
            DGVCities = new System.Windows.Forms.DataGridView();
            IdCities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NameCities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CountryCities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CodeCities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            BtnDeleteCities = new MaterialSkin.Controls.MaterialButton();
            BtnEditCities = new MaterialSkin.Controls.MaterialButton();
            BtnAddCities = new MaterialSkin.Controls.MaterialButton();
            BtnRefreshCities = new MaterialSkin.Controls.MaterialButton();
            tabPage4 = new System.Windows.Forms.TabPage();
            panel3 = new System.Windows.Forms.Panel();
            CMBCityPostOffices = new MaterialSkin.Controls.MaterialComboBox();
            TxtBoxNamePostOffices = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxCntctNPostOffices = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxAddressPostOffices = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            DGVOffices = new System.Windows.Forms.DataGridView();
            PostOfficeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PostOfficeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PostOfficeCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PostOfficeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PostOfficeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            BtnDeletePostOffices = new MaterialSkin.Controls.MaterialButton();
            BtnEditPostOffices = new MaterialSkin.Controls.MaterialButton();
            BtnAddPostOffices = new MaterialSkin.Controls.MaterialButton();
            BtnRefreshPostOffices = new MaterialSkin.Controls.MaterialButton();
            tabPage3 = new System.Windows.Forms.TabPage();
            DGVPersonnel = new System.Windows.Forms.DataGridView();
            PersonnelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonnelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonnelSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonnelPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonnelEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonnelDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PersonnelPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            CMBPositionPersonnel = new MaterialSkin.Controls.MaterialComboBox();
            CMBDepartmentPersonnel = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxEmailPersonnel = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxPhonePersonnel = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxSurnamePersonnel = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxNamePersonnel = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            BtnDeletePesonnel = new MaterialSkin.Controls.MaterialButton();
            BtnEditPesonnel = new MaterialSkin.Controls.MaterialButton();
            BtnAddPesonnel = new MaterialSkin.Controls.MaterialButton();
            BtnRefreshPesonnel = new MaterialSkin.Controls.MaterialButton();
            tabPage5 = new System.Windows.Forms.TabPage();
            panel4 = new System.Windows.Forms.Panel();
            CMBFromParcels = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            CMBStatusParcels = new MaterialSkin.Controls.MaterialComboBox();
            TxtBoxCostParcels = new MaterialSkin.Controls.MaterialTextBox();
            DTPDelieveryParcels = new System.Windows.Forms.DateTimePicker();
            DTPDispatchParcels = new System.Windows.Forms.DateTimePicker();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            TxtBoxWageParcels = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            DGVParcels = new System.Windows.Forms.DataGridView();
            ParcelsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsDispatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsDelievery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ParcelsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            BtnDeleteParcels = new MaterialSkin.Controls.MaterialButton();
            BtnEditParcels = new MaterialSkin.Controls.MaterialButton();
            BtnAddParcels = new MaterialSkin.Controls.MaterialButton();
            BtnRefreshParcels = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new System.Windows.Forms.TabPage();
            imageList1 = new System.Windows.Forms.ImageList(components);
            BtnSAdd = new MaterialSkin.Controls.MaterialButton();
            BtnSEdit = new MaterialSkin.Controls.MaterialButton();
            BtnDelete = new MaterialSkin.Controls.MaterialButton();
            CMBToParcels = new MaterialSkin.Controls.MaterialComboBox();
            CMBClientParcels = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCities).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tabPage4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVOffices).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPersonnel).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVParcels).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new System.Drawing.Point(4, 74);
            materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new System.Drawing.Size(1292, 538);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.ImageKey = "home_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage1.Location = new System.Drawing.Point(4, 39);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(1284, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new System.Drawing.Point(-477, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1600, 900);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = System.Drawing.Color.White;
            tabPage6.Controls.Add(panel1);
            tabPage6.Controls.Add(DGVCities);
            tabPage6.Controls.Add(tableLayoutPanel2);
            tabPage6.ImageKey = "add_home_work_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage6.Location = new System.Drawing.Point(4, 39);
            tabPage6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new System.Drawing.Size(1284, 495);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Cities";
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtBoxZipCode);
            panel1.Controls.Add(LblZipCode);
            panel1.Controls.Add(TxtBoxCountryCities);
            panel1.Controls.Add(LblCountryCities);
            panel1.Controls.Add(TxtBoxNameCities);
            panel1.Controls.Add(LblNameCities);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(734, 48);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(550, 447);
            panel1.TabIndex = 4;
            // 
            // TxtBoxZipCode
            // 
            TxtBoxZipCode.AnimateReadOnly = false;
            TxtBoxZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxZipCode.Depth = 0;
            TxtBoxZipCode.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxZipCode.LeadingIcon = null;
            TxtBoxZipCode.Location = new System.Drawing.Point(379, 186);
            TxtBoxZipCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxZipCode.MaxLength = 50;
            TxtBoxZipCode.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxZipCode.Multiline = false;
            TxtBoxZipCode.Name = "TxtBoxZipCode";
            TxtBoxZipCode.Size = new System.Drawing.Size(121, 50);
            TxtBoxZipCode.TabIndex = 7;
            TxtBoxZipCode.Text = "";
            TxtBoxZipCode.TrailingIcon = null;
            // 
            // LblZipCode
            // 
            LblZipCode.AutoSize = true;
            LblZipCode.Depth = 0;
            LblZipCode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            LblZipCode.Location = new System.Drawing.Point(300, 204);
            LblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblZipCode.MouseState = MaterialSkin.MouseState.HOVER;
            LblZipCode.Name = "LblZipCode";
            LblZipCode.Size = new System.Drawing.Size(62, 19);
            LblZipCode.TabIndex = 6;
            LblZipCode.Text = "Zip code";
            // 
            // TxtBoxCountryCities
            // 
            TxtBoxCountryCities.AnimateReadOnly = false;
            TxtBoxCountryCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxCountryCities.Depth = 0;
            TxtBoxCountryCities.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxCountryCities.LeadingIcon = null;
            TxtBoxCountryCities.Location = new System.Drawing.Point(379, 95);
            TxtBoxCountryCities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxCountryCities.MaxLength = 50;
            TxtBoxCountryCities.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxCountryCities.Multiline = false;
            TxtBoxCountryCities.Name = "TxtBoxCountryCities";
            TxtBoxCountryCities.Size = new System.Drawing.Size(121, 50);
            TxtBoxCountryCities.TabIndex = 5;
            TxtBoxCountryCities.Text = "";
            TxtBoxCountryCities.TrailingIcon = null;
            // 
            // LblCountryCities
            // 
            LblCountryCities.AutoSize = true;
            LblCountryCities.Depth = 0;
            LblCountryCities.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            LblCountryCities.Location = new System.Drawing.Point(307, 113);
            LblCountryCities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblCountryCities.MouseState = MaterialSkin.MouseState.HOVER;
            LblCountryCities.Name = "LblCountryCities";
            LblCountryCities.Size = new System.Drawing.Size(56, 19);
            LblCountryCities.TabIndex = 4;
            LblCountryCities.Text = "Country";
            // 
            // TxtBoxNameCities
            // 
            TxtBoxNameCities.AnimateReadOnly = false;
            TxtBoxNameCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxNameCities.Depth = 0;
            TxtBoxNameCities.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxNameCities.LeadingIcon = null;
            TxtBoxNameCities.Location = new System.Drawing.Point(89, 186);
            TxtBoxNameCities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxNameCities.MaxLength = 50;
            TxtBoxNameCities.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxNameCities.Multiline = false;
            TxtBoxNameCities.Name = "TxtBoxNameCities";
            TxtBoxNameCities.Size = new System.Drawing.Size(121, 50);
            TxtBoxNameCities.TabIndex = 3;
            TxtBoxNameCities.Text = "";
            TxtBoxNameCities.TrailingIcon = null;
            // 
            // LblNameCities
            // 
            LblNameCities.AutoSize = true;
            LblNameCities.Depth = 0;
            LblNameCities.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            LblNameCities.Location = new System.Drawing.Point(31, 204);
            LblNameCities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblNameCities.MouseState = MaterialSkin.MouseState.HOVER;
            LblNameCities.Name = "LblNameCities";
            LblNameCities.Size = new System.Drawing.Size(43, 19);
            LblNameCities.TabIndex = 2;
            LblNameCities.Text = "Name";
            // 
            // DGVCities
            // 
            DGVCities.AllowUserToAddRows = false;
            DGVCities.AllowUserToDeleteRows = false;
            DGVCities.AllowUserToResizeColumns = false;
            DGVCities.AllowUserToResizeRows = false;
            DGVCities.BackgroundColor = System.Drawing.SystemColors.Control;
            DGVCities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DGVCities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DGVCities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DGVCities.ColumnHeadersHeight = 45;
            DGVCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdCities, NameCities, CountryCities, CodeCities });
            DGVCities.Dock = System.Windows.Forms.DockStyle.Left;
            DGVCities.EnableHeadersVisualStyles = false;
            DGVCities.GridColor = System.Drawing.SystemColors.Control;
            DGVCities.Location = new System.Drawing.Point(0, 48);
            DGVCities.Margin = new System.Windows.Forms.Padding(0);
            DGVCities.MultiSelect = false;
            DGVCities.Name = "DGVCities";
            DGVCities.ReadOnly = true;
            DGVCities.RowHeadersVisible = false;
            DGVCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGVCities.Size = new System.Drawing.Size(705, 447);
            DGVCities.TabIndex = 3;
            // 
            // IdCities
            // 
            IdCities.HeaderText = "Id";
            IdCities.Name = "IdCities";
            IdCities.ReadOnly = true;
            IdCities.Width = 60;
            // 
            // NameCities
            // 
            NameCities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            NameCities.FillWeight = 23.64963F;
            NameCities.HeaderText = "Name";
            NameCities.Name = "NameCities";
            NameCities.ReadOnly = true;
            // 
            // CountryCities
            // 
            CountryCities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            CountryCities.FillWeight = 23.64963F;
            CountryCities.HeaderText = "Country";
            CountryCities.Name = "CountryCities";
            CountryCities.ReadOnly = true;
            // 
            // CodeCities
            // 
            CodeCities.FillWeight = 481.7518F;
            CodeCities.HeaderText = "Zip code";
            CodeCities.Name = "CodeCities";
            CodeCities.ReadOnly = true;
            CodeCities.Width = 110;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel2.Controls.Add(BtnDeleteCities, 2, 0);
            tableLayoutPanel2.Controls.Add(BtnEditCities, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnAddCities, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnRefreshCities, 3, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1284, 48);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // BtnDeleteCities
            // 
            BtnDeleteCities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnDeleteCities.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDeleteCities.Depth = 0;
            BtnDeleteCities.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnDeleteCities.FlatAppearance.BorderSize = 0;
            BtnDeleteCities.HighEmphasis = true;
            BtnDeleteCities.Icon = null;
            BtnDeleteCities.Location = new System.Drawing.Point(215, 7);
            BtnDeleteCities.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnDeleteCities.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDeleteCities.Name = "BtnDeleteCities";
            BtnDeleteCities.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnDeleteCities.Size = new System.Drawing.Size(95, 28);
            BtnDeleteCities.TabIndex = 5;
            BtnDeleteCities.Text = "Delete";
            BtnDeleteCities.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnDeleteCities.UseAccentColor = false;
            BtnDeleteCities.UseVisualStyleBackColor = true;
            BtnDeleteCities.Click += BtnDeleteCities_Click;
            // 
            // BtnEditCities
            // 
            BtnEditCities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnEditCities.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditCities.Depth = 0;
            BtnEditCities.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnEditCities.FlatAppearance.BorderSize = 0;
            BtnEditCities.HighEmphasis = true;
            BtnEditCities.Icon = null;
            BtnEditCities.Location = new System.Drawing.Point(111, 7);
            BtnEditCities.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnEditCities.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditCities.Name = "BtnEditCities";
            BtnEditCities.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnEditCities.Size = new System.Drawing.Size(94, 28);
            BtnEditCities.TabIndex = 4;
            BtnEditCities.Text = "Edit";
            BtnEditCities.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEditCities.UseAccentColor = false;
            BtnEditCities.UseVisualStyleBackColor = true;
            BtnEditCities.Click += BtnEditCities_Click;
            // 
            // BtnAddCities
            // 
            BtnAddCities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnAddCities.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAddCities.Depth = 0;
            BtnAddCities.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnAddCities.FlatAppearance.BorderSize = 0;
            BtnAddCities.HighEmphasis = true;
            BtnAddCities.Icon = null;
            BtnAddCities.Location = new System.Drawing.Point(5, 7);
            BtnAddCities.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnAddCities.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAddCities.Name = "BtnAddCities";
            BtnAddCities.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnAddCities.Size = new System.Drawing.Size(96, 28);
            BtnAddCities.TabIndex = 1;
            BtnAddCities.Text = "Add";
            BtnAddCities.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAddCities.UseAccentColor = false;
            BtnAddCities.UseVisualStyleBackColor = true;
            BtnAddCities.Click += BtnAddCities_Click;
            // 
            // BtnRefreshCities
            // 
            BtnRefreshCities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnRefreshCities.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRefreshCities.Depth = 0;
            BtnRefreshCities.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnRefreshCities.FlatAppearance.BorderSize = 0;
            BtnRefreshCities.HighEmphasis = true;
            BtnRefreshCities.Icon = null;
            BtnRefreshCities.Location = new System.Drawing.Point(320, 7);
            BtnRefreshCities.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnRefreshCities.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRefreshCities.Name = "BtnRefreshCities";
            BtnRefreshCities.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnRefreshCities.Size = new System.Drawing.Size(95, 28);
            BtnRefreshCities.TabIndex = 3;
            BtnRefreshCities.Text = "Refresh";
            BtnRefreshCities.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRefreshCities.UseAccentColor = false;
            BtnRefreshCities.UseVisualStyleBackColor = true;
            BtnRefreshCities.Click += BtnRefreshCities_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = System.Drawing.Color.White;
            tabPage4.Controls.Add(panel3);
            tabPage4.Controls.Add(DGVOffices);
            tabPage4.Controls.Add(tableLayoutPanel3);
            tabPage4.ImageKey = "local_post_office_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage4.Location = new System.Drawing.Point(4, 39);
            tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(1284, 495);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Post offices";
            // 
            // panel3
            // 
            panel3.Controls.Add(CMBCityPostOffices);
            panel3.Controls.Add(TxtBoxNamePostOffices);
            panel3.Controls.Add(materialLabel15);
            panel3.Controls.Add(materialLabel5);
            panel3.Controls.Add(TxtBoxCntctNPostOffices);
            panel3.Controls.Add(materialLabel9);
            panel3.Controls.Add(TxtBoxAddressPostOffices);
            panel3.Controls.Add(materialLabel7);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(734, 48);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(550, 447);
            panel3.TabIndex = 7;
            // 
            // CMBCityPostOffices
            // 
            CMBCityPostOffices.AutoResize = false;
            CMBCityPostOffices.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBCityPostOffices.Depth = 0;
            CMBCityPostOffices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBCityPostOffices.DropDownHeight = 174;
            CMBCityPostOffices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBCityPostOffices.DropDownWidth = 121;
            CMBCityPostOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBCityPostOffices.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBCityPostOffices.FormattingEnabled = true;
            CMBCityPostOffices.IntegralHeight = false;
            CMBCityPostOffices.ItemHeight = 43;
            CMBCityPostOffices.Location = new System.Drawing.Point(182, 152);
            CMBCityPostOffices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBCityPostOffices.MaxDropDownItems = 4;
            CMBCityPostOffices.MouseState = MaterialSkin.MouseState.OUT;
            CMBCityPostOffices.Name = "CMBCityPostOffices";
            CMBCityPostOffices.Size = new System.Drawing.Size(304, 49);
            CMBCityPostOffices.StartIndex = 0;
            CMBCityPostOffices.TabIndex = 14;
            // 
            // TxtBoxNamePostOffices
            // 
            TxtBoxNamePostOffices.AnimateReadOnly = false;
            TxtBoxNamePostOffices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxNamePostOffices.Depth = 0;
            TxtBoxNamePostOffices.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxNamePostOffices.LeadingIcon = null;
            TxtBoxNamePostOffices.Location = new System.Drawing.Point(182, 233);
            TxtBoxNamePostOffices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxNamePostOffices.MaxLength = 50;
            TxtBoxNamePostOffices.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxNamePostOffices.Multiline = false;
            TxtBoxNamePostOffices.Name = "TxtBoxNamePostOffices";
            TxtBoxNamePostOffices.Size = new System.Drawing.Size(304, 50);
            TxtBoxNamePostOffices.TabIndex = 13;
            TxtBoxNamePostOffices.Text = "";
            TxtBoxNamePostOffices.TrailingIcon = null;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel15.Location = new System.Drawing.Point(125, 249);
            materialLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new System.Drawing.Size(43, 19);
            materialLabel15.TabIndex = 12;
            materialLabel15.Text = "Name";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel5.Location = new System.Drawing.Point(142, 168);
            materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new System.Drawing.Size(28, 19);
            materialLabel5.TabIndex = 10;
            materialLabel5.Text = "City";
            // 
            // TxtBoxCntctNPostOffices
            // 
            TxtBoxCntctNPostOffices.AnimateReadOnly = false;
            TxtBoxCntctNPostOffices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxCntctNPostOffices.Depth = 0;
            TxtBoxCntctNPostOffices.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxCntctNPostOffices.LeadingIcon = null;
            TxtBoxCntctNPostOffices.Location = new System.Drawing.Point(182, 311);
            TxtBoxCntctNPostOffices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxCntctNPostOffices.MaxLength = 50;
            TxtBoxCntctNPostOffices.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxCntctNPostOffices.Multiline = false;
            TxtBoxCntctNPostOffices.Name = "TxtBoxCntctNPostOffices";
            TxtBoxCntctNPostOffices.Size = new System.Drawing.Size(304, 50);
            TxtBoxCntctNPostOffices.TabIndex = 9;
            TxtBoxCntctNPostOffices.Text = "";
            TxtBoxCntctNPostOffices.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel9.Location = new System.Drawing.Point(29, 327);
            materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new System.Drawing.Size(125, 19);
            materialLabel9.TabIndex = 8;
            materialLabel9.Text = "Contact number\r\n";
            // 
            // TxtBoxAddressPostOffices
            // 
            TxtBoxAddressPostOffices.AnimateReadOnly = false;
            TxtBoxAddressPostOffices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxAddressPostOffices.Depth = 0;
            TxtBoxAddressPostOffices.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxAddressPostOffices.LeadingIcon = null;
            TxtBoxAddressPostOffices.Location = new System.Drawing.Point(182, 68);
            TxtBoxAddressPostOffices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxAddressPostOffices.MaxLength = 50;
            TxtBoxAddressPostOffices.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxAddressPostOffices.Multiline = false;
            TxtBoxAddressPostOffices.Name = "TxtBoxAddressPostOffices";
            TxtBoxAddressPostOffices.Size = new System.Drawing.Size(304, 50);
            TxtBoxAddressPostOffices.TabIndex = 3;
            TxtBoxAddressPostOffices.Text = "";
            TxtBoxAddressPostOffices.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel7.Location = new System.Drawing.Point(107, 86);
            materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new System.Drawing.Size(58, 19);
            materialLabel7.TabIndex = 2;
            materialLabel7.Text = "Address";
            // 
            // DGVOffices
            // 
            DGVOffices.AllowUserToAddRows = false;
            DGVOffices.AllowUserToDeleteRows = false;
            DGVOffices.AllowUserToResizeColumns = false;
            DGVOffices.AllowUserToResizeRows = false;
            DGVOffices.BackgroundColor = System.Drawing.SystemColors.Control;
            DGVOffices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DGVOffices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DGVOffices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DGVOffices.ColumnHeadersHeight = 45;
            DGVOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVOffices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PostOfficeId, PostOfficeAddress, PostOfficeCity, PostOfficeName, PostOfficeNumber });
            DGVOffices.Dock = System.Windows.Forms.DockStyle.Left;
            DGVOffices.EnableHeadersVisualStyles = false;
            DGVOffices.GridColor = System.Drawing.SystemColors.Control;
            DGVOffices.Location = new System.Drawing.Point(0, 48);
            DGVOffices.Margin = new System.Windows.Forms.Padding(0);
            DGVOffices.MultiSelect = false;
            DGVOffices.Name = "DGVOffices";
            DGVOffices.ReadOnly = true;
            DGVOffices.RowHeadersVisible = false;
            DGVOffices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGVOffices.Size = new System.Drawing.Size(705, 447);
            DGVOffices.TabIndex = 6;
            // 
            // PostOfficeId
            // 
            PostOfficeId.HeaderText = "Id";
            PostOfficeId.Name = "PostOfficeId";
            PostOfficeId.ReadOnly = true;
            PostOfficeId.Width = 60;
            // 
            // PostOfficeAddress
            // 
            PostOfficeAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PostOfficeAddress.FillWeight = 23.64963F;
            PostOfficeAddress.HeaderText = "Address";
            PostOfficeAddress.Name = "PostOfficeAddress";
            PostOfficeAddress.ReadOnly = true;
            // 
            // PostOfficeCity
            // 
            PostOfficeCity.HeaderText = "City";
            PostOfficeCity.Name = "PostOfficeCity";
            PostOfficeCity.ReadOnly = true;
            // 
            // PostOfficeName
            // 
            PostOfficeName.HeaderText = "Name";
            PostOfficeName.Name = "PostOfficeName";
            PostOfficeName.ReadOnly = true;
            // 
            // PostOfficeNumber
            // 
            PostOfficeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PostOfficeNumber.FillWeight = 23.64963F;
            PostOfficeNumber.HeaderText = "Contact number";
            PostOfficeNumber.Name = "PostOfficeNumber";
            PostOfficeNumber.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel3.Controls.Add(BtnDeletePostOffices, 2, 0);
            tableLayoutPanel3.Controls.Add(BtnEditPostOffices, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnAddPostOffices, 0, 0);
            tableLayoutPanel3.Controls.Add(BtnRefreshPostOffices, 3, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1284, 48);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // BtnDeletePostOffices
            // 
            BtnDeletePostOffices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnDeletePostOffices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDeletePostOffices.Depth = 0;
            BtnDeletePostOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnDeletePostOffices.FlatAppearance.BorderSize = 0;
            BtnDeletePostOffices.HighEmphasis = true;
            BtnDeletePostOffices.Icon = null;
            BtnDeletePostOffices.Location = new System.Drawing.Point(215, 7);
            BtnDeletePostOffices.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnDeletePostOffices.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDeletePostOffices.Name = "BtnDeletePostOffices";
            BtnDeletePostOffices.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnDeletePostOffices.Size = new System.Drawing.Size(95, 28);
            BtnDeletePostOffices.TabIndex = 5;
            BtnDeletePostOffices.Text = "Delete";
            BtnDeletePostOffices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnDeletePostOffices.UseAccentColor = false;
            BtnDeletePostOffices.UseVisualStyleBackColor = true;
            BtnDeletePostOffices.Click += BtnDeletePostOffices_Click;
            // 
            // BtnEditPostOffices
            // 
            BtnEditPostOffices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnEditPostOffices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditPostOffices.Depth = 0;
            BtnEditPostOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnEditPostOffices.FlatAppearance.BorderSize = 0;
            BtnEditPostOffices.HighEmphasis = true;
            BtnEditPostOffices.Icon = null;
            BtnEditPostOffices.Location = new System.Drawing.Point(111, 7);
            BtnEditPostOffices.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnEditPostOffices.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditPostOffices.Name = "BtnEditPostOffices";
            BtnEditPostOffices.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnEditPostOffices.Size = new System.Drawing.Size(94, 28);
            BtnEditPostOffices.TabIndex = 4;
            BtnEditPostOffices.Text = "Edit";
            BtnEditPostOffices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEditPostOffices.UseAccentColor = false;
            BtnEditPostOffices.UseVisualStyleBackColor = true;
            BtnEditPostOffices.Click += BtnEditPostOffices_Click;
            // 
            // BtnAddPostOffices
            // 
            BtnAddPostOffices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnAddPostOffices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAddPostOffices.Depth = 0;
            BtnAddPostOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnAddPostOffices.FlatAppearance.BorderSize = 0;
            BtnAddPostOffices.HighEmphasis = true;
            BtnAddPostOffices.Icon = null;
            BtnAddPostOffices.Location = new System.Drawing.Point(5, 7);
            BtnAddPostOffices.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnAddPostOffices.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAddPostOffices.Name = "BtnAddPostOffices";
            BtnAddPostOffices.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnAddPostOffices.Size = new System.Drawing.Size(96, 28);
            BtnAddPostOffices.TabIndex = 1;
            BtnAddPostOffices.Text = "Add";
            BtnAddPostOffices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAddPostOffices.UseAccentColor = false;
            BtnAddPostOffices.UseVisualStyleBackColor = true;
            BtnAddPostOffices.Click += BtnPostOffices_Click;
            // 
            // BtnRefreshPostOffices
            // 
            BtnRefreshPostOffices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnRefreshPostOffices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRefreshPostOffices.Depth = 0;
            BtnRefreshPostOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnRefreshPostOffices.FlatAppearance.BorderSize = 0;
            BtnRefreshPostOffices.HighEmphasis = true;
            BtnRefreshPostOffices.Icon = null;
            BtnRefreshPostOffices.Location = new System.Drawing.Point(320, 7);
            BtnRefreshPostOffices.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnRefreshPostOffices.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRefreshPostOffices.Name = "BtnRefreshPostOffices";
            BtnRefreshPostOffices.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnRefreshPostOffices.Size = new System.Drawing.Size(95, 28);
            BtnRefreshPostOffices.TabIndex = 3;
            BtnRefreshPostOffices.Text = "Refresh";
            BtnRefreshPostOffices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRefreshPostOffices.UseAccentColor = false;
            BtnRefreshPostOffices.UseVisualStyleBackColor = true;
            BtnRefreshPostOffices.Click += BtnRefreshPostOffices_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.White;
            tabPage3.Controls.Add(DGVPersonnel);
            tabPage3.Controls.Add(panel2);
            tabPage3.Controls.Add(tableLayoutPanel1);
            tabPage3.ImageKey = "contact_page_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage3.Location = new System.Drawing.Point(4, 39);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(1284, 495);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Personnel";
            // 
            // DGVPersonnel
            // 
            DGVPersonnel.AllowUserToAddRows = false;
            DGVPersonnel.AllowUserToDeleteRows = false;
            DGVPersonnel.AllowUserToResizeColumns = false;
            DGVPersonnel.AllowUserToResizeRows = false;
            DGVPersonnel.BackgroundColor = System.Drawing.SystemColors.Control;
            DGVPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DGVPersonnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DGVPersonnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DGVPersonnel.ColumnHeadersHeight = 45;
            DGVPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PersonnelId, PersonnelName, PersonnelSurname, PersonnelPhoneNumber, PersonnelEmail, PersonnelDepartment, PersonnelPosition });
            DGVPersonnel.Dock = System.Windows.Forms.DockStyle.Left;
            DGVPersonnel.EnableHeadersVisualStyles = false;
            DGVPersonnel.GridColor = System.Drawing.SystemColors.Control;
            DGVPersonnel.Location = new System.Drawing.Point(0, 48);
            DGVPersonnel.Margin = new System.Windows.Forms.Padding(0);
            DGVPersonnel.MultiSelect = false;
            DGVPersonnel.Name = "DGVPersonnel";
            DGVPersonnel.ReadOnly = true;
            DGVPersonnel.RowHeadersVisible = false;
            DGVPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGVPersonnel.Size = new System.Drawing.Size(686, 447);
            DGVPersonnel.TabIndex = 8;
            // 
            // PersonnelId
            // 
            PersonnelId.HeaderText = "Id";
            PersonnelId.Name = "PersonnelId";
            PersonnelId.ReadOnly = true;
            PersonnelId.Width = 60;
            // 
            // PersonnelName
            // 
            PersonnelName.HeaderText = "Name";
            PersonnelName.Name = "PersonnelName";
            PersonnelName.ReadOnly = true;
            // 
            // PersonnelSurname
            // 
            PersonnelSurname.HeaderText = "Surname";
            PersonnelSurname.Name = "PersonnelSurname";
            PersonnelSurname.ReadOnly = true;
            // 
            // PersonnelPhoneNumber
            // 
            PersonnelPhoneNumber.HeaderText = "Number";
            PersonnelPhoneNumber.Name = "PersonnelPhoneNumber";
            PersonnelPhoneNumber.ReadOnly = true;
            // 
            // PersonnelEmail
            // 
            PersonnelEmail.HeaderText = "Email";
            PersonnelEmail.Name = "PersonnelEmail";
            PersonnelEmail.ReadOnly = true;
            // 
            // PersonnelDepartment
            // 
            PersonnelDepartment.HeaderText = "Office";
            PersonnelDepartment.Name = "PersonnelDepartment";
            PersonnelDepartment.ReadOnly = true;
            // 
            // PersonnelPosition
            // 
            PersonnelPosition.HeaderText = "Position";
            PersonnelPosition.Name = "PersonnelPosition";
            PersonnelPosition.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(CMBPositionPersonnel);
            panel2.Controls.Add(CMBDepartmentPersonnel);
            panel2.Controls.Add(materialLabel11);
            panel2.Controls.Add(materialLabel10);
            panel2.Controls.Add(TxtBoxEmailPersonnel);
            panel2.Controls.Add(materialLabel6);
            panel2.Controls.Add(TxtBoxPhonePersonnel);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(TxtBoxSurnamePersonnel);
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(TxtBoxNamePersonnel);
            panel2.Controls.Add(materialLabel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(753, 48);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(531, 447);
            panel2.TabIndex = 7;
            // 
            // CMBPositionPersonnel
            // 
            CMBPositionPersonnel.AutoResize = false;
            CMBPositionPersonnel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBPositionPersonnel.Depth = 0;
            CMBPositionPersonnel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBPositionPersonnel.DropDownHeight = 174;
            CMBPositionPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBPositionPersonnel.DropDownWidth = 121;
            CMBPositionPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBPositionPersonnel.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBPositionPersonnel.FormattingEnabled = true;
            CMBPositionPersonnel.IntegralHeight = false;
            CMBPositionPersonnel.ItemHeight = 43;
            CMBPositionPersonnel.Items.AddRange(new object[] { "Shipping Coordinator", "Warehouse Supervisor", "Logistics Coordinator", "Freight Forwarder", "Customs Broker", "Packaging Specialist", "Inventory Control Specialist", "Customer Service Representative", "Route Planner", "Shipping Clerk" });
            CMBPositionPersonnel.Location = new System.Drawing.Point(204, 317);
            CMBPositionPersonnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBPositionPersonnel.MaxDropDownItems = 4;
            CMBPositionPersonnel.MouseState = MaterialSkin.MouseState.OUT;
            CMBPositionPersonnel.Name = "CMBPositionPersonnel";
            CMBPositionPersonnel.Size = new System.Drawing.Size(284, 49);
            CMBPositionPersonnel.StartIndex = 0;
            CMBPositionPersonnel.TabIndex = 13;
            // 
            // CMBDepartmentPersonnel
            // 
            CMBDepartmentPersonnel.AutoResize = false;
            CMBDepartmentPersonnel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBDepartmentPersonnel.Depth = 0;
            CMBDepartmentPersonnel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBDepartmentPersonnel.DropDownHeight = 174;
            CMBDepartmentPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBDepartmentPersonnel.DropDownWidth = 121;
            CMBDepartmentPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBDepartmentPersonnel.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBDepartmentPersonnel.FormattingEnabled = true;
            CMBDepartmentPersonnel.IntegralHeight = false;
            CMBDepartmentPersonnel.ItemHeight = 43;
            CMBDepartmentPersonnel.Location = new System.Drawing.Point(204, 238);
            CMBDepartmentPersonnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBDepartmentPersonnel.MaxDropDownItems = 4;
            CMBDepartmentPersonnel.MouseState = MaterialSkin.MouseState.OUT;
            CMBDepartmentPersonnel.Name = "CMBDepartmentPersonnel";
            CMBDepartmentPersonnel.Size = new System.Drawing.Size(284, 49);
            CMBDepartmentPersonnel.StartIndex = 0;
            CMBDepartmentPersonnel.TabIndex = 12;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel11.Location = new System.Drawing.Point(128, 336);
            materialLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new System.Drawing.Size(59, 19);
            materialLabel11.TabIndex = 11;
            materialLabel11.Text = "Position";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel10.Location = new System.Drawing.Point(99, 258);
            materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new System.Drawing.Size(84, 19);
            materialLabel10.TabIndex = 10;
            materialLabel10.Text = "Department";
            // 
            // TxtBoxEmailPersonnel
            // 
            TxtBoxEmailPersonnel.AnimateReadOnly = false;
            TxtBoxEmailPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxEmailPersonnel.Depth = 0;
            TxtBoxEmailPersonnel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxEmailPersonnel.LeadingIcon = null;
            TxtBoxEmailPersonnel.Location = new System.Drawing.Point(323, 167);
            TxtBoxEmailPersonnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxEmailPersonnel.MaxLength = 50;
            TxtBoxEmailPersonnel.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxEmailPersonnel.Multiline = false;
            TxtBoxEmailPersonnel.Name = "TxtBoxEmailPersonnel";
            TxtBoxEmailPersonnel.Size = new System.Drawing.Size(166, 50);
            TxtBoxEmailPersonnel.TabIndex = 9;
            TxtBoxEmailPersonnel.Text = "";
            TxtBoxEmailPersonnel.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel6.Location = new System.Drawing.Point(268, 186);
            materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new System.Drawing.Size(41, 19);
            materialLabel6.TabIndex = 8;
            materialLabel6.Text = "Email";
            // 
            // TxtBoxPhonePersonnel
            // 
            TxtBoxPhonePersonnel.AnimateReadOnly = false;
            TxtBoxPhonePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxPhonePersonnel.Depth = 0;
            TxtBoxPhonePersonnel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxPhonePersonnel.LeadingIcon = null;
            TxtBoxPhonePersonnel.Location = new System.Drawing.Point(323, 103);
            TxtBoxPhonePersonnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxPhonePersonnel.MaxLength = 50;
            TxtBoxPhonePersonnel.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxPhonePersonnel.Multiline = false;
            TxtBoxPhonePersonnel.Name = "TxtBoxPhonePersonnel";
            TxtBoxPhonePersonnel.Size = new System.Drawing.Size(166, 50);
            TxtBoxPhonePersonnel.TabIndex = 7;
            TxtBoxPhonePersonnel.Text = "";
            TxtBoxPhonePersonnel.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.Location = new System.Drawing.Point(195, 123);
            materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(104, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Phone number";
            // 
            // TxtBoxSurnamePersonnel
            // 
            TxtBoxSurnamePersonnel.AnimateReadOnly = false;
            TxtBoxSurnamePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxSurnamePersonnel.Depth = 0;
            TxtBoxSurnamePersonnel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxSurnamePersonnel.LeadingIcon = null;
            TxtBoxSurnamePersonnel.Location = new System.Drawing.Point(204, 37);
            TxtBoxSurnamePersonnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxSurnamePersonnel.MaxLength = 50;
            TxtBoxSurnamePersonnel.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxSurnamePersonnel.Multiline = false;
            TxtBoxSurnamePersonnel.Name = "TxtBoxSurnamePersonnel";
            TxtBoxSurnamePersonnel.Size = new System.Drawing.Size(166, 50);
            TxtBoxSurnamePersonnel.TabIndex = 5;
            TxtBoxSurnamePersonnel.Text = "";
            TxtBoxSurnamePersonnel.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.Location = new System.Drawing.Point(121, 53);
            materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(65, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Surname";
            // 
            // TxtBoxNamePersonnel
            // 
            TxtBoxNamePersonnel.AnimateReadOnly = false;
            TxtBoxNamePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxNamePersonnel.Depth = 0;
            TxtBoxNamePersonnel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxNamePersonnel.LeadingIcon = null;
            TxtBoxNamePersonnel.Location = new System.Drawing.Point(69, 104);
            TxtBoxNamePersonnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxNamePersonnel.MaxLength = 50;
            TxtBoxNamePersonnel.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxNamePersonnel.Multiline = false;
            TxtBoxNamePersonnel.Name = "TxtBoxNamePersonnel";
            TxtBoxNamePersonnel.Size = new System.Drawing.Size(121, 50);
            TxtBoxNamePersonnel.TabIndex = 3;
            TxtBoxNamePersonnel.Text = "";
            TxtBoxNamePersonnel.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.Location = new System.Drawing.Point(12, 128);
            materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(43, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel1.Controls.Add(BtnDeletePesonnel, 2, 0);
            tableLayoutPanel1.Controls.Add(BtnEditPesonnel, 1, 0);
            tableLayoutPanel1.Controls.Add(BtnAddPesonnel, 0, 0);
            tableLayoutPanel1.Controls.Add(BtnRefreshPesonnel, 3, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1284, 48);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // BtnDeletePesonnel
            // 
            BtnDeletePesonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnDeletePesonnel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDeletePesonnel.Depth = 0;
            BtnDeletePesonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnDeletePesonnel.FlatAppearance.BorderSize = 0;
            BtnDeletePesonnel.HighEmphasis = true;
            BtnDeletePesonnel.Icon = null;
            BtnDeletePesonnel.Location = new System.Drawing.Point(215, 7);
            BtnDeletePesonnel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnDeletePesonnel.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDeletePesonnel.Name = "BtnDeletePesonnel";
            BtnDeletePesonnel.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnDeletePesonnel.Size = new System.Drawing.Size(95, 28);
            BtnDeletePesonnel.TabIndex = 5;
            BtnDeletePesonnel.Text = "Delete";
            BtnDeletePesonnel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnDeletePesonnel.UseAccentColor = false;
            BtnDeletePesonnel.UseVisualStyleBackColor = true;
            BtnDeletePesonnel.Click += BtnDeletePesonnel_Click;
            // 
            // BtnEditPesonnel
            // 
            BtnEditPesonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnEditPesonnel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditPesonnel.Depth = 0;
            BtnEditPesonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnEditPesonnel.FlatAppearance.BorderSize = 0;
            BtnEditPesonnel.HighEmphasis = true;
            BtnEditPesonnel.Icon = null;
            BtnEditPesonnel.Location = new System.Drawing.Point(111, 7);
            BtnEditPesonnel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnEditPesonnel.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditPesonnel.Name = "BtnEditPesonnel";
            BtnEditPesonnel.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnEditPesonnel.Size = new System.Drawing.Size(94, 28);
            BtnEditPesonnel.TabIndex = 4;
            BtnEditPesonnel.Text = "Edit";
            BtnEditPesonnel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEditPesonnel.UseAccentColor = false;
            BtnEditPesonnel.UseVisualStyleBackColor = true;
            BtnEditPesonnel.Click += BtnEditPesonnel_Click;
            // 
            // BtnAddPesonnel
            // 
            BtnAddPesonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnAddPesonnel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAddPesonnel.Depth = 0;
            BtnAddPesonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnAddPesonnel.FlatAppearance.BorderSize = 0;
            BtnAddPesonnel.HighEmphasis = true;
            BtnAddPesonnel.Icon = null;
            BtnAddPesonnel.Location = new System.Drawing.Point(5, 7);
            BtnAddPesonnel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnAddPesonnel.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAddPesonnel.Name = "BtnAddPesonnel";
            BtnAddPesonnel.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnAddPesonnel.Size = new System.Drawing.Size(96, 28);
            BtnAddPesonnel.TabIndex = 1;
            BtnAddPesonnel.Text = "Add";
            BtnAddPesonnel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAddPesonnel.UseAccentColor = false;
            BtnAddPesonnel.UseVisualStyleBackColor = true;
            BtnAddPesonnel.Click += BtnAddPesonnel_Click;
            // 
            // BtnRefreshPesonnel
            // 
            BtnRefreshPesonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnRefreshPesonnel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRefreshPesonnel.Depth = 0;
            BtnRefreshPesonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnRefreshPesonnel.FlatAppearance.BorderSize = 0;
            BtnRefreshPesonnel.HighEmphasis = true;
            BtnRefreshPesonnel.Icon = null;
            BtnRefreshPesonnel.Location = new System.Drawing.Point(320, 7);
            BtnRefreshPesonnel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnRefreshPesonnel.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRefreshPesonnel.Name = "BtnRefreshPesonnel";
            BtnRefreshPesonnel.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnRefreshPesonnel.Size = new System.Drawing.Size(95, 28);
            BtnRefreshPesonnel.TabIndex = 3;
            BtnRefreshPesonnel.Text = "Refresh";
            BtnRefreshPesonnel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRefreshPesonnel.UseAccentColor = false;
            BtnRefreshPesonnel.UseVisualStyleBackColor = true;
            BtnRefreshPesonnel.Click += BtnRefreshPesonnel_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = System.Drawing.Color.White;
            tabPage5.Controls.Add(panel4);
            tabPage5.Controls.Add(DGVParcels);
            tabPage5.Controls.Add(tableLayoutPanel4);
            tabPage5.ImageKey = "package_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage5.Location = new System.Drawing.Point(4, 39);
            tabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new System.Drawing.Size(1284, 495);
            tabPage5.TabIndex = 3;
            tabPage5.Text = "Parcels";
            // 
            // panel4
            // 
            panel4.Controls.Add(CMBClientParcels);
            panel4.Controls.Add(materialLabel18);
            panel4.Controls.Add(CMBToParcels);
            panel4.Controls.Add(CMBFromParcels);
            panel4.Controls.Add(materialLabel4);
            panel4.Controls.Add(materialLabel8);
            panel4.Controls.Add(materialLabel16);
            panel4.Controls.Add(CMBStatusParcels);
            panel4.Controls.Add(TxtBoxCostParcels);
            panel4.Controls.Add(DTPDelieveryParcels);
            panel4.Controls.Add(DTPDispatchParcels);
            panel4.Controls.Add(materialLabel14);
            panel4.Controls.Add(materialLabel12);
            panel4.Controls.Add(materialLabel13);
            panel4.Controls.Add(TxtBoxWageParcels);
            panel4.Controls.Add(materialLabel17);
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(840, 48);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(444, 447);
            panel4.TabIndex = 10;
            // 
            // CMBFromParcels
            // 
            CMBFromParcels.AutoResize = false;
            CMBFromParcels.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBFromParcels.Depth = 0;
            CMBFromParcels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBFromParcels.DropDownHeight = 174;
            CMBFromParcels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBFromParcels.DropDownWidth = 121;
            CMBFromParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBFromParcels.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBFromParcels.FormattingEnabled = true;
            CMBFromParcels.IntegralHeight = false;
            CMBFromParcels.ItemHeight = 43;
            CMBFromParcels.Location = new System.Drawing.Point(109, 148);
            CMBFromParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBFromParcels.MaxDropDownItems = 4;
            CMBFromParcels.MouseState = MaterialSkin.MouseState.OUT;
            CMBFromParcels.Name = "CMBFromParcels";
            CMBFromParcels.Size = new System.Drawing.Size(284, 49);
            CMBFromParcels.StartIndex = 0;
            CMBFromParcels.TabIndex = 24;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel4.Location = new System.Drawing.Point(69, 245);
            materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(20, 19);
            materialLabel4.TabIndex = 22;
            materialLabel4.Text = "To";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel8.Location = new System.Drawing.Point(51, 162);
            materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new System.Drawing.Size(38, 19);
            materialLabel8.TabIndex = 20;
            materialLabel8.Text = "From";
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel16.Location = new System.Drawing.Point(44, 394);
            materialLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new System.Drawing.Size(47, 19);
            materialLabel16.TabIndex = 19;
            materialLabel16.Text = "Status";
            // 
            // CMBStatusParcels
            // 
            CMBStatusParcels.AutoResize = false;
            CMBStatusParcels.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBStatusParcels.Depth = 0;
            CMBStatusParcels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBStatusParcels.DropDownHeight = 174;
            CMBStatusParcels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBStatusParcels.DropDownWidth = 121;
            CMBStatusParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBStatusParcels.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBStatusParcels.FormattingEnabled = true;
            CMBStatusParcels.IntegralHeight = false;
            CMBStatusParcels.ItemHeight = 43;
            CMBStatusParcels.Items.AddRange(new object[] { "Waiting", "Paid", "Confirmed", "In delivery", "Delivered" });
            CMBStatusParcels.Location = new System.Drawing.Point(106, 373);
            CMBStatusParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBStatusParcels.MaxDropDownItems = 4;
            CMBStatusParcels.MouseState = MaterialSkin.MouseState.OUT;
            CMBStatusParcels.Name = "CMBStatusParcels";
            CMBStatusParcels.Size = new System.Drawing.Size(287, 49);
            CMBStatusParcels.StartIndex = 0;
            CMBStatusParcels.TabIndex = 18;
            // 
            // TxtBoxCostParcels
            // 
            TxtBoxCostParcels.AnimateReadOnly = false;
            TxtBoxCostParcels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxCostParcels.Depth = 0;
            TxtBoxCostParcels.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxCostParcels.LeadingIcon = null;
            TxtBoxCostParcels.Location = new System.Drawing.Point(106, 69);
            TxtBoxCostParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxCostParcels.MaxLength = 50;
            TxtBoxCostParcels.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxCostParcels.Multiline = false;
            TxtBoxCostParcels.Name = "TxtBoxCostParcels";
            TxtBoxCostParcels.Size = new System.Drawing.Size(126, 50);
            TxtBoxCostParcels.TabIndex = 17;
            TxtBoxCostParcels.Text = "";
            TxtBoxCostParcels.TrailingIcon = null;
            // 
            // DTPDelieveryParcels
            // 
            DTPDelieveryParcels.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTPDelieveryParcels.Location = new System.Drawing.Point(307, 84);
            DTPDelieveryParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTPDelieveryParcels.Name = "DTPDelieveryParcels";
            DTPDelieveryParcels.Size = new System.Drawing.Size(133, 23);
            DTPDelieveryParcels.TabIndex = 16;
            // 
            // DTPDispatchParcels
            // 
            DTPDispatchParcels.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DTPDispatchParcels.Location = new System.Drawing.Point(307, 37);
            DTPDispatchParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DTPDispatchParcels.Name = "DTPDispatchParcels";
            DTPDispatchParcels.Size = new System.Drawing.Size(133, 23);
            DTPDispatchParcels.TabIndex = 15;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel14.Location = new System.Drawing.Point(53, 88);
            materialLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new System.Drawing.Size(33, 19);
            materialLabel14.TabIndex = 14;
            materialLabel14.Text = "Cost";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel12.Location = new System.Drawing.Point(240, 84);
            materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new System.Drawing.Size(65, 19);
            materialLabel12.TabIndex = 11;
            materialLabel12.Text = "Delievery";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel13.Location = new System.Drawing.Point(240, 37);
            materialLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new System.Drawing.Size(64, 19);
            materialLabel13.TabIndex = 10;
            materialLabel13.Text = "Dispatch";
            // 
            // TxtBoxWageParcels
            // 
            TxtBoxWageParcels.AnimateReadOnly = false;
            TxtBoxWageParcels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtBoxWageParcels.Depth = 0;
            TxtBoxWageParcels.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            TxtBoxWageParcels.LeadingIcon = null;
            TxtBoxWageParcels.Location = new System.Drawing.Point(106, 13);
            TxtBoxWageParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtBoxWageParcels.MaxLength = 50;
            TxtBoxWageParcels.MouseState = MaterialSkin.MouseState.OUT;
            TxtBoxWageParcels.Multiline = false;
            TxtBoxWageParcels.Name = "TxtBoxWageParcels";
            TxtBoxWageParcels.Size = new System.Drawing.Size(126, 50);
            TxtBoxWageParcels.TabIndex = 3;
            TxtBoxWageParcels.Text = "";
            TxtBoxWageParcels.TrailingIcon = null;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel17.Location = new System.Drawing.Point(13, 37);
            materialLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new System.Drawing.Size(73, 19);
            materialLabel17.TabIndex = 2;
            materialLabel17.Text = "Wage (kg)";
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
            DGVParcels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ParcelsId, ParcelsWage, ParcelsDispatch, ParcelsDelievery, ParcelsCost, ParcelsFrom, ParcelsTo, ParcelsClient, ParcelsStatus });
            DGVParcels.Dock = System.Windows.Forms.DockStyle.Left;
            DGVParcels.EnableHeadersVisualStyles = false;
            DGVParcels.GridColor = System.Drawing.SystemColors.Control;
            DGVParcels.Location = new System.Drawing.Point(0, 48);
            DGVParcels.Margin = new System.Windows.Forms.Padding(0);
            DGVParcels.MultiSelect = false;
            DGVParcels.Name = "DGVParcels";
            DGVParcels.ReadOnly = true;
            DGVParcels.RowHeadersVisible = false;
            DGVParcels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGVParcels.Size = new System.Drawing.Size(1025, 447);
            DGVParcels.TabIndex = 9;
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
            ParcelsWage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ParcelsWage.FillWeight = 23.64963F;
            ParcelsWage.HeaderText = "Wage";
            ParcelsWage.Name = "ParcelsWage";
            ParcelsWage.ReadOnly = true;
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
            // ParcelsFrom
            // 
            ParcelsFrom.HeaderText = "From";
            ParcelsFrom.Name = "ParcelsFrom";
            ParcelsFrom.ReadOnly = true;
            // 
            // ParcelsTo
            // 
            ParcelsTo.HeaderText = "To";
            ParcelsTo.Name = "ParcelsTo";
            ParcelsTo.ReadOnly = true;
            // 
            // ParcelsClient
            // 
            ParcelsClient.HeaderText = "Client";
            ParcelsClient.Name = "ParcelsClient";
            ParcelsClient.ReadOnly = true;
            // 
            // ParcelsStatus
            // 
            ParcelsStatus.HeaderText = "Status";
            ParcelsStatus.Name = "ParcelsStatus";
            ParcelsStatus.ReadOnly = true;
            ParcelsStatus.Width = 334;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel4.Controls.Add(BtnDeleteParcels, 2, 0);
            tableLayoutPanel4.Controls.Add(BtnEditParcels, 1, 0);
            tableLayoutPanel4.Controls.Add(BtnAddParcels, 0, 0);
            tableLayoutPanel4.Controls.Add(BtnRefreshParcels, 3, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1284, 48);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // BtnDeleteParcels
            // 
            BtnDeleteParcels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnDeleteParcels.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDeleteParcels.Depth = 0;
            BtnDeleteParcels.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnDeleteParcels.FlatAppearance.BorderSize = 0;
            BtnDeleteParcels.HighEmphasis = true;
            BtnDeleteParcels.Icon = null;
            BtnDeleteParcels.Location = new System.Drawing.Point(215, 7);
            BtnDeleteParcels.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnDeleteParcels.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDeleteParcels.Name = "BtnDeleteParcels";
            BtnDeleteParcels.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnDeleteParcels.Size = new System.Drawing.Size(95, 28);
            BtnDeleteParcels.TabIndex = 5;
            BtnDeleteParcels.Text = "Delete";
            BtnDeleteParcels.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnDeleteParcels.UseAccentColor = false;
            BtnDeleteParcels.UseVisualStyleBackColor = true;
            BtnDeleteParcels.Click += BtnDeleteParcels_Click;
            // 
            // BtnEditParcels
            // 
            BtnEditParcels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnEditParcels.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditParcels.Depth = 0;
            BtnEditParcels.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnEditParcels.FlatAppearance.BorderSize = 0;
            BtnEditParcels.HighEmphasis = true;
            BtnEditParcels.Icon = null;
            BtnEditParcels.Location = new System.Drawing.Point(111, 7);
            BtnEditParcels.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnEditParcels.MouseState = MaterialSkin.MouseState.HOVER;
            BtnEditParcels.Name = "BtnEditParcels";
            BtnEditParcels.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnEditParcels.Size = new System.Drawing.Size(94, 28);
            BtnEditParcels.TabIndex = 4;
            BtnEditParcels.Text = "Edit";
            BtnEditParcels.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEditParcels.UseAccentColor = false;
            BtnEditParcels.UseVisualStyleBackColor = true;
            BtnEditParcels.Click += BtnEditParcels_Click;
            // 
            // BtnAddParcels
            // 
            BtnAddParcels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnAddParcels.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAddParcels.Depth = 0;
            BtnAddParcels.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnAddParcels.FlatAppearance.BorderSize = 0;
            BtnAddParcels.HighEmphasis = true;
            BtnAddParcels.Icon = null;
            BtnAddParcels.Location = new System.Drawing.Point(5, 7);
            BtnAddParcels.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnAddParcels.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAddParcels.Name = "BtnAddParcels";
            BtnAddParcels.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnAddParcels.Size = new System.Drawing.Size(96, 28);
            BtnAddParcels.TabIndex = 1;
            BtnAddParcels.Text = "Add";
            BtnAddParcels.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAddParcels.UseAccentColor = false;
            BtnAddParcels.UseVisualStyleBackColor = true;
            BtnAddParcels.Click += BtnAddParcels_Click;
            // 
            // BtnRefreshParcels
            // 
            BtnRefreshParcels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnRefreshParcels.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRefreshParcels.Depth = 0;
            BtnRefreshParcels.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnRefreshParcels.FlatAppearance.BorderSize = 0;
            BtnRefreshParcels.HighEmphasis = true;
            BtnRefreshParcels.Icon = null;
            BtnRefreshParcels.Location = new System.Drawing.Point(320, 7);
            BtnRefreshParcels.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            BtnRefreshParcels.MouseState = MaterialSkin.MouseState.HOVER;
            BtnRefreshParcels.Name = "BtnRefreshParcels";
            BtnRefreshParcels.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnRefreshParcels.Size = new System.Drawing.Size(95, 28);
            BtnRefreshParcels.TabIndex = 3;
            BtnRefreshParcels.Text = "Refresh";
            BtnRefreshParcels.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRefreshParcels.UseAccentColor = false;
            BtnRefreshParcels.UseVisualStyleBackColor = true;
            BtnRefreshParcels.Click += BtnRefreshParcels_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.White;
            tabPage2.ImageKey = "logout_FILL0_wght600_GRAD0_opsz48.ico";
            tabPage2.Location = new System.Drawing.Point(4, 39);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new System.Drawing.Size(1284, 495);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Logout";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "contact_page_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(1, "home_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(2, "local_post_office_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(3, "package_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(4, "logout_FILL0_wght600_GRAD0_opsz48.ico");
            imageList1.Images.SetKeyName(5, "add_home_work_FILL0_wght600_GRAD0_opsz48.ico");
            // 
            // BtnSAdd
            // 
            BtnSAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnSAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnSAdd.Depth = 0;
            BtnSAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnSAdd.FlatAppearance.BorderSize = 0;
            BtnSAdd.HighEmphasis = true;
            BtnSAdd.Icon = null;
            BtnSAdd.Location = new System.Drawing.Point(4, 6);
            BtnSAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            BtnSAdd.MouseState = MaterialSkin.MouseState.HOVER;
            BtnSAdd.Name = "BtnSAdd";
            BtnSAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnSAdd.Size = new System.Drawing.Size(82, 25);
            BtnSAdd.TabIndex = 0;
            BtnSAdd.Text = "Add";
            BtnSAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnSAdd.UseAccentColor = false;
            BtnSAdd.UseVisualStyleBackColor = true;
            // 
            // BtnSEdit
            // 
            BtnSEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnSEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnSEdit.Depth = 0;
            BtnSEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnSEdit.FlatAppearance.BorderSize = 0;
            BtnSEdit.HighEmphasis = true;
            BtnSEdit.Icon = null;
            BtnSEdit.Location = new System.Drawing.Point(94, 6);
            BtnSEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            BtnSEdit.MouseState = MaterialSkin.MouseState.HOVER;
            BtnSEdit.Name = "BtnSEdit";
            BtnSEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnSEdit.Size = new System.Drawing.Size(82, 25);
            BtnSEdit.TabIndex = 1;
            BtnSEdit.Text = "Edit";
            BtnSEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnSEdit.UseAccentColor = false;
            BtnSEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDelete.Depth = 0;
            BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.HighEmphasis = true;
            BtnDelete.Icon = null;
            BtnDelete.Location = new System.Drawing.Point(184, 6);
            BtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            BtnDelete.Size = new System.Drawing.Size(82, 25);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnDelete.UseAccentColor = false;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // CMBToParcels
            // 
            CMBToParcels.AutoResize = false;
            CMBToParcels.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBToParcels.Depth = 0;
            CMBToParcels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBToParcels.DropDownHeight = 174;
            CMBToParcels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBToParcels.DropDownWidth = 121;
            CMBToParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBToParcels.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBToParcels.FormattingEnabled = true;
            CMBToParcels.IntegralHeight = false;
            CMBToParcels.ItemHeight = 43;
            CMBToParcels.Location = new System.Drawing.Point(109, 226);
            CMBToParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBToParcels.MaxDropDownItems = 4;
            CMBToParcels.MouseState = MaterialSkin.MouseState.OUT;
            CMBToParcels.Name = "CMBToParcels";
            CMBToParcels.Size = new System.Drawing.Size(284, 49);
            CMBToParcels.StartIndex = 0;
            CMBToParcels.TabIndex = 26;
            // 
            // CMBClientParcels
            // 
            CMBClientParcels.AutoResize = false;
            CMBClientParcels.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            CMBClientParcels.Depth = 0;
            CMBClientParcels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            CMBClientParcels.DropDownHeight = 174;
            CMBClientParcels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CMBClientParcels.DropDownWidth = 121;
            CMBClientParcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            CMBClientParcels.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            CMBClientParcels.FormattingEnabled = true;
            CMBClientParcels.IntegralHeight = false;
            CMBClientParcels.ItemHeight = 43;
            CMBClientParcels.Location = new System.Drawing.Point(109, 303);
            CMBClientParcels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CMBClientParcels.MaxDropDownItems = 4;
            CMBClientParcels.MouseState = MaterialSkin.MouseState.OUT;
            CMBClientParcels.Name = "CMBClientParcels";
            CMBClientParcels.Size = new System.Drawing.Size(284, 49);
            CMBClientParcels.StartIndex = 0;
            CMBClientParcels.TabIndex = 28;
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel18.Location = new System.Drawing.Point(60, 321);
            materialLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new System.Drawing.Size(41, 19);
            materialLabel18.TabIndex = 27;
            materialLabel18.Text = "Client";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1300, 615);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AdminForm";
            Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ShippingApp";
            Load += AdminForm_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCities).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVOffices).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVPersonnel).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVParcels).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialButton BtnSAdd;
        private MaterialSkin.Controls.MaterialButton BtnSEdit;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVCities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton BtnDeleteCities;
        private MaterialSkin.Controls.MaterialButton BtnEditCities;
        private MaterialSkin.Controls.MaterialButton BtnAddCities;
        private MaterialSkin.Controls.MaterialButton BtnRefreshCities;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxZipCode;
        private MaterialSkin.Controls.MaterialLabel LblZipCode;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxCountryCities;
        private MaterialSkin.Controls.MaterialLabel LblCountryCities;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxNameCities;
        private MaterialSkin.Controls.MaterialLabel LblNameCities;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxAddressPostOffices;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DataGridView DGVOffices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton BtnDeletePostOffices;
        private MaterialSkin.Controls.MaterialButton BtnEditPostOffices;
        private MaterialSkin.Controls.MaterialButton BtnAddPostOffices;
        private MaterialSkin.Controls.MaterialButton BtnRefreshPostOffices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton BtnDeletePesonnel;
        private MaterialSkin.Controls.MaterialButton BtnEditPesonnel;
        private MaterialSkin.Controls.MaterialButton BtnAddPesonnel;
        private MaterialSkin.Controls.MaterialButton BtnRefreshPesonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCities;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxCntctNPostOffices;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox CMBPositionPersonnel;
        private MaterialSkin.Controls.MaterialComboBox CMBDepartmentPersonnel;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxEmailPersonnel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxPhonePersonnel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxSurnamePersonnel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxNamePersonnel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxCostParcels;
        private System.Windows.Forms.DateTimePicker DTPDelieveryParcels;
        private System.Windows.Forms.DateTimePicker DTPDispatchParcels;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxWageParcels;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.DataGridView DGVParcels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton BtnDeleteParcels;
        private MaterialSkin.Controls.MaterialButton BtnEditParcels;
        private MaterialSkin.Controls.MaterialButton BtnAddParcels;
        private MaterialSkin.Controls.MaterialButton BtnRefreshParcels;
        private MaterialSkin.Controls.MaterialTextBox TxtBoxNamePostOffices;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostOfficeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostOfficeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostOfficeCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostOfficeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostOfficeNumber;
        private MaterialSkin.Controls.MaterialComboBox CMBCityPostOffices;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialComboBox CMBStatusParcels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelPosition;
        private MaterialSkin.Controls.MaterialComboBox CMBFromParcels;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsDispatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsDelievery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelsStatus;
        private MaterialSkin.Controls.MaterialComboBox CMBClientParcels;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialComboBox CMBToParcels;
    }
}

