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
    public partial class InformationFrm : Form
    {
        PaymentsOperationBL PaymentsConn = new PaymentsOperationBL(ConfigurationManager.ConnectionStrings["TeacherDBEntities"].ConnectionString);
        

        public InformationFrm()
        {
            InitializeComponent();
        }

        private void btnCalculateAll_Click(object sender, EventArgs e)
        {
            txtTotalBooklet.Text = Convert.ToInt32(PaymentsConn.CalcultaTotalBookletbyDate(dateTimePicker1.Value)).ToString();
            txtTotalPayment.Text = Convert.ToInt32(PaymentsConn.CalcultaTotalPaymentbyDate(dateTimePicker1.Value)).ToString();

            txtTotalRemainderPayment.Text = Convert.ToInt32(PaymentsConn.CalcultaTotalPaymentRemainderbyDate(dateTimePicker1.Value)).ToString();
            txtTotalRemainderBooklet.Text = Convert.ToInt32(PaymentsConn.CalcultaTotalBookletRemainderbyDate(dateTimePicker1.Value)).ToString();
            
        }

        private void InformationFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
