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
    
    public partial class Sale
    {
        public int ID_sale { get; set; }
        public int ID_agent { get; set; }
        public int Sale1 { get; set; }
    
        public virtual AgentCompany AgentCompany { get; set; }
    }
}
