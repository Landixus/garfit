using System;
using System.Globalization;
using DateTime = Dynastream.Fit.DateTime;
using SysDateTime = System.DateTime;

namespace GarFit.TCX
{
    public static class TcxUtility
    {
        /// <summary>
        /// Convert string to time
        /// </summary>
        /// <param name="dateTimeString">will be in a format of yyyy-mm-ddThh:mm:ss.000z</param>
        /// <returns></returns>
        public static DateTime ToFitTime(string dateTimeString)
        {
            //dateTimeString = dateTimeString.Replace("000Z", "0000000Z");
            try
            {
                // format can be "o"
                SysDateTime sysDateTime = SysDateTime.ParseExact(dateTimeString, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                DateTime dateTime = new DateTime(sysDateTime);
                return dateTime;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} is not in the correct format.", dateTimeString);
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
