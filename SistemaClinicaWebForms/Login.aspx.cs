using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaClinicaWebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            btnEntrar.Click += btnEntrar_Click;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEntrar_Click(object sender,EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string userName = "faso";
            string passName = "faso";
            if(user.Equals(userName) && password.Equals(passName))
            {
                Response.Write("<script>alert('USUÁRIO CORRETO')</script>");
            }
            else
            {
                Response.Write("<script>alert('USUÁRIO INCORRETO')</script>");
            }
        }
    }
}