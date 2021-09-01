using SimpliLearn.BusinessLayer.Models;
using SimpliLearn.DataAccessLayer;
using SimpliLearn.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.BusinessLayer
{
    public class Service : IService
    {
        public void AddStudent(StudentEntity studentEntity)
        {
            IRepository _repository = new Repository();

            //Student student = new Student()
            //{
            //    Email = studentEntity.Email,
            //    Gender = studentEntity.Gender,
            //    CreatedDate = DateTime.UtcNow,
            //    IsActive = true,
            //    StudentName = studentEntity.StudentName
            //};

            //_repository.AddStudent(student);

            _repository.AddStudent(new Student()
            {
                Email = studentEntity.Email,
                Gender = studentEntity.Gender,
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                StudentName = studentEntity.StudentName
            });
        }

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

        public StudentEntity GetStudentById(int StudentId)
        {
            IRepository _repository = new Repository();

            var student = _repository.GetStudentById(StudentId);

            return new StudentEntity()
            {
                Email = student.Email,
                Gender = student.Gender,
                StudentId = student.StudentId,
                IsActive = student.IsActive,
                StudentName = student.StudentName
            };

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
                    studentEntities.Add(new StudentEntity { StudentId = e.StudentId, StudentName = e.StudentName, Email = e.Email, Gender = e.Gender });
                }
            }

            return studentEntities;
        }

    }
}
