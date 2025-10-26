using System;
namespace ShoppingApp.Models.Request
{
	public class EntityRequest
	{
		public DateTime CreatedDateTime { get; set; }

        public long CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public long ModifiedBy { get; set; }

    }
}

