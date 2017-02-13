using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Parcial1_EdimarC.Entidades
{
    public class Empleados
    {
        [Key]

        public int EmpleadoId { get; set; }

        public string Nombres { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public double sueldo { get; set; }
        
    }
}
