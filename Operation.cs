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
            bridgeWood.WeekdayRateForRegularCustomer = 160;
            bridgeWood.WeekendRateForRegularCustomer = 60;
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
                return "Lakewood";
            }
            else if (leastCost == GetBridgewoodCost(checkInDate, checkOutDate))
            {
                return "Bridgewood";
            }
            else
            {
                return "Ridgewood";
            }
        }
    }
}
