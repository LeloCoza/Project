using System.Data;
using EntityLayer;

namespace DatabaseLayer
{
    public class DBOderDetails
    {
        public DB db;
        public DBOderDetails()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddOderDetailsDB(OderDetail OD)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into OderDetails (Size, NumOfItems, OderID, ProductID) VALUES ('" + OD.Size + "','" + OD.NumOfItems + "','" + OD.OderID + "','" + OD.ProductID + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateOderDetailsDB(OderDetail OD)
        {
            DataSet ds = new DataSet();
            string sql = "Update OderDetails set Size='" + OD.Size + "',NumOfItems='" + OD.NumOfItems + "',OderID='" + OD.OderID + "',ProductID='" + OD.ProductID + "' Where OderDetailsID='" + OD.OderDetailsID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteOderDetailsDB(OderDetail OD)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from OderDetails Where OderDetailsID='" + OD.OderDetailsID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveOderDetailsDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from OderDetails order by OderDetailsID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
