﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace CapaApresentacao.Models
{
    public partial class TipoEmpleado
    {
        public TipoEmpleado()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int IdTipoEmpleado { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}