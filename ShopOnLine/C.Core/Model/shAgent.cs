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
    
    public partial class shAgent
    {
        public string AgentGuid { get; set; }
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Url { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}