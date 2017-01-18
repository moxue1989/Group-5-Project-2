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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvProducts1 = new System.Windows.Forms.ListView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLoginMsg = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProducts1
            // 
            this.lvProducts1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProducts1.FullRowSelect = true;
            this.lvProducts1.HideSelection = false;
            this.lvProducts1.Location = new System.Drawing.Point(310, 184);
            this.lvProducts1.Name = "lvProducts1";
            this.lvProducts1.Size = new System.Drawing.Size(389, 125);
            this.lvProducts1.TabIndex = 2;
            this.lvProducts1.UseCompatibleStateImageBehavior = false;
            this.lvProducts1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.Width = 180;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnAddPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(181)))));
            this.btnAddPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(181)))));
            this.btnAddPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(181)))));
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddPackage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPackage.Location = new System.Drawing.Point(310, 316);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(100, 23);
            this.btnAddPackage.TabIndex = 10;
            this.btnAddPackage.Text = "ADD";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnEditPackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPackage.Enabled = false;
            this.btnEditPackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(181)))));
            this.btnEditPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(181)))));
            this.btnEditPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(181)))));
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditPackage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPackage.Location = new System.Drawing.Point(452, 316);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(100, 23);
            this.btnEditPackage.TabIndex = 11;
            this.btnEditPackage.Text = "EDIT";
            this.btnEditPackage.UseVisualStyleBackColor = false;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnDeletePackage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePackage.Enabled = false;
            this.btnDeletePackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(181)))));
            this.btnDeletePackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(181)))));
            this.btnDeletePackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(181)))));
            this.btnDeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDeletePackage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePackage.Location = new System.Drawing.Point(586, 316);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(113, 23);
            this.btnDeletePackage.TabIndex = 12;
            this.btnDeletePackage.Text = "DELETE";
            this.btnDeletePackage.UseVisualStyleBackColor = false;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // tbPkgDesc
            // 
            this.tbPkgDesc.Location = new System.Drawing.Point(473, 108);
            this.tbPkgDesc.Name = "tbPkgDesc";
            this.tbPkgDesc.ReadOnly = true;
            this.tbPkgDesc.Size = new System.Drawing.Size(226, 46);
            this.tbPkgDesc.TabIndex = 51;
            this.tbPkgDesc.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(467, 7);
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
            this.label8.Location = new System.Drawing.Point(588, 7);
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
            this.label7.Location = new System.Drawing.Point(305, 107);
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
            this.label6.Location = new System.Drawing.Point(305, 57);
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
            this.label5.Location = new System.Drawing.Point(468, 80);
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
            this.label4.Location = new System.Drawing.Point(305, 7);
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
            this.label3.Location = new System.Drawing.Point(305, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Added Products:";
            // 
            // tbPkgAgencyCommission
            // 
            this.tbPkgAgencyCommission.Location = new System.Drawing.Point(593, 34);
            this.tbPkgAgencyCommission.Name = "tbPkgAgencyCommission";
            this.tbPkgAgencyCommission.ReadOnly = true;
            this.tbPkgAgencyCommission.Size = new System.Drawing.Size(106, 20);
            this.tbPkgAgencyCommission.TabIndex = 41;
            // 
            // tbPkgBasePrice
            // 
            this.tbPkgBasePrice.Location = new System.Drawing.Point(472, 34);
            this.tbPkgBasePrice.Name = "tbPkgBasePrice";
            this.tbPkgBasePrice.ReadOnly = true;
            this.tbPkgBasePrice.Size = new System.Drawing.Size(107, 20);
            this.tbPkgBasePrice.TabIndex = 40;
            // 
            // tbPkgName
            // 
            this.tbPkgName.Location = new System.Drawing.Point(310, 35);
            this.tbPkgName.Name = "tbPkgName";
            this.tbPkgName.ReadOnly = true;
            this.tbPkgName.Size = new System.Drawing.Size(135, 20);
            this.tbPkgName.TabIndex = 39;
            // 
            // tbPkgStartDate
            // 
            this.tbPkgStartDate.Location = new System.Drawing.Point(310, 85);
            this.tbPkgStartDate.Name = "tbPkgStartDate";
            this.tbPkgStartDate.ReadOnly = true;
            this.tbPkgStartDate.Size = new System.Drawing.Size(135, 20);
            this.tbPkgStartDate.TabIndex = 52;
            // 
            // tbPkgEndDate
            // 
            this.tbPkgEndDate.Location = new System.Drawing.Point(310, 133);
            this.tbPkgEndDate.Name = "tbPkgEndDate";
            this.tbPkgEndDate.ReadOnly = true;
            this.tbPkgEndDate.Size = new System.Drawing.Size(135, 20);
            this.tbPkgEndDate.TabIndex = 53;
            // 
            // pnlPackages
            // 
            this.pnlPackages.AutoScroll = true;
            this.pnlPackages.Location = new System.Drawing.Point(23, 45);
            this.pnlPackages.Name = "pnlPackages";
            this.pnlPackages.Size = new System.Drawing.Size(250, 288);
            this.pnlPackages.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Available Packages:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lvProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlPackages);
            this.panel1.Controls.Add(this.tbPkgEndDate);
            this.panel1.Controls.Add(this.tbPkgStartDate);
            this.panel1.Controls.Add(this.tbPkgDesc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbPkgAgencyCommission);
            this.panel1.Controls.Add(this.tbPkgBasePrice);
            this.panel1.Controls.Add(this.tbPkgName);
            this.panel1.Controls.Add(this.btnDeletePackage);
            this.panel1.Controls.Add(this.btnEditPackage);
            this.panel1.Controls.Add(this.btnAddPackage);
            this.panel1.Controls.Add(this.lvProducts1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 373);
            this.panel1.TabIndex = 56;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.panel10.Controls.Add(this.pictureBox2);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.btnMinimize);
            this.panel10.Controls.Add(this.btnExit);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(761, 27);
            this.panel10.TabIndex = 57;
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
            this.btnMinimize.Location = new System.Drawing.Point(695, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 25);
            this.btnMinimize.TabIndex = 2;
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
            this.btnExit.Location = new System.Drawing.Point(725, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Agent_App_V2.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(56, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Packages - Travel Experts Inc.";
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
            this.header.Size = new System.Drawing.Size(761, 45);
            this.header.TabIndex = 58;
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
            this.btnLogout.Location = new System.Drawing.Point(703, 8);
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
            // lvProducts
            // 
            this.lvProducts.AllowUserToAddRows = false;
            this.lvProducts.AllowUserToDeleteRows = false;
            this.lvProducts.AllowUserToResizeRows = false;
            this.lvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lvProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.lvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvProducts.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.lvProducts.GridColor = System.Drawing.Color.White;
            this.lvProducts.Location = new System.Drawing.Point(310, 184);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(5);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.ReadOnly = true;
            this.lvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.lvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lvProducts.Size = new System.Drawing.Size(389, 123);
            this.lvProducts.TabIndex = 56;
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(761, 453);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts Packages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts1;
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
        private Panel panel1;
        private Panel panel10;
        private Button btnMinimize;
        private Button btnExit;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel header;
        private Button btnLogout;
        private Button btnBack;
        private Label lblLoginMsg;
        private DataGridView lvProducts;
    }
}