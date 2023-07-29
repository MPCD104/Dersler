using Kariyer.Kutuphane.DataAccess.Context;
using Kariyer.Kutuphane.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.DataAccess.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly KariyerKutuphaneContext kariyerKutuphaneContext;
        private DbSet<TEntity> entities;
        public GenericRepository(KariyerKutuphaneContext kariyerKutuphaneContext)
        {
            this.kariyerKutuphaneContext = kariyerKutuphaneContext;
            entities = kariyerKutuphaneContext.Set<TEntity>();
        }


        public TEntity Create(TEntity entity)
        {
            entities.Add(entity);
            kariyerKutuphaneContext.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            try
            {
                entities.Remove(GetById(id));
                kariyerKutuphaneContext.SaveChanges(true);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<TEntity> GetAll()
        {
            return entities.ToList();
        }

        public TEntity GetById(int Id)
        {
            return entities.Find(Id);
        }

        public bool Update(TEntity entity)
        {
            try
            {
                entities.Update(entity);
                kariyerKutuphaneContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
