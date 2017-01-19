using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Agent_App_V2
{
    public partial class frmMain : Form
    {
        private Agent agt;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            var packageForm = new frmPackages();
            if (packageForm.ShowDialog() == DialogResult.Abort)
            {
                Logout();
            }
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
            var frmSuppliers = new frmProdSuppliers();
            if (frmSuppliers.ShowDialog() == DialogResult.Abort)
            {
                Logout();
            }
        }

        private bool IsLoginValid()
        {
            return
                Validator.IsPresent(txtUsername) &&
                Validator.IsPresent(txtPassword);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtPassword) && Validator.IsPresent(txtUsername))
            {
                if (IsLoginValid())
                {
                    agt = new Agent();
                    agt.AgtFirstName = txtUsername.Text;
                    agt.AgtPassword = (txtPassword.Text);

                    agt = LoginDB.GetAgent(agt);
                    if (agt.AgtFirstName != null)
                    {
                        Login();
                    }
                    else
                    {
                        MessageBox.Show(@"Invalid Username or password");
                    }
                }
            }
        }

        private void Login()
        {
            Dashboardbody.Show();
            header.Show();
            Navbar.Show();
            loginDashboard.Hide();
            string agentWelcome = agt.AgtPosition + " " + agt.AgtFirstName + " " + agt.AgtLastName;
            lblLoginMsg.Text = @"Welcome back " + agentWelcome;
            AcceptButton = null;
        }

        private void Logout()
        {
            agt = null;
            Dashboardbody.Hide();
            header.Hide();
            Navbar.Hide();
            loginDashboard.Show();
            txtUsername.Text = @"Username";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.Text = @"Password";
            txtPassword.ForeColor = Color.Gray;
            lblPW.Visible = false;
            lblUsername.Visible = false;
            this.ActiveControl = label2;
            AcceptButton = btnLogin;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           Logout();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes application
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == @"Username")
            {
                lblUsername.Visible = true;
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.FromArgb(33, 33, 33);

            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == @"")
            {
                lblUsername.Visible = false;
                txtUsername.Text = @"Username";

            }
        }
        
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == @"Password")
            {
                lblPW.Visible = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(33, 33, 33);

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == @"")
            {
                lblPW.Visible = false;
                txtPassword.Text = @"Password";
                
            }
        }
    }
}
