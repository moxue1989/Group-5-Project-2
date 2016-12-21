using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentApp
{
    public partial class frmGUI : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }
        public frmGUI()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

        }
        //Code written by Kasi Emmanuel
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes application
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Code written by Kasi Emmanuel
        //maximize and restore application window 
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
        //Code written by Kasi Emmanuel
        private void frmGUI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        //Code written by Kasi Emmanuel
        private void rtxtDesc_Enter(object sender, EventArgs e)
        {
            rtxtDesc.Clear();
        }
        //Code written by Kasi Emmanuel
        private void rtxtDesc_Leave(object sender, EventArgs e)
        {
            rtxtDesc.Text = "Enter Package Description";//placeholder text
        }

        private void frmGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }
    }
}
