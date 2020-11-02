using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jhordy_P2_AP1.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }

        public string TipoTarea { get; set; }

    }
}