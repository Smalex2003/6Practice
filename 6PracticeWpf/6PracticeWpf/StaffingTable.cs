//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _6PracticeWpf
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffingTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffingTable()
        {
            this.PosistionList = new HashSet<PosistionList>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual Division Division { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosistionList> PosistionList { get; set; }
    }
}
