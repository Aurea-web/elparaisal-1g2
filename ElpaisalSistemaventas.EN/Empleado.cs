using System;
using System.Collections.Generic;
using System.Text;

namespace ElpaisalSistemaventas.EN
{
    public class Empleado
    {
        public short EmpleadoId { get; set; }
         public byte CargoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
    }

}
