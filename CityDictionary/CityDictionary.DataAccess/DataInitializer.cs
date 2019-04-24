using System.Collections.Generic;
using System.Data.Entity;
using CityDictionary.Models;

namespace CityDictionary.DataAccess
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        private List<City> cities;
        public DataInitializer()
        {
            cities = new List<City>
            {
                new City
                {
                    Name = "Astana",
                    CityCode = "+77172"
                },
                new City
                {
                    Name = "Almaty",
                    CityCode = "+77272"
                },
                new City
                {
                    Name = "Taraz",
                    CityCode = "+77262"
                },
                new City
                {
                    Name = "Uralsk",
                    CityCode = "+77112"
                },
                new City
                {
                    Name = "Talgykorgan",
                    CityCode = "+77282"
                },
            };
        }
        protected override void Seed(DataContext context)
        {
            context.Cities.AddRange(cities);
            base.Seed(context);
        }
    }
}
