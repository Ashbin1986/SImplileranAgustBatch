using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.DataAccessLayer.Repositories
{
    public interface IRepository
    {
        List<Student> GetStudents();

        List<Event> GetEvents();

        void AddStudent(Student student);

        Student GetStudentById(int StudentId);
        string GetEventNameByStudentId(int studentId);
    }
}
