using SimpliLearn.BusinessLayer.Models;
using SimpliLearn.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.BusinessLayer
{
    public class Service : IService
    {
        /// <summary>
        /// Get Events for a Year
        /// </summary>
        /// <returns></returns>
        public List<EventEntity> GetEvents()
        {
            List<EventEntity> eventEntities = new List<EventEntity>();

            IRepository _repository = new Repository();

            var events = _repository.GetEvents();

            if (events != null)
            {
                foreach (var e in events)
                {
                    eventEntities.Add(new EventEntity { EventId = e.EventId, EventDate = e.EventDate, EventName = e.EventName });
                }
            }

            return eventEntities;
        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns></returns>
        public List<StudentEntity> GetStudentEntities()
        {
            List<StudentEntity> studentEntities = new List<StudentEntity>();

            IRepository _repository = new Repository();

            var students = _repository.GetStudents();

            if (students != null)
            {
                foreach (var e in students)
                {
                    studentEntities.Add(new StudentEntity { StudentId = e.StudentId , StudentName = e.StudentName , Email = e.Email });
                }
            }

            return studentEntities;
        }
    }
}
