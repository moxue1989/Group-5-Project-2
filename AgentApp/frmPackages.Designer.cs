namespace AgentApp
{
    partial class FrmPackages
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackages));
            this.travelExpertsDataSet = new AgentApp.TravelExpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new AgentApp.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new AgentApp.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtPkgId = new System.Windows.Forms.TextBox();
            this.dpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtpkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtpkgCommission = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bnavMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bnavMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnavMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bnavMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.pkgBnavSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(119, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 33;
            label1.Text = "Package Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(119, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 13);
            label2.TabIndex = 23;
            label2.Text = "Package Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(119, 106);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 24;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(119, 132);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 13);
            label4.TabIndex = 26;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(119, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 13);
            label5.TabIndex = 28;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(248, 214);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 13);
            label6.TabIndex = 30;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(357, 214);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 13);
            label7.TabIndex = 32;
            label7.Text = "Commission:";
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgentApp.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtPkgName
            // 
            this.txtPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPkgName.Location = new System.Drawing.Point(251, 74);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(200, 20);
            this.txtPkgName.TabIndex = 36;
            this.txtPkgName.Tag = "Package Name";
            // 
            // txtPkgId
            // 
            this.txtPkgId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PackageId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtPkgId.Location = new System.Drawing.Point(251, 48);
            this.txtPkgId.Name = "txtPkgId";
            this.txtPkgId.Size = new System.Drawing.Size(200, 20);
            this.txtPkgId.TabIndex = 35;
            this.txtPkgId.Tag = "Package ID";
            // 
            // dpPkgStartDate
            // 
            this.dpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packagesBindingSource, "PkgStartDate", true));
            this.dpPkgStartDate.Location = new System.Drawing.Point(251, 102);
            this.dpPkgStartDate.Name = "dpPkgStartDate";
            this.dpPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.dpPkgStartDate.TabIndex = 25;
            this.dpPkgStartDate.Tag = "Start Date";
            // 
            // dpPkgEndDate
            // 
            this.dpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packagesBindingSource, "PkgEndDate", true));
            this.dpPkgEndDate.Location = new System.Drawing.Point(251, 128);
            this.dpPkgEndDate.Name = "dpPkgEndDate";
            this.dpPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.dpPkgEndDate.TabIndex = 27;
            this.dpPkgEndDate.Tag = "End Date";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgDesc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPkgDesc.Location = new System.Drawing.Point(251, 154);
            this.txtPkgDesc.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(200, 20);
            this.txtPkgDesc.TabIndex = 29;
            this.txtPkgDesc.Tag = "Description";
            // 
            // txtpkgBasePrice
            // 
            this.txtpkgBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgBasePrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtpkgBasePrice.Location = new System.Drawing.Point(251, 230);
            this.txtpkgBasePrice.Name = "txtpkgBasePrice";
            this.txtpkgBasePrice.Size = new System.Drawing.Size(91, 20);
            this.txtpkgBasePrice.TabIndex = 31;
            this.txtpkgBasePrice.Tag = "Base Price";
            // 
            // txtpkgCommission
            // 
            this.txtpkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgAgencyCommission", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtpkgCommission.Location = new System.Drawing.Point(360, 230);
            this.txtpkgCommission.Name = "txtpkgCommission";
            this.txtpkgCommission.Size = new System.Drawing.Size(91, 20);
            this.txtpkgCommission.TabIndex = 34;
            this.txtpkgCommission.Tag = "Agency Commission";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.BindingSource = this.packagesBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.btnDelete;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnavMoveFirstItem,
            this.bnavMovePreviousItem,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.bnavMoveNextItem,
            this.bnavMoveLastItem,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.btnDelete,
            this.toolStripSeparator7,
            this.pkgBnavSave,
            this.toolStripSeparator8,
            this.btnCancel});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 266);
            this.bindingNavigator1.MoveFirstItem = this.bnavMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bnavMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bnavMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bnavMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(595, 25);
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bnavMoveFirstItem
            // 
            this.bnavMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnavMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bnavMoveFirstItem.Image")));
            this.bnavMoveFirstItem.Name = "bnavMoveFirstItem";
            this.bnavMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bnavMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bnavMoveFirstItem.Text = "Move first";
            // 
            // bnavMovePreviousItem
            // 
            this.bnavMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnavMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bnavMovePreviousItem.Image")));
            this.bnavMovePreviousItem.Name = "bnavMovePreviousItem";
            this.bnavMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bnavMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bnavMovePreviousItem.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnavMoveNextItem
            // 
            this.bnavMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnavMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bnavMoveNextItem.Image")));
            this.bnavMoveNextItem.Name = "bnavMoveNextItem";
            this.bnavMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bnavMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bnavMoveNextItem.Text = "Move next";
            // 
            // bnavMoveLastItem
            // 
            this.bnavMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnavMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bnavMoveLastItem.Image")));
            this.bnavMoveLastItem.Name = "bnavMoveLastItem";
            this.bnavMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bnavMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bnavMoveLastItem.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // pkgBnavSave
            // 
            this.pkgBnavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pkgBnavSave.Image = ((System.Drawing.Image)(resources.GetObject("pkgBnavSave.Image")));
            this.pkgBnavSave.Name = "pkgBnavSave";
            this.pkgBnavSave.Size = new System.Drawing.Size(23, 22);
            this.pkgBnavSave.Text = "Save Data";
            this.pkgBnavSave.Click += new System.EventHandler(this.pkgBnavSave_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(47, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 291);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtPkgId);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.dpPkgStartDate);
            this.Controls.Add(label4);
            this.Controls.Add(this.dpPkgEndDate);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtpkgBasePrice);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtpkgCommission);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FrmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPackages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.TextBox txtPkgId;
        private System.Windows.Forms.DateTimePicker dpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dpPkgEndDate;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtpkgBasePrice;
        private System.Windows.Forms.TextBox txtpkgCommission;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        protected System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton bnavMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bnavMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bnavMoveNextItem;
        private System.Windows.Forms.ToolStripButton bnavMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton pkgBnavSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnCancel;
    }
}