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
    
    public partial class Order
    {
        public int Order_number { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string The_stage_of_execution { get; set; }
        public string Customer { get; set; }
        public string Manager { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Ordered_products Ordered_products { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
