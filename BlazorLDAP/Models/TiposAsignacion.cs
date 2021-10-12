using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class TiposAsignacion
    {
        public TiposAsignacion()
        {
            Asignaciones = new HashSet<Asignacion>();
        }

        public int IdTipoAsignacion { get; set; }
        public string DescricionAsignacion { get; set; }
        public int? IdEstadoTiposAsignacion { get; set; }

        public virtual Estado IdEstadoTiposAsignacionNavigation { get; set; }
        public virtual ICollection<Asignacion> Asignaciones { get; set; }
    }
}
