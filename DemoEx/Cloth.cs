//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoEx
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cloth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cloth()
        {
            this.Cloth_of_products = new HashSet<Cloth_of_products>();
            this.Fabric_warehouse = new HashSet<Fabric_warehouse>();
        }
    
        public int Article_of_cloth { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Picture { get; set; }
        public string Image { get; set; }
        public string Composition { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cloth_of_products> Cloth_of_products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fabric_warehouse> Fabric_warehouse { get; set; }
    }
}