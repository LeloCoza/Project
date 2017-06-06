using EntityLayer;
using System.Data;

namespace DatabaseLayer
{
    public class DBOder
    {
        /*declare a DB class variable
        and instantite it in the DLOder constructor*/
        public DB db;
        public DBOder()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddOderDB(Oder oder)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Oder (Status, TotalAmount, Date, AuthenticationID) VALUES ('" + oder.Status + "','" + oder.TotalAmount + "','" + oder.Date + oder.Authentication + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateOderDB(Oder oder)
        {
            DataSet ds = new DataSet();
            string sql = "Update Oder set Status='" + oder.Status + "',TotalAmount='" + oder.TotalAmount + "',Date='" + oder.Date + "',AuthenticationID='" + oder.Authentication + "' Where OderID='" + oder.OderID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteOderDB(Oder oder)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Oder Where OderID='" + oder.OderID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveOderDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Oder order by OderID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
