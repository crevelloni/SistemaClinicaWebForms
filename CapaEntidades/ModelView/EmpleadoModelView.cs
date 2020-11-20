using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EmpleadoModelView
    {
        public int IdEmpleado { get; set; }
        public int IdTipoEmpleado { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string NroDocumento { get; set; }
        public bool? Estado { get; set; }
        public string Imagen { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
