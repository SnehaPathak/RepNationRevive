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
    
    public partial class CampaignRep
    {
        public System.Guid CampaignRepId { get; set; }
        public System.Guid CampaignId { get; set; }
        public System.Guid RepId { get; set; }
        public CampaignRepStatus Status { get; set; }
        public string DateLastContacted { get; set; }
        public OfferLetterStatus OfferLetterStatus { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Rep Rep { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}
