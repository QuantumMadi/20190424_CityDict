namespace CityDictionary.DataAccess
{
    using CityDictionary.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=Model1")
        {
            Database.SetInitializer(new DataInitializer());
        }
            
        public DbSet<City> Cities { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}