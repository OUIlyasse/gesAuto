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
    
    public partial class Utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilisateur()
        {
            this.Enregistrements = new HashSet<Enregistrement>();
        }
    
        public int util_ID { get; set; }
        public Nullable<int> pers_ID { get; set; }
        public Nullable<System.DateTime> util_Date { get; set; }
        public string util_Identifiant { get; set; }
        public string util_MotPasse { get; set; }
        public Nullable<int> svc_ID { get; set; }
        public Nullable<int> prof_ID { get; set; }
    
        public virtual pers_Affecte pers_Affecte { get; set; }
        public virtual Profil Profil { get; set; }
        public virtual Service Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enregistrement> Enregistrements { get; set; }
    }
}
