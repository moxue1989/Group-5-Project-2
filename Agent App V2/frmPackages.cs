using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_App_V2
{
    public partial class frmPackages : Form
    {
        //private List<Package> packageList = TravelExpertsDB.GetPackages();
        //private List<Package_Product_Supplier> ppsList = null;


        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            //int count = 0;
            //foreach (var package in packageList)
            //{
            //    Button button = new Button();
            //    button.Location = new Point(10, 30*count);
            //    button.Size = new Size(200, 30);
            //    button.TabIndex = count;
            //    button.Text = package.PkgName;
            //    button.Tag = count.ToString();
            //    button.Click += Package_Button_Click;

            //    Controls.Add(button);
            //    count++;
            //}
        }

        private void Package_Button_Click(object sender, EventArgs e)
        {
            //Package CurrentPackage = packageList[Convert.ToInt32(((Button) sender).Tag)];
            //ppsList = CurrentPackage.GetPPS();
            //foreach (var pps in ppsList)
            //{
            //    pps.GetProductSupplier();
            //}
        }
    }
}
