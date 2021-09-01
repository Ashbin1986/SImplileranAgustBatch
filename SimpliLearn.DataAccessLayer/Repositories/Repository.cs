using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.DataAccessLayer.Repositories
{
    public class Repository : IRepository
    {
        public List<Event> GetEvents()
        {
            using(SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                return dbContext.Events.ToList();
            }
        }

        public List<Student> GetStudents()
        {
            using (SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                return dbContext.Students.ToList().Where(c=>c.IsActive == true).ToList();
            }
        }

        public void UpdateStudent(Student studentEntity)
        {
            using (SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                var student = dbContext.Students.Where(c => c.StudentId == studentEntity.StudentId).FirstOrDefault();

                if(student != null)
                {
                    student.Gender = studentEntity.Gender;
                }
                dbContext.SaveChanges();

            }
        }
        public void AddStudent(Student student)
        {
            using (SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                dbContext.Students.Add(student);
                dbContext.SaveChanges();

            }
        }

        public Student GetStudentById(int StudentId)
        {
            using (SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                return dbContext.Students.Where(c => c.IsActive == true && c.StudentId == StudentId).FirstOrDefault();
            }
        }
    }
}
