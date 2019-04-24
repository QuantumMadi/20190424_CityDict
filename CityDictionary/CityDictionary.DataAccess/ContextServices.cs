using CityDictionary.Models;
using System.Collections.Generic;
using System.Linq;

namespace CityDictionary.DataAccess
{
    public class ContextServices
    {
        public void AddNewNumber(City city, string number)
        {
            using (var context = new DataContext())
            {
                context.PhoneNumbers.Add(new PhoneNumber
                {
                    CityId = city.Id,
                    Number = number,                  
                });
                context.SaveChanges();
            }
        }
        public List<City> GetCities()
        {
            using (var context = new DataContext())
            {
                return context.Cities.ToList();
            }
        }
    }
}
