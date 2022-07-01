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
    public class BookletsOperationBL : DataAccessLayer<BookletsBL>, IOperations<BookletsBL>
    {
        #region Constructors
        public BookletsOperationBL()
        {

        }
        public BookletsOperationBL(string Conn) : base(Conn)
        {

        }
        #endregion
        

        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@BookletID", id);
            int Result = ExecNonQuery("sp_BookletDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(BookletsBL InsertObject)
        {

            SqlParameter[] para = new SqlParameter[5];
            para[0] = CreateParameters("@BookletName", InsertObject.BookletName);
            para[1] = CreateParameters("@StudentID", InsertObject.StudentID);
            para[2] = CreateParameters("@PaymentDate", InsertObject.PaymentDate);
            para[3] = CreateParameters("@PaymentAmount", InsertObject.PaymentAmount);
            para[4] = CreateParameters("@PaymentRemainder", InsertObject.PaymentRemainder);

            int Result = ExecNonQuery("sp_BookletInsert", CommandType.StoredProcedure, para);

            return Result;
        }

        public DataTable ReadAll()
        {
            //
            return ExecReader("sp_BookletsReadAll", CommandType.StoredProcedure);
        }


        //mme
        //public BookletsBL ReadByIDDGV(int id)
        //{

        //    SqlParameter[] para = new SqlParameter[1];
        //    para[0] = new SqlParameter("@id", id);
        //    DataTable dt = ExecReader("sp_BookletsReadByIdDGV", CommandType.StoredProcedure, para);
        //    BookletsBL bookletsBL = new BookletsBL()
        //    {
        //        BookletID = (int)dt.Rows[0]["BookletID"],
        //        BookletName = dt.Rows[0]["BookletName"].ToString(),
        //        StudentID = Convert.ToInt32(dt.Rows[0]["StudentID"].ToString()),
        //        PaymentDate = Convert.ToDateTime(dt.Rows[0]["PaymentDate"].ToString()),
        //        PaymentAmount = Convert.ToDecimal(dt.Rows[0]["PaymentAmount"].ToString()),
        //        PaymentRemainder = Convert.ToDecimal(dt.Rows[0]["PaymentRemainder"].ToString())
        //    };

        //    return bookletsBL;
        //}


        public BookletsBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@BookletID", id);
            DataTable dt = ExecReader("sp_BookletsReadbyID", CommandType.StoredProcedure, para);
            BookletsBL bookletsBL = new BookletsBL()
            {
                BookletID = (int)dt.Rows[0]["BookletID"],
                BookletName = dt.Rows[0]["BookletName"].ToString(),
                StudentID = (int)dt.Rows[0]["StudentID"],
                PaymentDate = Convert.ToDateTime(dt.Rows[0]["PaymentDate"].ToString()),
                PaymentAmount = Convert.ToDecimal(dt.Rows[0]["PaymentAmount"].ToString()),
                PaymentRemainder = Convert.ToDecimal(dt.Rows[0]["PaymentRemainder"].ToString())
            };

            return bookletsBL;
        }

        public int Update(BookletsBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = CreateParameters("@BookletID", UpdateObject.BookletID);
            para[1] = CreateParameters("@BookletName", UpdateObject.BookletName);
            para[2] = CreateParameters("@StudentID", UpdateObject.StudentID);
            para[3] = CreateParameters("@PaymentDate", UpdateObject.PaymentDate);
            para[4] = CreateParameters("@PaymentAmount", UpdateObject.PaymentAmount);
            para[5] = CreateParameters("@PaymentRemainder", UpdateObject.PaymentRemainder);

            int Result = ExecNonQuery("sp_BookletsUpdate", CommandType.StoredProcedure, para);
            return Result;
        }
        //ReadAllNotPaidBooketByGroup

        public DataTable ReadAllNotPaidBooketByGroup(DateTime date, string GroupName)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = CreateParameters("@Date", date);
            para[1] = CreateParameters("@GroupName", GroupName);
            return ExecReader("sp_BooketReadAllbyDateNotPaidByGroup", CommandType.StoredProcedure, para);
        }
        public DataTable ReadAllNotPaidBooket(DateTime date)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@Date", date);
            return ExecReader("sp_BooketReadAllbyDateNotPaid", CommandType.StoredProcedure, para);
        }
    }
}
