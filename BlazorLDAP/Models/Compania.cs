using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Compania
    {
        public Compania()
        {
            Asignaciones = new HashSet<Asignacion>();
        }

        public int IdCompania { get; set; }
        public string NombreCompania { get; set; }
        public int? IdEstadoCompania { get; set; }

        public virtual Estado IdEstadoCompaniaNavigation { get; set; }
        public virtual ICollection<Asignacion> Asignaciones { get; set; }
    }
}
