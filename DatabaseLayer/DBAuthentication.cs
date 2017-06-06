using EntityLayer;
using System.Data;

namespace DatabaseLayer
{
    public class DBAuthentication
    {
        public DB db;
        public DBAuthentication()
        {
            //instantiate DB object for connection to the database
            //in the DLAuthentication class
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Authentication (Username, Password, ConfirmPass, ActorID) VALUES ('" + auth.Username + "','" + auth.Password + "','" + auth.ConfirmPass + "','" + auth.ActorID + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "Update Authentication set Username='" + auth.Username + "',Password='" + auth.Password + "',ConfirmPass='" + auth.ConfirmPass + "',ActorID'" + auth.Actor + "' Where AuthenticationID='" + auth.AuthenticationID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Authentication Where AuthenticationID='" + auth.AuthenticationID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Authentication Where Username='" + auth.Username + "'and Password='" + auth.Password + "'";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
