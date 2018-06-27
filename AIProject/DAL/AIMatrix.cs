//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIProject.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AIMatrix
    {
        public int AIMatrixElementID { get; set; }
        public string Insurer { get; set; }
        public string PolicyType { get; set; }
        public string FormNumber { get; set; }
        public string FormEditionDate { get; set; }
        public Nullable<bool> FormIsUnacceptable { get; set; }
        public string WhoIsFormDesignedFor { get; set; }
        public string FormTitle { get; set; }
        public Nullable<bool> BIandPD { get; set; }
        public Nullable<bool> PIandAI { get; set; }
        public Nullable<bool> PrivityOfContractReqd { get; set; }
        public Nullable<bool> LimitsLessLang { get; set; }
        public Nullable<bool> FormHasSchedule { get; set; }
        public Nullable<bool> PremAndOps { get; set; }
        public Nullable<bool> ProdCompOps { get; set; }
        public string UnacceptableStdLang { get; set; }
        public string CommentsStdLang { get; set; }
        public Nullable<bool> SpfcActsOrOmissionsLang { get; set; }
        public Nullable<bool> SpfcThoseActingBehalfLang { get; set; }
        public Nullable<bool> RequiresContractExec { get; set; }
        public Nullable<bool> SpfcOnlyCoversWorkSubjContractLang { get; set; }
        public Nullable<bool> SpfcAIRequiredLang { get; set; }
        public Nullable<bool> SpfcNoDutyToDefendLang { get; set; }
        public string UnacceptableAdvLang { get; set; }
        public string CommentsAdvLang { get; set; }
        public Nullable<bool> PrimaryLang { get; set; }
        public Nullable<bool> NonContributoryLang { get; set; }
        public Nullable<bool> WaiverOfSubroLang { get; set; }
        public string AgentUnacceptableLang { get; set; }
    }
}
