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
    public class GroupsOperationBL : DataAccessLayer<GroupsBL>, IOperations<GroupsBL>
    {

        #region Constructors
        public GroupsOperationBL()
        {

        }
        public GroupsOperationBL(string Conn) : base(Conn)
        {

        }
        #endregion




        public int Delete(int id)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = CreateParameters("@GroupId", id);
            int Result = ExecNonQuery("sp_GroupDelete", CommandType.StoredProcedure, para);
            return Result;

        }

        public int Insert(GroupsBL InsertObject)
        {
            SqlParameter[] para = new SqlParameter[5];
            para[0] = CreateParameters("@GroupName", InsertObject.GroupName);
            para[1] = CreateParameters("@GroupLocation", InsertObject.GroupLocation);
            para[2] = CreateParameters("@GroupDate", InsertObject.GroupDate.Date);
            para[3] = CreateParameters("@FirstDay", InsertObject.FirstDay);
            para[4] = CreateParameters("@SecondDay", InsertObject.SecondDay);
            int Result = ExecNonQuery("sp_GroupInsert", CommandType.StoredProcedure, para);

            return Result;
        }

        public DataTable ReadAll()
        {
            return ExecReader("sp_GroupsReadAll", CommandType.StoredProcedure);
        }

        public GroupsBL ReadByID(int id)
        {

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@GroupId", id);
            DataTable dt = ExecReader("sp_GroupsReadbyID", CommandType.StoredProcedure, para);
            GroupsBL groupsBL = new GroupsBL()
            {
                GroupId = (int)dt.Rows[0]["GroupId"],
                GroupName = dt.Rows[0]["GroupName"].ToString(),
                GroupLocation = dt.Rows[0]["GroupLocation"].ToString(),
                GroupDate = Convert.ToDateTime(dt.Rows[0]["GroupDate"].ToString()),
                FirstDay = dt.Rows[0]["FirstDay"].ToString(),
                SecondDay = dt.Rows[0]["SecondDay"].ToString(),
                
            };

            return groupsBL;
        }

        public int Update(GroupsBL UpdateObject)
        {
            SqlParameter[] para = new SqlParameter[6];

            para[0] = CreateParameters("@GroupId", UpdateObject.GroupId);
            para[1] = CreateParameters("@GroupName", UpdateObject.GroupName);
            para[2] = CreateParameters("@GroupLocation", UpdateObject.GroupLocation);
            para[3] = CreateParameters("@GroupDate", UpdateObject.GroupDate);
            para[4] = CreateParameters("@FirstDay", UpdateObject.FirstDay);
            para[5] = CreateParameters("@SecondDay", UpdateObject.SecondDay);
            
            int Result = ExecNonQuery("sp_GroupsUpdate", CommandType.StoredProcedure, para);
            return Result;
        }
    }
}
