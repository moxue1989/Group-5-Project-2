namespace Agent_App_V2
{
    partial class frmAddEditSupplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.EditSupplierPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.EditSupplierPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(92, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(96, 85);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(182, 20);
            this.txtSuppName.TabIndex = 3;
            this.txtSuppName.Tag = "Suppler Name";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(261, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditSupplierPanel
            // 
            this.EditSupplierPanel.Controls.Add(this.btnCancel);
            this.EditSupplierPanel.Controls.Add(this.btnSave);
            this.EditSupplierPanel.Controls.Add(this.txtSuppName);
            this.EditSupplierPanel.Controls.Add(this.label2);
            this.EditSupplierPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditSupplierPanel.Location = new System.Drawing.Point(0, 0);
            this.EditSupplierPanel.Name = "EditSupplierPanel";
            this.EditSupplierPanel.Size = new System.Drawing.Size(440, 196);
            this.EditSupplierPanel.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(52, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditSupplier
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(440, 196);
            this.Controls.Add(this.EditSupplierPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditSupplier";
            this.Load += new System.EventHandler(this.frmAddEditSupplier_Load);
            this.EditSupplierPanel.ResumeLayout(false);
            this.EditSupplierPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel EditSupplierPanel;
        private System.Windows.Forms.Button btnSave;
    }
}