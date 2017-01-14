using System.ComponentModel;
using System.Windows.Forms;

namespace Agent_App_V2
{
    partial class frmAddEditPackage
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
            this.tbPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.tbPkgBasePrice = new System.Windows.Forms.TextBox();
            this.tbPkgDesc = new System.Windows.Forms.TextBox();
            this.tbPkgName = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAddedPS = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvNotAddedPS = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotAddedPS)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPkgAgencyCommission
            // 
            this.tbPkgAgencyCommission.Location = new System.Drawing.Point(230, 83);
            this.tbPkgAgencyCommission.Name = "tbPkgAgencyCommission";
            this.tbPkgAgencyCommission.Size = new System.Drawing.Size(100, 20);
            this.tbPkgAgencyCommission.TabIndex = 17;
            // 
            // tbPkgBasePrice
            // 
            this.tbPkgBasePrice.Location = new System.Drawing.Point(230, 57);
            this.tbPkgBasePrice.Name = "tbPkgBasePrice";
            this.tbPkgBasePrice.Size = new System.Drawing.Size(100, 20);
            this.tbPkgBasePrice.TabIndex = 16;
            // 
            // tbPkgDesc
            // 
            this.tbPkgDesc.Location = new System.Drawing.Point(230, 31);
            this.tbPkgDesc.Name = "tbPkgDesc";
            this.tbPkgDesc.Size = new System.Drawing.Size(100, 20);
            this.tbPkgDesc.TabIndex = 15;
            // 
            // tbPkgName
            // 
            this.tbPkgName.Location = new System.Drawing.Point(8, 31);
            this.tbPkgName.Name = "tbPkgName";
            this.tbPkgName.Size = new System.Drawing.Size(100, 20);
            this.tbPkgName.TabIndex = 12;
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Location = new System.Drawing.Point(8, 57);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtpPkgStartDate.TabIndex = 18;
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Location = new System.Drawing.Point(8, 83);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(135, 20);
            this.dtpPkgEndDate.TabIndex = 19;
            // 
            // dgvAddedPS
            // 
            this.dgvAddedPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedPS.Location = new System.Drawing.Point(8, 122);
            this.dgvAddedPS.MultiSelect = false;
            this.dgvAddedPS.Name = "dgvAddedPS";
            this.dgvAddedPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddedPS.Size = new System.Drawing.Size(240, 125);
            this.dgvAddedPS.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 45);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(254, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 45);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = ">";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvNotAddedPS
            // 
            this.dgvNotAddedPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotAddedPS.Location = new System.Drawing.Point(330, 122);
            this.dgvNotAddedPS.MultiSelect = false;
            this.dgvNotAddedPS.Name = "dgvNotAddedPS";
            this.dgvNotAddedPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotAddedPS.Size = new System.Drawing.Size(240, 165);
            this.dgvNotAddedPS.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 304);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvNotAddedPS);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAddedPS);
            this.Controls.Add(this.dtpPkgEndDate);
            this.Controls.Add(this.dtpPkgStartDate);
            this.Controls.Add(this.tbPkgAgencyCommission);
            this.Controls.Add(this.tbPkgBasePrice);
            this.Controls.Add(this.tbPkgDesc);
            this.Controls.Add(this.tbPkgName);
            this.Name = "frmAddEditPackage";
            this.Text = "frmAddEditPackage";
            this.Load += new System.EventHandler(this.frmAddEditPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotAddedPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPkgAgencyCommission;
        private TextBox tbPkgBasePrice;
        private TextBox tbPkgDesc;
        private TextBox tbPkgName;
        private DateTimePicker dtpPkgStartDate;
        private DateTimePicker dtpPkgEndDate;
        private DataGridView dgvAddedPS;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dgvNotAddedPS;
        private Button btnSave;
    }
}