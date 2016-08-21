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
using System.Windows.Shapes;
using ClientWPF.ServiceReference1;

namespace ClientWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowTest.xaml
    /// </summary>
    public partial class WindowTest : Window
    {
        SeatList s = null;
        List<ServiceReference1.SeatsItemEntity> seats = null;
        public WindowTest(ServiceReference1.SeatsItemEntity[] currentItem)
        {
            InitializeComponent();
           /* List<Seat> seats = new List<Seat>()
            {
                new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=2},
                new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=5},
                new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=17},
                new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=2},
                new Seat{SeatState = new SeatState{stateName = "Свободно"}, seatNumber=5},
                new Seat{SeatState = new SeatState{stateName = "Занято"}, seatNumber=17}
            };*/

            seats = currentItem.ToList();
             s = new SeatList(seats);
             test.ItemsSource = seats;
        }

        private void CurrentChoice_Seat(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }
    }
}
