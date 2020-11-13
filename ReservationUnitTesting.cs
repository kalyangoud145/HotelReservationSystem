using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReservationUnitTest
{
    [TestClass]
    public class ReservationUnitTesting
    {
        ///TC 1
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
        ///TC 2
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
        ///TC 3
        /// <summary>
        /// Adding the weekday and weekend regular customer rates and verifying.
        /// </summary>
        [TestMethod]
        public void Adding_Weekday_And_Weekend_RegularCustomerRates_And_Verifying()
        {
            //Arrange
            int expectedWeekDayRateforRegularCustomer = 110;
            int expectedWeekendRateforRegularCustomer = 90;
            //Act
            Hotel lakeWood = new Hotel
            {
                WeekdayRateForRegularCustomer = 110,
                WeekendRateForRegularCustomer = 90
            };
            Hotel bridgeWood = new Hotel
            {
                WeekdayRateForRegularCustomer = 150,
                WeekendRateForRegularCustomer = 50
            };
            Hotel ridgeWood = new Hotel
            {
                WeekdayRateForRegularCustomer = 220,
                WeekendRateForRegularCustomer = 150
            };
            //Assert
            Assert.AreEqual(expectedWeekDayRateforRegularCustomer, lakeWood.WeekdayRateForRegularCustomer);
            Assert.AreEqual(expectedWeekendRateforRegularCustomer, lakeWood.WeekendRateForRegularCustomer);
        }
        ///TC 4
        /// <summary>
        /// Givens the date range including weekend should return cheapest hotel.
        /// </summary>
        [TestMethod]
        public void Given_Date_Range_Including_Weekend_Should_Return_Cheapest_Hotel()
        {
            //Arrange
            int expectedHotelRate = 200;
            string expectedHotelName = "Lakewood and Bridgewood";
            //Act
            int actualHotelRate = Operation.FindCheapestHotelRate("11Sep2020", "12Sep2020");
            string actualHotelName = Operation.FindCheapestHotelName("11Sep2020", "12Sep2020");
            //Assert
            Assert.AreEqual(expectedHotelRate, actualHotelRate);
            Assert.AreEqual(expectedHotelName, actualHotelName);
        }
        /// <summary>
        /// Adding the rating to hotels and verifying.
        /// </summary>
        [TestMethod]
        public void Adding_Rating_To_Hotels_And_Verifying()
        {
            //Arrange
            int expectedRating = 5;
            Hotel lakeWood = new Hotel
            {
                Rating = 3
            };
            Hotel bridgeWood = new Hotel
            {
                Rating = 4
            };
            Hotel ridgeWood = new Hotel
            {
                Rating = 5
            };
            //Act
            int actualRating = ridgeWood.Rating;
            //Assert
            Assert.AreEqual(expectedRating, actualRating);
        }
        ///TC 6
        /// <summary>
        /// Given the date range should return cheapest best rated hotel.
        /// </summary>
        [TestMethod]
        public void Given_Date_Range_Should_Return_Cheapest_BestRated_Hotel()
        {
            //Arrange
            string expectedHotelName = "Bridgewood";
            int expectedRate = 200;
            //Act
            string actualHotelName = Operation.FindCheapestBestRatedHotelName("11Sep2020", "12Sep2020");
            int actualRate = Operation.FindCheapestHotelRate("11Sep2020", "12Sep2020");
            //Assert
            Assert.AreEqual(expectedRate, actualRate);
            Assert.AreEqual(expectedHotelName, actualHotelName);
        }
        ///TC 7
        /// <summary>
        /// Given the date range should return best rated hotel.
        /// </summary>
        [TestMethod]
        public void Given_Date_Range_Should_Return_BestRated_Hotel()
        {
            //Arrange
            string expectedHotelName = "Ridgewood";
            int expectedRate = 370;
            //Act
            string actualHotelName = Operation.FindBestRatedHotelName("11Sep2020", "12Sep2020");
            int actualRate = Operation.FindBestRatedHotelRate("11Sep2020", "12Sep2020");
            //Assert
            Assert.AreEqual(expectedRate, actualRate);
            Assert.AreEqual(expectedHotelName, actualHotelName);
        }
        ///TC 8
        /// <summary>
        /// Addings the weekday and weekend reward customer rates and verifying.
        /// </summary>
        [TestMethod]
        public void Adding_Weekday_And_Weekend_RewardCustomerRates_And_Verifying()
        {

            Hotel lakeWood = new Hotel
            {
                WeekdayRateForRegularCustomer = 110,
                WeekendRateForRegularCustomer = 90,
                WeekdayRateForRewardCustomer = 80,
                WeekendRateForRewardCustomer = 80,
                Rating = 3
            };
            Hotel bridgeWood = new Hotel
            {
                WeekdayRateForRegularCustomer = 150,
                WeekendRateForRegularCustomer = 50,
                WeekdayRateForRewardCustomer = 110,
                WeekendRateForRewardCustomer = 50,
                Rating = 4
            };
            Hotel ridgeWood = new Hotel
            {
                WeekdayRateForRegularCustomer = 220,
                WeekendRateForRegularCustomer = 150,
                WeekdayRateForRewardCustomer = 100,
                WeekendRateForRewardCustomer = 40,
                Rating = 5
            };
            //Arrange
            int expectedWeekdayRate = 80;
            int expectedWeekendRate = 80;
            //Act
            int actualWeekdayRate = lakeWood.WeekdayRateForRewardCustomer;
            int actualWeekendRate = lakeWood.WeekendRateForRewardCustomer;
            //Assert
            Assert.AreEqual(expectedWeekendRate, actualWeekendRate);
            Assert.AreEqual(expectedWeekdayRate, actualWeekdayRate);
        }
        ///TC 9
        /// <summary>
        /// Finds the cheapest best hotel and rating and price and verifying.
        /// </summary>
        [TestMethod]
        public void FindCheapest_BestHotel_AndRatingAndPrice_ForRewardCustomerAnd_Verifying()
        {
            //Arrange
            string expectedHotelName = "Ridgewood";
            int expectedRate = 140;
            int expectedRating = 5;
            //Act
            string actualHotelName = Operation.FindCheapestBestRatedHotelName("11Sep2020", "12Sep2020", "Reward");
            int actualRate = Operation.FindCheapestHotelRate("11Sep2020", "12Sep2020", "Reward");
            int actualRating = Operation.GetRatingOfHotel(actualHotelName);
            //Assert
            Assert.AreEqual(expectedHotelName, actualHotelName);
            Assert.AreEqual(expectedRate, actualRate);
            Assert.AreEqual(expectedRating, actualRating);
        }
        ///TC 10
        /// <summary>
        /// Find the cheapest best hotel and rating and price for regular customer and verifying.
        /// </summary>
        [TestMethod]
        public void FindCheapest_BestHotel_AndRatingAndPrice_ForRegularCustomer_And_Verifying()
        {
            //Arrange
            string expectedHotelName = "Bridgewood";
            int expectedRate = 200;
            int expectedRating = 4;
            //Act
            string actualHotelName = Operation.FindCheapestBestRatedHotelName("11Sep2020", "12Sep2020", "Regular");
            int actualRate = Operation.FindCheapestHotelRate("11Sep2020", "12Sep2020", "Regular");
            int actualRating = Operation.GetRatingOfHotel(actualHotelName);
            //Assert
            Assert.AreEqual(expectedHotelName, actualHotelName);
            Assert.AreEqual(expectedRate, actualRate);
            Assert.AreEqual(expectedRating, actualRating);
        }
    }
}

