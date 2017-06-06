using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DB
    {
        private string conn = ConfigurationManager.ConnectionStrings["FishLandDBEntities"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            var objsqlconn = new SqlConnection(conn);      //create connection to the database
            objsqlconn.Open();      //open connection
            var objcmd = new SqlCommand(sqlstring, objsqlconn);
            objcmd.ExecuteNonQuery();
        }

        public object ExecuteSqlString(string sqlstring)
        {
            var objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            var ds = new DataSet();
            var objcmd = new SqlCommand(sqlstring, objsqlconn);
            var objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }
    }
}
