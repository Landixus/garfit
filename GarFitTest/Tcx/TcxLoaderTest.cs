using System;
using GarFit.TCX;
using GarFit.TCX2;
using SysFile = System.IO.File;
using NUnit.Framework;
using System.Xml;
using System.Xml.Schema;
using System.Collections.Generic;
using System.IO;

namespace GarFitTest.Tcx {
	[TestFixture]
	public class TcxLoaderTest {
		[Test]
		public void LoadActivities_Test() {
			string assemblyFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
			string assemblyDirectory = assemblyFilePath.Replace(Path.GetFileName(assemblyFilePath),"");

			// assert file exists
			string fileName = assemblyDirectory + "../../../files/1_edit.tcx";
			Assert.True(SysFile.Exists(fileName));
			
			TrainingCenterDatabase_t db = TcxLoader.LoadActivities(fileName);
			Assert.NotNull(db);			
			if (db != null)
				Assert.AreEqual(db.Activities.Activity[0].Lap.Length, 20);
		}
	}
}
