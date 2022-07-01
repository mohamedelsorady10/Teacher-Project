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
    public class TestsOperationsBL : DataAccessLayer<TestsBL>, IOperations<TestsBL>
    {

        #region Constructors
        public TestsOperationsBL()
        {

        }
        public TestsOperationsBL(string Conn) : base(Conn)
        {

        }
        #endregion




        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@TestId", id);
            int Result = ExecNonQuery("sp_TestDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(TestsBL InsertObject)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = CreateParameters("@TestName", InsertObject.TestName);
            para[1] = CreateParameters("@TestDate", InsertObject.TestDate);
            para[2] = CreateParameters("@TestGrade", InsertObject.TestGrade);
            int Result = ExecNonQuery("sp_TestInsert", CommandType.StoredProcedure, para);

            return Result;
        }

        public DataTable ReadAll()
        {
            return ExecReader("sp_TestsReadAll", CommandType.StoredProcedure);
        }

        public TestsBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@TestId", id);
            DataTable dt = ExecReader("sp_TestsReadbyID", CommandType.StoredProcedure, para);
            TestsBL testsBL = new TestsBL()
            {
                TestId = (int)dt.Rows[0]["TestId"],
                TestName = dt.Rows[0]["TestName"].ToString(),
                TestDate = Convert.ToDateTime(dt.Rows[0]["TestDate"].ToString()),
                TestGrade = Convert.ToDecimal(dt.Rows[0]["TestGrade"].ToString())
            };

            return testsBL;
        }

        public int Update(TestsBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[4];

            para[0] = CreateParameters("@TestId", UpdateObject.TestId);
            para[1] = CreateParameters("@TestName", UpdateObject.TestName);
            para[2] = CreateParameters("@TestDate", UpdateObject.TestDate);
            para[3] = CreateParameters("@TestGrade", UpdateObject.TestGrade);

            int Result = ExecNonQuery("sp_TestsUpdate", CommandType.StoredProcedure, para);
            return Result;
        }
        
    }
}
