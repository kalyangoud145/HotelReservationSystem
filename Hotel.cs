using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public int Rating { get; set; }
        public int WeekdayRateForRegularCustomer { get; set; }
        public int WeekendRateForRegularCustomer { get; set; }
    }
}
