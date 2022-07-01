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
    public partial class StudentsTestFrm : Form
    {
        StudentTestsOperationBL StudentTestsConn = new StudentTestsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        StudentsOperationBL studentsConn = new StudentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        TestsOperationsBL TestsConn = new TestsOperationsBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        GroupsOperationBL GroupsConn = new GroupsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);

        public StudentsTestFrm()
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
            Clear();
        }
        private void Enabling()
        {
            cmbStudents.Enabled = npdStudentGrade.Enabled = cmbTests.Enabled = true;
        }
        private void Clear()
        {
            cmbStudents.Text = cmbTests.Text = string.Empty;
            npdStudentGrade.Value = 0;            
        }
        private void FillTestsdgv()
        {

            dgvTests.DataSource = StudentTestsConn.ReadAll();
            //dgvTests.Columns[0].Visible = false;
            dgvTests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FillStudentTestsdgv()
        {

            dgvTests.DataSource = StudentTestsConn.ReadAll();
            //dgvTests.Columns[0].Visible = false;
            dgvTests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbTests.SelectedValue != null && cmbStudents.SelectedValue!=null && npdStudentGrade.Value > 0 )
            {
                int Result = StudentTestsConn.Insert(new StudentTestsBL
                {
                    StudentId = Convert.ToInt32(cmbStudents.SelectedValue),
                    TestId = Convert.ToInt32(cmbTests.SelectedValue),
                    StudentGrade = npdStudentGrade.Value
                });
                if (Result > 0)
                {
                    MessageBox.Show("Saving ...");
                    Clear();
                    FillTestsdgv();
                }
                else
                { MessageBox.Show("Not Saved!"); }
            }
            else
            {
                MessageBox.Show("Plz Enter Test Full Data to insert it !!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dgvTests.Rows[dgvTests.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Test to delete!");
                return;
            }
            if (MessageBox.Show("Are You sure Deleting", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int Result = StudentTestsConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillTestsdgv(); }
                else { MessageBox.Show("Delete is canceled"); }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null || cmbTests.SelectedValue == null || npdStudentGrade.Value < 0)
            {
                MessageBox.Show("Plz Enter Full Data");
            }
            else
            {
                int id;
                try
                {
                    id = Convert.ToInt32(dgvTests.Rows[dgvTests.CurrentRow.Index].Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Select a Test to Update!");
                    return;
                }

                StudentTestsBL SelectedTest = new StudentTestsBL()
                {
                    StudentTestID = id,
                    TestId =Convert.ToInt32(cmbTests.SelectedValue),
                    StudentId = Convert.ToInt32(cmbStudents.SelectedValue),
                    StudentGrade = npdStudentGrade.Value,
                };

                int Result = StudentTestsConn.Update(SelectedTest);



                if (Result > 0)
                { MessageBox.Show("Update Done"); Clear(); FillTestsdgv(); }
                else
                { MessageBox.Show("Not Updated!!"); }
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillTestsdgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TestsFrm().Show();
        }

        private void StudentsTestFrm_Load(object sender, EventArgs e)
        {
            FillComboGroups();
            FillComboTest();
            btnDelete.Enabled = !SysUsers._IsAdmin ? false : true;
        }
        private void FillComboGroups()
        {
            cmbGroups.DataSource = GroupsConn.ReadAll();
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupId";
        }
        private void FillComboStudentsbyGroups(int id)
        {
            cmbStudents.DataSource = studentsConn.ReadAllByGroup(id);
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";
        }
        private void FillComboTest()
        {
            cmbTests.DataSource = TestsConn.ReadAll();
            cmbTests.DisplayMember = "TestName";
            cmbTests.ValueMember = "TestId";
        }

        private void dgvTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();
            int id = Convert.ToInt32(dgvTests.Rows[dgvTests.CurrentRow.Index].Cells[0].Value);
            StudentTestsBL SelectedStudentTest = StudentTestsConn.ReadByID(id);

            cmbStudents.SelectedValue = SelectedStudentTest.StudentId.ToString();
            cmbTests.SelectedValue = SelectedStudentTest.TestId.ToString();
            npdStudentGrade.Value = SelectedStudentTest.StudentGrade;
        }

       

    

        private void cmbGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillComboStudentsbyGroups((int)cmbGroups.SelectedValue);
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
