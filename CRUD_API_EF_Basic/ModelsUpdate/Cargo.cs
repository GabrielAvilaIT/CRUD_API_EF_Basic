using System;
using System.Collections.Generic;

namespace CRUD_API_EF_Basic.ModelsUpdate
{
    public partial class Cargo
    {
        public Cargo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdCargo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
