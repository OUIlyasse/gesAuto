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
    
    public partial class vwBon_Entree_Article
    {
        public int be_A_ID { get; set; }
        public Nullable<System.DateTime> be_A_Date { get; set; }
        public string vl_Marque { get; set; }
        public string art_Designation { get; set; }
        public Nullable<bool> be_A_Etat { get; set; }
        public Nullable<decimal> be_Qte_Livree { get; set; }
        public Nullable<int> be_ID { get; set; }
        public string be_A_Description { get; set; }
        public Nullable<int> unit_M_ID { get; set; }
        public string unit_M_Nom { get; set; }
        public string unit_M_Abreviation { get; set; }
    }
}
