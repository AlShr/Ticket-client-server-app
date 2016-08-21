using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClientWPF.ServiceReference1;

using System.ServiceModel;
using System.Threading;

namespace ClientWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Guid WindowId;
        CollectionViewSource RoutesView;
        List<ServiceReference1.TransportItem> transportItems = new List<TransportItem>();
        ServiceReference1.TransportItem itemTransport;
        public List<ServiceReference1.TransportItem> TransportItems
        {
            get { return this.transportItems; }
            set { this.transportItems = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            RoutesView = (CollectionViewSource)this.Resources["RoutesView"];
            WindowId = Guid.NewGuid();
            CallBackHandler.form = this;           
            string[] cities;
            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, (ThreadStart)delegate()
            {
                try
                {
                    cities = CallBackHandler.proxy.GetCity();
                    foreach (var v in cities)
                    {
                        cb_From.Items.Add(v);
                        cb_To.Items.Add(v);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+" "+ex.StackTrace);
                }
            });

            cb_From.SelectedIndex = cb_To.SelectedIndex = 0;
            //this.dp_Date.DisplayDate = DateTime.Now;
            this.dp_Date.SelectedDate = DateTime.Now;   // В календаре выбираем текущую дату
           
            //this.dp_Date.DisplayDateStart = DateTime.Now;
        }
     /*   private void LoadRoutesData()
        {
          Transport t = new Transport() 	   
          { 		    
                id = 1, 
		        carriageNumber = 1, 
		        cost = 100, 
		        number = 43522,
	            routeId = 1, 
		        seatsCount = 10,
	            transportTypeId = 1,
                TransportType = new TransportType() 
                { 
                     id = 1, 
		             transportType1 = "Самолет" 
                },  		        
                tRoute = new tRoute() 
		        {
		             id = 1,
		             price = 100, 
		             arrival = DateTime.Now.AddDays(10), 
		             departure = DateTime.Now, fromId = 1, 
		             toId = 2, City = new City() 
		             {
		                id = 1, 
			        city1 = "Zaporizhzhya" 
		             }, 
		             City1 = new City() 
		             {
			         id = 1, 
			         city1 = "Cherkasy" 
		             } 
		        },
 	           Seats=new List<Seat>()
               {
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=1},                    
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=2},                
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=3},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=4},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=5},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=6},
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=7},                    
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=8},                
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=9},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=10},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=11},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=12},
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=13},                    
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=14},                
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=15},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=16},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=17},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=18},
                    new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=19},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=20},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=21},
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=22},                    
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=23},                
                   new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=24},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=25},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=26},                
                   new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=27},
               }
          };
        transportItems.Add(t);
	    t = new Transport() 
	    { 		    
            id = 1, 
		    carriageNumber = 1, 
		    cost = 100, 
		    number = 43522,
	        routeId = 1, 
		    seatsCount = 10,
	        transportTypeId = 1,
            TransportType = new TransportType() 
		    {                      
                id = 1, 
		        transportType1 = "Автобус"                 
            }, 
 		
            tRoute = new tRoute() 
		    {
		         id = 1,
		         price = 100, 
		         arrival = DateTime.Now.AddDays(10), 
		         departure = DateTime.Now, fromId = 1, 
		         toId = 2, City = new City() 
		         {
		            id = 1, 
			        city1 = "Zaporizhzhya" 
		         }, 
		         City1 = new City() 
		         {
			         id = 1, 
			         city1 = "Cherkasy" 
		         } 
		    },
            Seats=new List<Seat>()
            {
                new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=1},                    
                new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=2},                
                new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=3},                
                new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=4},                
                new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=5},                
                new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=6}
            }
	        };
            transportItems.Add(t);	        
            t = new Transport() 
	        {
 		        id = 1, 
		        carriageNumber = 1, 
		        cost = 100, 
		        number = 43522,
	            routeId = 1, 
		        seatsCount = 10,
	            transportTypeId = 1,
                TransportType = new TransportType() 
		        { 
                    id = 1, 
		            transportType1 = "Поезд"                     
                }, 
 		        tRoute = new tRoute() 
		        {
		             id = 1,
		             price = 100, 
		             arrival = DateTime.Now.AddDays(10), 
		             departure = DateTime.Now, fromId = 1, 
		             toId = 2, City = new City() 
		             {
		                id = 1, 
			            city1 = "Zaporizhzhya" 
		             }, 
		             City1 = new City() 
		             {
			             id = 1, 
			             city1 = "Cherkasy" 
		             } 
		        },
                Seats = new List<Seat>()
                {
                    new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=1},                    
                    new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=2},                
                    new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=3},                
                    new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=4},                
                    new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=5},                
                    new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=6}
                }
	            };                            
            transportItems.Add(t);
        }
        */
        private void LoadRoutesData()
        {
            ServiceReference1.TransportItem[] tt = null;
            tt = CallBackHandler.proxy.GetRoutes(cb_From.SelectedItem.ToString(), cb_To.SelectedItem.ToString(), (DateTime)dp_Date.SelectedDate, WindowId);
            transportItems = tt.ToList();
        }
        private void bt_Find_Click(object sender, RoutedEventArgs e)
        {
            LoadRoutesData();
            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal,
                     (ThreadStart)delegate()
                     {
                         RoutesView.Source = transportItems;
                     });
        }
        private void Master_Details_Seats(object sender, MouseButtonEventArgs e)
        {
            ServiceReference1.SeatsItemEntity[] si = null;
            si = CallBackHandler.proxy.GetSeats(itemTransport.TransportItemID);
            WindowTest w = new WindowTest(si);
            w.ShowDialog();          
        }

        private void Master_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            itemTransport = (TransportItem)currentTransport.Items.CurrentItem;
        }
    }

    public class CallBackHandler : ITicketServiceCallback
    {
        static InstanceContext site = new InstanceContext(new CallBackHandler());
        public static TicketServiceClient proxy = new TicketServiceClient(site);
        public static MainWindow form = null;

        public void RefreshSeats()
        { 
            
        }


    }
}
