using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Equipo
    {
        public Equipo()
        {
            Asignaciones = new HashSet<Asignacion>();
        }

        public string NumeroActivoFijo { get; set; }
        public string MarcaEquipo { get; set; }
        public string ModeloEquipo { get; set; }
        public string SerialEquipo { get; set; }
        public DateTime? FechaFabricacionEquipo { get; set; }
        public int? EstadoEquipos { get; set; }
        public int? IdTipoEquipoEquipos { get; set; }

        public virtual Estado EstadoEquiposNavigation { get; set; }
        public virtual TiposEquipo IdTipoEquipoEquiposNavigation { get; set; }
        public virtual ICollection<Asignacion> Asignaciones { get; set; }
    }
}
