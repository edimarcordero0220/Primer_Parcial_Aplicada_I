using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parcial1_EdimarC.Entidades;
using Parcial1_EdimarC.DAL;

namespace Parcial1_EdimarC.BLL
{
    public class EmpleadosBLL
    {
        public static void Guardar(Empleados em)
        {
            try
            {
                Parcial1Ap1Db db = new Parcial1Ap1Db();
                db.Empleado.Add(em);
                db.SaveChanges();
                db.Dispose();
            }catch(Exception ex)
            {
                throw ex;
            }

        }
        public static void Eliminar(Empleados em)
        {
            Parcial1Ap1Db db = new Parcial1Ap1Db();
            Empleados emple = db.Empleado.Find(em);

            db.Empleado.Remove(emple);
            db.SaveChanges();

        }
        public static Empleados Buscar(int Id)
        {
            Parcial1Ap1Db db = new Parcial1Ap1Db();
            return db.Empleado.Find(Id);
        }
        public static void Eliminar(int v)
        {
            Parcial1Ap1Db db = new Parcial1Ap1Db();
            Empleados emple = db.Empleado.Find(v);
            try
            {
                db.Empleado.Remove(emple);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static List<Empleados>GetListaNombre(string tmp)
        {
            List<Empleados> lista = new List<Empleados>();
            Parcial1Ap1Db db = new Parcial1Ap1Db();
            lista = db.Empleado.Where(p => p.Nombres == tmp).ToList();
            return lista;
        }

        internal static object GetLista(int selectedValue, DateTime value1, DateTime value2)
        {
            throw new NotImplementedException();
        }

        internal static object GetListaNombre(int selectedValue, DateTime value1, DateTime value2)
        {
            throw new NotImplementedException();
        }

        public static List<Empleados> GetLista()
        {
            List<Empleados> lista = new List<Empleados>();
            Parcial1Ap1Db db = new Parcial1Ap1Db();
            lista = db.Empleado.ToList();
            return lista;
        }
        public static List<Empleados> GetLista(int empleadoId)
        {
            List<Empleados> lista = new List<Empleados>();
            Parcial1Ap1Db db = new Parcial1Ap1Db();
            lista = db.Empleado.Where(p => p.EmpleadoId == empleadoId).ToList();
            return lista;
        }
    }
}
