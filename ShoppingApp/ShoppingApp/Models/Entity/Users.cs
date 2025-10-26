using System;
namespace ShoppingApp.Models.Entity
{
	public class Users
	{
		public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public long ModifiedBy { get; set; }
        public virtual City CityNavigation { get; set; }
    }
}

