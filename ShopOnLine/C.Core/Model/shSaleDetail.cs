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
    
    public partial class shSaleDetail
    {
        public string SaleDetailGuid { get; set; }
        public int SaleDetailId { get; set; }
        public string SaleGuid { get; set; }
        public Nullable<int> CachTinhGiaTriKhuyenMai { get; set; }
        public string GiaTri { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> DieuKienApDung { get; set; }
        public string MaCauHinh { get; set; }
        public string CategoryGuidProductGuid { get; set; }
        public string CategoryGuid { get; set; }
        public string ProductGuid { get; set; }
        public Nullable<int> Percents { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Nullable<decimal> PriceAfterPercents { get; set; }
        public string SaleAttach { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual shProduct shProduct { get; set; }
        public virtual shSale shSale { get; set; }
    }
}