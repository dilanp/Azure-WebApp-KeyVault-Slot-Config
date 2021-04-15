using System;

namespace MvcMovie.Dates
{
    public static class DateManager
    {
        public static DateTime AmericanIndependanceDay = DateTime.Parse("04/07/1776");
        public static DateTime TitanicSank = DateTime.Parse("15/04/1912");
        public static DateTime BattleOfHastings = DateTime.Parse("14/10/1066");

        public static long DaysSince(DateTime sinceDate)
        {
            return DaysSince(sinceDate, DateTime.Today);
        }

        public static long DaysSince(DateTime sinceDate, DateTime currentDate)
        {
            return (currentDate - sinceDate).Days;
        }
    }
}