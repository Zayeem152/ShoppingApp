using System;
namespace ShoppingApp.Models.Entity
{
	public class City
	{
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long StateId { get; set; }
        public virtual State StateNavigation { get; set; }
        public ICollection<Users> UserNavigation { get; set; }
    }
}

