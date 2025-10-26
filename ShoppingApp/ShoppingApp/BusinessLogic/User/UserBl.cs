using System;
using ShoppingApp.BusinessRepo.User;
using ShoppingApp.Models.Request;

namespace ShoppingApp.BusinessLogic.User
{
	public class UserBl: IUserBl
	{
        private readonly IUserBr mUserBr;

        public UserBl(IUserBr userBr)
		{
            mUserBr = userBr;
        }
		public Task<long> PostUser(AddUserRequest request)
		{
			return mUserBr.PostUser(request);
		}

    }
}

