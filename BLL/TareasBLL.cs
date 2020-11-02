using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jhordy_P2_AP1.DAL;
using Jhordy_P2_AP1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Jhordy_P2_AP1.BLL
{
    public class TareasBLL
    {

        public static List<Tareas> GetTareas()
        {
            List<Tareas> tareas = new List<Tareas>();
            Contexto contexto = new Contexto();

            try
            {
                tareas = contexto.Tareas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tareas;
        }
    }
}