using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace TicketServiceWCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IClientCallBack))]
    public interface ITicketService
    {
        [OperationContract]
        TransportItem[] GetRoutes(string cityFrom, string cityTo, DateTime fromId, Guid guid);//возвращает список маршрутов

        [OperationContract]
        string[] GetCity(); //возвращает список городов из Таблицы City для заполнения листбокса

        [OperationContract]
        SeatsItemEntity[] GetSeats(int transportId);
        
        
        
       /* [OperationContract]
        bool BuyTicket(int _seatId, string passangerName);    // покупка билета
        [OperationContract]
        bool BookTicket(int _seatId, string passangerName);     //  зарезервировать билет
        [OperationContract]
        bool CancelBook(int _seatId, string name);   //отказ от брони билета    
        [OperationContract(IsOneWay = true, IsInitiating = true)]
        void Login(Guid guid);   // Метод который инициирует сессию и добавляет пользователя
        [OperationContract(IsOneWay = true, IsTerminating = true)]
        void Logout(Guid guid);   // Метод который закрывает сессию и удаляет пользователя
*/
    }

    public interface IClientCallBack
    {
        [OperationContract]
        void RefreshSeats();  //обновление данных открытого окна
    }
    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "TicketService.ContractType".
    [DataContract]
    public class CitesItemEntity:INotifyPropertyChanged
    {
        string cityName;
        [DataMember]
        public int CityItemID { set; get; }
        [DataMember]
        public string CityName 
        { 
            set
            {
                this.cityName=value;
                OnPropertyChanged("CityName");
            } 
            get
            {
                return cityName;
            } 
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    [DataContract]
    public class SeatStateItemEntity:INotifyPropertyChanged
    {
        string seatStateName;
        [DataMember]
        public int SeatStateItemID { set; get; }
        [DataMember]
        public string SeatStateName 
        { 
            set
            { 
                this.seatStateName=value;
                OnPropertyChanged("SeatStateName");
            } 
            get
            {
                return seatStateName; 
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    [DataContract]
    public class TicketStateItemEntity:INotifyPropertyChanged
    {
        string ticketStateName;
        [DataMember]
        public int TicketStateItemID { set; get; }
        [DataMember]
        public string TicketStateName 
        { 
            set
            {
                this.ticketStateName=value;
                OnPropertyChanged("TicketStateName");
            }
            get
            {
                return ticketStateName;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    [DataContract]
    public class TransportTypeItem:INotifyPropertyChanged
    {

        string transportTypeNameItem;
        [DataMember]
        public string TransportTypeNameItem
        {
            set
            {
                this.transportTypeNameItem = value;
                OnPropertyChanged("TransportTypeNameItem");
            }
            get { return transportTypeNameItem; }
        }
        [DataMember]
        public int TransportItemID { set; get; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    [DataContract]
    public class TRoutesItemEntity:INotifyPropertyChanged
    {
        CitesItemEntity fromCityItem;
        CitesItemEntity toCityItem;
        DateTime arrivalItem;
        DateTime departureItem;
        int priceItem;
        [DataMember]
        public int TRoutesItemID { set; get; }
        [DataMember]
        public CitesItemEntity FromCityItem
        {
            set
            {
                this.fromCityItem = value;
                OnPropertyChanged("FromCityItem");
            }
            get { return fromCityItem;}
        }
        [DataMember]
        public CitesItemEntity ToCityItem
        {
            set
            {
                this.toCityItem = value;
                OnPropertyChanged("ToCityItem");
            }
            get { return toCityItem; }
        }
        [DataMember]
        public DateTime ArrivalItem
        {
            set
            {
                this.arrivalItem = value;
                OnPropertyChanged("ArrivalItem");
            }
            get { return arrivalItem; }
        }
        [DataMember]
        public DateTime DepartureItem
        {
            set
            {
                this.departureItem = value;
                OnPropertyChanged("DepartureItem");
            }
            get { return departureItem; }
        }
        [DataMember]
        public int PriceItem
        {
            set
            {
                this.priceItem = value;
                OnPropertyChanged("PriceItem");
            }
            get { return priceItem; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    [DataContract]
    public class TransportItem : INotifyPropertyChanged
    {
        TRoutesItemEntity routeItem;
        TransportTypeItem transportsTypeItem;
        int number;
        int seatsCountItem;
        int carriageNumberItem;
        int costItem;
        [DataMember]
        public int TransportItemID { set; get; }
        [DataMember]
        public TransportTypeItem TransportsTypeItem
        {
            set
            {
                this.transportsTypeItem = value;
                OnPropertyChanged("TransportsTypeItem");
            }
            get { return transportsTypeItem; }
        }
        [DataMember]
        public TRoutesItemEntity RouteItem
        {
            set
            {
                this.routeItem = value;
                OnPropertyChanged("RouteItem");
            }
            get
            {
                return routeItem;
            }
        }
        [DataMember]
        public int Number
        {
            set 
            {
                this.number = value;
                OnPropertyChanged("Number");
            }
            get { return number; }
        }
        [DataMember]
        public int SeatsCountItem
        {
            set
            {
                this.seatsCountItem = value;
                OnPropertyChanged("SeatsCountItem");
            }
            get { return seatsCountItem; }
        }
        [DataMember]
        public int CarriageNumberItem
        {
            set
            {
                this.carriageNumberItem = value;
                OnPropertyChanged("CarriageNumberItem");
            }
            get { return carriageNumberItem; }
        }
        [DataMember]
        public int CostItem
        {
            set 
            {
                this.costItem = value;
                OnPropertyChanged("CostItem");
            }
            get { return costItem; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    [DataContract]
    public class
        SeatsItemEntity : INotifyPropertyChanged
    {
        string seatState;
        int transportID;
        int seatNumber;
        [DataMember]
        public int SeatsItemID { set; get; }
        [DataMember]
        public string SeatState
        {
            set
            {
                this.seatState = value;
                OnPropertyChanged("SeatState");
            }
            get { return seatState; }
        }

        [DataMember]
        public int TransportID
        {
            set
            {
                this.transportID = value;
                OnPropertyChanged("TransportID");
            }
            get { return transportID; }
        }


        [DataMember]
        public int SeatNumber
        {
            set
            {
                this.seatNumber = value;
                OnPropertyChanged("SeatNumber");
            }
            get { return seatNumber; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
