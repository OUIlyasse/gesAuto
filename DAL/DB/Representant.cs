//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Representant
    {
        public int rep_ID { get; set; }
        public Nullable<int> frns_ID { get; set; }
        public string rep_Nom { get; set; }
        public string rep_Prenom { get; set; }
        public string rep_Cin { get; set; }
        public string rep_Tele { get; set; }
        public string rep_Observation { get; set; }
        public Nullable<bool> rep_Status { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
    }
}
