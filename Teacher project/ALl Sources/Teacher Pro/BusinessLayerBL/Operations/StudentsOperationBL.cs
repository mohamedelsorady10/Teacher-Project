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
    public class StudentsOperationBL : DataAccessLayer<StudentsBL>, IOperations<StudentsBL>
    {
        #region Constructors
        public StudentsOperationBL()
        {

        }
        public StudentsOperationBL(string Conn) : base(Conn)
        {

        }
        #endregion



        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@StudentId", id);
            int Result = ExecNonQuery("sp_StudentDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(StudentsBL InsertObject)
        {
            SqlParameter[] para = new SqlParameter[6];
            para[0] = CreateParameters("@StudentName", InsertObject.StudentName);
            para[1] = CreateParameters("@StudentMobile", InsertObject.StudentMobile);
            para[2] = CreateParameters("@ParentMobile", InsertObject.ParentMobile);
            para[3] = CreateParameters("@StudentAddress", InsertObject.StudentAddress);
            para[4] = CreateParameters("@Notes", InsertObject.Notes);
            para[5] = CreateParameters("@GroupId", InsertObject.GroupId);
            int Result = ExecNonQuery("sp_StudentInsert", CommandType.StoredProcedure, para);

            return Result;
        }

        public DataTable ReadAll()
        {
            return ExecReader("sp_StudentsReadAll", CommandType.StoredProcedure);
        }

        public StudentsBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@StudentId", id);
            DataTable dt = ExecReader("sp_StudentsReadbyID", CommandType.StoredProcedure, para);
            StudentsBL studentsBL = new StudentsBL()
            {
                StudentId = (int)dt.Rows[0]["StudentId"],
                StudentName = dt.Rows[0]["StudentName"].ToString(),
                StudentMobile = dt.Rows[0]["StudentMobile"].ToString(),
                ParentMobile = dt.Rows[0]["ParentMobile"].ToString(),
                StudentAddress = dt.Rows[0]["StudentAddress"].ToString(),
                Notes = dt.Rows[0]["Notes"].ToString(),
                GroupId = (int)dt.Rows[0]["GroupId"]

            };

            return studentsBL;
        }

        public int Update(StudentsBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[7];

            para[0] = CreateParameters("@StudentId", UpdateObject.StudentId);
            para[1] = CreateParameters("@StudentName", UpdateObject.StudentName);
            para[2] = CreateParameters("@StudentMobile", UpdateObject.StudentMobile);
            para[3] = CreateParameters("@ParentMobile", UpdateObject.ParentMobile);
            para[4] = CreateParameters("@StudentAddress", UpdateObject.StudentAddress);
            para[5] = CreateParameters("@Notes", UpdateObject.Notes);
            para[6] = CreateParameters("@GroupId", UpdateObject.GroupId);

            int Result = ExecNonQuery("sp_StudentsUpdate", CommandType.StoredProcedure, para);
            return Result;
        }

        public DataTable ReadAllByGroup(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@GroupId", id);

            return ExecReader("sp_StudentsReadAllByGroup", CommandType.StoredProcedure, para);
        }
       
        public DataTable ReadSearchByStudentMobile(string StudentMobile)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@StudentMobile", StudentMobile);
            return ExecReader("sp_sp_ReadSearchByMobile", CommandType.StoredProcedure, para);
        }
        public DataTable ReadSearchByName(string name)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@StudentName", name);
            return ExecReader("sp_ReadSearchByName", CommandType.StoredProcedure,para);
        }
        public DataTable ReadSearchByGroup(string group)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@Group", group);
            return ExecReader("sp_sp_ReadSearchByGroup", CommandType.StoredProcedure, para);
        }

    }
}
