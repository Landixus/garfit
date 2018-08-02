using System;
using System.Collections.Generic;
using System.Diagnostics;
using Dynastream.Fit;
using GarFit.TCX;
using GarFit.TCX2;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit
{
	class Program
	{
		static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            //  read tcx file to class
            string inputTcxFile = "";
            if (args.Length != 1)
            {
                Console.Write("Usage: CreateFitFile <tcxFile>");
                return;
            }
            else inputTcxFile = args[0];

            // check input file
            if (!System.IO.File.Exists(inputTcxFile))
            {
                Console.Write("File " + inputTcxFile + " not exists");
                return;
            }

            // read tcx to activity data class
            TrainingCenterDatabase_t activityData = FitGen.ReadTcxFile(inputTcxFile);

            //  encode activity file
            string outputFileName = System.IO.Path.GetFileNameWithoutExtension(inputTcxFile);
            if (string.IsNullOrEmpty(outputFileName)) outputFileName = "output";
            FitGen.EncodeActivityFile(activityData, outputFileName);

            watch.Stop();
        }
	}
}