using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1LuisChinchilla.BLL.Models
{
    public class InventarioCursosListModel
    {
        public string Nombre_Carrera { get; set; }

        public int Codigo_Asignatura { get; set; }

        public string Nombre_Asignatura { get; set; }

        public decimal Creditos { get; set; }

        public string Cuatrimestre { get; set; }

        public int Duracion_Semanas { get; set; }

        public decimal Horas_Semanales { get; set; }

        public string Nombre_Docente { get; set; }

        public string Correo { get; set; }

        public DateTime Fecha_Inicio { get; set; }

        public DateTime Fecha_Final { get; set; }

        public Boolean Active { get; set; }
    }
}
