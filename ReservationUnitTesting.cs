using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReservationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_HotelName_And_RegularCustomerRates_And_Verifying()
        {
            Hotel lakeWood = new Hotel();
            Hotel bridgeWood = new Hotel();
            Hotel ridgeWood = new Hotel();
            lakeWood.HotelName = "Lakewood";
            bridgeWood.HotelName = "Bridgewood";
            ridgeWood.HotelName = "Ridgewood";
            lakeWood.WeekdayRateForRegularCustomer = 110;
            lakeWood.WeekendRateForRegularCustomer = 90;
            bridgeWood.WeekdayRateForRegularCustomer = 160;
            bridgeWood.WeekendRateForRegularCustomer = 60;
            ridgeWood.WeekdayRateForRegularCustomer = 220;
            ridgeWood.WeekendRateForRegularCustomer = 150;
            string expectedHotelName = "Lakewood";
            int expectedWeekDayRateforRegularCustomer = 110;
            int expectedWeekendRateforRegularCustomer = 90;
            Assert.AreEqual(expectedHotelName, lakeWood.HotelName);
            Assert.AreEqual(expectedWeekDayRateforRegularCustomer, lakeWood.WeekdayRateForRegularCustomer);
            Assert.AreEqual(expectedWeekendRateforRegularCustomer, lakeWood.WeekendRateForRegularCustomer);
        }
    }
}

