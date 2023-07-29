using Kariyer.Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.DataAccess.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> GetAll();
        TEntity GetById(int Id);
        TEntity Create(TEntity entity);
        bool Delete(int id);
        bool Update(TEntity entity);
    }
}
