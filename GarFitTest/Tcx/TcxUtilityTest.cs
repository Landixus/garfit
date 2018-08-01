using NUnit.Framework;
using System;
using DateTime = Dynastream.Fit.DateTime;
using SysDateTime = System.DateTime;
using GarFit.TCX;

namespace GarFitTest.Tcx
{
    [TestFixture()]
    public class TcxUtilityTest
    {
        [Test()]
		public void ToFitTime_Test()
        {
			string dateTimeString = "2017-11-27T12:16:30.000Z";
			SysDateTime actual = new SysDateTime(2017, 11, 27, 12, 16, 30, DateTimeKind.Utc);

			DateTime dateTime = TcxUtility.ToFitTime(dateTimeString);
			Assert.AreEqual(dateTime.GetDateTime(), actual);
        }
    }
}
