using EntityLayer;
using DatabaseLayer;

namespace BusinessLayer
{
    public class BLProduct
    {
        public DBProduct objDataLayer = new DBProduct();  //create a DatabaseLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddProduct(Product product)
        {
            objDataLayer.AddProductDB(product);
        }

        public void UpdateProduct(Product product)
        {
            objDataLayer.UpdateProductDB(product);
        }

        public void DeleteProduct(Product product)
        {
            objDataLayer.DeleteProductDB(product);
        }

        public object RetrieveProduct()
        {
            return objDataLayer.RetrieveProductDB();
        }
    }
}
