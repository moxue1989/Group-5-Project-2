using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Agent_App_V2
{
    public partial class frmMain : Form
    {
        Agent agt = new Agent();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            var packageForm = new frmPackages();
            packageForm.ShowDialog();
            Close();
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
           
            var frmSuppliers = new frmProdSuppliers();
            frmSuppliers.ShowDialog();
            
        }

        private bool IsLoginValid()
        {
            return
                Validator.IsPresent(txtUsername) &&
                Validator.IsPresent(txtPassword) &&
                Validator.IsInt(txtPassword);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLoginValid())
            {
                agt.AgtFirstName = txtUsername.Text;
                agt.AgtPassword = Convert.ToInt32(txtPassword.Text);

                if (LoginDB.GetAgent(agt).AgtFirstName != null)
                {
                    Dashboardbody.Show();
                    header.Show();
                    Navbar.Show();
                    loginDashboard.Hide();
                    lblLoginMsg.Text = @"Welcome back " + agt.AgtFirstName;

                }
                else
                {
                    MessageBox.Show(@"Invalid Username or password");
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (agt.AgtFirstName != null)
            {
                Dashboardbody.Show();
                header.Show();
                Navbar.Show();
                loginDashboard.Hide();
                lblLoginMsg.Text = @"Welcome back " + agt.AgtFirstName;
            }
            else
            {
                Dashboardbody.Hide();
                header.Hide();
                Navbar.Hide();
                loginDashboard.Show();
                this.ActiveControl = label2;
            }
            

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            agt.AgtFirstName = null;
            agt.AgtPassword = 0;
            Dashboardbody.Hide();
            header.Hide();
            Navbar.Hide();
            loginDashboard.Show();
            this.ActiveControl = label2;
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

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == @"Username")
            {
                lblUsername.Visible = true;
                txtUsername.Text = "";

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

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == @"Password")
            {
                lblPW.Visible = true;
                txtPassword.Text = "";
                
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
