using DatabaseLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BLActorIdentity
    {
        public DBActorIdentity objDataLayer = new DBActorIdentity();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActorIdentity(ActorIdentity actor_identity)
        {
            objDataLayer.AddActorIdentityDB(actor_identity);
        }

        public void UpdateActorIdentity(ActorIdentity actor_identity)
        {
            objDataLayer.UpdateActorIdentityDB(actor_identity);
        }

        public void DeleteActorIdentity(ActorIdentity actor_identity)
        {
            objDataLayer.DeleteActorIdentityDB(actor_identity);
        }

        public object RetrieveActorIdentity()
        {
            return objDataLayer.RetrieveActorIdentityDB();
        }
    }
}
