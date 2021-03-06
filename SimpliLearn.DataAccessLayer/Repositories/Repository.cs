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
                //var records = from m in dbContext.Students select m;

                dbContext.Database.SqlQuery<Student>("Select * from Student");


                return dbContext.Students.ToList().Where(c => c.IsActive == true).ToList().OrderByDescending(c => c.CreatedDate).ToList();
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

        public string GetEventNameByStudentId(int studentId)
        {
            string eventName = "N/A";

            using (SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                var eventMapping = dbContext.Event_StudentMapping.Where(c => c.StudentId == studentId).FirstOrDefault();

                if(eventMapping !=null)
                {
                    eventName = dbContext.Events.Where(c => c.EventId == eventMapping.EventId).FirstOrDefault().EventName;
                }
            }

            return eventName;
        }

        public List<Student> GetStudents(int Srudentid)
        {
            throw new NotImplementedException();
        }
    }
}
