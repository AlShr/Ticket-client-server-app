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
    
    public partial class Seats
    {
        public Seats()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int id { get; set; }
        public int seatStateId { get; set; }
        public int seatNumber { get; set; }
        public int transportId { get; set; }
    
        public virtual SeatState SeatState { get; set; }
        public virtual Transports Transports { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
