using Kariyer.Kutuphane.Business;
using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.Controllers.Base;
using Kariyer.Kutuphane.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kariyer.Kutuphane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UyeController : BaseController<IUyeManager, Uye>
    {
        public UyeController(IUyeManager manager) : base(manager)
        {
        }
    }
}
