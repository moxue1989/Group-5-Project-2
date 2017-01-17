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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProdToList
            // 
            this.btnAddProdToList.Location = new System.Drawing.Point(553, 165);
            this.btnAddProdToList.Name = "btnAddProdToList";
            this.btnAddProdToList.Size = new System.Drawing.Size(44, 55);
            this.btnAddProdToList.TabIndex = 3;
            this.btnAddProdToList.Text = "<";
            this.btnAddProdToList.UseVisualStyleBackColor = true;
            this.btnAddProdToList.Click += new System.EventHandler(this.btnAddProdToList_Click);
            // 
            // btnRemoveProdFrList
            // 
            this.btnRemoveProdFrList.Location = new System.Drawing.Point(553, 269);
            this.btnRemoveProdFrList.Name = "btnRemoveProdFrList";
            this.btnRemoveProdFrList.Size = new System.Drawing.Size(44, 58);
            this.btnRemoveProdFrList.TabIndex = 4;
            this.btnRemoveProdFrList.Text = ">";
            this.btnRemoveProdFrList.UseVisualStyleBackColor = true;
            this.btnRemoveProdFrList.Click += new System.EventHandler(this.btnRemoveProdFrList_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(615, 141);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(70, 23);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "&Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(691, 141);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(70, 23);
            this.btnEditProd.TabIndex = 7;
            this.btnEditProd.Text = "&Edit";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(767, 141);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(62, 23);
            this.btnDeleteProd.TabIndex = 8;
            this.btnDeleteProd.Text = "&Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.Location = new System.Drawing.Point(35, 136);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteSupp.TabIndex = 11;
            this.btnDeleteSupp.Text = "&Delete";
            this.btnDeleteSupp.UseVisualStyleBackColor = true;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.Location = new System.Drawing.Point(102, 136);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(69, 23);
            this.btnEditSupp.TabIndex = 10;
            this.btnEditSupp.Text = "&Edit";
            this.btnEditSupp.UseVisualStyleBackColor = true;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(177, 136);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(69, 23);
            this.btnAddSupp.TabIndex = 9;
            this.btnAddSupp.Text = "&Add ";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(275, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Supplied Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(610, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "All Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(31, 108);
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
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.Location = new System.Drawing.Point(36, 165);
            this.dataGridSuppliers.MultiSelect = false;
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.ReadOnly = true;
            this.dataGridSuppliers.RowHeadersVisible = false;
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
            this.dataGridProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdSupp.Location = new System.Drawing.Point(277, 165);
            this.dataGridProdSupp.MultiSelect = false;
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.ReadOnly = true;
            this.dataGridProdSupp.RowHeadersVisible = false;
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
            this.dataGridNotInSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotInSupp.Location = new System.Drawing.Point(615, 165);
            this.dataGridNotInSupp.MultiSelect = false;
            this.dataGridNotInSupp.Name = "dataGridNotInSupp";
            this.dataGridNotInSupp.ReadOnly = true;
            this.dataGridNotInSupp.RowHeadersVisible = false;
            this.dataGridNotInSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNotInSupp.Size = new System.Drawing.Size(214, 273);
            this.dataGridNotInSupp.TabIndex = 17;
            // 
            // datagridPackages
            // 
            this.datagridPackages.AllowUserToAddRows = false;
            this.datagridPackages.AllowUserToDeleteRows = false;
            this.datagridPackages.AllowUserToResizeRows = false;
            this.datagridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPackages.Enabled = false;
            this.datagridPackages.Location = new System.Drawing.Point(277, 344);
            this.datagridPackages.MultiSelect = false;
            this.datagridPackages.Name = "datagridPackages";
            this.datagridPackages.ReadOnly = true;
            this.datagridPackages.RowHeadersVisible = false;
            this.datagridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPackages.Size = new System.Drawing.Size(247, 99);
            this.datagridPackages.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(272, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Added to Package:";
            // 
            // frmProdSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 484);
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
    }
}