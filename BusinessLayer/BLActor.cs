using DatabaseLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BLActor
    {
        public DBActor objDataLayer = new DBActor();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActor(Actor actor)
        {
            objDataLayer.AddActorDB(actor);
        }

        public void UpdateActor(Actor actor)
        {
            objDataLayer.UpdateActorDB(actor);
        }

        public void DeleteActor(Actor actor)
        {
            objDataLayer.DeleteActorDB(actor);
        }

        public object RetrieveActor()
        {
            return objDataLayer.RetrieveActorDB();
        }
    }
}
