/*
 * Created by SharpDevelop.
 * User: nhdinh
 * Date: 8/2/2018
 * Time: 16:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GarFit;
using GarFit.TCX2;
using NUnit.Framework;

namespace GarFitTest.Tcx
{
	[TestFixture]
	public class FitGenTest
	{
		[Test]
		public void EncodeActivityFileTest()
		{
			TrainingCenterDatabase_t db = FitGen.ReadTcxFile(@"C:\Users\nhdinh\Desktop\GarFit\GarFit\bin\Debug\1.tcx");
			FitGen.EncodeActivityFile(db, null);
			
			Assert.Pass();
		}
	}
}
