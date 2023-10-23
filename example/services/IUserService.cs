using System;
using example.models;
namespace example.services
{
	public interface IUserService
	{
		List<userModel> GetAll();
	}
}

