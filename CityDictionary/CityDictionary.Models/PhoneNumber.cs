using System;

namespace CityDictionary.Models
{
    public class PhoneNumber : Entity
    {
        public string Number { get; set; }
        public virtual City City { get; set; }
        public virtual Guid CityId { get; set; }
    }
}
