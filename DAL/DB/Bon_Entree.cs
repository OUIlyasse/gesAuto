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
    
    public partial class Bon_Entree
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Entree()
        {
            this.Bon_Entree_Article = new HashSet<Bon_Entree_Article>();
        }
    
        public int be_ID { get; set; }
        public Nullable<System.DateTime> be_Date { get; set; }
        public string be_Designation { get; set; }
        public string be_Reference { get; set; }
        public string be_PV { get; set; }
        public Nullable<int> frns_ID { get; set; }
        public Nullable<int> rep_ID { get; set; }
        public string be_Description { get; set; }
        public Nullable<bool> be_Status { get; set; }
        public Nullable<bool> be_Suppression { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Entree_Article> Bon_Entree_Article { get; set; }
    }
}
