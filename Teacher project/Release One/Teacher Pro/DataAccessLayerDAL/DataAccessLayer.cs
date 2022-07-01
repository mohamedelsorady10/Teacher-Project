
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerDAL
{
    public abstract class DataAccessLayer <T> : DataBaseDAL
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DataAccessLayer()
        {

        }
        /// <summary>
        /// Contructor To Pass ConnectionString 
        /// </summary>
        /// <param name="constr">Connection String </param>
        public DataAccessLayer(string constr):base(constr)
        {

        }
        /// <summary>
        /// To execute Scalar Command 
        /// </summary>
        /// <param name="cmdtext"> Command text </param>
        /// <param name="cmdtypt"> Command type Text Or Procedure</param>
        /// <param name="paras">Array Of SqlParamenters </param>
        /// <returns> Object </returns>
        protected object ExecScalar(string cmdtext, CommandType cmdtypt = CommandType.Text, params SqlParameter[] paras)
        {
            using (SqlConnection con = new SqlConnection(DbConnectionString))
            { 
               OpenConnection(con);
                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = cmdtypt;
                cmd.Parameters.AddRange(paras);
                object Result = cmd.ExecuteScalar();
                CloseConnection(con);
                return Result;
            }
        }
        /// <summary>
        /// To Execute Non Query Insert - update - Delete 
        /// </summary>
        /// <param name="cmdtext"> Command text </param>
        /// <param name="cmdtypt"> Command type Text Or Procedure</param>
        /// <param name="paras">Array Of SqlParamenters </param>
        /// <returns> Numbers Of Rows </returns>
        protected int ExecNonQuery(string cmdtext, CommandType cmdtypt = CommandType.Text, params SqlParameter[] paras)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConnectionString))
                {
                    OpenConnection(con);
                    SqlCommand cmd = new SqlCommand(cmdtext, con);
                    cmd.CommandType = cmdtypt;
                    cmd.Parameters.AddRange(paras);
                    int Result = cmd.ExecuteNonQuery();
                    CloseConnection(con);
                    return Result;
                }
            }
            catch (Exception)
            {
                return -1;
            }           
        }
        /// <summary>
        /// To Execute Reader 
        /// </summary>
        /// <param name="cmdtext"> Command text </param>
        /// <param name="cmdtypt"> Command type Text Or Procedure</param>
        /// <param name="paras">Array Of SqlParamenters </param>
        /// <returns> Data table Of Return Select </returns>
        protected DataTable ExecReader(string cmdtext, CommandType cmdtypt = CommandType.Text, params SqlParameter[] paras)
        {
            using (SqlConnection con = new SqlConnection(DbConnectionString))
            {
                SqlCommand cmd = new SqlCommand(cmdtext, con);
                cmd.CommandType = cmdtypt;
                cmd.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                SqlDataAdapter dapt = new SqlDataAdapter(cmd);
                dapt.Fill(dt);

                return dt;
            }
        }
        /// <summary>
        /// To create SQL Paramneter Object 
        /// </summary>
        /// <param name="name"> Name Of Paramenter</param>
        /// <param name="value">Value Of Paramenter</param>
        /// <returns> SqlParamter Object </returns>
        protected SqlParameter CreateParameters(string name, object value)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.SqlValue = value;
            return para;
        }
        /// <summary>
        /// To create SQL Paramneter Object 
        /// </summary>
        /// <param name="name"> Name Of Paramenter</param>
        /// <param name="type"> Type Of Paramenter</param>
        /// <param name="value">Value Of Paramenter</param>
        /// <returns> SqlParamter Object </returns>
        protected SqlParameter CreateParameters(string name,SqlDbType Type, object value)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.SqlDbType = Type;
            para.SqlValue = value;
            return para;
        }
        /// <summary>
        ///  Open Connection Method
        /// </summary>
        /// <param name="connection"> Object Of SqlConnection </param>
        protected void OpenConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        /// <summary>
        ///  Close Connection Method
        /// </summary>
        /// <param name="connection"> Object Of SqlConnection </param>
        protected void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Dispose();
                connection.Close();
            }
        }
        /// <summary>
        ///  To Dispose Object Of Data Access Layer 
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect(GC.GetGeneration(this), GCCollectionMode.Forced);
        }
        ///// <summary>
        ///// To Execute Reader 
        ///// Notes : This Method is Abstract Method 
        ///// </summary>
        ///// <param name="cmdtext"> Command text </param>
        ///// <param name="cmdtypt"> Command type Text Or Procedure</param>
        ///// <param name="paras">Array Of SqlParamenters </param>
        ///// <returns> T Generic As Business Object </returns>
        //protected abstract T ExecReaderAsObject(string cmdtext, CommandType cmdtypt = CommandType.Text, params SqlParameter[] paras);
        /// <summary>
        /// desconstructor
        /// </summary>
        ~DataAccessLayer()
        {
            this.Dispose();
        }
    }
}

