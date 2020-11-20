using CapaApresentacao.Models;
using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SistemaClinicaWebForms
{
    public partial class frmGestionarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }
        protected override void OnInit(EventArgs e)
        {
            btnCadastrar.Click += btnCadastrar_Click;
        }
        private PacienteModelView GetEntity()
        {
            PacienteModelView ObjPacienteModelView = new PacienteModelView();
            ObjPacienteModelView.IdPaciente = 0;
            ObjPacienteModelView.Nombres = TextNome.Text;
            ObjPacienteModelView.ApMaterno = TextMae.Text;
            ObjPacienteModelView.ApPaterno = TextPai.Text;
            ObjPacienteModelView.Edad = Convert.ToInt32(TextIdade.Text);
            ObjPacienteModelView.Sexo = (ddlSexo.SelectedValue == "Femenino") ? 'F' : 'M'; // Masculino , Femenino
            ObjPacienteModelView.NroDocumento = txtRG.Text;
            ObjPacienteModelView.Direccion = TextEnder.Text;
            ObjPacienteModelView.Telefono = TextTel.Text;
            ObjPacienteModelView.Estado = true;

            return ObjPacienteModelView;

        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //cadastro paciante
            PacienteModelView ObjPacienteModelView = GetEntity();
            // enviar a capa de logica de negocio
            bool response = PacienteLN.getInstance().CadastrarPaciente(ObjPacienteModelView);
            if (response == true)
            {
                Response.Write("<script>alert('REGISTRO CORRETO.')</script>");
            }
            else
            {
                Response.Write("<script>alert('REGISTRO INCORRETO.')</script>");
            }
        }

        public static List<PacienteModelView> ListarPaciente()
        {
            List<PacienteModelView> Lista = null;
            try
            {
                Lista = PacienteLN.getInstance().ListarPaciente();
            }
            catch (Exception ex)
            {
                Lista = null;
            }
            return Lista;
        }
    }
}