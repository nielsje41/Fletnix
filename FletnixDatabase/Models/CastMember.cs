//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FletnixDatabase.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CastMember
    {
        public CastMember()
        {
            this.Cast = new HashSet<Cast>();
        }
    
        public int CastMemberID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
    
        public virtual ICollection<Cast> Cast { get; set; }
    }
}