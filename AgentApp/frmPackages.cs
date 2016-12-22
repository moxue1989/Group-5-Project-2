﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class FrmPackages : Form
    {
        public FrmPackages()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
        }

        private void pkgBnavSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    this.Validate();
                    this.packagesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    packagesTableAdapter.Fill(travelExpertsDataSet.Packages); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    tableAdapterManager.UpdateAll(travelExpertsDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show(@"A error occurred. " + @"Some rows were not updated.", @"Concurrency Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    packagesTableAdapter.Fill(travelExpertsDataSet.Packages); //populate textboxes with existing records
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(@"Database error # " + ex.Number + @": " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
        }
        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtPkgId) &&
                Validator.IsPresent(txtPkgName) &&
                Validator.IsPresent(txtPkgDesc) &&
                Validator.IsPresent(txtpkgBasePrice) &&
                Validator.IsPresent(txtpkgCommission);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This record will be permanently deleted.", @"Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            packagesBindingSource.CancelEdit();//cancels the edit command
        }
    }
}
