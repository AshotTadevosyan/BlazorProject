using System;
using example.models;
namespace example.services
{
	public class userService : IUserService
	{
		public List<userModel> GetAll()
		{
			// call to API retrieve data drom DB
			return new List<userModel>()
			{
				new userModel()
				{ ID = 1,
					FirstName = "Ashot",
					LastName = "Tadevosyan",
					Address = "Noratus",
					DoB = DateTime.Now
				},
			    new userModel()
				{
					ID = 2,
					FirstName = "Tigran",
					LastName = "Ginosyan",
					Address = "Ashtarak",
					DoB = DateTime.Now
				}
			};

		}
	}
}

