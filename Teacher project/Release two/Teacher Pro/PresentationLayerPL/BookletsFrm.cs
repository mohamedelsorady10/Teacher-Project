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
    public partial class BookletsFrm : Form
    {
        BookletsOperationBL BookletsConn = new BookletsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        GroupsOperationBL GroupsConn = new GroupsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        StudentsOperationBL studentsConn = new StudentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);


        public BookletsFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FillComboStudents()
        {
            cmbStudents.DataSource = studentsConn.ReadAll();
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";

        }
        private void BookletsFrm_Load(object sender, EventArgs e)
        {
            FillComboGroups();
            FillComboStudents();
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillBookletsdgv();
        }
        private void FillBookletsdgv()
        {

            dgvBooklets.DataSource = BookletsConn.ReadAll();
            //dgvBooklets.Columns[0].Visible = false;
            dgvBooklets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBooklet.Text)  || string.IsNullOrEmpty(cmbStudents.Text) || dpDate.Value == null || npdPaymentAmount.Value < 0  || npdPaymentRemainder.Value < 0)
            {
                MessageBox.Show("Plz Enter Full Data");
            }
            else
            {
                int id;
                try
                {
                    id = Convert.ToInt32(dgvBooklets.Rows[dgvBooklets.CurrentRow.Index].Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Select a Booklet to Update!");
                    return;
                }

                BookletsBL SelectedBooklet = new BookletsBL()
                {
                    BookletID = id,
                    BookletName = txtBooklet.Text,
                    StudentID = Convert.ToInt32(cmbStudents.SelectedValue),
                    PaymentDate =Convert.ToDateTime( dpDate.Value),
                    PaymentAmount =Convert.ToDecimal( npdPaymentAmount.Value),
                    PaymentRemainder = Convert.ToDecimal(npdPaymentRemainder.Value)
                };

                int Result = BookletsConn.Update(SelectedBooklet);



                if (Result > 0)
                { MessageBox.Show("Update Done"); Clear(); FillBookletsdgv(); }
                else
                { MessageBox.Show("Not Updated!!"); }
            }

        }

        private void Clear()
        {
            txtBooklet.Text =  string.Empty;
            dpDate.Value = DateTime.Now;
            npdPaymentRemainder.Value = npdPaymentAmount.Value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dgvBooklets.Rows[dgvBooklets.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Booklet to delete!");
                return;
            }
            if (MessageBox.Show("Are You sure Deleting", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int Result = BookletsConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillBookletsdgv(); }
                else
                {
                    MessageBox.Show("Can't delete Booklet with Students");
                }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBooklet.Text) && cmbStudents.Text != null && cmbGroups.Text!=null && npdPaymentAmount.Value >0 && npdPaymentRemainder.Value >= 0)
            {
                int Result = BookletsConn.Insert(new BookletsBL
                {
                    BookletName = txtBooklet.Text,
                    StudentID = Convert.ToInt32(cmbStudents.SelectedValue.ToString()),
                    PaymentDate = dpDate.Value,
                    PaymentAmount = npdPaymentAmount.Value,
                    PaymentRemainder = npdPaymentRemainder.Value
                });
                if (Result > 0)
                {
                    MessageBox.Show("Saving ...");
                    Clear();
                    FillBookletsdgv();
                }
                else
                { MessageBox.Show("Not Saved!"); }
            }
            else
            {
                MessageBox.Show("Plz Enter Booklet Full Data to insert it !!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Enabling();
            Clear();
        }
        private void Enabling()
        {
            txtBooklet.Enabled = dpDate.Enabled = npdPaymentAmount.Enabled = npdPaymentRemainder.Enabled = cmbStudents.Enabled = cmbGroups.Enabled = true;
        }

        private void cmbGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillComboStudentsbyGroups((int)cmbGroups.SelectedValue);
        }

        private void btnShowALLNotPaidGroupBooket_Click(object sender, EventArgs e)
        {
            FillBooketsdgvAllNotPaidByGroup();
        }

        private void btnShowALLNotPaidBooket_Click(object sender, EventArgs e)
        {
            FillBooketsdgvAllNotPaid();
        }
        private void FillBooketsdgvAllNotPaid()
        {

            dgvNotPaidBooklet.DataSource = BookletsConn.ReadAllNotPaidBooket(dpDate.Value);
            //dgvNotPaidBooklet.Columns[0].Visible = false;
            dgvNotPaidBooklet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FillBooketsdgvAllNotPaidByGroup()
        {

            dgvNotPaidBooklet.DataSource = BookletsConn.ReadAllNotPaidBooketByGroup(dpDate.Value,cmbGroups.Text);
            //dgvNotPaidBooklet.Columns[0].Visible = false;
            dgvNotPaidBooklet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBooklet_Leave(object sender, EventArgs e)
        {
            if (txtBooklet.Text == string.Empty)
            {
                errorProvider1.SetError(txtBooklet, "Plz enter a Name");
            }
            else { errorProvider1.Clear(); }
        }

        private void dgvBooklets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();

            int id = Convert.ToInt32(dgvBooklets.Rows[dgvBooklets.CurrentRow.Index].Cells[0].Value);

            //BookletsBL bookletsBL = BookletsConn.ReadByIDDGV(id);
            
            BookletsBL bookletsBL = BookletsConn.ReadByID(id);
            txtBooklet.Text = bookletsBL.BookletName.ToString();
            cmbGroups.Text = string.Empty;
            cmbStudents.SelectedValue = bookletsBL.StudentID.ToString();
            dpDate.Value = Convert.ToDateTime(bookletsBL.PaymentDate.ToString());
            npdPaymentAmount.Value = Convert.ToDecimal(bookletsBL.PaymentAmount.ToString());
            npdPaymentRemainder.Value = Convert.ToDecimal(bookletsBL.PaymentRemainder.ToString());
        }
    }
}
