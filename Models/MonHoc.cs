//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TracNghiem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            this.CauHois = new HashSet<CauHois>();
        }
    
        public int id { get; set; }
        public string TenMonHocs { get; set; }
        public string Meta { get; set; }
        public Nullable<int> MaKhoi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauHois> CauHois { get; set; }
        public virtual Khois Khois { get; set; }
    }
}