using System;
using ShoppingApp.Models.Request;

namespace ShoppingApp.BusinessLogic.User
{
	public interface IUserBl
	{
        Task<long> PostUser(AddUserRequest request);

    }
}

