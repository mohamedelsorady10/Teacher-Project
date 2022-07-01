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
    public class AttendanceOperationBL : DataAccessLayer<AttendancesBL>, IOperations<AttendancesBL>
    {
        #region Constructors
        public AttendanceOperationBL()
        {

        }
        public AttendanceOperationBL(string Conn) : base(Conn)
        {

        }
        #endregion




        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@AttendanceID", id);
            int Result = ExecNonQuery("sp_AttendanceDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(AttendancesBL InsertObject)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = CreateParameters("@AttendanceDate", InsertObject.AttendanceDate);
            para[1] = CreateParameters("@StudentID", InsertObject.StudentID);
            int Result = ExecNonQuery("sp_AttendanceInsert", CommandType.StoredProcedure, para);

            return Result;
        }
        public DataTable ReadAll()
        {
            return null;
        }

        public DataTable ReadAll(DateTime date)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@AttendanceDate", date);
            return ExecReader("sp_AttendanceReadAll", CommandType.StoredProcedure, para);
        }

        public AttendancesBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@AttendanceID", id);
            DataTable dt = ExecReader("sp_AttendanceReadbyID", CommandType.StoredProcedure, para);
            AttendancesBL attendancesBL = new AttendancesBL()
            {
                AttendanceDate = Convert.ToDateTime(dt.Rows[0]["AttendanceDate"].ToString()),
                StudentID = (int)dt.Rows[0]["StudentID"]
            };

            return attendancesBL;
        }
        //ReadAllAbsence
        public DataTable ReadAllAbsence(DateTime date)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@Date", date);
            return ExecReader("sp_AbsenceReadAllbyDate", CommandType.StoredProcedure, para);
        }
        public DataTable ReadAllAbsenceByGroup(DateTime date, string GroupName)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = CreateParameters("@GroupName", GroupName);
            para[1] = CreateParameters("@Date", date);
            return ExecReader("sp_AbsenceReadAllbyGroup", CommandType.StoredProcedure, para);
        }



        public int Update(AttendancesBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[3];

            para[0] = CreateParameters("@AttendanceID", UpdateObject.AttendanceID);
            para[1] = CreateParameters("@AttendanceDate", UpdateObject.AttendanceDate);
            para[2] = CreateParameters("@StudentID", UpdateObject.StudentID);

            int Result = ExecNonQuery("sp_AttendanceUpdate", CommandType.StoredProcedure, para);
            return Result;
        }


    }
}
