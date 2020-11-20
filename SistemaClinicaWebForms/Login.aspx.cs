using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

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

            Empleado objEmpleado = EmpleadoLN.getInstance().AcessoSistema(txtUsuario.Text, txtPassword.Text);
            if(objEmpleado != null)
            {
                Response.Write("<script>alert('USUARIO CORRETO.')</script>");
                Response.Redirect("PainelGeral.aspx");
            }
            else
            {
                Response.Write("<script>alert('USUARIO INCORRETO.')</script>");
            }
        }
    }
}