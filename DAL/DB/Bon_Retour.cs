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
    
    public partial class Bon_Retour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Retour()
        {
            this.Bon_Retour_Article = new HashSet<Bon_Retour_Article>();
        }
    
        public int bt_ID { get; set; }
        public string bt_Designation { get; set; }
        public Nullable<System.DateTime> bt_Date { get; set; }
        public string bt_Reference { get; set; }
        public Nullable<int> unt_ID { get; set; }
        public string bt_Description { get; set; }
        public Nullable<bool> bt_Status { get; set; }
        public Nullable<bool> bt_Suppression { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Retour_Article> Bon_Retour_Article { get; set; }
        public virtual Unite_Soutien Unite_Soutien { get; set; }
    }
}