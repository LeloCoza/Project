using DatabaseLayer;    
using EntityLayer;

namespace BusinessLayer
{
    public class BLOder
    {
        public DBOder objDataLayer = new DBOder();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddOder(Oder oder)
        {
            objDataLayer.AddOderDB(oder);
        }

        public void UpdateOder(Oder oder)
        {
            objDataLayer.UpdateOderDB(oder);
        }

        public void DeleteOder(Oder oder)
        {
            objDataLayer.DeleteOderDB(oder);
        }

        public object RetrieveOder()
        {
            return objDataLayer.RetrieveOderDB();
        }
    }
}
