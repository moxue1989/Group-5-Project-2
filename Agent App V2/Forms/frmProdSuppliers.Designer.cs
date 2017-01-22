using System.ComponentModel;
using System.Windows.Forms;

namespace Agent_App_V2
{
    partial class frmProdSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdSuppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddProdToList = new System.Windows.Forms.Button();
            this.btnRemoveProdFrList = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnDeleteSupp = new System.Windows.Forms.Button();
            this.btnEditSupp = new System.Windows.Forms.Button();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridSuppliers = new System.Windows.Forms.DataGridView();
            this.dataGridProdSupp = new System.Windows.Forms.DataGridView();
            this.dataGridAllProd = new System.Windows.Forms.DataGridView();
            this.datagridPackages = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLoginMsg = new System.Windows.Forms.Label();
            this.Navbar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).BeginInit();
            this.header.SuspendLayout();
            this.Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProdToList
            // 
            this.btnAddProdToList.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProdToList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProdToList.BackgroundImage")));
            this.btnAddProdToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProdToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProdToList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddProdToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddProdToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddProdToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdToList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddProdToList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProdToList.Location = new System.Drawing.Point(566, 176);
            this.btnAddProdToList.Name = "btnAddProdToList";
            this.btnAddProdToList.Size = new System.Drawing.Size(30, 37);
            this.btnAddProdToList.TabIndex = 3;
            this.btnAddProdToList.UseVisualStyleBackColor = false;
            this.btnAddProdToList.Click += new System.EventHandler(this.btnAddProdToList_Click);
            // 
            // btnRemoveProdFrList
            // 
            this.btnRemoveProdFrList.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveProdFrList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProdFrList.BackgroundImage")));
            this.btnRemoveProdFrList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveProdFrList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProdFrList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRemoveProdFrList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemoveProdFrList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRemoveProdFrList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProdFrList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemoveProdFrList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveProdFrList.Location = new System.Drawing.Point(566, 251);
            this.btnRemoveProdFrList.Name = "btnRemoveProdFrList";
            this.btnRemoveProdFrList.Size = new System.Drawing.Size(30, 37);
            this.btnRemoveProdFrList.TabIndex = 4;
            this.btnRemoveProdFrList.UseVisualStyleBackColor = false;
            this.btnRemoveProdFrList.Click += new System.EventHandler(this.btnRemoveProdFrList_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnAddProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnAddProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnAddProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProducts.Location = new System.Drawing.Point(620, 130);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(70, 23);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "ADD";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnEditProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnEditProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnEditProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProd.Location = new System.Drawing.Point(696, 131);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(70, 23);
            this.btnEditProd.TabIndex = 7;
            this.btnEditProd.Text = "EDIT";
            this.btnEditProd.UseVisualStyleBackColor = false;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnDeleteProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnDeleteProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnDeleteProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDeleteProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteProd.Location = new System.Drawing.Point(772, 130);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(62, 23);
            this.btnDeleteProd.TabIndex = 8;
            this.btnDeleteProd.Text = "DELETE";
            this.btnDeleteProd.UseVisualStyleBackColor = false;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnDeleteSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnDeleteSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnDeleteSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDeleteSupp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteSupp.Location = new System.Drawing.Point(41, 130);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteSupp.TabIndex = 11;
            this.btnDeleteSupp.Text = "DELETE";
            this.btnDeleteSupp.UseVisualStyleBackColor = false;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnEditSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnEditSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnEditSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditSupp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditSupp.Location = new System.Drawing.Point(107, 130);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(69, 23);
            this.btnEditSupp.TabIndex = 10;
            this.btnEditSupp.Text = "EDIT";
            this.btnEditSupp.UseVisualStyleBackColor = false;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnAddSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnAddSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(31)))), ((int)(((byte)(191)))));
            this.btnAddSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddSupp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSupp.Location = new System.Drawing.Point(182, 130);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(69, 23);
            this.btnAddSupp.TabIndex = 9;
            this.btnAddSupp.Text = "ADD";
            this.btnAddSupp.UseVisualStyleBackColor = false;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(335, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Supplied Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(676, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "All Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(88, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "All Suppliers";
            // 
            // dataGridSuppliers
            // 
            this.dataGridSuppliers.AllowUserToAddRows = false;
            this.dataGridSuppliers.AllowUserToDeleteRows = false;
            this.dataGridSuppliers.AllowUserToResizeRows = false;
            this.dataGridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuppliers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.ColumnHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSuppliers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridSuppliers.GridColor = System.Drawing.Color.White;
            this.dataGridSuppliers.Location = new System.Drawing.Point(41, 165);
            this.dataGridSuppliers.MultiSelect = false;
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.ReadOnly = true;
            this.dataGridSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dataGridSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuppliers.Size = new System.Drawing.Size(210, 278);
            this.dataGridSuppliers.TabIndex = 15;
            this.dataGridSuppliers.SelectionChanged += new System.EventHandler(this.dataGridSuppliers_SelectionChanged);
            // 
            // dataGridProdSupp
            // 
            this.dataGridProdSupp.AllowUserToAddRows = false;
            this.dataGridProdSupp.AllowUserToDeleteRows = false;
            this.dataGridProdSupp.AllowUserToResizeRows = false;
            this.dataGridProdSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProdSupp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridProdSupp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProdSupp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProdSupp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProdSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdSupp.ColumnHeadersVisible = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProdSupp.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridProdSupp.GridColor = System.Drawing.Color.White;
            this.dataGridProdSupp.Location = new System.Drawing.Point(297, 165);
            this.dataGridProdSupp.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridProdSupp.MultiSelect = false;
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.ReadOnly = true;
            this.dataGridProdSupp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProdSupp.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridProdSupp.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridProdSupp.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridProdSupp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridProdSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdSupp.Size = new System.Drawing.Size(247, 136);
            this.dataGridProdSupp.TabIndex = 16;
            this.dataGridProdSupp.SelectionChanged += new System.EventHandler(this.dataGridProdSupp_SelectionChanged);
            // 
            // dataGridAllProd
            // 
            this.dataGridAllProd.AllowUserToAddRows = false;
            this.dataGridAllProd.AllowUserToDeleteRows = false;
            this.dataGridAllProd.AllowUserToResizeRows = false;
            this.dataGridAllProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAllProd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridAllProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAllProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAllProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridAllProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllProd.ColumnHeadersVisible = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAllProd.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridAllProd.GridColor = System.Drawing.Color.White;
            this.dataGridAllProd.Location = new System.Drawing.Point(620, 165);
            this.dataGridAllProd.MultiSelect = false;
            this.dataGridAllProd.Name = "dataGridAllProd";
            this.dataGridAllProd.ReadOnly = true;
            this.dataGridAllProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridAllProd.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridAllProd.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridAllProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAllProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAllProd.Size = new System.Drawing.Size(214, 278);
            this.dataGridAllProd.TabIndex = 17;
            this.dataGridAllProd.SelectionChanged += new System.EventHandler(this.dataGridAllProd_SelectionChanged);
            // 
            // datagridPackages
            // 
            this.datagridPackages.AllowUserToAddRows = false;
            this.datagridPackages.AllowUserToDeleteRows = false;
            this.datagridPackages.AllowUserToResizeRows = false;
            this.datagridPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridPackages.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridPackages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridPackages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridPackages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.datagridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPackages.ColumnHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPackages.DefaultCellStyle = dataGridViewCellStyle30;
            this.datagridPackages.Enabled = false;
            this.datagridPackages.GridColor = System.Drawing.Color.White;
            this.datagridPackages.Location = new System.Drawing.Point(297, 344);
            this.datagridPackages.MultiSelect = false;
            this.datagridPackages.Name = "datagridPackages";
            this.datagridPackages.ReadOnly = true;
            this.datagridPackages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPackages.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.datagridPackages.RowHeadersVisible = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.datagridPackages.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.datagridPackages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPackages.Size = new System.Drawing.Size(247, 99);
            this.datagridPackages.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(332, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Added to Package:";
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
            this.header.Size = new System.Drawing.Size(878, 45);
            this.header.TabIndex = 20;
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
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.Navbar.Controls.Add(this.pictureBox2);
            this.Navbar.Controls.Add(this.label5);
            this.Navbar.Controls.Add(this.panel10);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(878, 27);
            this.Navbar.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Agent_App_V2.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(8, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(61, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product and Suppliers - Travel Experts Inc.";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnMinimize);
            this.panel10.Controls.Add(this.btnExit);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(878, 27);
            this.panel10.TabIndex = 8;
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
            this.btnMinimize.Location = new System.Drawing.Point(812, 1);
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
            this.btnExit.Location = new System.Drawing.Point(842, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmProdSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(878, 484);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Navbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datagridPackages);
            this.Controls.Add(this.dataGridAllProd);
            this.Controls.Add(this.dataGridProdSupp);
            this.Controls.Add(this.dataGridSuppliers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSupp);
            this.Controls.Add(this.btnEditSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnRemoveProdFrList);
            this.Controls.Add(this.btnAddProdToList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddProdToList;
        private Button btnRemoveProdFrList;
        private Button btnAddProducts;
        private Button btnEditProd;
        private Button btnDeleteProd;
        private Button btnDeleteSupp;
        private Button btnEditSupp;
        private Button btnAddSupp;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridSuppliers;
        private DataGridView dataGridProdSupp;
        private DataGridView dataGridAllProd;
        private DataGridView datagridPackages;
        private Label label4;
        private Panel header;
        private Button btnBack;
        private Label lblLoginMsg;
        private Panel Navbar;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel10;
        private Button btnMinimize;
        private Button btnExit;
        private Button btnLogout;
    }
}