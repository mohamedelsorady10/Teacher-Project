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
    public partial class TestsFrm : Form
    {
        TestsOperationsBL TestsConn = new TestsOperationsBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);

        public TestsFrm()
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
            txtTestName.Text = string.Empty;
            npdTestGrade.Value = 0;
            dtPickerTestDate.Value = DateTime.Now;
        }
        private void Enabling()
        {
            txtTestName.Enabled = npdTestGrade.Enabled= dtPickerTestDate.Enabled = true;            
        }
        private void Clear()
        {
            txtTestName.Text = string.Empty;
            npdTestGrade.Value = 0;
            dtPickerTestDate.Value = DateTime.Now;
        }

        private void FillTestsdgv()
        {
            dgvTests.DataSource = TestsConn.ReadAllDGV();
            dgvTests.Columns[0].Visible = false;
            dgvTests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabling();
            int id = Convert.ToInt32(dgvTests.Rows[dgvTests.CurrentRow.Index].Cells[0].Value);
            TestsBL SelectedTest = TestsConn.ReadByID(id);

            txtTestName.Text = SelectedTest.TestName.ToString();
            npdTestGrade.Value = SelectedTest.TestGrade;
            dtPickerTestDate.Text = SelectedTest.TestDate.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTestName.Text) && npdTestGrade.Value > 0 )
            {
                int Result = TestsConn.Insert(new TestsBL
                {
                    TestName = txtTestName.Text,
                    TestGrade = npdTestGrade.Value,
                    TestDate = dtPickerTestDate.Value
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
                int Result = TestsConn.Delete(id);
                if (Result > 0)
                { MessageBox.Show("Deleted.."); Clear(); FillTestsdgv(); }
                else { MessageBox.Show("Delete is canceled"); }
            }
            else { MessageBox.Show("Delete canceled"); }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestName.Text) || npdTestGrade.Value < 0 )
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

                TestsBL SelectedTest = new TestsBL()
                {
                    TestId = id,
                    TestName = txtTestName.Text,
                    TestGrade = npdTestGrade.Value,
                    TestDate = dtPickerTestDate.Value
                };

                int Result = TestsConn.Update(SelectedTest);



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

        private void TestsFrm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = !SysUsers._IsAdmin ? false : true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(map,0,0);
        }
        Bitmap map;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            map = new Bitmap(this.Size.Width, this.Height, g);
            Graphics ag = Graphics.FromImage(map);
            ag.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
