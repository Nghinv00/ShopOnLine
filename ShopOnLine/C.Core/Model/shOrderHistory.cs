//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C.Core.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class shOrderHistory
    {
        public int Id { get; set; }
        public string OrderGuid { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public string Description { get; set; }
        public string MemberGuid { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}