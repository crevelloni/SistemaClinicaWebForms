using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAcessoDados;

namespace CapaLogicaNegocio
{
   public class PacienteLN
    {
        #region "PATRON SINGLETON"
        private static PacienteLN ObjPaciente = null;
        private PacienteLN() { }
        public static PacienteLN getInstance()
        {
            if (ObjPaciente == null)
            {
                ObjPaciente = new PacienteLN();
            }
            return ObjPaciente;
        }
        #endregion
        public bool CadastrarPaciente(PacienteModelView objPacienteModelView)
        {
            try
            {
                return PacienteDAO.getInstance().CadastrarPaciente(objPacienteModelView);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public List<PacienteModelView> ListarPaciente()
        {
            try
            {
                return PacienteDAO.getInstance().ListarPaciente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
