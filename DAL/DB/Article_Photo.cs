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
    
    public partial class Article_Photo
    {
        public int pho_ID { get; set; }
        public string pho_Path { get; set; }
        public byte[] pho_Image { get; set; }
        public string pho_Nom { get; set; }
        public string pho_Extension { get; set; }
        public Nullable<int> art_ID { get; set; }
        public string pho_Description { get; set; }
        public Nullable<bool> pho_Status { get; set; }
    
        public virtual Article_Info Article_Info { get; set; }
    }
}
