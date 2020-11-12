using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Operation
    {
        private static int totalCost = 0;
        /// <summary>
        /// Method returns month in digit format
        /// </summary>
        /// <param name="month">The month.</param>
        /// <returns></returns>
        public static int GetMonthInDigits(string month)
        {
            switch (month.ToLower())
            {
                case "jan":
                    return 1;
                case "feb":
                    return 2;
                case "mar":
                    return 3;
                case "apr":
                    return 4;
                case "may":
                    return 5;
                case "jun":
                    return 6;
                case "jul":
                    return 7;
                case "aug":
                    return 8;
                case "sep":
                    return 9;
                case "oct":
                    return 10;
                case "nov":
                    return 11;
                case "dec":
                    return 12;
                default:
                    Console.WriteLine("Invalid Month");
                    return 0;
            }
        }
        /// <summary>
        /// Gives day of the week
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static string GetDay(string date)
        {
            int day = Convert.ToInt32(date.Substring(0, 2));
            string month = date.Substring(2, 3);
            int year = Convert.ToInt32(date.Substring(5));
            DateTime d = new DateTime(year, Operation.GetMonthInDigits(month), day);
            return d.DayOfWeek.ToString();
        }
        /// <summary>
        /// Gets the lakewood cost.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static int GetLakewoodCost(string checkInDate, string checkOutDate)
        {
            totalCost = 0;
            Hotel lakeWood = new Hotel();
            lakeWood.WeekdayRateForRegularCustomer = 110;
            lakeWood.WeekendRateForRegularCustomer = 90;
            string checkInday = GetDay(checkInDate);
            string checkOutday = GetDay(checkOutDate);
            if (checkInday.Equals("Saturday") || checkInday.Equals("Sunday"))
            {
                totalCost += lakeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += lakeWood.WeekdayRateForRegularCustomer;
            }
            if (checkOutday.Equals("Saturday") || checkOutday.Equals("Sunday"))
            {
                totalCost += lakeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += lakeWood.WeekdayRateForRegularCustomer;
            }
            return totalCost;
        }
        /// <summary>
        /// Gets the bridgewood hotel cost.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static int GetBridgewoodCost(string checkInDate, string checkOutDate)
        {
            totalCost = 0;
            Hotel bridgeWood = new Hotel();
            bridgeWood.WeekdayRateForRegularCustomer = 150;
            bridgeWood.WeekendRateForRegularCustomer = 50;
            string checkInday = GetDay(checkInDate);
            string checkOutday = GetDay(checkOutDate);
            if (checkInday.Equals("Saturday") || checkInday.Equals("Sunday"))
            {
                totalCost += bridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += bridgeWood.WeekdayRateForRegularCustomer;
            }
            if (checkOutday.Equals("Saturday") || checkOutday.Equals("Sunday"))
            {
                totalCost += bridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += bridgeWood.WeekdayRateForRegularCustomer;
            }
            return totalCost;
        }
        /// <summary>
        /// Gets the ridgewood hotel cost.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static int GetRidgewoodCost(string checkInDate, string checkOutDate)
        {
            totalCost = 0;
            Hotel ridgeWood = new Hotel();
            ridgeWood.WeekdayRateForRegularCustomer = 220;
            ridgeWood.WeekendRateForRegularCustomer = 150;
            string checkInday = GetDay(checkInDate);
            string checkOutday = GetDay(checkOutDate);
            if (checkInday.Equals("Saturday") || checkInday.Equals("Sunday"))
            {
                totalCost += ridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += ridgeWood.WeekdayRateForRegularCustomer;
            }
            if (checkOutday.Equals("Saturday") || checkOutday.Equals("Sunday"))
            {
                totalCost += ridgeWood.WeekendRateForRegularCustomer;
            }
            else
            {
                totalCost += ridgeWood.WeekdayRateForRegularCustomer;
            }
            return totalCost;
        }
        /// <summary>
        /// Method returns cheapest hotel rate 
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static int FindCheapestHotelRate(string checkInDate, string checkOutDate)
        {
            int lakeWoodCost = GetLakewoodCost(checkInDate, checkOutDate);
            int bridgeWoodCost = GetBridgewoodCost(checkInDate, checkOutDate);
            int ridgeWoodCost = GetRidgewoodCost(checkInDate, checkOutDate);
            int leastCost = lakeWoodCost < bridgeWoodCost ? lakeWoodCost : bridgeWoodCost;
            leastCost = leastCost < ridgeWoodCost ? leastCost : ridgeWoodCost;
            return leastCost;
        }
        /// <summary>
        /// Returns the name of the cheapest hotel.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static string FindCheapestHotelName(string checkInDate, string checkOutDate)
        {
            int leastCost = FindCheapestHotelRate(checkInDate, checkOutDate);
            if (leastCost == GetLakewoodCost(checkInDate, checkOutDate))
            {
                if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate))
                {
                    return "Lakewood and Bridgewood";
                }
                return "Lakewood";
            }
            else if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate))
            {
                if (leastCost == GetRidgewoodCost(checkInDate, checkOutDate))
                {
                    return "Bridgewood and Ridgewood";
                }
                return "Bridgewood";
            }
            else
            {
                if (leastCost == GetLakewoodCost(checkInDate, checkOutDate))
                {
                    return "Ridgewood and Lakewood";
                }
                return "Ridgewood";
            }
        }
        /// <summary>
        /// Gives the rating of hotel passed
        /// </summary>
        /// <param name="hotel">The hotel.</param>
        /// <returns></returns>
        public static int GetRatingOfHotel(string hotel)
        {
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
            if (hotel.Equals("Lakewood"))
            {
                return lakeWood.Rating;
            }
            else if (hotel.Equals("Bridgewood"))
            {
                return bridgeWood.Rating;
            }
            else
            {
                return ridgeWood.Rating;
            }
        }
        /// <summary>
        /// Return  the name of the cheapest best rated hotel.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static string FindCheapestBestRatedHotelName(string checkInDate, string checkOutDate)
        {
            string hotelName = FindCheapestHotelName(checkInDate, checkOutDate);
            if (hotelName.Contains("and"))
            {
                string[] hotels = hotelName.Split(" and ");
                int rating1 = GetRatingOfHotel(hotels[0]);
                int rating2 = GetRatingOfHotel(hotels[1]);
                if (rating1 > rating2)
                {
                    return hotels[0];
                }
                else
                {
                    return hotels[1];
                }
            }
            else
            {
                return hotelName;
            }
        }
        /// <summary>
        /// Find the name of the best rated hotel.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static string FindBestRatedHotelName(string checkInDate, string checkOutDate)
        {
            int cost = FindBestRatedHotelRate(checkInDate, checkOutDate);
            if (cost == GetRidgewoodCost(checkInDate, checkOutDate))
            {
                return "Ridgewood";
            }
            else if (cost == GetBridgewoodCost(checkInDate, checkOutDate))
            {
                return "Bridgewood";
            }
            else
            {
                return "Lakewood";
            }
        }
        /// <summary>
        /// Find the best rated hotel rate.
        /// </summary>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="checkOutDate">The check out date.</param>
        /// <returns></returns>
        public static int FindBestRatedHotelRate(string checkInDate, string checkOutDate)
        {
            int lakewoodRating = GetRatingOfHotel("Lakewood");
            int bridgewoodRating = GetRatingOfHotel("Bridgewood");
            int ridgewoodRating = GetRatingOfHotel("Ridgewood");
            int maxRating = lakewoodRating > bridgewoodRating ? lakewoodRating : bridgewoodRating;
            maxRating = maxRating > ridgewoodRating ? maxRating : ridgewoodRating;
            if (maxRating == lakewoodRating)
            {
                return GetLakewoodCost(checkInDate, checkOutDate);
            }
            else if (maxRating == bridgewoodRating)
            {
                return GetBridgewoodCost(checkInDate, checkOutDate);
            }
            else
            {
                return GetRidgewoodCost(checkInDate, checkOutDate);
            }
        }
    }
}

