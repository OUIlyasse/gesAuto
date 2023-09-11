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
    
    public partial class Vehicule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicule()
        {
            this.Bon_CodeBarre = new HashSet<Bon_CodeBarre>();
            this.Bon_Entree_Article = new HashSet<Bon_Entree_Article>();
            this.Bon_Retour_Article = new HashSet<Bon_Retour_Article>();
            this.Bon_Sortie_Article = new HashSet<Bon_Sortie_Article>();
            this.Mouvements = new HashSet<Mouvement>();
            this.Vehicule_Article = new HashSet<Vehicule_Article>();
        }
    
        public int vl_ID { get; set; }
        public string vl_Immatriculation { get; set; }
        public string vl_Modele { get; set; }
        public string vl_Marque { get; set; }
        public Nullable<System.DateTime> vl_Annee_Fabrication { get; set; }
        public string vl_Description { get; set; }
        public Nullable<bool> vl_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_CodeBarre> Bon_CodeBarre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Entree_Article> Bon_Entree_Article { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Retour_Article> Bon_Retour_Article { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Sortie_Article> Bon_Sortie_Article { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mouvement> Mouvements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicule_Article> Vehicule_Article { get; set; }
    }
}
