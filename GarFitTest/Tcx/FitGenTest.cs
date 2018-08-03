using System;
using System.IO;
using GarFit;
using GarFit.TCX2;
using NUnit.Framework;
using System.Reflection;

namespace GarFitTest.Tcx {
	[TestFixture]
	public class FitGenTest {
		[Test]
		public void EncodeActivityFileTest() {
			string assemblyFilePath = Assembly.GetExecutingAssembly().GetName().CodeBase;
			string assemblyPath = assemblyFilePath.Replace(Path.GetFileName(assemblyFilePath), "");
			
			string tcxFile = assemblyPath;
			tcxFile += ".." + Path.DirectorySeparatorChar;
			tcxFile += ".." + Path.DirectorySeparatorChar;
			tcxFile += ".." + Path.DirectorySeparatorChar;
			tcxFile += "files" + Path.DirectorySeparatorChar;
			tcxFile += "1.tcx";
			
			TrainingCenterDatabase_t db = FitGen.ReadTcxFile(tcxFile);
			FitGen.EncodeActivityFile(db, null);
			
			Assert.Pass();
		}
	}
}
