//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace transport_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class package_route
    {
        public int id { get; set; }
        public Nullable<int> next_position { get; set; }
        public Nullable<int> transaction { get; set; }
    
        public virtual address address { get; set; }
        public virtual package_transaction package_transaction { get; set; }
    }
}
