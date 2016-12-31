using System.ComponentModel;
using System.Windows.Forms;
using AgentApp.TravelExpertsDataSetTableAdapters;

namespace AgentApp
{
    partial class FrmSuppliers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppliers));
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new AgentApp.TravelExpertsDataSet();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.bNavSupp = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bNavMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bNavMovePrev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bNavMoveNext = new System.Windows.Forms.ToolStripButton();
            this.bNavMoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.suppliersTableAdapter = new AgentApp.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new AgentApp.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            productIdLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavSupp)).BeginInit();
            this.bNavSupp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            productIdLabel.Location = new System.Drawing.Point(1, 9);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(77, 19);
            productIdLabel.TabIndex = 1;
            productIdLabel.Text = "Supplier Id:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            prodNameLabel.Location = new System.Drawing.Point(1, 35);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(101, 19);
            prodNameLabel.TabIndex = 3;
            prodNameLabel.Text = "Supplier Name:";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupplierId", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtSupplierId.Location = new System.Drawing.Point(119, 9);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(136, 20);
            this.txtSupplierId.TabIndex = 1;
            this.txtSupplierId.Tag = "Supplier ID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSupName
            // 
            this.txtSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.txtSupName.Location = new System.Drawing.Point(119, 34);
            this.txtSupName.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtSupName.Multiline = true;
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(136, 40);
            this.txtSupName.TabIndex = 3;
            this.txtSupName.Tag = "Supplier Name";
            // 
            // bNavSupp
            // 
            this.bNavSupp.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bNavSupp.BindingSource = this.suppliersBindingSource;
            this.bNavSupp.CountItem = this.bindingNavigatorCountItem;
            this.bNavSupp.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bNavSupp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNavSupp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavSupp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNavMoveFirst,
            this.bNavMovePrev,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bNavMoveNext,
            this.bNavMoveLast,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.productsBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.btnCancel});
            this.bNavSupp.Location = new System.Drawing.Point(0, 181);
            this.bNavSupp.MoveFirstItem = null;
            this.bNavSupp.MoveLastItem = null;
            this.bNavSupp.MoveNextItem = null;
            this.bNavSupp.MovePreviousItem = null;
            this.bNavSupp.Name = "bNavSupp";
            this.bNavSupp.PositionItem = this.bindingNavigatorPositionItem;
            this.bNavSupp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNavSupp.Size = new System.Drawing.Size(384, 25);
            this.bNavSupp.TabIndex = 4;
            this.bNavSupp.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bNavMoveFirst
            // 
            this.bNavMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNavMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("bNavMoveFirst.Image")));
            this.bNavMoveFirst.Name = "bNavMoveFirst";
            this.bNavMoveFirst.RightToLeftAutoMirrorImage = true;
            this.bNavMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.bNavMoveFirst.Text = "Move first";
            this.bNavMoveFirst.Click += new System.EventHandler(this.bNavMoveFirst_Click);
            // 
            // bNavMovePrev
            // 
            this.bNavMovePrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNavMovePrev.Image = ((System.Drawing.Image)(resources.GetObject("bNavMovePrev.Image")));
            this.bNavMovePrev.Name = "bNavMovePrev";
            this.bNavMovePrev.RightToLeftAutoMirrorImage = true;
            this.bNavMovePrev.Size = new System.Drawing.Size(23, 22);
            this.bNavMovePrev.Text = "Move previous";
            this.bNavMovePrev.Click += new System.EventHandler(this.bNavMovePrev_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bNavMoveNext
            // 
            this.bNavMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNavMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("bNavMoveNext.Image")));
            this.bNavMoveNext.Name = "bNavMoveNext";
            this.bNavMoveNext.RightToLeftAutoMirrorImage = true;
            this.bNavMoveNext.Size = new System.Drawing.Size(23, 22);
            this.bNavMoveNext.Text = "Move next";
            this.bNavMoveNext.Click += new System.EventHandler(this.bNavMoveNext_Click);
            // 
            // bNavMoveLast
            // 
            this.bNavMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bNavMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("bNavMoveLast.Image")));
            this.bNavMoveLast.Name = "bNavMoveLast";
            this.bNavMoveLast.RightToLeftAutoMirrorImage = true;
            this.bNavMoveLast.Size = new System.Drawing.Size(23, 22);
            this.bNavMoveLast.Text = "Move last";
            this.bNavMoveLast.Click += new System.EventHandler(this.bNavMoveLast_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(47, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.36649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.04803F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.82096F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 206);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(productIdLabel);
            this.panel1.Controls.Add(this.txtSupplierId);
            this.panel1.Controls.Add(this.txtSupName);
            this.panel1.Controls.Add(prodNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(60, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 62);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(57, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 62);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suppliers - Travel Experts Inc.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(57, 146);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 60);
            this.panel5.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 60);
            this.panel3.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(325, 146);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(59, 60);
            this.panel6.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Controls.Add(this.btnExit);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(325, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(59, 62);
            this.panel10.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(20, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = null;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgentApp.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.suppliersBindingSource;
            // 
            // FrmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 206);
            this.Controls.Add(this.bNavSupp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavSupp)).EndInit();
            this.bNavSupp.ResumeLayout(false);
            this.bNavSupp.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource suppliersBindingSource;
        private TravelExpertsDataSet travelExpertsDataSet;
        private SuppliersTableAdapter suppliersTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private TextBox txtSupplierId;
        private TextBox txtSupName;
        private BindingNavigator bNavSupp;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bNavMoveFirst;
        private ToolStripButton bNavMovePrev;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bNavMoveNext;
        private ToolStripButton bNavMoveLast;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton productsBindingNavigatorSaveItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel10;
        private Button btnExit;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private ToolStripButton btnCancel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ErrorProvider errorProvider1;
    }
}