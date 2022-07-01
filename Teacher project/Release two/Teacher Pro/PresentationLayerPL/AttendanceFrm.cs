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
    public partial class AttendanceFrm : Form
    {
        AttendanceOperationBL AttendanceConn = new AttendanceOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        GroupsOperationBL Groupsconn = new GroupsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        StudentsOperationBL studentsConn = new StudentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        public AttendanceFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceFrm_Load(object sender, EventArgs e)
        {
            FillComboGroups();
            FillComboStudents();

            btnDelete.Enabled = !SysUsers._IsAdmin? false:true;
            
        }
        private void FillComboStudents()
        {
            cmbStudents.DataSource = studentsConn.ReadAll();
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";

        }
        private void FillComboGroups()
        {
            cmbGroups.DataSource = Groupsconn.ReadAll();
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "GroupId";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillAttendancedgv();
        }
        private void FillAttendancedgv()
        {           
            dgvAttendance.DataSource = AttendanceConn.ReadAll(dtPickerDate.Value);
            dgvAttendance.Columns[0].Visible = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null )
            {
                MessageBox.Show("Plz Enter Full Data");
            }
            else
            {
                int id;
                try
                {
                    id = Convert.ToInt32(dgvAttendance.Rows[dgvAttendance.CurrentRow.Index].Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Select an attendance to Update!");
                    return;
                }

                AttendancesBL SelectedAttendance = new AttendancesBL()
                {
                    AttendanceID = id,
                    StudentID = Convert.ToInt32(cmbStudents.SelectedValue),                   
                    AttendanceDate = Convert.ToDateTime(dtPickerDate.Value)
                };

                int Result = AttendanceConn.Update(SelectedAttendance);



                if (Result > 0)
                { MessageBox.Show("Update Done"); /*Clear();*/ FillAttendancedgv(); }
                else
                { MessageBox.Show("Not Updated!!"); }
            }
            
        }
        private void Clear()
        {
            cmbStudents.Text = cmbGroups.Text = string.Empty;
            dtPickerDate.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dgvAttendance.Rows[dgvAttendance.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a attendance to delete!");
                return;
            }
            if (MessageBox.Show("Are You sure Deleting", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int Result = AttendanceConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillAttendancedgv(); }
                else { MessageBox.Show("Delete is canceled"); }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbGroups.SelectedValue != null && cmbStudents.SelectedValue != null)
            {
                int Result = AttendanceConn.Insert(new AttendancesBL
                {
                    StudentID = Convert.ToInt32(cmbStudents.SelectedValue),
                    AttendanceDate = dtPickerDate.Value
                });
                if (Result > 0)
                {
                    MessageBox.Show("Saving ...");
                    Clear();
                    FillAttendancedgv();
                }
                else
                { MessageBox.Show("Not Saved!"); }
                }
                else
                {
                    MessageBox.Show("Plz Enter Test Full Data to insert it !!");
                }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Enabling();
            Clear();
        }
        private void Enabling()
        {
            cmbStudents.Enabled = cmbGroups.Enabled = dtPickerDate.Enabled = true;
        }

        private void cmbGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillComboStudentsbyGroups((int)cmbGroups.SelectedValue);
        }
        private void FillComboStudentsbyGroups(int id)
        {
            cmbStudents.DataSource = studentsConn.ReadAllByGroup(id);
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();
            int id = Convert.ToInt32(dgvAttendance.Rows[dgvAttendance.CurrentRow.Index].Cells[0].Value);
            AttendancesBL SelectedAttendance = AttendanceConn.ReadByID(id);
            //StudentsBL studentsBL = studentsConn.ReadByID(SelectedAttendance.StudentID);

            //cmbGroups.SelectedValue = SelectedStudent.GroupId.ToString();
            cmbStudents.SelectedValue = SelectedAttendance.StudentID.ToString();
            dtPickerDate.Value = SelectedAttendance.AttendanceDate;

            cmbGroups.Enabled = false;
        }

        private void btnShowALLAbsence_Click(object sender, EventArgs e)
        {
            FillAbsencedgv();
        }
        private void FillAbsencedgv()
        {

            dgvAbsence.DataSource = AttendanceConn.ReadAllAbsence(dtPickerDate.Value);
            //dgvNotPaid.Columns[0].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FillAbsencedgvbyGroup()
        {

            dgvAbsence.DataSource = AttendanceConn.ReadAllAbsenceByGroup(dtPickerDate.Value, cmbGroups.Text);
            //dgvNotPaid.Columns[0].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowALLAbsenceGroup_Click(object sender, EventArgs e)
        {
            FillAbsencedgvbyGroup();
        }
    }
}
