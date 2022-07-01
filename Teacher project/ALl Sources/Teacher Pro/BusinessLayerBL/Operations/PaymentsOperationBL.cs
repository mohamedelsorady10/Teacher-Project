using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using BusinessLayerBL.Models;
using DataAccessLayerDAL;


namespace BusinessLayerBL.Operations
{
    public class PaymentsOperationBL : DataAccessLayer<PaymentsBL>, IOperations<PaymentsBL>
    {
        #region Constructors
        public PaymentsOperationBL()
        {

        }
        public PaymentsOperationBL(string Conn) : base(Conn)
        {

        }
        #endregion




        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@PaymentId", id);
            int Result = ExecNonQuery("sp_PaymentDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(PaymentsBL InsertObject)
        {
            SqlParameter[] para = new SqlParameter[4];
            para[0] = CreateParameters("@PaymentAmount", InsertObject.PaymentAmount);
            para[1] = CreateParameters("@PaymentRemainder", InsertObject.PaymentRemainder);
            para[2] = CreateParameters("@PaymentDate", InsertObject.PaymentDate);
            para[3] = CreateParameters("@StudentId", InsertObject.StudentId);
            int Result = ExecNonQuery("sp_PaymentInsert", CommandType.StoredProcedure, para);

            return Result;
        }

        public DataTable ReadAll()
        {
            return ExecReader("sp_PaymentReadAll", CommandType.StoredProcedure);
        }

        public PaymentsBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@PaymentId", id);
            DataTable dt = ExecReader("sp_PaymentReadbyID", CommandType.StoredProcedure, para);
            PaymentsBL paymentsBL = new PaymentsBL()
            {
                PaymentId = (int)dt.Rows[0]["PaymentId"],
                StudentId = (int)dt.Rows[0]["StudentId"],
                PaymentDate =Convert.ToDateTime(dt.Rows[0]["PaymentDate"].ToString()),
                PaymentAmount = Convert.ToDecimal(dt.Rows[0]["PaymentAmount"].ToString()),
                PaymentRemainder = Convert.ToDecimal(dt.Rows[0]["PaymentRemainder"].ToString())
            };

            return paymentsBL;
        }

        public int Update(PaymentsBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[5];

            para[0] = CreateParameters("@PaymentId", UpdateObject.PaymentId);
            para[1] = CreateParameters("@PaymentAmount", UpdateObject.PaymentAmount);
            para[2] = CreateParameters("@PaymentDate", UpdateObject.PaymentDate);
            para[3] = CreateParameters("@StudentId", UpdateObject.StudentId);
            para[4] = CreateParameters("@PaymentRemainder", UpdateObject.PaymentRemainder);

            int Result = ExecNonQuery("sp_PaymentUpdate", CommandType.StoredProcedure, para);
            return Result;
        }
    }
}
