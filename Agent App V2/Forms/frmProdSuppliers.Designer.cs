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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridNotInSupp = new System.Windows.Forms.DataGridView();
            this.datagridPackages = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProdToList
            // 
            this.btnAddProdToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddProdToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProdToList.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAddProdToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdToList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProdToList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProdToList.Location = new System.Drawing.Point(566, 187);
            this.btnAddProdToList.Name = "btnAddProdToList";
            this.btnAddProdToList.Size = new System.Drawing.Size(26, 31);
            this.btnAddProdToList.TabIndex = 3;
            this.btnAddProdToList.Text = "<";
            this.btnAddProdToList.UseVisualStyleBackColor = false;
            this.btnAddProdToList.Click += new System.EventHandler(this.btnAddProdToList_Click);
            // 
            // btnRemoveProdFrList
            // 
            this.btnRemoveProdFrList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRemoveProdFrList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveProdFrList.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnRemoveProdFrList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProdFrList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveProdFrList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveProdFrList.Location = new System.Drawing.Point(566, 250);
            this.btnRemoveProdFrList.Name = "btnRemoveProdFrList";
            this.btnRemoveProdFrList.Size = new System.Drawing.Size(26, 31);
            this.btnRemoveProdFrList.TabIndex = 4;
            this.btnRemoveProdFrList.Text = ">";
            this.btnRemoveProdFrList.UseVisualStyleBackColor = false;
            this.btnRemoveProdFrList.Click += new System.EventHandler(this.btnRemoveProdFrList_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnAddProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProducts.Location = new System.Drawing.Point(620, 138);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(70, 23);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "&Add";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnEditProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProd.Location = new System.Drawing.Point(696, 139);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(70, 23);
            this.btnEditProd.TabIndex = 7;
            this.btnEditProd.Text = "&Edit";
            this.btnEditProd.UseVisualStyleBackColor = false;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnDeleteProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDeleteProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteProd.Location = new System.Drawing.Point(772, 138);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(62, 23);
            this.btnDeleteProd.TabIndex = 8;
            this.btnDeleteProd.Text = "&Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = false;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnDeleteSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDeleteSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDeleteSupp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteSupp.Location = new System.Drawing.Point(41, 134);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteSupp.TabIndex = 11;
            this.btnDeleteSupp.Text = "&Delete";
            this.btnDeleteSupp.UseVisualStyleBackColor = false;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnEditSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnEditSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditSupp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditSupp.Location = new System.Drawing.Point(107, 134);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(69, 23);
            this.btnEditSupp.TabIndex = 10;
            this.btnEditSupp.Text = "&Edit";
            this.btnEditSupp.UseVisualStyleBackColor = false;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnAddSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddSupp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSupp.Location = new System.Drawing.Point(182, 134);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(69, 23);
            this.btnAddSupp.TabIndex = 9;
            this.btnAddSupp.Text = "&Add ";
            this.btnAddSupp.UseVisualStyleBackColor = false;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(676, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "All Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(88, 101);
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
            this.dataGridSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.ColumnHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSuppliers.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridSuppliers.GridColor = System.Drawing.Color.White;
            this.dataGridSuppliers.Location = new System.Drawing.Point(41, 165);
            this.dataGridSuppliers.MultiSelect = false;
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.ReadOnly = true;
            this.dataGridSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dataGridSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuppliers.Size = new System.Drawing.Size(210, 273);
            this.dataGridSuppliers.TabIndex = 15;
            this.dataGridSuppliers.SelectionChanged += new System.EventHandler(this.dataGridSuppliers_SelectionChanged);
            // 
            // dataGridProdSupp
            // 
            this.dataGridProdSupp.AllowUserToAddRows = false;
            this.dataGridProdSupp.AllowUserToDeleteRows = false;
            this.dataGridProdSupp.AllowUserToResizeRows = false;
            this.dataGridProdSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProdSupp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProdSupp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProdSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdSupp.ColumnHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProdSupp.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridProdSupp.GridColor = System.Drawing.Color.White;
            this.dataGridProdSupp.Location = new System.Drawing.Point(297, 165);
            this.dataGridProdSupp.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridProdSupp.MultiSelect = false;
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.ReadOnly = true;
            this.dataGridProdSupp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProdSupp.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridProdSupp.RowHeadersVisible = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridProdSupp.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridProdSupp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridProdSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdSupp.Size = new System.Drawing.Size(247, 136);
            this.dataGridProdSupp.TabIndex = 16;
            this.dataGridProdSupp.SelectionChanged += new System.EventHandler(this.dataGridProdSupp_SelectionChanged);
            // 
            // dataGridNotInSupp
            // 
            this.dataGridNotInSupp.AllowUserToAddRows = false;
            this.dataGridNotInSupp.AllowUserToDeleteRows = false;
            this.dataGridNotInSupp.AllowUserToResizeRows = false;
            this.dataGridNotInSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNotInSupp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridNotInSupp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNotInSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridNotInSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotInSupp.ColumnHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNotInSupp.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridNotInSupp.GridColor = System.Drawing.Color.White;
            this.dataGridNotInSupp.Location = new System.Drawing.Point(620, 165);
            this.dataGridNotInSupp.MultiSelect = false;
            this.dataGridNotInSupp.Name = "dataGridNotInSupp";
            this.dataGridNotInSupp.ReadOnly = true;
            this.dataGridNotInSupp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNotInSupp.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridNotInSupp.RowHeadersVisible = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridNotInSupp.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridNotInSupp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridNotInSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNotInSupp.Size = new System.Drawing.Size(214, 273);
            this.dataGridNotInSupp.TabIndex = 17;
            // 
            // datagridPackages
            // 
            this.datagridPackages.AllowUserToAddRows = false;
            this.datagridPackages.AllowUserToDeleteRows = false;
            this.datagridPackages.AllowUserToResizeRows = false;
            this.datagridPackages.BackgroundColor = System.Drawing.Color.White;
            this.datagridPackages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPackages.DefaultCellStyle = dataGridViewCellStyle27;
            this.datagridPackages.Enabled = false;
            this.datagridPackages.GridColor = System.Drawing.Color.White;
            this.datagridPackages.Location = new System.Drawing.Point(297, 344);
            this.datagridPackages.MultiSelect = false;
            this.datagridPackages.Name = "datagridPackages";
            this.datagridPackages.ReadOnly = true;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.datagridPackages.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.datagridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPackages.Size = new System.Drawing.Size(247, 99);
            this.datagridPackages.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(332, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Added to Package:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Agent_App_V2.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(5, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(58, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Product and Suppliers - Travel Experts Inc.";
            // 
            // frmProdSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(878, 484);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datagridPackages);
            this.Controls.Add(this.dataGridNotInSupp);
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
            this.Name = "frmProdSuppliers";
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private DataGridView dataGridNotInSupp;
        private DataGridView datagridPackages;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
    }
}