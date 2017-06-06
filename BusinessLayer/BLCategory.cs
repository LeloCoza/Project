using DatabaseLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BLCategory
    {
        public DBCategory objDataLayer = new DBCategory();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddCategory(Category category)
        {
            objDataLayer.AddCategoryDB(category);
        }

        public void UpdateCategory(Category category)
        {
            objDataLayer.UpdateCategoryDB(category);
        }

        public void DeleteCategory(Category category)
        {
            objDataLayer.DeleteCategoryDB(category);
        }

        public object RetrieveCategory()
        {
            return objDataLayer.RetrieveCategoryDB();
        }
    }
}
