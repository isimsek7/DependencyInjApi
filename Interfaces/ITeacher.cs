using System;
namespace DependencyInjApi.Interfaces
{
	public interface ITeacher
	{
        string FirstName { get; set; }
        string LastName { get; set; }

        string GetInfo();
	}
}

