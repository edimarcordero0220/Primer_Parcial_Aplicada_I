using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parcial1_EdimarC.Entidades;
using Parcial1_EdimarC.DAL;

namespace Parcial1_EdimarC.BLL
{
    public class RepositoryBLL
    {
        public static bool Guardar(Empleados nuevo)
        {
            bool retornar = false;
            using (var db = new Repositorio<Empleados>())
            {
                retornar = db.Guardar(nuevo) != null;
            }
            return retornar;

        }
        public static bool Eliminar(Empleados Id)
        {
            bool result = false;
            using (var db = new Repositorio<Empleados>())
            {
                result = db.Eliminar(Id);

            }
            return result;
        }
    }
}
