using System;
using System.Collections.Generic;
using Dynastream.Fit;
using GarFit.TCX2;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit
{
	/// <summary>
	/// Description of FitGen.
	/// </summary>
	public class FitGen
	{
        public static TrainingCenterDatabase_t ReadTcxFile(string inputTcxFile)
        {
        	return TCX.TcxLoader.LoadActivities(inputTcxFile);
        }

        public static void EncodeActivityFile(TrainingCenterDatabase_t db, string outputFileName)
        {
            //  write FIT file
            Encode encoder = new Encode(ProtocolVersion.V20);

            System.IO.FileStream fitDest = new System.IO.FileStream(outputFileName + ".fit", System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.Read);

            // Write our header
            encoder.Open(fitDest);
            
            // FIT file_id message
            FileIdMesg fileIdMesg = new FileIdMesg();
            fileIdMesg.SetType(File.Activity);  // Activity File = 4
            fileIdMesg.SetManufacturer(Manufacturer.Garmin);
            fileIdMesg.SetProduct(GarminProduct.Fr935);
            fileIdMesg.SetSerialNumber(null);
            fileIdMesg.SetTimeCreated(new DateTime(db.Activities.Activity[0].Id));    // set from input file

            // Encode each message, a definition message is automatically generated and output if necessary
            encoder.Write(fileIdMesg);
            
            // FIT event message : not found in TCX
            // FIT deviceInfo message: not found in TCX
            // FIT deviceSettings message: not found in TCX
            // FIT UserProfile message: : not found in TCX
            // FIT Sport:
            SportMesg sportMesg = new SportMesg();
            sportMesg.SetSport(Sport.Running);
            sportMesg.SetSubSport(SubSport.Road);

            // Encode each message, a definition message is automatically generated and output if necessary
            encoder.Write(sportMesg);
            
            // create FIT record and lap message
            foreach (Activity_t act in db.Activities.Activity) {
            	foreach (ActivityLap_t lap in act.Lap) {
            		List<RecordMesg> records = new List<RecordMesg>();
            		// FIT Record message:
            		foreach (Trackpoint_t trackPoint in lap.Track) {
            			RecordMesg recMesg = new RecordMesg();
            			recMesg.SetTimestamp(new DateTime(trackPoint.Time));
            			recMesg.SetPositionLat(Utils.ConvertTcxLatLongToFit(trackPoint.Position.LatitudeDegrees));
            			recMesg.SetPositionLong(Utils.ConvertTcxLatLongToFit(trackPoint.Position.LongitudeDegrees));
            			recMesg.SetDistance((float)trackPoint.DistanceMeters);
            			recMesg.SetAltitude((float)trackPoint.AltitudeMeters);
            			//recMesg.SetSpeed((float)trackPoint.Extensions.Any["Speed"]);
						if (trackPoint.HeartRateBpm != null)
							recMesg.SetHeartRate((byte)trackPoint.HeartRateBpm.Value);
            			recMesg.SetCadence((byte)trackPoint.Cadence);
            			//recMesg.SetTemperature((sbyte)trackPoint);
            			
            			records.Add(recMesg);
            		}
            		
            		LapMesg lapMesg = new LapMesg();
            		lapMesg.SetTimestamp(new DateTime(lap.StartTime));
            		lapMesg.SetStartTime(new DateTime(lap.StartTime));
            		lapMesg.SetStartPositionLat(Utils.ConvertTcxLatLongToFit(lap.Track[0].Position.LatitudeDegrees));
            		lapMesg.SetStartPositionLong(Utils.ConvertTcxLatLongToFit(lap.Track[0].Position.LongitudeDegrees));
            		// TODO: EndPosition
            		lapMesg.SetTotalElapsedTime((float)lap.TotalTimeSeconds);
            		// TODO: The rest
            		
            		encoder.Write(records);
            		encoder.Write(lapMesg);
            	}
            }
            
            // FIT Session: not found in tcx
            // FIT Activity
            ActivityMesg activityMesg = new ActivityMesg();
            activityMesg.SetTimestamp(new DateTime(db.Activities.Activity[0].Id));
            //activityMesg.SetTotalTimerTime(db.Activities.Activity[0].Training.);
            //activityMesg.SetNumSessions();
            encoder.Write(activityMesg);
            

            // Update header datasize and file CRC
            encoder.Close();
            fitDest.Close();

            Console.WriteLine("Encoded FIT file " + outputFileName + ".fit");
        }
	}
}
