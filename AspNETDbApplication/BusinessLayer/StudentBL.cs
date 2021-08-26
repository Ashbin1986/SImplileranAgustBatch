using DataLayer;
using DataTransferModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBL
    {
        DBHelper dbHelper;
        public StudentBL()
        {
            dbHelper = new DBHelper();
        }

        public List<Student> GetStudents()
        {
            return dbHelper.GetStudentList();
        }

        public bool AddStudent(Student student)
        {
            ValidateModel(student);

            return dbHelper.AddStudent(student);
        }

        public object UpdateStudent(Student student)
        {
            return dbHelper.UpdateStudent(student);
        }

        public bool DeleteStudent(int studentId)
        {
            return dbHelper.DeleteStudent(studentId);
        }

        private void ValidateModel(Student student)
        {
            if(student == null)
            {
               // throw Exception;
            }

        }
    }
}
