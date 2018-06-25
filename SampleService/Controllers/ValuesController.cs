using SampleService.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("api/Cities")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<City> Cities()
        {
            return Helpers.Funcs.GetSampleCities();
        }
    }
}
