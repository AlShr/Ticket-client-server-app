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
    
    public partial class Cities
    {
        public Cities()
        {
            this.tRoutes = new HashSet<tRoutes>();
            this.tRoutes1 = new HashSet<tRoutes>();
        }
    
        public int id { get; set; }
        public string city { get; set; }
    
        public virtual ICollection<tRoutes> tRoutes { get; set; }
        public virtual ICollection<tRoutes> tRoutes1 { get; set; }
    }
}
