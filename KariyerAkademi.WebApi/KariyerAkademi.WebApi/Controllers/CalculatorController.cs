using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KariyerAkademi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("topla/{sayi1}/{sayi2}")]
        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

    }
}
