using DatabaseLayer;    
using EntityLayer;

namespace BusinessLayer
{
    public class BLOderDetails
    {
        public DBOderDetails objDataLayer = new DBOderDetails();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddOderDetails(OderDetail OD)
        {
            objDataLayer.AddOderDetailsDB(OD);
        }

        public void UpdateOderDetails(OderDetail OD)
        {
            objDataLayer.UpdateOderDetailsDB(OD);
        }

        public void DeleteOderDetails(OderDetail OD)
        {
            objDataLayer.DeleteOderDetailsDB(OD);
        }

        public object RetrieveOderDetails()
        {
            return objDataLayer.RetrieveOderDetailsDB();
        }
    }
}
