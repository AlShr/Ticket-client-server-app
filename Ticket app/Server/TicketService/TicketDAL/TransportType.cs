//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransportType
    {
        public TransportType()
        {
            this.Transports = new HashSet<Transports>();
        }
    
        public int id { get; set; }
        public string transportType1 { get; set; }
    
        public virtual ICollection<Transports> Transports { get; set; }
    }
}
