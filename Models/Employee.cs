//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int employeeID { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public System.DateTime joinedDate { get; set; }
        public int positionID { get; set; }
        public int teamID { get; set; }
    
        public virtual Position Position { get; set; }
        public virtual Team Team { get; set; }
    }
}
