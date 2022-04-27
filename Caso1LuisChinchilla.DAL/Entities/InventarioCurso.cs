using System;
using System.Collections.Generic;

namespace Caso1LuisChinchilla.DAL.Entities
{
    public partial class InventarioCurso
    {
        public int Indice { get; set; }
        public int CodigoAsignatura { get; set; }
        public string NombreCarrera { get; set; } = null!;
        public string NombreAsignatura { get; set; } = null!;
        public decimal Creditos { get; set; }
        public string Cuatrimestre { get; set; } = null!;
        public int DuracionSemanas { get; set; }
        public decimal HorasSemanales { get; set; }
        public string NombreDocente { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public bool Active { get; set; }
    }
}
