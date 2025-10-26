using System;
namespace ShoppingApp.Models.Entity
{
	public class State
	{
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CountryId { get; set; }
        public virtual Country CountryNavigation { get; set; }
        public ICollection<City> CityNavigation { get; set; }
    }
}

