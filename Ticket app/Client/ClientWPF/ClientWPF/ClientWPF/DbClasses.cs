using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF
{
    public partial class Seat
    {
        public Seat()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int id { get; set; }
        public int seatStateId { get; set; }
        public int seatNumber { get; set; }
        public int transportId { get; set; }

        public virtual SeatState SeatState { get; set; }
        public virtual Transport Transport { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public partial class SeatState
    {
        public SeatState()
        {
            this.Seats = new HashSet<Seat>();
        }

        public int id { get; set; }
        public string stateName { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
    }
    public partial class Ticket
    {
        public int id { get; set; }
        public string passangerName { get; set; }
        public int transportId { get; set; }
        public int seatId { get; set; }
        public Nullable<System.DateTime> purchaseDate { get; set; }
        public int ticketStateId { get; set; }

        public virtual Seat Seat { get; set; }
        public virtual TicketState TicketState { get; set; }
        public virtual Transport Transport { get; set; }
    }
    public partial class TicketState
    {
        public TicketState()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int id { get; set; }
        public string stateName { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public partial class Transport
    {
        public Transport()
        {
            this.Seats = new HashSet<Seat>();
            this.Tickets = new HashSet<Ticket>();
        }

        public int id { get; set; }
        public int transportTypeId { get; set; }
        public int number { get; set; }
        public int routeId { get; set; }
        public Nullable<int> seatsCount { get; set; }
        public Nullable<int> carriageNumber { get; set; }
        public Nullable<int> cost { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual TransportType TransportType { get; set; }
        public virtual tRoute tRoute { get; set; }
    }
    public partial class TransportType
    {
        public TransportType()
        {
            this.Transports = new HashSet<Transport>();
        }

        public int id { get; set; }
        public string transportType1 { get; set; }

        public virtual ICollection<Transport> Transports { get; set; }
    }
    public partial class tRoute
    {
        public tRoute()
        {
            this.Transports = new HashSet<Transport>();
        }

        public int id { get; set; }
        public int fromId { get; set; }
        public int toId { get; set; }
        public Nullable<System.DateTime> arrival { get; set; }
        public Nullable<System.DateTime> departure { get; set; }
        public Nullable<int> price { get; set; }

        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual ICollection<Transport> Transports { get; set; }
    }
    public partial class City
    {
        public City()
        {
            this.tRoutes = new HashSet<tRoute>();
            this.tRoutes1 = new HashSet<tRoute>();
        }

        public int id { get; set; }
        public string city1 { get; set; }

        public virtual ICollection<tRoute> tRoutes { get; set; }
        public virtual ICollection<tRoute> tRoutes1 { get; set; }
    }
}
