using DependencyInjApi.Interfaces;

namespace DependencyInjApi.Entitites
{
    public class Classroom
    {
        private readonly ITeacher _teacher;

        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
