using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ClientWPF
{
    public class SeatList : ObservableCollection<ServiceReference1.SeatsItemEntity>
    {
        public SeatList(List<ServiceReference1.SeatsItemEntity> seats)
            :base()
        {
            foreach (var s in seats)
            {
                base.Add(s);
            }
        }
        public SeatList()
        { }
    }
}
