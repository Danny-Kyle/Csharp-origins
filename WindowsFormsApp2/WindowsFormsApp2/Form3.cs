using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btndashboard.Height;
            pnlNav.Top = btndashboard.Top;
            pnlNav.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btndashboard.Height;
            pnlNav.Top = btndashboard.Top;
            pnlNav.Left = btndashboard.Left;    
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEmployeeStatus_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmployeeStatus.Height;
            pnlNav.Top = btnEmployeeStatus.Top;
            btnEmployeeStatus.BackColor = Color.FromArgb(46, 51, 73);
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUS_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUS.Height;
            pnlNav.Top = btnContactUS.Top;
            btnContactUS.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btndashboard_Leave(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEmployeeStatus_Leave(object sender, EventArgs e)
        {
            btnEmployeeStatus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUS_Leave(object sender, EventArgs e)
        {
            btnContactUS.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
