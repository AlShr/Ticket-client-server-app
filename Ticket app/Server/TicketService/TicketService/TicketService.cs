using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TicketDAL;

namespace TicketServiceWCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TicketService : ITicketService
    {
        //хранение текущего пользователя и IClientCallBack; Guid - идкнтификатор клиента(присылает пользователь при Login); IClientCallBack - контракт клиента
        static Dictionary<Guid, IClientCallBack> clients = new Dictionary<Guid, IClientCallBack>();
        //хранение текущего билета  и списка  заинтерисованных клиентов
        static Dictionary<int, List<Guid>> ticketsClient = new Dictionary<int, List<Guid>>();
        //для различия клиентов которые просматривают направление пути
        //необходимо вызывать метод GetRoutes
        //для увеличения счетчика
        //static int counter = 0;
        //для поиска среди активных клиентов 
        TRoutesItemEntity[] transportRoutes;
        List<TransportItem> transportItems=new List<TransportItem>();
        TransportItem[] transportItemsArray;
        TicketsDAL transportDalacess = new TicketsDAL();
        private bool SearchClientByName(Guid name)
        {
            foreach (var user in clients.Keys)
            {
                if (name == user)
                    return true;
            }
            return false;
        }
        //для поиска списка клиентов по билету
        private bool SearchTicketsClient(string name)
        {
            foreach (int user in ticketsClient.Keys)
            {
                int hashCode = name.GetHashCode();
                if (hashCode == user)
                    return true;
            }
            return false;
        }
        // CallBack метод текущего пользователя
        public IClientCallBack CurrentCallBack
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IClientCallBack>();
            }
        }
        public void TranslateTransportDALtoTransportContractData(Transports transportDAL, TransportItem transportContractData)
        {
                     
            transportContractData.TransportItemID = transportDAL.transportTypeId;
            transportContractData.RouteItem = new TRoutesItemEntity()
            {
                ArrivalItem = (DateTime)transportDAL.tRoutes.arrival,
                DepartureItem = (DateTime)transportDAL.tRoutes.departure,
                FromCityItem = new CitesItemEntity()
                {
                    CityName = transportDAL.tRoutes.Cities.city
                },
                ToCityItem = new CitesItemEntity()
                {
                    CityName = transportDAL.tRoutes.Cities1.city
                },
                PriceItem = (int)transportDAL.tRoutes.price
            };
            transportContractData.TransportsTypeItem = new TransportTypeItem()
            {
                TransportTypeNameItem = transportDAL.TransportType.transportType1
            };
            transportContractData.SeatsCountItem = (int)transportDAL.seatsCount;
            transportContractData.Number = transportDAL.number;
            transportContractData.CarriageNumberItem = (int)transportDAL.carriageNumber;//номер вагона
            transportContractData.CostItem = (int)transportDAL.cost;
            
        }
        //возвращает список маршрутов
        public TransportItem[] GetRoutes(string cityFrom, string cityTo, DateTime fromId, Guid guid)
        {
            Transports[] currentTransport = transportDalacess.GetRoutes(cityFrom, cityTo, fromId, guid);
            TransportItem transportItem=new TransportItem();
            foreach(Transports transportItemContractData in currentTransport)
            {
                transportItem=new TransportItem();
                TranslateTransportDALtoTransportContractData(transportItemContractData,transportItem);
                transportItems.Add(transportItem);
            }
            transportItemsArray = transportItems.ToArray();
            return transportItemsArray;
        }

        public void TranslateSeatsDALtoSeatsContractData(Seats seatDAL, SeatsItemEntity seatContractData)
        {

            seatContractData.SeatNumber = seatDAL.seatNumber;
            seatContractData.SeatState = seatDAL.SeatState.stateName;
            
            seatContractData.TransportID = (int)seatDAL.transportId;

        }

        public SeatsItemEntity[] GetSeats(int transportId)
        {
            List<SeatsItemEntity> sit = new List<SeatsItemEntity>();
            Seats[] currentSeats = transportDalacess.GetSeats(transportId);
            SeatsItemEntity seatItem = new SeatsItemEntity();
            foreach (Seats seatItemContractData in currentSeats)
            {
                seatItem = new SeatsItemEntity();
                TranslateSeatsDALtoSeatsContractData(seatItemContractData, seatItem);
                sit.Add(seatItem);
            }
            

            return sit.ToArray();
        }

        //возвращает список городов из Таблицы City для заполнения листбокса
        public string[] GetCity()
        {
            string[] cities = null;
            cities = transportDalacess.GetCity();
            return cities;
        }
    }
}
