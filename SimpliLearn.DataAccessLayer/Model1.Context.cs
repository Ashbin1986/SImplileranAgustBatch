﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpliLearn.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class SchoolManagementEntities : DbContext
    {
        public SchoolManagementEntities()
            : base("name=SchoolManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Event_StudentMapping> Event_StudentMapping { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserCredentail> UserCredentails { get; set; }
        public DbSet<StudentData> StudentDatas { get; set; }
    
        public virtual int AddStudent(string studentName, string gender, string email, Nullable<bool> isActive, Nullable<int> eventId)
        {
            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("EventId", eventId) :
                new ObjectParameter("EventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStudent", studentNameParameter, genderParameter, emailParameter, isActiveParameter, eventIdParameter);
        }
    
        public virtual int DeleteStudent(Nullable<int> studentid)
        {
            var studentidParameter = studentid.HasValue ?
                new ObjectParameter("Studentid", studentid) :
                new ObjectParameter("Studentid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStudent", studentidParameter);
        }
    
        public virtual ObjectResult<FetchStudentRecords_Result> FetchStudentRecords()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FetchStudentRecords_Result>("FetchStudentRecords");
        }
    
        public virtual ObjectResult<FetchUserInformation_Result> FetchUserInformation(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FetchUserInformation_Result>("FetchUserInformation", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<GetEventParticipants_Result> GetEventParticipants()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEventParticipants_Result>("GetEventParticipants");
        }
    
        public virtual ObjectResult<GetEvents_Result> GetEvents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEvents_Result>("GetEvents");
        }
    }
}