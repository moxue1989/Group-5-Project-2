namespace Agent_App_V2
{
    partial class frmSuppliers
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
            this.lvProd = new System.Windows.Forms.ListView();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.dataGridProdSupp = new System.Windows.Forms.DataGridView();
            this.chProdId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProd
            // 
            this.lvProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdId,
            this.chProdName});
            this.lvProd.Location = new System.Drawing.Point(490, 49);
            this.lvProd.Name = "lvProd";
            this.lvProd.Size = new System.Drawing.Size(261, 274);
            this.lvProd.TabIndex = 0;
            this.lvProd.UseCompatibleStateImageBehavior = false;
            this.lvProd.View = System.Windows.Forms.View.Details;
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(150, 16);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(210, 21);
            this.cbProducts.TabIndex = 1;
            this.cbProducts.SelectionChangeCommitted += new System.EventHandler(this.cbProducts_SelectionChangeCommitted);
            // 
            // dataGridProdSupp
            // 
            this.dataGridProdSupp.AllowUserToAddRows = false;
            this.dataGridProdSupp.AllowUserToDeleteRows = false;
            this.dataGridProdSupp.AllowUserToOrderColumns = true;
            this.dataGridProdSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdSupp.Location = new System.Drawing.Point(26, 49);
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.Size = new System.Drawing.Size(334, 274);
            this.dataGridProdSupp.TabIndex = 2;
            // 
            // chProdId
            // 
            this.chProdId.Text = "Product ID";
            this.chProdId.Width = 70;
            // 
            // chProdName
            // 
            this.chProdName.Text = "Product Name";
            this.chProdName.Width = 150;
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
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridProdSupp);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.lvProd);
            this.Name = "frmSuppliers";
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProd;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.DataGridView dataGridProdSupp;
        private System.Windows.Forms.ColumnHeader chProdId;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}