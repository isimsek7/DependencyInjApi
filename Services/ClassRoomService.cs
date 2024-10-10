
using DependencyInjApi.Entitites;
using DependencyInjApi.Interfaces;

namespace DependencyInjApi.Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly Classroom _classroom;
        public ClassroomService(ITeacher teacher)
        {

            teacher.FirstName = "John";
            teacher.LastName = "Doe";

            _classroom = new Classroom(teacher);
        }

        public string DisplayTeacherInfo()
        {
            return _classroom.GetTeacherInfo();
        }
    }
}
