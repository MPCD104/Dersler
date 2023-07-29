using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer.Kutuphane.Controllers.Base
{
    
    public class BaseController<TManager , TEntity> : ControllerBase 
        where TManager : IBaseManager<TEntity> 
        where TEntity : BaseEntity
    {
        TManager manager;
        public BaseController(TManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public List<TEntity> GetAll()
        {
            return manager.GetAll();
        }

        [HttpGet("{id}")]
        public TEntity Get(int id)
        { 
            return manager.GetById(id);
        }

        [HttpPost]
        public bool Post([FromBody] TEntity entity)
        {
            return manager.Create(entity);
        }

        [HttpPut]
        public void Put([FromBody] TEntity entity)
        {
            manager.Update(entity);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return manager.Delete(id);
        }

    }
}
