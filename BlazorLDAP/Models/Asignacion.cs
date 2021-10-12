using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Asignacion
    {
        public int IdAsignacion { get; set; }
        public string DescripcionAsignacion { get; set; }
        public DateTime FechaAsignación { get; set; }
        public int? IdTipoAsignacionAsignaciones { get; set; }
        public long? NumeroCedulaAsignaciones { get; set; }
        public string NumeroActivoFijoAsignaciones { get; set; }
        public int? IdCompaniaAsignaciones { get; set; }

        public virtual Compania IdCompaniaAsignacionesNavigation { get; set; }
        public virtual TiposAsignacion IdTipoAsignacionAsignacionesNavigation { get; set; }
        public virtual Equipo NumeroActivoFijoAsignacionesNavigation { get; set; }
        public virtual Usuario NumeroCedulaAsignacionesNavigation { get; set; }
    }
}
