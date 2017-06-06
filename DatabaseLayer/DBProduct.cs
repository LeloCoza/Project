using EntityLayer;
using System.Data;

namespace DatabaseLayer
{
    public class DBProduct
    {
        public DB db;
        public DBProduct()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddProductDB(Product product)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Product (ProductName, ProductDescript, ProductPrice, ProductPicture, CategoryID) VALUES ('" + product.ProductName + "','" + product.ProductDescript + "','" + product.ProductPrice + "','" + product.ProductPicture + "','" + product.Category + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateProductDB(Product product)
        {
            DataSet ds = new DataSet();
            string sql = "Update Product set ProductName='" + product.ProductName + "',ProductDescript='" + product.ProductDescript + "',ProductPrice='" + product.ProductPrice + "'ProductPicture='" + product.ProductPicture + "'CategoryID='" + product.Category + "' Where ProductID='" + product.ProductID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteProductDB(Product product)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Productr Where ProductID='" + product.ProductID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveProductDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Product order by ProductID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
