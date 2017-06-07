using System;
using BusinessLayer;
using EntityLayer;

namespace FishLandProj
{
    public partial class Register : System.Web.UI.Page
    {
        //create and instantiate objects to use
        Actor actor = new Actor();
        BLActor bl_actor = new BLActor();

        Authentication auth = new Authentication();
        BLAuthentication bl_auth = new BLAuthentication();

        ActorIdentity actoridentity = new ActorIdentity();
        BLActorIdentity bl_actoridentity = new BLActorIdentity();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            actor.ActorIdentityID = 1;


            if (actoridentity.ActorIdentityID == 1 && actoridentity.Description == "Customer")
            {
                actor.Name = txtName.Text;
                actor.Surname = txtSurname.Text;
                actor.DateOfBirth = DateTime.Parse(txtDOB.Text);
                actor.Cellphone = txtCellphone.Text;

                auth.Username = txtUsername.Text;
                auth.Password = txtPassword.Text;
                auth.ConfirmPass = txtCPassword.Text;
                auth.ActorID = actor.ActorID;

                actor.Email = txtEmail.Text;
                actor.Address = txtAddress.Text;

                //actoridentity.ActorIdentityID = 1;
                //actor.ActorIdentityID = actoridentity.ActorIdentityID;

               
            }

            bl_actor.AddActor(actor);
            bl_auth.AddAuthentication(auth);

            lblRegister.Visible = true;     //displays message when user/actor has registered successfully.
            clear();
        }

        //clears all textboxes after data is submitted.
        public void clear()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            txtCellphone.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCPassword.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }
    }
}