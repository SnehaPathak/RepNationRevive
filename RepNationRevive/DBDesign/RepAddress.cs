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
    
    public partial class RepAddress
    {
        public System.Guid RepAddressId { get; set; }
        public System.Guid RepId { get; set; }
        public string AddressId { get; set; }
        public AddressType AddressType { get; set; }
        public bool IsPrimary { get; set; }
        public Status Status { get; set; }
    
        public virtual Address Address { get; set; }
    }
}
