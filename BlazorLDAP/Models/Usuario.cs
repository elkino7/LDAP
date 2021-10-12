using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Asignaciones = new HashSet<Asignacion>();
        }

        public long NumeroCedula { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string CargoUsuario { get; set; }
        public string NombreCentroUsuario { get; set; }
        public int IdRolUsuario { get; set; }
        public string IdSucursalUsuario { get; set; }
        public int IdEstadoUsuario { get; set; }

        public virtual Estado IdEstadoUsuarioNavigation { get; set; }
        public virtual Rol IdRolUsuarioNavigation { get; set; }
        public virtual Sucursal IdSucursalUsuarioNavigation { get; set; }
        public virtual ICollection<Asignacion> Asignaciones { get; set; }
    }
}
