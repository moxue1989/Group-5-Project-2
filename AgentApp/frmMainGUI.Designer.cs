﻿using System.ComponentModel;
using System.Windows.Forms;
using AgentApp.TravelExpertsDataSetTableAdapters;

namespace AgentApp
{
    partial class FrmMainGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainGui));
            this.tableAdapterManager = new AgentApp.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.displayPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACKAGESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.navPkgAddEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navProdAddEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSUPPLIERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navProdSuppAddEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navSuppAddEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRecordsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new AgentApp.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.packagesProductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packages_Products_SuppliersTableAdapter = new AgentApp.TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewRecordsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AgentApp.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eDITToolStripMenuItem1,
            this.vIEWToolStripMenuItem1,
            this.pACKAGESToolStripMenuItem1,
            this.pRODUCTSToolStripMenuItem,
            this.pRODUCTSUPPLIERSToolStripMenuItem,
            this.sUPPLIERSToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // eDITToolStripMenuItem1
            // 
            this.eDITToolStripMenuItem1.Name = "eDITToolStripMenuItem1";
            this.eDITToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem1.Text = "EDIT";
            // 
            // vIEWToolStripMenuItem1
            // 
            this.vIEWToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.toolStripSeparator1,
            this.monthlyToolStripMenuItem,
            this.yearlyToolStripMenuItem,
            this.toolStripSeparator3,
            this.displayPackagesToolStripMenuItem,
            this.toolStripSeparator2,
            this.packagesToolStripMenuItem});
            this.vIEWToolStripMenuItem1.Name = "vIEWToolStripMenuItem1";
            this.vIEWToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem1.Text = "VIEW";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Enabled = false;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // yearlyToolStripMenuItem
            // 
            this.yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            this.yearlyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.yearlyToolStripMenuItem.Text = "Yearly";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(123, 6);
            // 
            // displayPackagesToolStripMenuItem
            // 
            this.displayPackagesToolStripMenuItem.Enabled = false;
            this.displayPackagesToolStripMenuItem.Name = "displayPackagesToolStripMenuItem";
            this.displayPackagesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.displayPackagesToolStripMenuItem.Text = "Display";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.packagesToolStripMenuItem.Text = " Packages";
            // 
            // pACKAGESToolStripMenuItem1
            // 
            this.pACKAGESToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navPkgAddEdit,
            this.toolStripSeparator7,
            this.viewRecordsToolStripMenuItem3});
            this.pACKAGESToolStripMenuItem1.Name = "pACKAGESToolStripMenuItem1";
            this.pACKAGESToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.pACKAGESToolStripMenuItem1.Text = "PACKAGES";
            // 
            // navPkgAddEdit
            // 
            this.navPkgAddEdit.Name = "navPkgAddEdit";
            this.navPkgAddEdit.Size = new System.Drawing.Size(121, 22);
            this.navPkgAddEdit.Text = "Add/Edit";
            this.navPkgAddEdit.Click += new System.EventHandler(this.navPkgAddEdit_Click);
            // 
            // pRODUCTSToolStripMenuItem
            // 
            this.pRODUCTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navProdAddEdit,
            this.toolStripSeparator5,
            this.viewRecordsToolStripMenuItem1});
            this.pRODUCTSToolStripMenuItem.Name = "pRODUCTSToolStripMenuItem";
            this.pRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.pRODUCTSToolStripMenuItem.Text = "PRODUCTS";
            // 
            // navProdAddEdit
            // 
            this.navProdAddEdit.Name = "navProdAddEdit";
            this.navProdAddEdit.Size = new System.Drawing.Size(144, 22);
            this.navProdAddEdit.Text = "Add/Edit";
            this.navProdAddEdit.Click += new System.EventHandler(this.navProdAddEdit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // viewRecordsToolStripMenuItem1
            // 
            this.viewRecordsToolStripMenuItem1.Name = "viewRecordsToolStripMenuItem1";
            this.viewRecordsToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.viewRecordsToolStripMenuItem1.Text = "View Records";
            // 
            // pRODUCTSUPPLIERSToolStripMenuItem
            // 
            this.pRODUCTSUPPLIERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navProdSuppAddEdit,
            this.toolStripSeparator4,
            this.viewRecordsToolStripMenuItem});
            this.pRODUCTSUPPLIERSToolStripMenuItem.Name = "pRODUCTSUPPLIERSToolStripMenuItem";
            this.pRODUCTSUPPLIERSToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.pRODUCTSUPPLIERSToolStripMenuItem.Text = "PRODUCT SUPPLIERS";
            // 
            // navProdSuppAddEdit
            // 
            this.navProdSuppAddEdit.Name = "navProdSuppAddEdit";
            this.navProdSuppAddEdit.Size = new System.Drawing.Size(144, 22);
            this.navProdSuppAddEdit.Text = "Add/Edit";
            this.navProdSuppAddEdit.Click += new System.EventHandler(this.navProdSuppAddEdit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            // 
            // sUPPLIERSToolStripMenuItem
            // 
            this.sUPPLIERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navSuppAddEdit,
            this.toolStripSeparator6,
            this.viewRecordsToolStripMenuItem2});
            this.sUPPLIERSToolStripMenuItem.Name = "sUPPLIERSToolStripMenuItem";
            this.sUPPLIERSToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.sUPPLIERSToolStripMenuItem.Text = "SUPPLIERS";
            // 
            // navSuppAddEdit
            // 
            this.navSuppAddEdit.Name = "navSuppAddEdit";
            this.navSuppAddEdit.Size = new System.Drawing.Size(144, 22);
            this.navSuppAddEdit.Text = "Add/Edit";
            this.navSuppAddEdit.Click += new System.EventHandler(this.navSuppAddEdit_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // viewRecordsToolStripMenuItem2
            // 
            this.viewRecordsToolStripMenuItem2.Name = "viewRecordsToolStripMenuItem2";
            this.viewRecordsToolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.viewRecordsToolStripMenuItem2.Text = "View Records";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(838, 2);
            this.label1.MinimumSize = new System.Drawing.Size(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "&Sign out";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // packagesProductsSuppliersBindingSource
            // 
            this.packagesProductsSuppliersBindingSource.DataMember = "Packages_Products_Suppliers";
            // 
            // packages_Products_SuppliersTableAdapter
            // 
            this.packages_Products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            // 
            // viewRecordsToolStripMenuItem3
            // 
            this.viewRecordsToolStripMenuItem3.Name = "viewRecordsToolStripMenuItem3";
            this.viewRecordsToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.viewRecordsToolStripMenuItem3.Text = "View Records";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // FrmMainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainGUI";
            this.Load += new System.EventHandler(this.frmMainGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableAdapterManager tableAdapterManager;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private ToolStripMenuItem pRODUCTSUPPLIERSToolStripMenuItem;
        private ToolStripMenuItem sUPPLIERSToolStripMenuItem;
        private ToolStripMenuItem navProdAddEdit;
        private BindingSource productsBindingSource;
        private ProductsTableAdapter productsTableAdapter;
        private ToolStripMenuItem navProdSuppAddEdit;
        private ToolStripMenuItem navSuppAddEdit;
        private ToolStripMenuItem eDITToolStripMenuItem1;
        private ToolStripMenuItem vIEWToolStripMenuItem1;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem monthlyToolStripMenuItem;
        private ToolStripMenuItem yearlyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem displayPackagesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem packagesToolStripMenuItem;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem viewRecordsToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem viewRecordsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem viewRecordsToolStripMenuItem2;
        private Label label1;
        private BindingSource packagesProductsSuppliersBindingSource;
        private Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter;
        private BindingSource productsBindingSource1;
        private ToolStripMenuItem pACKAGESToolStripMenuItem1;
        private ToolStripMenuItem navPkgAddEdit;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem viewRecordsToolStripMenuItem3;
    }
}