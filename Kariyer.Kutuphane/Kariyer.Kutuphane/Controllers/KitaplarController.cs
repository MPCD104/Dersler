using Kariyer.Kutuphane.Business;
using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kariyer.Kutuphane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitaplarController : ControllerBase
    {
        IKitapManager kitapManager;
        public KitaplarController(IKitapManager kitapManager)
        {
            this.kitapManager=kitapManager;
        }
        [HttpGet]
        public List<Kitap> Get()
        {
            return kitapManager.GetAll();
        }

        // GET api/<KitapsController>/5
        [HttpGet("{id}")]
        public Kitap Get(int id)
        {
            return kitapManager.GetById(id);
        }

        // POST api/<KitapsController>
        [HttpPost]
        public void Post([FromBody] Kitap kitap)
        { 
            kitapManager.Create(kitap);
        }

        // PUT api/<KitapsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KitapsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            kitapManager.Delete(id);
        }
    }
}
