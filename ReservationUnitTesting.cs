using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReservationUnitTest
{
    [TestClass]
    public class ReservationUnitTesting
    {
        /// <summary>
        ///checks Addition of the hotel name and regular customer rates 
        /// </summary>
        [TestMethod]
        public void Adding_HotelName_And_RegularCustomerRates_And_Verifying()
        {
            //Arrange
            string expectedHotelName = "Lakewood";
            int expectedWeekDayRateforRegularCustomer = 110;
            int expectedWeekendRateforRegularCustomer = 90;
            //Act
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
            //Assert
            Assert.AreEqual(expectedHotelName, lakeWood.HotelName);
            Assert.AreEqual(expectedWeekDayRateforRegularCustomer, lakeWood.WeekdayRateForRegularCustomer);
            Assert.AreEqual(expectedWeekendRateforRegularCustomer, lakeWood.WeekendRateForRegularCustomer);
        }
        /// <summary>
        /// Givens the date range should return cheapest hotel.
        /// </summary>
        [TestMethod]
        public void Given_DateRange_Should_Return_CheapestHotel()
        {
            //Arrange
            int expectedHotelRate = 220;
            string expectedHotelName = "Lakewood";
            //Act
            string actualHotelName = Operation.FindCheapestHotelName("10Sep2020", "11Sep2020");
            int actualHotelRate = Operation.FindCheapestHotelRate("10Sep2020", "11Sep2020");
            //Assert
            Assert.AreEqual(expectedHotelName, actualHotelName);
            Assert.AreEqual(expectedHotelRate, actualHotelRate);
        }
    }
}

