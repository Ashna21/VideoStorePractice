//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCart
    {
        public int ShoppingCartID { get; set; }
        public int UserID { get; set; }
        public int VideoID { get; set; }
        public int Quantity { get; set; }
    
        public virtual User User { get; set; }
        public virtual Video Video { get; set; }
    }
}
