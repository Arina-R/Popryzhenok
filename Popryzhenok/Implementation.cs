//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Popryzhenok
{
    using System;
    using System.Collections.Generic;
    
    public partial class Implementation
    {
        public int ID_implementation { get; set; }
        public int ID_product { get; set; }
        public int ID_agent { get; set; }
        public System.DateTime Date { get; set; }
        public int Quantity { get; set; }
    
        public virtual AgentCompany AgentCompany { get; set; }
        public virtual Product Product { get; set; }
    }
}