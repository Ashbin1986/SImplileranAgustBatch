using SimpliLearn.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.BusinessLayer
{
    public interface IService
    {
        List<EventEntity> GetEvents();

        List<StudentEntity> GetStudentEntities();

    }
}
