using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jhordy_P2_AP1.Entidades
{
    public class ProyectosDetalle
    {
        [Key]

        public int Id { get; set; }

        public int ProyectoId { get; set; }

        public int TareaId { get; set; }

        public string Requerimiento { get; set; }

        public double Tiempo { get; set; }

        [ForeignKey("TareaId")]
        public Tareas tarea { get; set; } = new Tareas();
    }
}