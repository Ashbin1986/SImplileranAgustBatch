using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.DataLayer.Repositories
{
    public interface IRepository
    {
        List<Student> GetStudents();

        List<Event> GetEvents();
    }
}
