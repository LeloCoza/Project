using EntityLayer;
using System.Data;

namespace DatabaseLayer
{
    public class DBActor
    {
        public DB db;
        public DBActor()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddActorDB(Actor actor)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Actor (Name, Surname, DateOfBirth, Cellphone, Email, Address, ActorIdentityID) VALUES ('" + actor.Name + "','" + actor.Surname + "','" + actor.DateOfBirth + "','" + actor.Cellphone + "','" + actor.Email + "','" + actor.Address + actor.ActorIdentity + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }
        public void UpdateActorDB(Actor actor)
        {
            DataSet ds = new DataSet();
            string sql = "Update Actor set Name='" + actor.Name + "',Surname='" + actor.Surname + "',DateOfBirth='" + actor.DateOfBirth + "',Cellphone='" + actor.Cellphone + "',Email='" + actor.Email + "',Address='" + actor.Address + "',ActorIdentityID='" + actor.ActorID + "' Where ActorID='" + actor.ActorID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteActorDB(Actor actor)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Actor Where ActorID='" + actor.ActorID + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveActorDB()
        {
            string sql = "Select * from Actor order by ActorID";
            DataSet ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
