using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorLDAP.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Compania = new HashSet<Compania>();
            Equipos = new HashSet<Equipo>();
            Roles = new HashSet<Rol>();
            Sucursales = new HashSet<Sucursal>();
            TiposAsignacions = new HashSet<TiposAsignacion>();
            TiposEquipos = new HashSet<TiposEquipo>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEstado { get; set; }
        public string DescripcionEstado { get; set; }

        public virtual ICollection<Compania> Compania { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<Rol> Roles { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }
        public virtual ICollection<TiposAsignacion> TiposAsignacions { get; set; }
        public virtual ICollection<TiposEquipo> TiposEquipos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
