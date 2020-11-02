using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jhordy_P2_AP1.Entidades
{
    public class Proyectos
    {
        [Key]

        public int ProyectoId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string Descripcion { get; set; }

        public double Tiempo { get; set; }

        [ForeignKey("ProyectoId")]
        public virtual List<ProyectosDetalle> Detalle { get; set; } = new List<ProyectosDetalle>();
    }
}