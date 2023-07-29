using Kariyer.Kutuphane.Business;
using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.Controllers.Base;
using Kariyer.Kutuphane.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer.Kutuphane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YayinEvleriController : BaseController<IYayinEviManager, YayinEvi>
    {
        public YayinEvleriController(IYayinEviManager yayinEviManager) : base(yayinEviManager)
        {

        }
    }
}
