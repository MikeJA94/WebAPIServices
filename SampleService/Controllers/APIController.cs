using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using SampleService.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace SampleService.Controllers
{
    public class APIController : ApiController
    {
        [HttpGet]
        [Route("api/Cities")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<City> Cities()
        {
            return new Helpers.GetData().GetSampleCities();
        }


        [HttpGet]
        [Route("api/wildlife")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<Animal> wildlife()
        {
            return new Helpers.GetData().GetSampleWildlife();
        }
    }
}
