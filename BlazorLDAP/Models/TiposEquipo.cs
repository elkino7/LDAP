using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class TiposEquipo
    {
        public TiposEquipo()
        {
            Equipos = new HashSet<Equipo>();
        }

        public int IdTipoEquipo { get; set; }
        public string DescripcionEquipo { get; set; }
        public int? EstadoTipoEquipo { get; set; }

        public virtual Estado EstadoTipoEquipoNavigation { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
