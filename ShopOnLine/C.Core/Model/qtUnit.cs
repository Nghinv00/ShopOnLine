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
    
    public partial class qtUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public qtUnit()
        {
            this.qtUserRoles = new HashSet<qtUserRole>();
            this.qtUsers = new HashSet<qtUser>();
        }
    
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public string UnitCode { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string LevelCode { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<qtUserRole> qtUserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<qtUser> qtUsers { get; set; }
    }
}
