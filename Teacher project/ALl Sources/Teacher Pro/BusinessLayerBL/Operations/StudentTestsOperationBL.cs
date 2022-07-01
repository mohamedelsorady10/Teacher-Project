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
    public class StudentTestsOperationBL : DataAccessLayer<StudentTestsBL>, IOperations<StudentTestsBL>
    {

        #region Constructors
        public StudentTestsOperationBL()
        {

        }
        public StudentTestsOperationBL(string Conn) : base(Conn)
        {

        }
        #endregion




        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@StudentTestID", id);
            int Result = ExecNonQuery("sp_StudentTestDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(StudentTestsBL InsertObject)
        {
            SqlParameter[] para = new SqlParameter[3];
            para[0] = CreateParameters("@StudentId", InsertObject.StudentId);
            para[1] = CreateParameters("@TestId", InsertObject.TestId);
            para[2] = CreateParameters("@StudentGrade", InsertObject.StudentGrade);
            int Result = ExecNonQuery("sp_StudentTestInsert", CommandType.StoredProcedure, para);

            return Result;
        }

        public DataTable ReadAll()
        {
            return ExecReader("sp_StudentTestsReadAll", CommandType.StoredProcedure);
        }

        public StudentTestsBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@StudentTestID", id);
            DataTable dt = ExecReader("sp_StudentTestsReadbyID", CommandType.StoredProcedure, para);
            StudentTestsBL studentTestsBL = new StudentTestsBL()
            {
                StudentTestID = (int)dt.Rows[0]["StudentTestID"],
                StudentId = (int)dt.Rows[0]["StudentId"],
                TestId = (int)dt.Rows[0]["TestId"],
                StudentGrade = Convert.ToDecimal(dt.Rows[0]["StudentGrade"].ToString())                
            };

            return studentTestsBL;
        }

        public int Update(StudentTestsBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[4];

            para[0] = CreateParameters("@StudentTestID", UpdateObject.StudentTestID);
            para[1] = CreateParameters("@StudentId", UpdateObject.StudentId);
            para[2] = CreateParameters("@TestId", UpdateObject.TestId);
            para[3] = CreateParameters("@StudentGrade", UpdateObject.StudentGrade);
            

            int Result = ExecNonQuery("sp_StudentTestsUpdate", CommandType.StoredProcedure, para);
            return Result;
        }

    }
}
