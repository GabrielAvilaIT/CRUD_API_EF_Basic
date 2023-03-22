using System;
using System.Collections.Generic;

namespace CRUD_API_EF_Basic.Models
{
    public partial class Cargo
    {
        public int IdCargo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
