namespace SampleService.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Animals : DbContext
    {
        public Animals()
            : base("name=Animals")
        {
        }

         public virtual DbSet<Animal> AllAnimals { get; set; }
    }
    
}