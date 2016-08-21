using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDAL
{
    public class TicketsDAL
    {
        public Transports[] GetRoutes(string cityFrom, string cityTo, DateTime fromId, Guid guid)
        {
            //counter++;
            Transports[] transportRoutes = null;
            using (teamEntities1 contex = new teamEntities1())
            {
                try
                {
                    transportRoutes = (from t in contex.Transports
                                           //.Include("Seats")
                                           //.Include("Tickets")                 
                                           .Include("TransportType")
                                           .Include("tRoutes")
                                           .Include("tRoutes.Cities")
                                           .Include("tRoutes.Cities1")
                                           .Where(x => x.tRoutes.Cities.city.Equals(cityFrom, StringComparison.OrdinalIgnoreCase)
                                             && x.tRoutes.Cities1.city.Equals(cityTo, StringComparison.OrdinalIgnoreCase)) // фильтр по городам*/
                                       /* .Where(x => x.tRoute.departure.Value == fromId) // фильтр по дате */
                                       select t).ToArray();
                }
                catch (Exception ex) { }
            }
            /*
            if (transportRoutes != null) // если нашлись искомые маршруты
            {
                foreach (var item in transportRoutes) // перебираем  и заносим все маршруты в коллекцию
                {
                    
                    if (ticketsClient.Count != 0) // если не первый клиент в коллекции. Для работы for ниже
                    {
                        // Перебираем колекциию пользователей каждого маршрута и удаляем их "прошлые запросы"
                        for (int i = ticketsClient[item.routeId].Count - 1; i > 0; i--)
                        {
                            // Если найден прошлый запрос пользователя 
                            if (ticketsClient[item.routeId][i].CompareTo(guid) == 0)
                            {
                                // Удаляем старый запрос пользователя
                                ticketsClient[item.routeId].Remove(guid);
                                // Если такой маршрут больше не просматривает никакой пользователь, то 
                                if (ticketsClient[item.routeId].Count == 0)
                                {
                                    // удаляем такой маршрут из списка просматриваемых маршрутов
                                    ticketsClient.Remove(item.routeId);
                                }
                            }
                        }
                    }
                    if (ticketsClient.Keys.Contains(item.routeId)) // если в коллекции маршрутов есть данный маршрут
                    {
                        ticketsClient[item.routeId].Add(guid); // Добавляем нового пользователя в коллекцию пользователей, которые просматривают данный маршрут
                    }
                    else
                    {
                        ticketsClient.Add(item.routeId, new List<Guid>() { guid }); // заносим маршрут и создаем коллекцию пользователей, которые просматривают этот маршрут (что бы потом у этих клиентов обновить список билетов)
                    }
                    // добавить удаление пользователя из маршрутов
                }
            }*/
            return transportRoutes;
        }

        public Seats[] GetSeats(int transportId)
        {
            Transports[] transportRoutes = null;
            using (teamEntities1 contex = new teamEntities1())
            {

                Seats[] trasnportSeats = null;
                try
                {                   

                    trasnportSeats = (from t in contex.Seats               
                                           .Include("SeatState")
                                           .Include("Transports")
                                           .Where(x => x.transportId == transportId) // фильтр по транспорту
                                       select t).ToArray();
                }
                catch (Exception ex) { }

                return trasnportSeats;
            }
        }

        public string[] GetCity()
        {
            string[] cities = null;
            using (teamEntities1 context = new teamEntities1())
            {
                cities = (from c in context.Cities
                          select c.city).ToArray();
            }
            return cities;
        }
    
    }
}
