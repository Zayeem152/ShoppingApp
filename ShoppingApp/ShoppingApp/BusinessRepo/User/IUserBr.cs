using System;
using ShoppingApp.Models.Request;

namespace ShoppingApp.BusinessRepo.User
{
	public interface IUserBr
	{
        Task<long> PostUser(AddUserRequest request);

    }
}

