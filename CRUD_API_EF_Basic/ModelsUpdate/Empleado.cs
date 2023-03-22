using System;
using System.Collections.Generic;

namespace CRUD_API_EF_Basic.ModelsUpdate
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public int? IdCargo { get; set; }

        public virtual Cargo? IdCargoNavigation { get; set; }
    }
}
