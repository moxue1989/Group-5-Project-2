using System.ComponentModel;
using System.Windows.Forms;

namespace Agent_App_V2
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnProductSuppliers = new System.Windows.Forms.Button();
            this.lblLoginMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Packages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.Location = new System.Drawing.Point(281, 144);
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Size = new System.Drawing.Size(126, 97);
            this.btnProductSuppliers.TabIndex = 1;
            this.btnProductSuppliers.Text = "Product and Suppliers";
            this.btnProductSuppliers.UseVisualStyleBackColor = true;
            this.btnProductSuppliers.Click += new System.EventHandler(this.btnProductSuppliers_Click);
            // 
            // lblLoginMsg
            // 
            this.lblLoginMsg.AutoSize = true;
            this.lblLoginMsg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoginMsg.Location = new System.Drawing.Point(105, 33);
            this.lblLoginMsg.Name = "lblLoginMsg";
            this.lblLoginMsg.Size = new System.Drawing.Size(107, 19);
            this.lblLoginMsg.TabIndex = 2;
            this.lblLoginMsg.Text = "Welcome \"User\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(485, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logout";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginMsg);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnProductSuppliers;
        private Label lblLoginMsg;
        private Label label1;
    }
}

