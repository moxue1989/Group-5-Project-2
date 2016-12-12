namespace AgentApp
{
    partial class frmGUI
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
            this.tcPackages = new MetroFramework.Controls.MetroTabControl();
            this.tpPackages = new MetroFramework.Controls.MetroTabPage();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.cbPkgName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCommission = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtBasePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPkgDesc = new MetroFramework.Controls.MetroTextBox();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtProductId = new MetroFramework.Controls.MetroTextBox();
            this.cbProdList = new MetroFramework.Controls.MetroComboBox();
            this.tpAddons = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.tcPackages.SuspendLayout();
            this.tpPackages.SuspendLayout();
            this.tpAddons.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPackages
            // 
            this.tcPackages.AccessibleName = "";
            this.tcPackages.Controls.Add(this.tpPackages);
            this.tcPackages.Controls.Add(this.tpAddons);
            this.tcPackages.Location = new System.Drawing.Point(100, 76);
            this.tcPackages.Name = "tcPackages";
            this.tcPackages.SelectedIndex = 1;
            this.tcPackages.Size = new System.Drawing.Size(712, 394);
            this.tcPackages.Style = MetroFramework.MetroColorStyle.Teal;
            this.tcPackages.TabIndex = 0;
            this.tcPackages.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcPackages.UseStyleColors = true;
            // 
            // tpPackages
            // 
            this.tpPackages.BackColor = System.Drawing.Color.White;
            this.tpPackages.Controls.Add(this.mtAdd);
            this.tpPackages.Controls.Add(this.cbPkgName);
            this.tpPackages.Controls.Add(this.metroLabel8);
            this.tpPackages.Controls.Add(this.txtCommission);
            this.tpPackages.Controls.Add(this.metroLabel7);
            this.tpPackages.Controls.Add(this.txtBasePrice);
            this.tpPackages.Controls.Add(this.metroLabel6);
            this.tpPackages.Controls.Add(this.metroLabel5);
            this.tpPackages.Controls.Add(this.metroLabel4);
            this.tpPackages.Controls.Add(this.metroLabel3);
            this.tpPackages.Controls.Add(this.metroLabel2);
            this.tpPackages.Controls.Add(this.metroLabel1);
            this.tpPackages.Controls.Add(this.txtPkgDesc);
            this.tpPackages.Controls.Add(this.dpEndDate);
            this.tpPackages.Controls.Add(this.dpStartDate);
            this.tpPackages.Controls.Add(this.txtProductId);
            this.tpPackages.Controls.Add(this.cbProdList);
            this.tpPackages.CustomBackground = true;
            this.tpPackages.HorizontalScrollbarBarColor = true;
            this.tpPackages.Location = new System.Drawing.Point(4, 35);
            this.tpPackages.Name = "tpPackages";
            this.tpPackages.Size = new System.Drawing.Size(704, 355);
            this.tpPackages.TabIndex = 0;
            this.tpPackages.Text = "Packages";
            this.tpPackages.VerticalScrollbarBarColor = true;
            this.tpPackages.VerticalScrollbarSize = 12;
            // 
            // mtAdd
            // 
            this.mtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtAdd.CustomBackground = true;
            this.mtAdd.Location = new System.Drawing.Point(35, 18);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(27, 31);
            this.mtAdd.TabIndex = 19;
            this.mtAdd.Text = "                  ";
            this.mtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileImage = global::AgentApp.Properties.Resources.add_icon3;
            this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtAdd.UseTileImage = true;
            // 
            // cbPkgName
            // 
            this.cbPkgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPkgName.FormattingEnabled = true;
            this.cbPkgName.ItemHeight = 23;
            this.cbPkgName.Location = new System.Drawing.Point(27, 97);
            this.cbPkgName.Name = "cbPkgName";
            this.cbPkgName.Size = new System.Drawing.Size(210, 29);
            this.cbPkgName.TabIndex = 18;
            this.cbPkgName.Tag = "Package List";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(472, 235);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Commission";
            // 
            // txtCommission
            // 
            this.txtCommission.BackColor = System.Drawing.Color.White;
            this.txtCommission.CustomBackground = true;
            this.txtCommission.Location = new System.Drawing.Point(472, 257);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(94, 28);
            this.txtCommission.TabIndex = 16;
            this.txtCommission.Tag = "Commission";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(356, 235);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BackColor = System.Drawing.Color.White;
            this.txtBasePrice.CustomBackground = true;
            this.txtBasePrice.Location = new System.Drawing.Point(356, 257);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.PromptText = "Price";
            this.txtBasePrice.Size = new System.Drawing.Size(94, 28);
            this.txtBasePrice.TabIndex = 14;
            this.txtBasePrice.Tag = "Base Price";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(147, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "End Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Start Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(356, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Products List";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Description";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Package Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(356, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Product ID";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.BackColor = System.Drawing.Color.White;
            this.txtPkgDesc.CustomBackground = true;
            this.txtPkgDesc.Location = new System.Drawing.Point(27, 246);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.PromptText = "Enter Package Description";
            this.txtPkgDesc.Size = new System.Drawing.Size(230, 90);
            this.txtPkgDesc.TabIndex = 7;
            this.txtPkgDesc.Tag = "Package Description";
            // 
            // dpEndDate
            // 
            this.dpEndDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEndDate.Location = new System.Drawing.Point(147, 183);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(88, 22);
            this.dpEndDate.TabIndex = 5;
            // 
            // dpStartDate
            // 
            this.dpStartDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartDate.Location = new System.Drawing.Point(27, 183);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(88, 22);
            this.dpStartDate.TabIndex = 4;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.White;
            this.txtProductId.CustomBackground = true;
            this.txtProductId.ForeColor = System.Drawing.Color.Transparent;
            this.txtProductId.Location = new System.Drawing.Point(356, 97);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(153, 28);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.Tag = "Product ID";
            // 
            // cbProdList
            // 
            this.cbProdList.FormattingEnabled = true;
            this.cbProdList.ItemHeight = 23;
            this.cbProdList.Location = new System.Drawing.Point(356, 175);
            this.cbProdList.Name = "cbProdList";
            this.cbProdList.Size = new System.Drawing.Size(210, 29);
            this.cbProdList.TabIndex = 2;
            this.cbProdList.Tag = "Product List";
            // 
            // tpAddons
            // 
            this.tpAddons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpAddons.Controls.Add(this.metroPanel4);
            this.tpAddons.Controls.Add(this.metroPanel2);
            this.tpAddons.Controls.Add(this.metroPanel1);
            this.tpAddons.CustomBackground = true;
            this.tpAddons.HorizontalScrollbarBarColor = true;
            this.tpAddons.Location = new System.Drawing.Point(4, 35);
            this.tpAddons.Name = "tpAddons";
            this.tpAddons.Size = new System.Drawing.Size(704, 355);
            this.tpAddons.TabIndex = 1;
            this.tpAddons.Text = "Package Addons";
            this.tpAddons.VerticalScrollbarBarColor = true;
            this.tpAddons.VerticalScrollbarSize = 12;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel13);
            this.metroPanel4.Controls.Add(this.metroTextBox5);
            this.metroPanel4.Controls.Add(this.metroLabel15);
            this.metroPanel4.Controls.Add(this.metroTextBox7);
            this.metroPanel4.Controls.Add(this.metroLabel16);
            this.metroPanel4.Controls.Add(this.metroTextBox8);
            this.metroPanel4.CustomBackground = true;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(12, 227);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(647, 80);
            this.metroPanel4.TabIndex = 18;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.Location = new System.Drawing.Point(446, 11);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(73, 19);
            this.metroLabel13.TabIndex = 18;
            this.metroLabel13.Text = "Supplier ID";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.BackColor = System.Drawing.Color.White;
            this.metroTextBox5.CustomBackground = true;
            this.metroTextBox5.Location = new System.Drawing.Point(446, 33);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.TabIndex = 17;
            this.metroTextBox5.Tag = "Product ID";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.CustomBackground = true;
            this.metroLabel15.Location = new System.Drawing.Point(234, 11);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(71, 19);
            this.metroLabel15.TabIndex = 16;
            this.metroLabel15.Text = "Product ID";
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.BackColor = System.Drawing.Color.White;
            this.metroTextBox7.CustomBackground = true;
            this.metroTextBox7.Location = new System.Drawing.Point(234, 33);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.TabIndex = 15;
            this.metroTextBox7.Tag = "Product ID";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.CustomBackground = true;
            this.metroLabel16.Location = new System.Drawing.Point(10, 11);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(123, 19);
            this.metroLabel16.TabIndex = 14;
            this.metroLabel16.Text = "Product Supplier ID";
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.BackColor = System.Drawing.Color.White;
            this.metroTextBox8.CustomBackground = true;
            this.metroTextBox8.Location = new System.Drawing.Point(10, 33);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.TabIndex = 13;
            this.metroTextBox8.Tag = "Product ID";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.metroTextBox2);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroTextBox1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 39);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(435, 73);
            this.metroPanel2.TabIndex = 18;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.Location = new System.Drawing.Point(234, 9);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(95, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Product Name";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.White;
            this.metroTextBox2.CustomBackground = true;
            this.metroTextBox2.Location = new System.Drawing.Point(234, 31);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.TabIndex = 11;
            this.metroTextBox2.Tag = "Product ID";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 9);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Product ID";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.White;
            this.metroTextBox1.CustomBackground = true;
            this.metroTextBox1.Location = new System.Drawing.Point(10, 31);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.Tag = "Product ID";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroTextBox3);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroTextBox4);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 129);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(435, 80);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.Location = new System.Drawing.Point(234, 11);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(97, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Supplier Name";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.Color.White;
            this.metroTextBox3.CustomBackground = true;
            this.metroTextBox3.Location = new System.Drawing.Point(234, 33);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.TabIndex = 15;
            this.metroTextBox3.Tag = "Product ID";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.Location = new System.Drawing.Point(10, 11);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(73, 19);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Supplier ID";
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.BackColor = System.Drawing.Color.White;
            this.metroTextBox4.CustomBackground = true;
            this.metroTextBox4.Location = new System.Drawing.Point(10, 33);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.TabIndex = 13;
            this.metroTextBox4.Tag = "Product ID";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(721, 491);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Exit";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ofDialog
            // 
            this.ofDialog.FileName = "Browse";
            this.ofDialog.Title = "Attach Image";
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgentApp.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 541);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tcPackages);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmGUI";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "     Customize Packages";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcPackages.ResumeLayout(false);
            this.tpPackages.ResumeLayout(false);
            this.tpPackages.PerformLayout();
            this.tpAddons.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcPackages;
        private MetroFramework.Controls.MetroTabPage tpPackages;
        private MetroFramework.Controls.MetroTabPage tpAddons;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private MetroFramework.Controls.MetroTextBox txtProductId;
        private MetroFramework.Controls.MetroComboBox cbProdList;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtBasePrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtCommission;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroComboBox cbPkgName;
        private MetroFramework.Controls.MetroTile mtAdd;
    }
}

