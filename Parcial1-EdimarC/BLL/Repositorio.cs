using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parcial1_EdimarC.DAL;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Parcial1_EdimarC.BLL
{
    public class Repositorio<TEntity> : IRepositoriy<TEntity> where TEntity : class
    {
        Parcial1Ap1Db context = null;
        public Repositorio()
        {
            context = new Parcial1Ap1Db();
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }
        public TEntity Guardar(TEntity n)
        {
            TEntity result = null;
            try
            {
                EntitySet.Add(n);
                context.SaveChanges();
                result = n;
            }catch(Exception e)
            {
                throw e;
            }return result;
        }
        public TEntity Buscar(Expression<Func<TEntity, bool>> id)
        {
            TEntity retornar = null;
            try
            {
                retornar = EntitySet.FirstOrDefault(id);
            }catch(Exception e)
            {
                throw e;
            }return retornar;
        }
        public bool Eliminar(TEntity id)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(id);
                EntitySet.Remove(id);
                result = context.SaveChanges() > 0;
            }catch(Exception e)
            {
                throw e;
            }return result;
        }
        public List<TEntity> GetList()
        {
            try
            {
                return EntitySet.ToList();
            }catch (Exception e)
            {
                throw e;
            }
        }
        public List<TEntity> GetListNombre(Expression<Func<TEntity, bool>> nombre)
        {
            try
            {
                return EntitySet.Where(nombre).ToList();
            }catch(Exception e)
            {
                throw e;
            }
        }
        public List<TEntity> GetListFecha(Expression<Func<TEntity, bool>> fecha)
        {
            try
            {
                return EntitySet.Where(fecha).ToList();
            }catch (Exception e)
            {
                throw e;
            }
        }
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        TEntity IRepositoriy<TEntity>.Guardar(TEntity nuevo)
        {
            throw new NotImplementedException();
        }

        bool IRepositoriy<TEntity>.Eliminar(TEntity Id)
        {
            throw new NotImplementedException();
        }

        TEntity IRepositoriy<TEntity>.Buscar(Expression<Func<TEntity, bool>> Id)
        {
            throw new NotImplementedException();
        }

        List<TEntity> IRepositoriy<TEntity>.GetList()
        {
            throw new NotImplementedException();
        }

        List<TEntity> IRepositoriy<TEntity>.GetListNombre(Expression<Func<TEntity, bool>> nombre)
        {
            throw new NotImplementedException();
        }

        List<TEntity> IRepositoriy<TEntity>.GetLisFecha(Expression<Func<TEntity, bool>> fecha)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
