using SampleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Helpers
{
    public interface IGetData
    {
        List<City> GetSampleCities();
        List<Animal> GetSampleWildlife();

    }
}
