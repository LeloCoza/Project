using EntityLayer;     
using System.Data;

namespace DatabaseLayer
{
    public class DBCategory
    {
        /*declare a DB class variable
        and instantite it in the DLOder constructor*/
        public DB db;
        public DBCategory()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddCategoryDB(Category category)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Category (CategoryName) VALUES ('" + category.CategoryName + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCategoryDB(Category category)
        {
            DataSet ds = new DataSet();
            string sql = "Update Category set CategoryName='" + category.CategoryName + "' Where CategoryID='" + category.CategoryID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCategoryDB(Category category)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Category Where CategoryID='" + category.CategoryID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveCategoryDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Category order by CategoryID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
