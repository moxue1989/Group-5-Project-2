using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class Suppliers : Form
    {
        private string SupplierId;
        private string SupName;

        //On Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            lvData.View = View.Details;//View the data details
            lvData.FullRowSelect = true;//Select the entire row of data

            //Add Columns
            lvData.Columns.Add("SupName", 150);//Add Name column with and set width to 150
            lvData.Columns.Add("SupplierId", 150);//Add Position column with and set width to 150

        }

        private void lvData_MouseClick(object sender, MouseEventArgs e)
        {
            String SupName = lvData.SelectedItems[0].SubItems[0].Text;//store list item name in string
            String SupplierId = lvData.SelectedItems[0].SubItems[1].Text;//store list item pos in string

            txtSupName.Focus();
            txtSupName.Text = SupName;//Display selected row "name" in input box
            txtSupId.Text = SupplierId;//Display selected row "pos" in input box

        }

        //Add Row
        private void add(string SupName, String SupplierId)
        {
            String[] row = { SupName, SupplierId };// Create array for storing user data

            ListViewItem item = new ListViewItem(row); //Store user input in array

            //Add Items
            lvData.Items.Add(item);//Add user input in List View
        }
        //Add record button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtSupName.Text, txtSupId.Text);//add all inputed data into ListView

            //Clear Text
            txtSupName.Clear();
            txtSupId.Clear();

            txtSupName.Focus();

        }





        //Clear Inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Text
            txtSupName.Clear();
            txtSupId.Clear();


            txtSupName.Focus();
        }

        //Update Input Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lvData.SelectedItems[0].SubItems[0].Text = txtSupName.Text;//pull list item name and update if necassary with new iput
            lvData.SelectedItems[0].SubItems[1].Text = txtSupId.Text;//pull list item pos and update if necassary with new iput

            //Clear Text
            txtSupName.Clear();
            txtSupId.Clear();


            txtSupName.Focus();
        }

        //Delete Method declared
        private void delete()
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lvData.Items.RemoveAt(lvData.SelectedIndices[0]);//remove the selected row
                //Clear Text
                txtSupName.Clear();
                txtSupId.Clear();


                txtSupName.Focus();
            }
        }

        //Delete Records
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

        }
    }
}
