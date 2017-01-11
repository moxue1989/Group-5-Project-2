namespace Agent_App_V2
{
    partial class frmEditPackageProducts
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
            this.lvAdded = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNotAdded = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvAdded
            // 
            this.lvAdded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Supplier});
            this.lvAdded.FullRowSelect = true;
            this.lvAdded.HideSelection = false;
            this.lvAdded.Location = new System.Drawing.Point(12, 36);
            this.lvAdded.MultiSelect = false;
            this.lvAdded.Name = "lvAdded";
            this.lvAdded.Size = new System.Drawing.Size(231, 213);
            this.lvAdded.TabIndex = 0;
            this.lvAdded.UseCompatibleStateImageBehavior = false;
            this.lvAdded.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product:";
            this.Product.Width = 76;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Supplier:";
            this.Supplier.Width = 150;
            // 
            // lvNotAdded
            // 
            this.lvNotAdded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNotAdded.FullRowSelect = true;
            this.lvNotAdded.HideSelection = false;
            this.lvNotAdded.Location = new System.Drawing.Point(354, 36);
            this.lvNotAdded.Name = "lvNotAdded";
            this.lvNotAdded.Size = new System.Drawing.Size(231, 213);
            this.lvNotAdded.TabIndex = 1;
            this.lvNotAdded.UseCompatibleStateImageBehavior = false;
            this.lvNotAdded.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product:";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier:";
            this.columnHeader2.Width = 150;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(278, 57);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 52);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = ">";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 52);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(213, 7);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(35, 13);
            this.lblPackageName.TabIndex = 4;
            this.lblPackageName.Text = "label1";
            // 
            // frmEditPackageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lvNotAdded);
            this.Controls.Add(this.lvAdded);
            this.Name = "frmEditPackageProducts";
            this.Text = "frmEditPackageProducts";
            this.Load += new System.EventHandler(this.frmEditPackageProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAdded;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ListView lvNotAdded;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPackageName;
    }
}