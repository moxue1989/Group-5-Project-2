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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // lvProd
            // 
            this.lvProd.Location = new System.Drawing.Point(395, 50);
            this.lvProd.Name = "lvProd";
            this.lvProd.Size = new System.Drawing.Size(393, 51);
            this.lvProd.TabIndex = 0;
            this.lvProd.UseCompatibleStateImageBehavior = false;
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
            this.dataGridProdSupp.Location = new System.Drawing.Point(18, 49);
            this.dataGridProdSupp.Name = "dataGridProdSupp";
            this.dataGridProdSupp.Size = new System.Drawing.Size(341, 274);
            this.dataGridProdSupp.TabIndex = 2;
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
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
    }
}