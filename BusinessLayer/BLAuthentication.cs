using EntityLayer;      
using DatabaseLayer;

namespace BusinessLayer
{
    public class BLAuthentication
    {
        public DBAuthentication objDataLayer = new DBAuthentication();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddAuthentication(Authentication auth)
        {
            objDataLayer.AddAuthenticationDB(auth);
        }

        public void UpdateAuthentication(Authentication auth)
        {
            objDataLayer.UpdateAuthenticationDB(auth);
        }

        public void DeleteAuthentication(Authentication auth)
        {
            objDataLayer.DeleteAuthenticationDB(auth);
        }

        public object RetrieveAuthentication(Authentication auth)
        {
            return objDataLayer.RetrieveAuthenticationDB(auth);
        }
    }
}
