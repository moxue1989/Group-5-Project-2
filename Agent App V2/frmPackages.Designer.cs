namespace Agent_App_V2
{
    partial class frmPackages
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
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPackageID = new System.Windows.Forms.TextBox();
            this.tbPkgName = new System.Windows.Forms.TextBox();
            this.tbPkgStartDate = new System.Windows.Forms.TextBox();
            this.tbPkgEndDate = new System.Windows.Forms.TextBox();
            this.tbPkgDesc = new System.Windows.Forms.TextBox();
            this.tbPkgBasePrice = new System.Windows.Forms.TextBox();
            this.tbPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(296, 155);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(322, 125);
            this.lvProducts.TabIndex = 2;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.Width = 150;
            // 
            // tbPackageID
            // 
            this.tbPackageID.Location = new System.Drawing.Point(296, 51);
            this.tbPackageID.Name = "tbPackageID";
            this.tbPackageID.Size = new System.Drawing.Size(100, 20);
            this.tbPackageID.TabIndex = 3;
            // 
            // tbPkgName
            // 
            this.tbPkgName.Location = new System.Drawing.Point(296, 77);
            this.tbPkgName.Name = "tbPkgName";
            this.tbPkgName.Size = new System.Drawing.Size(100, 20);
            this.tbPkgName.TabIndex = 4;
            // 
            // tbPkgStartDate
            // 
            this.tbPkgStartDate.Location = new System.Drawing.Point(296, 103);
            this.tbPkgStartDate.Name = "tbPkgStartDate";
            this.tbPkgStartDate.Size = new System.Drawing.Size(100, 20);
            this.tbPkgStartDate.TabIndex = 5;
            // 
            // tbPkgEndDate
            // 
            this.tbPkgEndDate.Location = new System.Drawing.Point(296, 129);
            this.tbPkgEndDate.Name = "tbPkgEndDate";
            this.tbPkgEndDate.Size = new System.Drawing.Size(100, 20);
            this.tbPkgEndDate.TabIndex = 6;
            // 
            // tbPkgDesc
            // 
            this.tbPkgDesc.Location = new System.Drawing.Point(518, 51);
            this.tbPkgDesc.Name = "tbPkgDesc";
            this.tbPkgDesc.Size = new System.Drawing.Size(100, 20);
            this.tbPkgDesc.TabIndex = 7;
            // 
            // tbPkgBasePrice
            // 
            this.tbPkgBasePrice.Location = new System.Drawing.Point(518, 77);
            this.tbPkgBasePrice.Name = "tbPkgBasePrice";
            this.tbPkgBasePrice.Size = new System.Drawing.Size(100, 20);
            this.tbPkgBasePrice.TabIndex = 8;
            // 
            // tbPkgAgencyCommission
            // 
            this.tbPkgAgencyCommission.Location = new System.Drawing.Point(518, 103);
            this.tbPkgAgencyCommission.Name = "tbPkgAgencyCommission";
            this.tbPkgAgencyCommission.Size = new System.Drawing.Size(100, 20);
            this.tbPkgAgencyCommission.TabIndex = 9;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(296, 287);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(100, 23);
            this.btnAddPackage.TabIndex = 10;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Enabled = false;
            this.btnEditPackage.Location = new System.Drawing.Point(402, 287);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(100, 23);
            this.btnEditPackage.TabIndex = 11;
            this.btnEditPackage.Text = "Edit Package";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Enabled = false;
            this.btnDeletePackage.Location = new System.Drawing.Point(508, 286);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(100, 23);
            this.btnDeletePackage.TabIndex = 12;
            this.btnDeletePackage.Text = "Delete Package";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 322);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.tbPkgAgencyCommission);
            this.Controls.Add(this.tbPkgBasePrice);
            this.Controls.Add(this.tbPkgDesc);
            this.Controls.Add(this.tbPkgEndDate);
            this.Controls.Add(this.tbPkgStartDate);
            this.Controls.Add(this.tbPkgName);
            this.Controls.Add(this.tbPackageID);
            this.Controls.Add(this.lvProducts);
            this.Name = "frmPackages";
            this.Text = "frmPackages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbPackageID;
        private System.Windows.Forms.TextBox tbPkgName;
        private System.Windows.Forms.TextBox tbPkgStartDate;
        private System.Windows.Forms.TextBox tbPkgEndDate;
        private System.Windows.Forms.TextBox tbPkgDesc;
        private System.Windows.Forms.TextBox tbPkgBasePrice;
        private System.Windows.Forms.TextBox tbPkgAgencyCommission;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnDeletePackage;
    }
}