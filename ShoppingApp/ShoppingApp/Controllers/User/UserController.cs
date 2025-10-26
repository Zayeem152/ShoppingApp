using System;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.BusinessLogic.User;
using ShoppingApp.Models.Request;

namespace ShoppingApp.Controllers.User
{
	[ApiController]
	[Route("[controller]")]
	public class UserController: ControllerBase
	{
        private readonly IUserBl mUserBl;

        public UserController(IUserBl userBl)
		{
            mUserBl = userBl;
        }

		[HttpGet("getUserById/{userId}")]
		public IActionResult GetUserById(long userId)
		{
			return Ok();
		}

        [HttpPost("postUser")]
        public IActionResult PostUser(AddUserRequest request)
        {
			var result = mUserBl.PostUser(request);
            return Ok(result);
        }
    }
}

