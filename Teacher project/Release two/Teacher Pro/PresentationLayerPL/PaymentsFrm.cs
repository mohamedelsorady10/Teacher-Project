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
    public partial class PaymentsFrm : Form
    {
        PaymentsOperationBL PaymentConn = new PaymentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        GroupsOperationBL Groupsconn = new GroupsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        StudentsOperationBL studentsConn = new StudentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);

       


        public PaymentsFrm()
        {
            InitializeComponent();
        }

        private void PaymentsFrm_Load(object sender, EventArgs e)
        {
            FillComboGroups();

            FillComboStudents();

            btnDelete.Enabled = !SysUsers._IsAdmin ? false : true;
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillPaymentdgv();
        }
        private void FillPaymentdgv()
        {

            dgvPayment.DataSource = PaymentConn.ReadAllByDate(dtPickerDate.Value);
            dgvPayment.Columns[0].Visible = false;
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null || npdAmount.Value <=0 || npdRemainder.Value<0)
            {
                MessageBox.Show("Plz Enter Full Data");
            }
            else
            {
                int id;
                try
                {
                    id = Convert.ToInt32(dgvPayment.Rows[dgvPayment.CurrentRow.Index].Cells[0].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Select a payment to Update!");
                    return;
                }

                PaymentsBL SelectedPayment = new PaymentsBL()
                {
                    PaymentId = id,
                    StudentId = Convert.ToInt32(cmbStudents.SelectedValue),
                    PaymentDate = Convert.ToDateTime(dtPickerDate.Value),
                    PaymentAmount = Convert.ToDecimal(npdAmount.Value),
                    PaymentRemainder = Convert.ToDecimal(npdRemainder.Value),


                };

                int Result = PaymentConn.Update(SelectedPayment);



                if (Result > 0)
                { MessageBox.Show("Update Done"); Clear(); FillPaymentdgv(); }
                else
                { MessageBox.Show("Not Updated!!"); }
            }
        }
        private void Clear()
        {
            cmbStudents.Text = cmbGroups.Text = string.Empty;
            dtPickerDate.Value = DateTime.Now;
            npdRemainder.Value = npdAmount.Value = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(dgvPayment.Rows[dgvPayment.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a payment to delete!");
                return;
            }
            if (MessageBox.Show("Are You sure Deleting", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int Result = PaymentConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillPaymentdgv(); }
                else { MessageBox.Show("Delete is canceled"); }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbGroups.SelectedValue != null && cmbStudents.SelectedValue != null && npdAmount.Value > 0 && npdRemainder.Value >= 0)
            {
                int Result = PaymentConn.Insert(new PaymentsBL
                {
                    StudentId = Convert.ToInt32(cmbStudents.SelectedValue),
                    PaymentDate = dtPickerDate.Value,
                    PaymentAmount = npdAmount.Value,
                    PaymentRemainder = npdRemainder.Value
                });
                if (Result > 0)
                {
                    MessageBox.Show("Saving ...");
                    Clear();
                    FillPaymentdgv();
                }
                else
                { MessageBox.Show("Not Saved!"); }
            }
            else
            {
                MessageBox.Show("Plz Enter Test Full Data to insert it !!");
            }
        }

        private void Enabling()
        {
            cmbStudents.Enabled = cmbGroups.Enabled = dtPickerDate.Enabled = true;
            npdAmount.Value = npdRemainder.Value = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Enabling();
            Clear();
        }


        private void FillComboStudentsbyGroups(int id)
        {
            cmbStudents.DataSource = studentsConn.ReadAllByGroup(id);
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.ValueMember = "StudentId";
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();
            int id = Convert.ToInt32(dgvPayment.Rows[dgvPayment.CurrentRow.Index].Cells[0].Value);
            PaymentsBL SelectedPayment = PaymentConn.ReadByID(id);

            //cmbGroups.SelectedValue = SelectedStudent.GroupId.ToString();
            //cmbGroups.Text = SelectedPayment..ToString();
            dtPickerDate.Value = Convert.ToDateTime(SelectedPayment.PaymentDate);
            npdAmount.Value = SelectedPayment.PaymentAmount;
            npdRemainder.Value = SelectedPayment.PaymentRemainder;

            cmbStudents.SelectedValue = SelectedPayment.StudentId.ToString();

        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillPaymentdgvAll()
        {

            dgvPayment.DataSource = PaymentConn.ReadAll();
            dgvPayment.Columns[0].Visible = false;
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FillPaymentdgvAllByGroup()
        {

            dgvPayment.DataSource = PaymentConn.ReadAllByGroup(cmbGroups.Text,dtPickerDate.Value);
            dgvPayment.Columns[0].Visible = false;
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            FillPaymentdgvAll();
        }

        private void btnShowAllByGroup_Click(object sender, EventArgs e)
        {
            FillPaymentdgvAllByGroup();

        }
        private void FillPaymentdgvAllByGroupNotPaid()
        {

            dgvNotPaid.DataSource = PaymentConn.ReadAllByGroupNotPaid(cmbGroups.Text, dtPickerDate.Value);
            //dgvNotPaid.Columns[0].Visible = false;
            dgvNotPaid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        private void btnShowALLNotPaidGroup_Click(object sender, EventArgs e)
        {
            FillPaymentdgvAllByGroupNotPaid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnShowALLNotPaid_Click(object sender, EventArgs e)
        {
            FillPaymentdgvAllNotPaid();
        }
        private void FillPaymentdgvAllNotPaid()
        {

            dgvNotPaid.DataSource = PaymentConn.ReadAllNotPaid(dtPickerDate.Value);
            //dgvNotPaid.Columns[0].Visible = false;
            dgvNotPaid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FillPaymentdgvAllByMonth()
        {

            dgvPayment.DataSource = PaymentConn.ReadAllByDate(dtPickerDate.Value);
            //dgvPayment.Columns[0].Visible = false;
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShowAllByMonth_Click(object sender, EventArgs e)
        {
            FillPaymentdgvAllByMonth();
        }

        private void cmbGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillComboStudentsbyGroups((int)cmbGroups.SelectedValue);
        }

        private void dgvPayment_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();

            int id = Convert.ToInt32(dgvPayment.Rows[dgvPayment.CurrentRow.Index].Cells[0].Value);

            PaymentsBL paymentsBL = PaymentConn.ReadByID(id);

            cmbGroups.Text = string.Empty;
            cmbStudents.SelectedValue = paymentsBL.StudentId.ToString();
            dtPickerDate.Value =Convert.ToDateTime( paymentsBL.PaymentDate.ToString());
            npdAmount.Value= Convert.ToDecimal( paymentsBL.PaymentAmount.ToString());
            npdRemainder.Value= Convert.ToDecimal( paymentsBL.PaymentRemainder.ToString());
            
        }
    }
}
