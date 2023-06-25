using Kariyer.Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.Business.Abstracts
{
    public interface IBaseManager<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> GetAll();
        TEntity GetById(int Id);
        bool Create(TEntity entity);
        bool Delete(int id);
        bool Update(TEntity entity);
    }
}
