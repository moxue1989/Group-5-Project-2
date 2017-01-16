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
            this.cbProdSupp = new System.Windows.Forms.ComboBox();
            this.dataGridProdSupp = new System.Windows.Forms.DataGridView();
            this.btnAddProdToList = new System.Windows.Forms.Button();
            this.btnRemoveProdFrList = new System.Windows.Forms.Button();
            this.dataGridNotInSupp = new System.Windows.Forms.DataGridView();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnDeleteSupp = new System.Windows.Forms.Button();
            this.btnEditSupp = new System.Windows.Forms.Button();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProdSupp
            // 
            this.cbProdSupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdSupp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProdSupp.FormattingEnabled = true;
            this.cbProdSupp.Location = new System.Drawing.Point(390, 102);
            this.cbProdSupp.Name = "cbProdSupp";
            this.cbProdSupp.Size = new System.Drawing.Size(206, 21);
            this.cbProdSupp.Sorted = true;
            this.cbProdSupp.TabIndex = 1;
            this.cbProdSupp.SelectionChangeCommitted += new System.EventHandler(this.cbProducts_SelectionChangeCommitted);
            // 
            // dataGridProdSupp
            // 
            this.dataGridProdSupp.AllowUserToAddRows = false;
            this.dataGridProdSupp.AllowUserToDeleteRows = false;
            this.dataGridProdSupp.AllowUserToOrderColumns = true;
            this.dataGridProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdSupp.Location = new System.Drawing.Point(26, 170);
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.ReadOnly = true;
            this.dataGridProdSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdSupp.Size = new System.Drawing.Size(334, 274);
            this.dataGridProdSupp.TabIndex = 2;
            this.dataGridProdSupp.SelectionChanged += new System.EventHandler(this.dataGridProdSupp_SelectionChanged);
            // 
            // btnAddProdToList
            // 
            this.btnAddProdToList.Location = new System.Drawing.Point(477, 256);
            this.btnAddProdToList.Name = "btnAddProdToList";
            this.btnAddProdToList.Size = new System.Drawing.Size(28, 30);
            this.btnAddProdToList.TabIndex = 3;
            this.btnAddProdToList.Text = "<";
            this.btnAddProdToList.UseVisualStyleBackColor = true;
            this.btnAddProdToList.Click += new System.EventHandler(this.btnAddProdToList_Click);
            // 
            // btnRemoveProdFrList
            // 
            this.btnRemoveProdFrList.Location = new System.Drawing.Point(477, 344);
            this.btnRemoveProdFrList.Name = "btnRemoveProdFrList";
            this.btnRemoveProdFrList.Size = new System.Drawing.Size(28, 30);
            this.btnRemoveProdFrList.TabIndex = 4;
            this.btnRemoveProdFrList.Text = ">";
            this.btnRemoveProdFrList.UseVisualStyleBackColor = true;
            this.btnRemoveProdFrList.Click += new System.EventHandler(this.btnRemoveProdFrList_Click);
            // 
            // dataGridNotInSupp
            // 
            this.dataGridNotInSupp.AllowUserToAddRows = false;
            this.dataGridNotInSupp.AllowUserToDeleteRows = false;
            this.dataGridNotInSupp.AllowUserToOrderColumns = true;
            this.dataGridNotInSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotInSupp.Location = new System.Drawing.Point(615, 170);
            this.dataGridNotInSupp.Name = "dataGridNotInSupp";
            this.dataGridNotInSupp.ReadOnly = true;
            this.dataGridNotInSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNotInSupp.Size = new System.Drawing.Size(292, 274);
            this.dataGridNotInSupp.TabIndex = 5;
            this.dataGridNotInSupp.SelectionChanged += new System.EventHandler(this.dataGridNotInSupp_SelectionChanged);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(837, 141);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(70, 23);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "&Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(724, 141);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(70, 23);
            this.btnEditProd.TabIndex = 7;
            this.btnEditProd.Text = "&Edit";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(615, 141);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(62, 23);
            this.btnDeleteProd.TabIndex = 8;
            this.btnDeleteProd.Text = "&Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.Location = new System.Drawing.Point(386, 73);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteSupp.TabIndex = 11;
            this.btnDeleteSupp.Text = "&Delete";
            this.btnDeleteSupp.UseVisualStyleBackColor = true;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.Location = new System.Drawing.Point(453, 73);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(69, 23);
            this.btnEditSupp.TabIndex = 10;
            this.btnEditSupp.Text = "&Edit";
            this.btnEditSupp.UseVisualStyleBackColor = true;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(528, 73);
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
            this.label1.Location = new System.Drawing.Point(87, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Available Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(695, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(385, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Suppliers and  Products";
            // 
            // frmProdSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSupp);
            this.Controls.Add(this.btnEditSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.dataGridNotInSupp);
            this.Controls.Add(this.btnRemoveProdFrList);
            this.Controls.Add(this.btnAddProdToList);
            this.Controls.Add(this.dataGridProdSupp);
            this.Controls.Add(this.cbProdSupp);
            this.Name = "frmProdSuppliers";
            this.Text = "frmSuppliers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSuppliers_FormClosed);
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbProdSupp;
        private DataGridView dataGridProdSupp;
        private Button btnAddProdToList;
        private Button btnRemoveProdFrList;
        private DataGridView dataGridNotInSupp;
        private Button btnAddProducts;
        private Button btnEditProd;
        private Button btnDeleteProd;
        private Button btnDeleteSupp;
        private Button btnEditSupp;
        private Button btnAddSupp;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}