﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminClient
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class teamProject2022Entities : DbContext
    {
        public teamProject2022Entities()
            : base("name=teamProject2022Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Seats> Seats { get; set; }
        public DbSet<SeatState> SeatState { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketState> TicketState { get; set; }
        public DbSet<Transports> Transports { get; set; }
        public DbSet<TransportType> TransportType { get; set; }
        public DbSet<tRoutes> tRoutes { get; set; }
    }
}
