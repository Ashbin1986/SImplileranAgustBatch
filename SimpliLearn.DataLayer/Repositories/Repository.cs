using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.DataLayer.Repositories
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
                return dbContext.Students.ToList();
            }
        }
    }
}
