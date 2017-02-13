using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Parcial1_EdimarC.Entidades;

namespace Parcial1_EdimarC.DAL
{
    public class Parcial1Ap1Db:DbContext
    {
        public Parcial1Ap1Db():base("name = ConStr")
        {
                
        }

        public virtual DbSet<Empleados> Empleado{ get; set; }
    }
}
