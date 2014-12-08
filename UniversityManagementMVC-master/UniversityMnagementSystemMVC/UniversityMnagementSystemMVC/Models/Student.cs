//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityMnagementSystemMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.EnrollInACourses = new HashSet<EnrollInACourse>();
            this.Results = new HashSet<Result>();
        }
    
        public int StudentId { get; set; }
        public int RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public System.DateTime Date { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<EnrollInACourse> EnrollInACourses { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}