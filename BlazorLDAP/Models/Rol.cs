using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string DescripcionRol { get; set; }
        public int? IdEstadoRol { get; set; }

        public virtual Estado IdEstadoRolNavigation { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
