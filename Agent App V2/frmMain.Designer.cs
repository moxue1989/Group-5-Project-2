namespace Agent_App_V2
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnProductSuppliers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Packages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.Location = new System.Drawing.Point(213, 194);
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Size = new System.Drawing.Size(87, 40);
            this.btnProductSuppliers.TabIndex = 1;
            this.btnProductSuppliers.Text = "Product Suppliers";
            this.btnProductSuppliers.UseVisualStyleBackColor = true;
            this.btnProductSuppliers.Click += new System.EventHandler(this.btnProductSuppliers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KASI: Use this button to run your form";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "Travel Experts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProductSuppliers;
        private System.Windows.Forms.Label label1;
    }
}

