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
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        Agent agt = new Agent();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLoginValid())
            {
                agt.AgtFirstName = txtUserName.Text;
                agt.AgtPassword = Convert.ToInt32(txtPassword.Text);

                if (LoginDB.GetAgent(agt).AgtFirstName != null)
                {
                    MessageBox.Show(@"Logined in!");
                }
                else
                {
                    MessageBox.Show(@"Invalid Username or password");
                }

            }
            
        }

        private bool IsLoginValid()
        {
            return
                Validator.IsPresent(txtUserName) &&
                Validator.IsPresent(txtPassword) &&
                Validator.IsInt(txtPassword);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
