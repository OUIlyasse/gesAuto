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
    
    public partial class Select_v_Bon_Reference_Retour_Result
    {
        public int br_ID { get; set; }
        public string br_Type { get; set; }
        public Nullable<int> art_ID { get; set; }
        public string ref_reference { get; set; }
        public Nullable<int> bon_ID { get; set; }
        public Nullable<decimal> br_Qte { get; set; }
        public Nullable<int> bt_A_ID { get; set; }
        public Nullable<bool> br_Status_Gravage { get; set; }
    }
}
