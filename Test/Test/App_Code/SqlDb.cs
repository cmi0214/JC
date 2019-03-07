using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace YonaTest
{
    public sealed class SqlDb
    {

        public static string DbConn;
        public SqlConnection objConn;


        public SqlDb()
        {

            if (DbConn == null || DbConn == "")
            {
                DbConn = WebConfigurationManager.ConnectionStrings["YonaTest"].ConnectionString;
            }
            objConn = new SqlConnection(DbConn);
        }



        // [ Property ] DB Connection String Property
        public string DBConnection
        {
            get
            {
                return DbConn;
            }
            set
            {
                DbConn = value;
            }
        }


        // [Method] DB return DataSet
        #region SelectData

        public DataSet SelectData(string strSQL)
        {
            System.Data.DataSet dsTemp = null;


            using (SqlConnection cn = new SqlConnection(DbConn))
            {
                using (System.Data.SqlClient.SqlDataAdapter daTemp = new SqlDataAdapter(strSQL, cn))
                {
                    cn.Open();
                    daTemp.SelectCommand.CommandTimeout = 6000;
                    dsTemp = new DataSet();
                    daTemp.Fill(dsTemp);
                    daTemp.Dispose();
                    cn.Close();

                }
            }



            return dsTemp;

        }
        #endregion

        #region ExecuteData
        public void ExecData(string strSQL)
        {
            if (objConn.ToString() == "")
            {
                throw new ArgumentNullException("DatabaseConnectoin", "No value for the database conneciton string");
            }
            else
            {
                if (objConn.State == ConnectionState.Closed)
                {
                    objConn.Open();
                }
                System.Data.SqlClient.SqlCommand myCommand = new SqlCommand(strSQL, objConn);
                myCommand.CommandTimeout = 6000;
                myCommand.ExecuteNonQuery();
                objConn.Close();
            }
        }
        #endregion



    }
}