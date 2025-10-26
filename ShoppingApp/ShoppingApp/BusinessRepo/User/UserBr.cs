using System;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Models.Entity;
using ShoppingApp.Models.Request;

namespace ShoppingApp.BusinessRepo.User
{
	public class UserBr: IUserBr
	{
        private readonly AppDbContext mContext;

        public UserBr(AppDbContext context)
		{
            mContext = context;
        }

        public async Task<long> PostUser(AddUserRequest request)
        {
            Users users;

            if (request.UserId > 0)
            {
                users = await mContext.Users
                    .FirstOrDefaultAsync(user => user.Id == request.UserId);

                if (users == null)
                {
                    throw new Exception("User not found");
                }

                users.Name = request.UserName;
                users.Email = request.Email;
                users.PhoneNumber = request.MobileNumber;
                users.Address = request.Address;
                users.CityId = request.CityId;
                users.ModifiedDateTime = DateTime.UtcNow;
                users.ModifiedBy = request.ModifiedBy;

                mContext.Users.Update(users);
            }
            else
            {
                users = new Users
                {
                    Name = request.UserName,
                    Email = request.Email,
                    PhoneNumber = request.MobileNumber,
                    Address = request.Address,
                    CityId = request.CityId,
                    CreatedBy = request.CreatedBy,
                    CreatedDateTime = DateTime.UtcNow
                };

                await mContext.Users.AddAsync(users);
            }

            await mContext.SaveChangesAsync();  

            return users.Id; 
        }

    }
}

