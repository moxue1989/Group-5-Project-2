using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace AgentApp
{
    public partial class ucLogin : MetroUserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }
    }
}
