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
    
    public partial class Genre
    {
        public Genre()
        {
            this.Movie = new HashSet<Movie>();
            this.Series = new HashSet<Series>();
        }
    
        public string Genre1 { get; set; }
    
        public virtual ICollection<Movie> Movie { get; set; }
        public virtual ICollection<Series> Series { get; set; }
    }
}
