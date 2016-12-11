namespace AgentApp
{
    partial class frmGUI
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
            this.tcPackages = new MetroFramework.Controls.MetroTabControl();
            this.tpPackages = new MetroFramework.Controls.MetroTabPage();
            this.tpProducts = new MetroFramework.Controls.MetroTabPage();
            this.tpSupp = new MetroFramework.Controls.MetroTabPage();
            this.tpProdSupp = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbProdList = new MetroFramework.Controls.MetroComboBox();
            this.txtProductId = new MetroFramework.Controls.MetroTextBox();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new MetroFramework.Controls.MetroTextBox();
            this.txtPkgDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtBasePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCommission = new MetroFramework.Controls.MetroTextBox();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.tcPackages.SuspendLayout();
            this.tpPackages.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPackages
            // 
            this.tcPackages.AccessibleName = "";
            this.tcPackages.Controls.Add(this.tpPackages);
            this.tcPackages.Controls.Add(this.tpProducts);
            this.tcPackages.Controls.Add(this.tpSupp);
            this.tcPackages.Controls.Add(this.tpProdSupp);
            this.tcPackages.Location = new System.Drawing.Point(92, 86);
            this.tcPackages.Name = "tcPackages";
            this.tcPackages.SelectedIndex = 1;
            this.tcPackages.Size = new System.Drawing.Size(686, 349);
            this.tcPackages.Style = MetroFramework.MetroColorStyle.Blue;
            this.tcPackages.TabIndex = 0;
            this.tcPackages.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tcPackages.UseStyleColors = true;
            // 
            // tpPackages
            // 
            this.tpPackages.Controls.Add(this.metroLabel8);
            this.tpPackages.Controls.Add(this.txtCommission);
            this.tpPackages.Controls.Add(this.metroLabel7);
            this.tpPackages.Controls.Add(this.txtBasePrice);
            this.tpPackages.Controls.Add(this.metroLabel6);
            this.tpPackages.Controls.Add(this.metroLabel5);
            this.tpPackages.Controls.Add(this.metroLabel4);
            this.tpPackages.Controls.Add(this.metroLabel3);
            this.tpPackages.Controls.Add(this.metroLabel2);
            this.tpPackages.Controls.Add(this.metroLabel1);
            this.tpPackages.Controls.Add(this.txtPkgDesc);
            this.tpPackages.Controls.Add(this.txtPkgName);
            this.tpPackages.Controls.Add(this.dpEndDate);
            this.tpPackages.Controls.Add(this.dpStartDate);
            this.tpPackages.Controls.Add(this.txtProductId);
            this.tpPackages.Controls.Add(this.cbProdList);
            this.tpPackages.HorizontalScrollbarBarColor = true;
            this.tpPackages.Location = new System.Drawing.Point(4, 35);
            this.tpPackages.Name = "tpPackages";
            this.tpPackages.Size = new System.Drawing.Size(678, 310);
            this.tpPackages.TabIndex = 0;
            this.tpPackages.Text = "Packages";
            this.tpPackages.VerticalScrollbarBarColor = true;
            this.tpPackages.VerticalScrollbarSize = 12;
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.metroLabel10);
            this.tpProducts.Controls.Add(this.metroTextBox2);
            this.tpProducts.Controls.Add(this.metroLabel9);
            this.tpProducts.Controls.Add(this.metroTextBox1);
            this.tpProducts.HorizontalScrollbarBarColor = true;
            this.tpProducts.Location = new System.Drawing.Point(4, 35);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Size = new System.Drawing.Size(678, 310);
            this.tpProducts.TabIndex = 1;
            this.tpProducts.Text = "Products";
            this.tpProducts.VerticalScrollbarBarColor = true;
            this.tpProducts.VerticalScrollbarSize = 12;
            // 
            // tpSupp
            // 
            this.tpSupp.HorizontalScrollbarBarColor = true;
            this.tpSupp.Location = new System.Drawing.Point(4, 35);
            this.tpSupp.Name = "tpSupp";
            this.tpSupp.Size = new System.Drawing.Size(678, 310);
            this.tpSupp.TabIndex = 2;
            this.tpSupp.Text = "Suppliers";
            this.tpSupp.VerticalScrollbarBarColor = true;
            this.tpSupp.VerticalScrollbarSize = 12;
            // 
            // tpProdSupp
            // 
            this.tpProdSupp.HorizontalScrollbarBarColor = true;
            this.tpProdSupp.Location = new System.Drawing.Point(4, 35);
            this.tpProdSupp.Name = "tpProdSupp";
            this.tpProdSupp.Size = new System.Drawing.Size(678, 310);
            this.tpProdSupp.TabIndex = 3;
            this.tpProdSupp.Text = "Product Supplier";
            this.tpProdSupp.VerticalScrollbarBarColor = true;
            this.tpProdSupp.VerticalScrollbarSize = 12;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(758, 476);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 32);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Exit";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cbProdList
            // 
            this.cbProdList.FormattingEnabled = true;
            this.cbProdList.ItemHeight = 23;
            this.cbProdList.Location = new System.Drawing.Point(356, 140);
            this.cbProdList.Name = "cbProdList";
            this.cbProdList.Size = new System.Drawing.Size(210, 29);
            this.cbProdList.TabIndex = 2;
            this.cbProdList.Tag = "Product List";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(356, 62);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(153, 28);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.Tag = "Product ID";
            // 
            // dpStartDate
            // 
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartDate.Location = new System.Drawing.Point(27, 70);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(88, 22);
            this.dpStartDate.TabIndex = 4;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEndDate.Location = new System.Drawing.Point(147, 70);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(88, 22);
            this.dpEndDate.TabIndex = 5;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(27, 140);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.PromptText = "Enter Package Name";
            this.txtPkgName.Size = new System.Drawing.Size(230, 28);
            this.txtPkgName.TabIndex = 6;
            this.txtPkgName.Tag = "Package Name";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(27, 211);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.PromptText = "Enter Package Description";
            this.txtPkgDesc.Size = new System.Drawing.Size(230, 90);
            this.txtPkgDesc.TabIndex = 7;
            this.txtPkgDesc.Tag = "Package Description";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(356, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Product ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Description";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(356, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Products List";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 40);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Start Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(147, 40);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "End Date";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(356, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(356, 222);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.PromptText = "Price";
            this.txtBasePrice.Size = new System.Drawing.Size(94, 28);
            this.txtBasePrice.TabIndex = 14;
            this.txtBasePrice.Tag = "Base Price";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(472, 200);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Commission";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(472, 222);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(94, 28);
            this.txtCommission.TabIndex = 16;
            this.txtCommission.Tag = "Commission";
            // 
            // ofDialog
            // 
            this.ofDialog.FileName = "Browse";
            this.ofDialog.Title = "Attach Image";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Package Name";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(22, 48);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Product ID";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(22, 70);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.Tag = "Product ID";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(246, 48);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(95, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Product Name";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(246, 70);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(153, 28);
            this.metroTextBox2.TabIndex = 11;
            this.metroTextBox2.Tag = "Product ID";
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 531);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tcPackages);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGUI";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "     Customize Packages";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcPackages.ResumeLayout(false);
            this.tpPackages.ResumeLayout(false);
            this.tpPackages.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.tpProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcPackages;
        private MetroFramework.Controls.MetroTabPage tpPackages;
        private MetroFramework.Controls.MetroTabPage tpProducts;
        private MetroFramework.Controls.MetroTabPage tpSupp;
        private MetroFramework.Controls.MetroTabPage tpProdSupp;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtPkgDesc;
        private MetroFramework.Controls.MetroTextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private MetroFramework.Controls.MetroTextBox txtProductId;
        private MetroFramework.Controls.MetroComboBox cbProdList;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtBasePrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtCommission;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}

