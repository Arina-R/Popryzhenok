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
    
    public partial class Priority
    {
        public int ID_priority { get; set; }
        public int ID_agent { get; set; }
        public int Priority1 { get; set; }
    
        public virtual AgentCompany AgentCompany { get; set; }
    }
}
