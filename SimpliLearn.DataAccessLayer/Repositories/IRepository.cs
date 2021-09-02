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

        List<Student> GetStudents(int Srudentid);

       
    }

    public interface IDel
    {
        void del();

    }

    public class Child : IRepository,IDel
    {
        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void del()
        {
            throw new NotImplementedException();
        }

        public string GetEventNameByStudentId(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetEvents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int StudentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents(int Srudentid)
        {
            throw new NotImplementedException();
        }
    }
}
