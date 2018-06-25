using SampleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleService.Helpers
{
    public class Funcs
    {
        public static List<City> GetSampleCities()
        {
            List<City> cities = new List<City>();
            // Simply create sample records in memory for demo
            cities.Add(new City() { Id = 1, Name = "New York", Image = "https://i.ytimg.com/vi/MtCMtC50gwY/maxresdefault.jpg", Population = "8,405,837", Location = new float[] { 40.7127837F, -74.0059413F } });
            cities.Add(new City() { Id = 2, Name = "Los Angeles", Image = "https://www.telegraph.co.uk/content/dam/Travel/Destinations/North%20America/USA/California/los%20angeles/Los%20Angeles%20lead-xlarge.jpg", Population = "3,884,307", Location = new float[] { 34.0522342F, -118.2436849F } });
            cities.Add(new City() { Id = 3, Name = "Chicago", Image = "https://s3-us-west-2.amazonaws.com/au-assets/assets/images/blog/City+Photo+Guides/Chicago/10BrooklynBicycle+(1)+(1)+(1).jpg", Population = "2,718,782", Location = new float[] { 41.8781136F, -87.6297982F } });
            cities.Add(new City() { Id = 4, Name = "Philadelphia", Image = "https://www.lonelyplanet.com/travel-blog/tip-article/wordpress_uploads/2016/01/Image-by-R.-Kennedy-for-VISIT-PHILADELPHIA%C2%AE.jpg", Population = "1,553,165", Location = new float[] { 39.9525839F, -75.1652215F } });
            return cities;
        }
    }
}