//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Event_StudentMapping
    {
        public int Event_StudentId { get; set; }
        public Nullable<int> EventId { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Student Student { get; set; }
    }
}