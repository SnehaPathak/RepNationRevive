//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepNationRevive.DBDesign
{
    using System;
    using System.Collections.Generic;
    
    public partial class HighSchool
    {
        public System.Guid HighSchoolId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public System.Guid StateId { get; set; }
        public System.Guid CountryId { get; set; }
        public string Zip { get; set; }
        public string Website { get; set; }
        public Status Status { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
