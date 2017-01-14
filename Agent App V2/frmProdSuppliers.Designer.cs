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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridNotInSupp = new System.Windows.Forms.DataGridView();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnDeleteSupp = new System.Windows.Forms.Button();
            this.btnEditSupp = new System.Windows.Forms.Button();
            this.btnAddSupp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProdSupp
            // 
            this.cbProdSupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdSupp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProdSupp.FormattingEnabled = true;
            this.cbProdSupp.Location = new System.Drawing.Point(150, 16);
            this.cbProdSupp.Name = "cbProdSupp";
            this.cbProdSupp.Size = new System.Drawing.Size(210, 21);
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
            this.dataGridProdSupp.Location = new System.Drawing.Point(26, 105);
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.ReadOnly = true;
            this.dataGridProdSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdSupp.Size = new System.Drawing.Size(334, 274);
            this.dataGridProdSupp.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(428, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(428, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = ">";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataGridNotInSupp
            // 
            this.dataGridNotInSupp.AllowUserToAddRows = false;
            this.dataGridNotInSupp.AllowUserToDeleteRows = false;
            this.dataGridNotInSupp.AllowUserToOrderColumns = true;
            this.dataGridNotInSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotInSupp.Location = new System.Drawing.Point(538, 49);
            this.dataGridNotInSupp.Name = "dataGridNotInSupp";
            this.dataGridNotInSupp.ReadOnly = true;
            this.dataGridNotInSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNotInSupp.Size = new System.Drawing.Size(292, 330);
            this.dataGridNotInSupp.TabIndex = 5;
            this.dataGridNotInSupp.SelectionChanged += new System.EventHandler(this.dataGridNotInSupp_SelectionChanged);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(761, 20);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(70, 23);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "&Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(645, 20);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(70, 23);
            this.btnEditProd.TabIndex = 7;
            this.btnEditProd.Text = "&Edit";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(537, 20);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(62, 23);
            this.btnDeleteProd.TabIndex = 8;
            this.btnDeleteProd.Text = "&Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.Location = new System.Drawing.Point(47, 76);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteSupp.TabIndex = 11;
            this.btnDeleteSupp.Text = "&Delete";
            this.btnDeleteSupp.UseVisualStyleBackColor = true;
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.Location = new System.Drawing.Point(155, 76);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(69, 23);
            this.btnEditSupp.TabIndex = 10;
            this.btnEditSupp.Text = "&Edit";
            this.btnEditSupp.UseVisualStyleBackColor = true;
            this.btnEditSupp.Click += new System.EventHandler(this.btnEditSupp_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(271, 76);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(69, 23);
            this.btnAddSupp.TabIndex = 9;
            this.btnAddSupp.Text = "&Add ";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // frmProdSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 419);
            this.Controls.Add(this.btnDeleteSupp);
            this.Controls.Add(this.btnEditSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.dataGridNotInSupp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridProdSupp);
            this.Controls.Add(this.cbProdSupp);
            this.Name = "frmProdSuppliers";
            this.Text = "frmSuppliers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSuppliers_FormClosed);
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotInSupp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox cbProdSupp;
        private DataGridView dataGridProdSupp;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dataGridNotInSupp;
        private Button btnAddProducts;
        private Button btnEditProd;
        private Button btnDeleteProd;
        private Button btnDeleteSupp;
        private Button btnEditSupp;
        private Button btnAddSupp;
    }
}