using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1LuisChinchilla.BLL.Models
{
    public class InventarioCursosDetailModel
    {
        [Required]
        public string Nombre_Carrera { get; set; }
        [Required]
        public int Codigo_Asignatura { get; set; }
        [Required]
        public string Nombre_Asignatura { get; set; }
        [Required]
        public decimal Creditos { get; set; }
        [Required]
        public string Cuatrimestre { get; set; }
        [Required]
        public int Duracion_Semanas { get; set; }
        [Required]
        public decimal Horas_Semanales { get; set; }
        [Required]
        public string Nombre_Docente { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public DateTime Fecha_Inicio { get; set; }
        [Required]
        public DateTime Fecha_Final { get; set; }
        [Required]
        public Boolean Active { get; set; }
    }
}
