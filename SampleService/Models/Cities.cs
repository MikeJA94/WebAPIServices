namespace SampleService.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Cities : DbContext
    {
        public Cities()
            : base("name=Cities")
        {
        }

         public virtual DbSet<City> AllCities { get; set; }
    }
    
}