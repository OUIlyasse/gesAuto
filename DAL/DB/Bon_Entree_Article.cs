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
    
    public partial class Bon_Entree_Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Entree_Article()
        {
            this.Bon_reference = new HashSet<Bon_reference>();
            this.Mouvements = new HashSet<Mouvement>();
        }
    
        public int be_A_ID { get; set; }
        public Nullable<System.DateTime> be_A_Date { get; set; }
        public Nullable<decimal> be_Qte_Livree { get; set; }
        public Nullable<int> be_ID { get; set; }
        public Nullable<int> art_ID { get; set; }
        public Nullable<int> vl_ID { get; set; }
        public Nullable<int> unit_M_ID { get; set; }
        public string be_A_Description { get; set; }
        public Nullable<bool> be_A_Etat { get; set; }
    
        public virtual Article_Info Article_Info { get; set; }
        public virtual Bon_Entree Bon_Entree { get; set; }
        public virtual Unite_Mesure Unite_Mesure { get; set; }
        public virtual Vehicule Vehicule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_reference> Bon_reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mouvement> Mouvements { get; set; }
    }
}
