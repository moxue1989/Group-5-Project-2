using System.ComponentModel;
using System.Windows.Forms;

namespace Agent_App_V2
{
    partial class frmPackages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackages));
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.tbPkgDesc = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.tbPkgBasePrice = new System.Windows.Forms.TextBox();
            this.tbPkgName = new System.Windows.Forms.TextBox();
            this.tbPkgStartDate = new System.Windows.Forms.TextBox();
            this.tbPkgEndDate = new System.Windows.Forms.TextBox();
            this.pnlPackages = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.lblLoginMsg = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.AllowColumnReorder = true;
            this.lvProducts.AutoArrange = false;
            this.lvProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lvProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(404, 285);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(10);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(390, 125);
            this.lvProducts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvProducts.TabIndex = 2;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 251;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnAddPackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnAddPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnAddPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddPackage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPackage.Location = new System.Drawing.Point(404, 417);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(71, 23);
            this.btnAddPackage.TabIndex = 10;
            this.btnAddPackage.Text = "ADD";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnEditPackage.Enabled = false;
            this.btnEditPackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnEditPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnEditPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditPackage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPackage.Location = new System.Drawing.Point(574, 417);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(71, 23);
            this.btnEditPackage.TabIndex = 11;
            this.btnEditPackage.Text = "EDIT";
            this.btnEditPackage.UseVisualStyleBackColor = false;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnDeletePackage.Enabled = false;
            this.btnDeletePackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnDeletePackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnDeletePackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDeletePackage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePackage.Location = new System.Drawing.Point(723, 417);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(71, 23);
            this.btnDeletePackage.TabIndex = 12;
            this.btnDeletePackage.Text = "DELETE";
            this.btnDeletePackage.UseVisualStyleBackColor = false;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // tbPkgDesc
            // 
            this.tbPkgDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPkgDesc.Enabled = false;
            this.tbPkgDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPkgDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPkgDesc.Location = new System.Drawing.Point(563, 169);
            this.tbPkgDesc.Margin = new System.Windows.Forms.Padding(10);
            this.tbPkgDesc.MaxLength = 100;
            this.tbPkgDesc.Name = "tbPkgDesc";
            this.tbPkgDesc.ReadOnly = true;
            this.tbPkgDesc.Size = new System.Drawing.Size(231, 73);
            this.tbPkgDesc.TabIndex = 51;
            this.tbPkgDesc.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(558, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Base Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(675, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Commission:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(400, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(400, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(558, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(400, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(400, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Added Products:";
            // 
            // tbPkgAgencyCommission
            // 
            this.tbPkgAgencyCommission.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgAgencyCommission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPkgAgencyCommission.Enabled = false;
            this.tbPkgAgencyCommission.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPkgAgencyCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPkgAgencyCommission.Location = new System.Drawing.Point(681, 116);
            this.tbPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(10);
            this.tbPkgAgencyCommission.Name = "tbPkgAgencyCommission";
            this.tbPkgAgencyCommission.ReadOnly = true;
            this.tbPkgAgencyCommission.Size = new System.Drawing.Size(113, 20);
            this.tbPkgAgencyCommission.TabIndex = 41;
            this.tbPkgAgencyCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPkgBasePrice
            // 
            this.tbPkgBasePrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPkgBasePrice.Enabled = false;
            this.tbPkgBasePrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPkgBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPkgBasePrice.Location = new System.Drawing.Point(564, 116);
            this.tbPkgBasePrice.Margin = new System.Windows.Forms.Padding(10);
            this.tbPkgBasePrice.Name = "tbPkgBasePrice";
            this.tbPkgBasePrice.ReadOnly = true;
            this.tbPkgBasePrice.Size = new System.Drawing.Size(94, 20);
            this.tbPkgBasePrice.TabIndex = 40;
            this.tbPkgBasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPkgName
            // 
            this.tbPkgName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPkgName.Enabled = false;
            this.tbPkgName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPkgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPkgName.Location = new System.Drawing.Point(403, 116);
            this.tbPkgName.Margin = new System.Windows.Forms.Padding(10);
            this.tbPkgName.Name = "tbPkgName";
            this.tbPkgName.ReadOnly = true;
            this.tbPkgName.Size = new System.Drawing.Size(135, 20);
            this.tbPkgName.TabIndex = 39;
            this.tbPkgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPkgStartDate
            // 
            this.tbPkgStartDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPkgStartDate.Enabled = false;
            this.tbPkgStartDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPkgStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPkgStartDate.Location = new System.Drawing.Point(402, 169);
            this.tbPkgStartDate.Margin = new System.Windows.Forms.Padding(10);
            this.tbPkgStartDate.Name = "tbPkgStartDate";
            this.tbPkgStartDate.ReadOnly = true;
            this.tbPkgStartDate.Size = new System.Drawing.Size(135, 20);
            this.tbPkgStartDate.TabIndex = 52;
            this.tbPkgStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPkgEndDate
            // 
            this.tbPkgEndDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPkgEndDate.Enabled = false;
            this.tbPkgEndDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbPkgEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbPkgEndDate.Location = new System.Drawing.Point(403, 220);
            this.tbPkgEndDate.Margin = new System.Windows.Forms.Padding(10);
            this.tbPkgEndDate.Name = "tbPkgEndDate";
            this.tbPkgEndDate.ReadOnly = true;
            this.tbPkgEndDate.Size = new System.Drawing.Size(135, 20);
            this.tbPkgEndDate.TabIndex = 53;
            this.tbPkgEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlPackages
            // 
            this.pnlPackages.AutoSize = true;
            this.pnlPackages.Location = new System.Drawing.Point(30, 116);
            this.pnlPackages.Name = "pnlPackages";
            this.pnlPackages.Size = new System.Drawing.Size(331, 324);
            this.pnlPackages.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(117, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Available Packages:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.panel10.Controls.Add(this.btnMinimize);
            this.panel10.Controls.Add(this.btnExit);
            this.panel10.Controls.Add(this.pictureBox2);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(858, 27);
            this.panel10.TabIndex = 56;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(800, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 25);
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(66)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(830, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Agent_App_V2.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.label10.Location = new System.Drawing.Point(49, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Packages - Travel Experts Inc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(61, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Product and Suppliers - Travel Experts Inc.";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.btnLogout.Location = new System.Drawing.Point(820, 8);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(27, 30);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.btnBack.Location = new System.Drawing.Point(30, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.header.Controls.Add(this.btnLogout);
            this.header.Controls.Add(this.btnBack);
            this.header.Controls.Add(this.lblLoginMsg);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 27);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(858, 45);
            this.header.TabIndex = 58;
            // 
            // lblLoginMsg
            // 
            this.lblLoginMsg.AutoSize = true;
            this.lblLoginMsg.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblLoginMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.lblLoginMsg.Location = new System.Drawing.Point(63, 8);
            this.lblLoginMsg.Name = "lblLoginMsg";
            this.lblLoginMsg.Size = new System.Drawing.Size(0, 30);
            this.lblLoginMsg.TabIndex = 2;
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(858, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPackages);
            this.Controls.Add(this.tbPkgEndDate);
            this.Controls.Add(this.tbPkgStartDate);
            this.Controls.Add(this.tbPkgDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPkgAgencyCommission);
            this.Controls.Add(this.tbPkgBasePrice);
            this.Controls.Add(this.tbPkgName);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.lvProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts Packages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.RichTextBox tbPkgDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPkgAgencyCommission;
        private System.Windows.Forms.TextBox tbPkgBasePrice;
        private System.Windows.Forms.TextBox tbPkgName;
        private System.Windows.Forms.TextBox tbPkgStartDate;
        private System.Windows.Forms.TextBox tbPkgEndDate;
        private System.Windows.Forms.Panel pnlPackages;
        private System.Windows.Forms.Label label1;
        private Panel panel10;
        private Label label2;
        private Button btnMinimize;
        private Button btnExit;
        private PictureBox pictureBox2;
        private Label label10;
        private Button btnLogout;
        private Button btnBack;
        private Panel header;
        private Label lblLoginMsg;
    }
}