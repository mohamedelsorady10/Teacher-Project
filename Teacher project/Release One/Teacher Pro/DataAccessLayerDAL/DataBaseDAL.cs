/*'***********************************************************************
'Author       : ElSayed ElSaid Hawas                         ............*
'company      : Smart Software™                              ............*
'Country      : Egypt                                        ............*
'Date         : 28 - 10 - 2018                                ............*
'Version      : 1.0                                          ............*
'Email        : sout_2000@hotmail.com                        ............*                                         
'Mobile       : +02 01229446375                              ............*
' Description : Smart Software FrameWork                     ............*
'*************************************************************************
' SMART SOFTWARE
'(C) Copyright 2012 by ElSayed ElSaid Hawas     
'All Rights Reserved.
'If you have any Comments, suggestions, 
'or if you need help on something send me an e-mail at : sout_2000@Hotmail.com. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccessLayerDAL
{
    public abstract class DataBaseDAL : CollectionBase
    {
        //Fields
        private readonly string dbConnectionString;
        //Properties
        /// <summary>
        /// Property to Get the ConnectionString
        /// </summary>
        public string DbConnectionString
        {
            get
            {
                return dbConnectionString;
            }
        }
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DataBaseDAL()
        {
            
        }
        /// <summary>
        /// Non Default -Constructor 
        /// </summary>
        /// <param name="ConStr"> Connection String </param>
        public DataBaseDAL(string ConStr)
        {
            dbConnectionString = ConStr;
        }
        #endregion
    }
}