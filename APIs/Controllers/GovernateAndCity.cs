using APIs.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernateAndCity : ControllerBase
    {

        private  IGovernateAndCityRepo governateAndCity;
        public GovernateAndCity(  IGovernateAndCityRepo governateAndCity) {

            this.governateAndCity = governateAndCity;



        }
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(governateAndCity.getdata());
        }
    }
}
