using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public string IdSucursal { get; set; }
        public string NombreLocal { get; set; }
        public string CiudadLocal { get; set; }
        public string DireccionSucursal { get; set; }
        public int? IdEstadoSucursal { get; set; }

        public virtual Estado IdEstadoSucursalNavigation { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
