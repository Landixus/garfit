using System;
using System.Collections.Generic;
using System.Diagnostics;
using Dynastream.Fit;
using GarFit.TCX;
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
            TCX.TcxActivity activityData = ReadTcxFile(inputTcxFile);

            //  encode activity file
            string outputFileName = System.IO.Path.GetFileNameWithoutExtension(inputTcxFile);
            if (string.IsNullOrEmpty(outputFileName)) outputFileName = "output";
            EncodeActivityFile(activityData, outputFileName);

            watch.Stop();
        }

        private static TCX.TcxActivity ReadTcxFile(string inputGpxFile)
        {
            return TCX.TcxLoader.CreateTestData();
        }

        private static void EncodeActivityFile(TCX.TcxActivity activityData, string outputFileName)
        {
            // FIT file_id message
            FileIdMesg fileIdMesg = new FileIdMesg();
            fileIdMesg.SetType(File.Activity);  // Activity File = 4
            fileIdMesg.SetManufacturer(Manufacturer.Garmin);
            fileIdMesg.SetProduct(GarminProduct.Fr935);
            fileIdMesg.SetSerialNumber(null);
            fileIdMesg.SetTimeCreated(new DateTime(621463080));    // set from input file

            // FIT activity message
            ActivityMesg activityMesg = new ActivityMesg();
            activityMesg.SetTimestamp(activityData.Id);
            activityMesg.SetType(Activity.Manual);
            activityMesg.SetNumSessions(1);

            //  FIT session message
            SessionMesg sessionMesg = new SessionMesg();
            sessionMesg.SetTimestamp(activityData.Id);
            sessionMesg.SetStartTime(activityData.Id);
            sessionMesg.SetSport(Sport.Running);

            // FIT lap message
            List<LapMesg> listOfLapMesg = new List<LapMesg>();
            foreach (TcxLap lap in activityData.Laps)
            {
                LapMesg lapMesg = new LapMesg();
                lapMesg.SetTimestamp(lap.StartTime);
            }

            // FIT data message

            //  write FIT file
            Encode encodeDemo = new Encode(ProtocolVersion.V20);

            System.IO.FileStream fitDest = new System.IO.FileStream(outputFileName + ".fit", System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.Read);

            // Write our header
            encodeDemo.Open(fitDest);

            // Encode each message, a definition message is automatically generated and output if necessary
            encodeDemo.Write(fileIdMesg);

            // Update header datasize and file CRC
            encodeDemo.Close();
            fitDest.Close();

            Console.WriteLine("Encoded FIT file " + outputFileName + ".fit");
        }
	}
}