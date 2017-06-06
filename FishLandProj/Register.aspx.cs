using System;
using BusinessLayer;
using EntityLayer;

namespace FishLandProj
{
    public partial class Register : System.Web.UI.Page
    {
        //create and instantiate objects to use
        Actor actor = new Actor();
        BLActor lt_actor = new BLActor();

        Authentication auth = new Authentication();
        BLAuthentication lt_auth = new BLAuthentication();

        ActorIdentity actoridentity = new ActorIdentity();
        BLActorIdentity lt_actoridentity = new BLActorIdentity();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            actor.ActorIdentityID = 1;

            actor.Name = txtName.Text;
            actor.Surname = txtSurname.Text;
            actor.DateOfBirth = (DateTime)Convert.ChangeType(txtDOB.Text, typeof(DateTime));
            actor.Cellphone = txtCellphone.Text;

            auth.Username = txtUsername.Text;
            auth.Password = txtPassword.Text;
            auth.ConfirmPass = txtCPassword.Text;

            actor.Email = txtEmail.Text;
            actor.Address = txtAddress.Text;

            //actoridentity.ActorIdentityID = 1;

            lt_actor.AddActor(actor);
            lt_auth.AddAuthentication(auth);

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
            txtEmail.Text = "";
            txtAddress.Text = "";
        }
    }
}