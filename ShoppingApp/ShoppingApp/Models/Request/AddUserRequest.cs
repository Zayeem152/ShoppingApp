using System;
namespace ShoppingApp.Models.Request
{
	public class AddUserRequest: EntityRequest
    {
		public long UserId { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
    }
}

