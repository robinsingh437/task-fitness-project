//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FittyProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sportswear
    {
        public int itemId { get; set; }
        public string gender { get; set; }
        public string type { get; set; }
        public string size { get; set; }
        public string itemDescription { get; set; }
        public Nullable<decimal> price { get; set; }
        public string imageUrl { get; set; }
        public Nullable<int> quantity { get; set; }
    }
}
