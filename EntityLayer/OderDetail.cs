//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class OderDetail
    {
        public int OderDetailsID { get; set; }
        public int OderID { get; set; }
        public int ProductID { get; set; }
        public int Size { get; set; }
        public int NumOfItems { get; set; }
    
        public virtual Oder Oder { get; set; }
        public virtual Product Product { get; set; }
    }
}