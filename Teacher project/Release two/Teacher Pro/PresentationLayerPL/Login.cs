using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using BusinessLayerBL.Models;
namespace PresentationLayerPL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SysUsers.SetUsers();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text,
                    password=textBox2.Text;
            if (SysUsers.UsersList.Any(u => u.UserName.Equals(username) && u.Password.Equals(password)))
            {
                 SysUsers._IsAdmin = SysUsers.UsersList.FirstOrDefault(u => u.UserName.Equals(username) && u.Password.Equals(password)).IsAdmin;

                MainFrm mainFrm = new MainFrm();
                mainFrm.FormClosed += new FormClosedEventHandler(this.Login_FormClosed);
                mainFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show( "username or password is not valid","warrning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Plz enter a Name");
            }
            else { errorProvider1.Clear(); }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Plz enter a valid Password");
            }
            else { errorProvider1.Clear(); }
        }
    }
}
