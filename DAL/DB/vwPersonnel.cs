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
    
    public partial class vwPersonnel
    {
        public int pers_ID { get; set; }
        public string pers_Prenom { get; set; }
        public string pers_Prenom_Ar { get; set; }
        public string pers_Nom { get; set; }
        public string pers_Nom_Ar { get; set; }
        public string pers_Mle_FA { get; set; }
        public string grd_Grade { get; set; }
        public string unt_Unite { get; set; }
        public Nullable<System.DateTime> pers_Date_Naissance { get; set; }
        public string pers_Lieu_Naissance { get; set; }
        public string pers_Lieu_Naissance_Ar { get; set; }
        public Nullable<System.DateTime> pers_Date_Engagement { get; set; }
        public Nullable<System.DateTime> pers_Date_Nomination { get; set; }
        public string pers_Reff_Nomination { get; set; }
        public string pers_Origine { get; set; }
        public string pers_Origine_Ar { get; set; }
        public string pers_CIN { get; set; }
        public string pers_Sexe { get; set; }
        public string pers_Adresse_Personnelle { get; set; }
        public string pers_Adresse_Personnelle_Ar { get; set; }
        public string pers_Carte_FA { get; set; }
        public string pers_Specialite { get; set; }
        public string pers_Fonction { get; set; }
        public string pers_Fonction_Ar { get; set; }
        public Nullable<decimal> pers_Taille { get; set; }
        public string pers_Sit_Fam { get; set; }
        public string pers_Sit_Fam_Ar { get; set; }
        public string pers_E_Prenom { get; set; }
        public string pers_E_Nom { get; set; }
        public string pers_E_CIN { get; set; }
        public Nullable<System.DateTime> pers_E_Date_Naissance { get; set; }
        public string pers_E_Lieu_Naissance { get; set; }
        public string pers_Nbr_Enf { get; set; }
        public string pers_PPR { get; set; }
        public string gs_Nom { get; set; }
        public string pers_Mutuel { get; set; }
        public string pers_Immatriculation { get; set; }
        public string pers_Affiliation { get; set; }
        public Nullable<System.DateTime> pers_Date_Affiliation { get; set; }
        public string pers_Pere_Prenom { get; set; }
        public string pers_Pere_Nom { get; set; }
        public string pers_Pere_CIN { get; set; }
        public Nullable<System.DateTime> pers_Pere_Date_Naissance { get; set; }
        public string pers_Pere_Lieu_Naissance { get; set; }
        public string pers_Mere_Prenom { get; set; }
        public string pers_Mere_Nom { get; set; }
        public string pers_Mere_CIN { get; set; }
        public Nullable<System.DateTime> pers_Mere_Date_Naissance { get; set; }
        public string pers_Mere_Lieu_Naissance { get; set; }
        public string pers_Niv_Instrution { get; set; }
        public string pers_Diplome_Universitaire { get; set; }
        public string pers_Num_Passeport { get; set; }
        public string pers_Num_Arm_Chasse { get; set; }
        public Nullable<bool> pers_Status { get; set; }
    }
}
