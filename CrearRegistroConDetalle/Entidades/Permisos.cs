using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace CrearRegistroConDetalle.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool VecesAsignado { get; set; }

        [ForeignKey("PermisoId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }
    }
}
