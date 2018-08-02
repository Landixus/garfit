/*
 * Created by SharpDevelop.
 * User: nhdinh
 * Date: 8/2/2018
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GarFit.TCX;
using GarFit.TCX2;
using SysFile = System.IO.File;
using NUnit.Framework;
using System.Xml;
using System.Xml.Schema;
using System.Collections.Generic;

namespace GarFitTest.Tcx {
	[TestFixture]
	public class TcxLoaderTest {
		TcxLoader loader;
		
		[TestFixtureSetUp] 
		public void Init() {
			loader = new TcxLoader();
		}
		
		[Test]
		public void GetTcxDocTest() {
			// assert file exists
			string fileName = @"..\..\..\files\short.tcx";
			Assert.True(SysFile.Exists(fileName));
			
			// try loading the tcx file and throw no exception
			try {
				XmlDocument xdocument = loader.GetTcxDoc(fileName);
				Assert.NotNull(xdocument);
			} catch (Exception ex) {
				Assert.Fail(ex.Message);
			}
		}
		
		[Test]
		public void GetTcxDocTest_Fail() {
			// assert file exists
			string fileName = @"..\..\..\files\short_fail.tcx";
			Assert.True(SysFile.Exists(fileName));
			
			// try loading the tcx file and throw no exception
			try {
				XmlDocument xdocument = loader.GetTcxDoc(fileName);
				Assert.Null(xdocument);
			} catch (Exception ex) {
				Assert.IsFalse(string.IsNullOrEmpty(ex.Message), ex.Message, ex);
			}
		}
		
		[Test]
		public void LoadActivities_Test() {
			// assert file exists
			string fileName = @"..\..\..\files\short.tcx";
			Assert.True(SysFile.Exists(fileName));
			
			TrainingCenterDatabase_t db = loader.LoadActivities(fileName);
			Assert.NotNull(db);			
			if (db != null)
				Assert.AreEqual(db.Activities.Activity[0].Lap.Length, 5);
		}
	}
}
