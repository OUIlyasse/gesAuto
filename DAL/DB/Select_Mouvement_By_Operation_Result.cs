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
    
    public partial class Select_Mouvement_By_Operation_Result
    {
        public int mvt_ID { get; set; }
        public Nullable<int> bon_ID { get; set; }
        public Nullable<System.DateTime> mvt_Date { get; set; }
        public Nullable<int> vl_ID { get; set; }
        public Nullable<int> art_ID { get; set; }
        public Nullable<decimal> mvt_Qte { get; set; }
        public string be_Designation { get; set; }
        public string be_Reference { get; set; }
        public string unit_M_Nom { get; set; }
    }
}
