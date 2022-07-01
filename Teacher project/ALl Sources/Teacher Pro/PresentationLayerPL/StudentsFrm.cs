using BusinessLayerBL.Models;
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

namespace PresentationLayerPL
{
    public partial class StudentsFrm : Form
    {
        StudentsOperationBL studentsConn = new StudentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        GroupsOperationBL groupsConn = new GroupsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        public StudentsFrm()
        {
            InitializeComponent();
        }

        private void StudentsFrm_Load(object sender, EventArgs e)
        {
            FillComboGroups();
            btnDelete.Enabled = !SysUsers._IsAdmin ? false : true;
        }
        private void FillComboGroups()
        {
            cmbGroups.DataSource = groupsConn.ReadAll();
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupId";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Enabling()
        {
            txtStudentName.Enabled = txtStudentMobile.Enabled = txtParentMobile.Enabled = txtNotes.Enabled = txtAddress.Enabled = true;
        }
        private void Clear()
        {
            txtStudentName.Text = txtParentMobile.Text = txtStudentMobile.Text = txtNotes.Text = txtAddress.Text = string.Empty;
            cmbGroups.Text = string.Empty;
        }
        private void FillStudentsdgv()
        {
            dgvStudents.DataSource = studentsConn.ReadAll();
            //dgvGroups.Columns[0].Visible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //private void FillStudentsdgvBySearch()
        //{
        //    dgvStudents.DataSource = studentsConn.ReadAllBySearch();
        //    //dgvGroups.Columns[0].Visible = false;
        //    dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //}


        private void btnNew_Click(object sender, EventArgs e)
        {
            Enabling();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillStudentsdgv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtStudentName.Text) || string.IsNullOrEmpty(txtStudentMobile.Text) || string.IsNullOrEmpty(txtParentMobile.Text) || string.IsNullOrEmpty(txtNotes.Text))
            {
                MessageBox.Show("Plz Enter Full Data");
            }
            else
            {
                int id;
                try
                {
                    id = Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentRow.Index].Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Select a Student to Update!");
                    return;
                }

                StudentsBL SelectedStudent = new StudentsBL()
                {
                    StudentId = id,
                    StudentName = txtStudentName.Text,
                    StudentAddress = txtAddress.Text,
                    Notes = txtNotes.Text,
                    StudentMobile = txtStudentMobile.Text,
                    ParentMobile = txtParentMobile.Text,
                    GroupId = Convert.ToInt32(cmbGroups.SelectedValue)
                };

                int Result = studentsConn.Update(SelectedStudent);



                if (Result > 0)
                { MessageBox.Show("Update Done"); Clear(); FillStudentsdgv(); }
                else
                { MessageBox.Show("Not Updated!!"); }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            int id;
            try
            {
                id = Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Student to delete!");
                return;
            }
            if (MessageBox.Show("Are You sure Deleting", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int Result = studentsConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillStudentsdgv(); }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtNotes.Text) && !string.IsNullOrEmpty(txtParentMobile.Text) && !string.IsNullOrEmpty(txtStudentMobile.Text) && !string.IsNullOrEmpty(txtStudentName.Text) && cmbGroups.SelectedValue != null)
            {
                int Result = studentsConn.Insert(new StudentsBL
                {
                    StudentName = txtStudentName.Text,
                     StudentMobile = txtStudentMobile.Text,
                    ParentMobile = txtParentMobile.Text,
                     StudentAddress = txtAddress.Text,
                      Notes = txtNotes.Text,
                      GroupId =Convert.ToInt32(cmbGroups.SelectedValue)                      
                });
                if (Result > 0)
                {
                    MessageBox.Show("Saving ...");
                    Clear();
                    FillStudentsdgv();
                }
                else
                { MessageBox.Show("Not Saved!"); }
            }
            else
            {
                MessageBox.Show("Plz Enter Groups Full Data to insert it !!");
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Enabling();
            int id = Convert.ToInt32(dgvStudents.Rows[dgvStudents.CurrentRow.Index].Cells[0].Value);
            StudentsBL SelectedStudent = studentsConn.ReadByID(id);

            txtStudentName.Text = SelectedStudent.StudentName.ToString();
            txtStudentMobile.Text = SelectedStudent.StudentMobile.ToString();
            txtParentMobile.Text = SelectedStudent.ParentMobile.ToString();
            txtNotes.Text = SelectedStudent.Notes.ToString();
            txtAddress.Text = SelectedStudent.StudentAddress.ToString();
            cmbGroups.SelectedValue = SelectedStudent.GroupId.ToString();
        }

        private void cmbSearchBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{

            
            //if(cmbSearchBy.SelectedIndex == 0)
            //{
            //    //search by name
            //    FillDgvStudentsbyStudentName(txtSearch.Text);
            //}
            //else if(cmbSearchBy.SelectedIndex == 1)
            //{
            //    //search by mobile
            //    FillDgvStudentsbyMobile(txtSearch.Text);
            //}
            //else if (cmbSearchBy.SelectedIndex == 2)
            //{
            //    //search by group
            //    FillDgvStudentsbyGroup(txtSearch.Text);
            //}
            //}
            //catch (Exception)
            //{              
            //}
        }

        private void FillDgvStudentsbyMobile(string StudentMobile)
        {
            dgvStudents.DataSource = studentsConn.ReadSearchByStudentMobile(StudentMobile);
            //dgvGroups.Columns[0].Visible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillDgvStudentsbyStudentName(string StudentName)
        {
            dgvStudents.DataSource = studentsConn.ReadSearchByName(StudentName);
            //dgvGroups.Columns[0].Visible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FillDgvStudentsbyGroup(string group)
        {
            dgvStudents.DataSource = studentsConn.ReadSearchByGroup(group);
            //dgvGroups.Columns[0].Visible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                if (cmbSearchBy.SelectedIndex == 0)
                {
                    //search by name
                    FillDgvStudentsbyStudentName(txtSearch.Text);
                }
                else if (cmbSearchBy.SelectedIndex == 1)
                {
                    //search by mobile
                    FillDgvStudentsbyMobile(txtSearch.Text);
                }
                else if (cmbSearchBy.SelectedIndex == 2)
                {
                    //search by group
                    FillDgvStudentsbyGroup(txtSearch.Text);
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
