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
    
    public partial class RecruitmentAgeGroupPreference
    {
        public int RecruitmentAgeGroupPreferenceId { get; set; }
        public System.Guid RecruitmentId { get; set; }
        public AgeGroupType AgeGroupType { get; set; }
        public bool Enabled { get; set; }
    }
}
