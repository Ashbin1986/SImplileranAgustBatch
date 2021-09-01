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
                var st =  dbContext.Students.ToList();
                return st;
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
    }
}
