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
    
    public partial class RepScreeningScoreCalculated
    {
        public System.Guid RepScreeningScoreCalculatedId { get; set; }
        public System.Guid CampaignId { get; set; }
        public System.Guid RepId { get; set; }
        public int Score { get; set; }
    }
}
