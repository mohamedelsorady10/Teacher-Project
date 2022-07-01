using BusinessLayerBL.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using BusinessLayerBL;
using BusinessLayerBL.Models;

namespace PresentationLayerPL
{
    public partial class GroupsFrm : Form
    {
        

       GroupsOperationBL groupsConn = new GroupsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);

        public GroupsFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Enabling();
            txtGroupLocation.Text = txtGroupName.Text = txtFirstDay.Text = txtSecondDay.Text = string.Empty;
        }
        private void Enabling()
        {
            txtGroupLocation.Enabled = txtGroupName.Enabled = txtFirstDay.Enabled = txtSecondDay.Enabled = true; 
        }
        private void Clear()
        {
            txtGroupName.Text = txtGroupLocation.Text = txtFirstDay.Text = txtSecondDay.Text = string.Empty;
            dtPickerGroupDate.Value = DateTime.Now;
        }

        private void FillGroupsdgv()
        {
           
            dgvGroups.DataSource = groupsConn.ReadAll();
            dgvGroups.Columns[0].Visible = false;
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGroupLocation.Text) && !string.IsNullOrEmpty(txtGroupName.Text) && !string.IsNullOrEmpty(txtFirstDay.Text) && !string.IsNullOrEmpty(txtSecondDay.Text) )
            {
                int Result = groupsConn.Insert(new GroupsBL
                {
                    GroupName = txtGroupName.Text,
                    GroupLocation = txtGroupLocation.Text,
                    GroupDate = dtPickerGroupDate.Value,
                    FirstDay = txtFirstDay.Text,
                    SecondDay = txtSecondDay.Text
                });
                if (Result > 0)
                {
                    MessageBox.Show("Saving ...");
                    Clear();
                    FillGroupsdgv();
                }
                else
                { MessageBox.Show("Not Saved!"); }
            }
            else
            {
                MessageBox.Show("Plz Enter Groups Full Data to insert it !!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Group to delete!");
                return;
            }
            if (MessageBox.Show("Are You sure Deleting", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int Result = groupsConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillGroupsdgv(); }
                else
                {
                    MessageBox.Show("Can't delete Group with Students");
                }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
      
            if (string.IsNullOrEmpty(txtGroupName.Text) || string.IsNullOrEmpty(txtGroupLocation.Text) || string.IsNullOrEmpty(txtFirstDay.Text) || string.IsNullOrEmpty(txtSecondDay.Text))
            {
                MessageBox.Show("Plz Enter Full Data");
            }
            else
            {
                int id;
                try
                {
                    id = Convert.ToInt32(dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Select a Group to Update!");
                    return;
                }

                GroupsBL SelectedGroup = new GroupsBL()
                {
                    GroupId = id,
                    GroupName = txtGroupName.Text,
                    GroupLocation = txtGroupLocation.Text,
                    GroupDate = dtPickerGroupDate.Value,
                    FirstDay = txtFirstDay.Text,
                    SecondDay = txtSecondDay.Text
                };

                int Result = groupsConn.Update(SelectedGroup);



                if (Result > 0)
                { MessageBox.Show("Update Done"); Clear(); FillGroupsdgv(); }
                else
                { MessageBox.Show("Not Updated!!"); }
            }


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillGroupsdgv();
        }

        private void dgvGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();
            int id = Convert.ToInt32(dgvGroups.Rows[dgvGroups.CurrentRow.Index].Cells[0].Value);
            GroupsBL SelectedGroup = groupsConn.ReadByID(id);

            txtGroupName.Text = SelectedGroup.GroupName.ToString();
            txtGroupLocation.Text = SelectedGroup.GroupLocation.ToString();
            dtPickerGroupDate.Text = SelectedGroup.GroupDate.ToString();
            txtFirstDay.Text = SelectedGroup.FirstDay.ToString();
            txtSecondDay.Text = SelectedGroup.SecondDay.ToString();

        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupsFrm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = !SysUsers._IsAdmin ? false : true;
        }

        private void txtGroupName_Leave(object sender, EventArgs e)
        {
            if (txtGroupName.Text == string.Empty)
            {
                errorProvider1.SetError(txtGroupName, "Plz enter a Group Name");
            }
            else { errorProvider1.Clear(); }
        }

        private void txtGroupLocation_Leave(object sender, EventArgs e)
        {
            if (txtGroupLocation.Text == string.Empty)
            {
                errorProvider1.SetError(txtGroupLocation, "Plz enter a Location");
            }
            else { errorProvider1.Clear(); }
        }

        private void txtFirstDay_Leave(object sender, EventArgs e)
        {
            if (txtFirstDay.Text == string.Empty)
            {
                errorProvider1.SetError(txtFirstDay, "Plz enter a first day");
            }
            else { errorProvider1.Clear(); }
        }

        private void txtSecondDay_Leave(object sender, EventArgs e)
        {
            if (txtSecondDay.Text == string.Empty)
            {
                errorProvider1.SetError(txtSecondDay, "Plz enter a second day");
            }
            else { errorProvider1.Clear(); }
        }
    }
}
