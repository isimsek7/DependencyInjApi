using System;
using DependencyInjApi.Interfaces;
namespace DependencyInjApi.Entitites
{
	public class Teacher:ITeacher
	{
		public Teacher()
		{
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string GetInfo()
		{

			return ($"Name of the teacher is'{FirstName} {LastName}");
		}
		
	}
}

