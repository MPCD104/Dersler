using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.Entities; 

namespace Kariyer.Kutuphane.Business
{
    public class BaseManager<T> : IBaseManager<T> where T : BaseEntity
    {
        List<T> list;
        public BaseManager()
        {
            if (list == null)
                list = new List<T>();
        }
        public bool Create(T entity)
        {
            if(list.Any(x=> x.Id == entity.Id))
            {
                return false;
            }

            list.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
           list.Remove(GetById(id));
            return true;
        }

        public List<T> GetAll()
        {
            return list;
        }

        public T GetById(int Id)
        {
            return list.FirstOrDefault(x => x.Id == Id);
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
