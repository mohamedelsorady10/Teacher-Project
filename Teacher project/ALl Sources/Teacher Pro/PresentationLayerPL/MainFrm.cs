using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerPL
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        


        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            new StudentsFrm().Show();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            new GroupsFrm().Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnRestoreDown.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void BtnRestoreDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximize.BringToFront();
        }
       
        private void MainFrm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StudentsTestFrm().Show();
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            new AttendanceFrm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PaymentsFrm().Show();
        }
    }
}
