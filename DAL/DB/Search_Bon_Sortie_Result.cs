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
    
    public partial class Search_Bon_Sortie_Result
    {
        public int bs_ID { get; set; }
        public string bs_Designation { get; set; }
        public Nullable<System.DateTime> bs_Date { get; set; }
        public string bs_Reference { get; set; }
        public Nullable<int> unt_ID { get; set; }
        public string bs_Description { get; set; }
        public Nullable<bool> bs_Status { get; set; }
        public Nullable<bool> bs_Suppression { get; set; }
    }
}
