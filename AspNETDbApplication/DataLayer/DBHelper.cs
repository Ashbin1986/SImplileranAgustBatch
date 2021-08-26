using DataTransferModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    
    public class DBHelper
    {
        #region Declaring sql objects
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        string sqlConnectionString = "Data Source=.;Initial catalog=SchoolManagement;Integrated Security=true;";
        #endregion

        public DBHelper()
        {
            sqlConnection = new SqlConnection(sqlConnectionString);
        }

        public DataSet GetStudents()
        {
            dataAdapter = new SqlDataAdapter(DBConstants.FetchStudentRecords, sqlConnection); // Specify query/Proc
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure; // mention Proc Type
            dataSet = new DataSet();//Create Temp location
            dataAdapter.Fill(dataSet, "Students"); // fill temp location
            return dataSet;
        }

        public object UpdateStudent(Student student)
        {
            bool isSuccess = false;
            try
            {
                sqlCommand = new SqlCommand(DBConstants.UpdateStudent, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StudentName", student.StudentName);
                sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                sqlCommand.Parameters.AddWithValue("@Email", student.Email);
                sqlCommand.Parameters.AddWithValue("@IsActive", student.IsActive);
                sqlCommand.Parameters.AddWithValue("@EventId", student.EventId);
                sqlConnection.Open();

                int isAdded = sqlCommand.ExecuteNonQuery();

                if (isAdded >= 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
                sqlCommand.Dispose();
            }

            return isSuccess;
        }

        public bool AddStudent(Student student)
        {
            bool isSuccess = false;
            try
            {
                sqlCommand = new SqlCommand(DBConstants.AddStudent, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StudentName", student.StudentName);
                sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                sqlCommand.Parameters.AddWithValue("@Email", student.Email);
                sqlCommand.Parameters.AddWithValue("@IsActive", student.IsActive);
                sqlCommand.Parameters.AddWithValue("@EventId", student.EventId);
                sqlConnection.Open();

                int isAdded = sqlCommand.ExecuteNonQuery();

                if (isAdded >= 0)
                {
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
                sqlCommand.Dispose();
            }

            return isSuccess;
        }

        public bool DeleteStudent(int Studentid)
        {
            bool isSuccess = false;
            try
            {
                sqlCommand = new SqlCommand(DBConstants.DeleteStudent, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Studentid", Studentid);
                sqlConnection.Open();

                int isAdded = sqlCommand.ExecuteNonQuery();

                if (isAdded >= 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
                sqlCommand.Dispose();
            }

            return isSuccess;
        }

        public List<Student> GetStudentList()
        {
            List<Student> lstStudent = new List<Student>();

            try
            {
                sqlCommand = new SqlCommand(DBConstants.FetchStudentRecords, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();

                SqlDataReader dr= sqlCommand.ExecuteReader();
                while(dr.Read())
                {
                    lstStudent.Add(new Student { StudentName = dr["StudentName"].ToString(), Email = dr["Email"].ToString(), StudentId = Convert.ToInt32(dr["StudentId"]) });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
                sqlCommand.Dispose();
            }
            return lstStudent;

        }


        public DataSet GetUserInformation(UserCredentails userCredentails)
        {
            dataAdapter = new SqlDataAdapter(DBConstants.FetchUserInformation, sqlConnection); // Specify query/Proc
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure; // mention Proc Type
            dataAdapter.SelectCommand.Parameters.AddWithValue("@UserName", userCredentails.UserName);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Password", userCredentails.Password);
            dataSet = new DataSet();//Create Temp location
            dataAdapter.Fill(dataSet, "User"); // fill temp location
            return dataSet;
        }

    }
}
