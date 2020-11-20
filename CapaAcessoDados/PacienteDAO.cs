using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaAcessoDados
{
   public class PacienteDAO
    {
        #region "PATRON SINGLETON"
        private static PacienteDAO daoPaciente = null;
        private PacienteDAO() { }
        public static PacienteDAO getInstance()
        {
            if (daoPaciente == null)
            {
                daoPaciente = new PacienteDAO();
            }
            return daoPaciente;
        }
        #endregion
        public bool CadastrarPaciente(PacienteModelView objPacienteModelView)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spCadastrarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pmrNombres", objPacienteModelView.Nombres);
                cmd.Parameters.AddWithValue("@pmrApMaterno", objPacienteModelView.ApMaterno);
                cmd.Parameters.AddWithValue("@pmrApPaterno", objPacienteModelView.ApPaterno);
                cmd.Parameters.AddWithValue("@pmrEdad", objPacienteModelView.Edad);
                cmd.Parameters.AddWithValue("@pmrSexo", objPacienteModelView.Sexo);
                cmd.Parameters.AddWithValue("@pmrNroDoc", objPacienteModelView.NroDocumento);
                cmd.Parameters.AddWithValue("@pmrDireccion", objPacienteModelView.Direccion);
                cmd.Parameters.AddWithValue("@pmrTelefono", objPacienteModelView.Telefono);
                cmd.Parameters.AddWithValue("@pmrEstado", objPacienteModelView.Estado);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                    if (filas > 0) response = true;
            }
            catch(Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }
        public List<PacienteModelView> ListarPaciente()
        {
            List<PacienteModelView> Lista = new List<PacienteModelView>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spListarPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    // Criar objetos de tipo paciente

                    PacienteModelView objPacienteModelView = new PacienteModelView();
                    objPacienteModelView.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                    objPacienteModelView.Nombres = dr["nombre"].ToString();
                    objPacienteModelView.ApPaterno = dr["apPaterno"].ToString();
                    objPacienteModelView.ApMaterno = dr["apMaterno"].ToString();
                    objPacienteModelView.Edad = Convert.ToInt32(dr["edad"].ToString());
                    objPacienteModelView.Sexo = Convert.ToChar(dr["sexo"].ToString());
                    objPacienteModelView.NroDocumento = dr["nroDocumento"].ToString();
                    objPacienteModelView.Direccion = dr["direccion"].ToString();
                    objPacienteModelView.Estado = true;

                    // adicionar a lista de objetos
                    Lista.Add(objPacienteModelView);
                }
                //using (SqlDataReader dr1 = cmd.ExecuteReader())
                //{
                //    PacienteModelView objPacienteModelView = new PacienteModelView();
                //    objPacienteModelView.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                //    objPacienteModelView.Nombres = dr["nombre"].ToString();
                //    objPacienteModelView.ApPaterno = dr["apPaterno"].ToString();
                //    objPacienteModelView.ApMaterno = dr["apMaterno"].ToString();
                //    objPacienteModelView.Edad = Convert.ToInt32(dr["edad"].ToString());
                //    objPacienteModelView.Sexo = Convert.ToChar(dr["sexo"].ToString());
                //    objPacienteModelView.NroDocumento = dr["nroDocumento"].ToString();
                //    objPacienteModelView.Direccion = dr["direccion"].ToString();
                //    objPacienteModelView.Estado = true;
                //}
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Lista;
        }
    }
}
