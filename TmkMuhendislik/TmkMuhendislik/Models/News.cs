//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TmkMuhendislik.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int N_Id { get; set; }
        public string N_Head { get; set; }
        public string N_Photo { get; set; }
        public string N_Description { get; set; }
        public string N_CreateDate { get; set; }
        public string N_UpdateDate { get; set; }
        public string N_DeleteDate { get; set; }
        public Nullable<bool> N_Check { get; set; }
        public Nullable<int> A_Id { get; set; }
    
        public virtual AdminInfo AdminInfo { get; set; }
    }
}