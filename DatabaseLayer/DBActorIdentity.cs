using EntityLayer;
using System.Data;

namespace DatabaseLayer
{
    public class DBActorIdentity
    {
        public DB db;
        public DBActorIdentity()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddActorIdentintyDB(ActorIdentity actor_identity)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into ActorIdentity (Description) VALUES ('" + actor_identity.Description + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }


        public void UpdateActorIdentintyDB(ActorIdentity actor_identity)
        {
            DataSet ds = new DataSet();
            string sql = "Update ActorIdentity set Description='" + actor_identity.Description + "' Where ActorIdentityID='" + actor_identity.ActorIdentityID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        public void DeleteActorIdentintyDB(ActorIdentity actor_identity)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from ActorIdentity Where ActorIdentityID='" + actor_identity.ActorIdentityID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }
        
        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveActorIdentintyDB()
        {
            string sql = "Select * from ActorIdentity order by ActorIdentityID";
            DataSet ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
