using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Dynastream.Fit;
using GarFit.TCX2;
using DateTime = Dynastream.Fit.DateTime;
using SysPath = System.IO.Path;
using SysFile = System.IO.File;
using SysFileStream = System.IO.FileStream;
using SysFileShare = System.IO.FileShare;
using SysFileAccess = System.IO.FileAccess;
using SysFileMode = System.IO.FileMode;

namespace GarFit
{
    /// <summary>
    /// Description of FitGen.
    /// </summary>
    public class FitGen
    {
        public static TrainingCenterDatabase_t ReadTcxFile(string inputTcxFile)
        {
            // get schema Uri
            var schemaUri = "TCX2" + SysPath.DirectorySeparatorChar + "TrainingCenterDatabasev2.xsd";
            if (!SysFile.Exists(schemaUri))
                schemaUri = "http://www.garmin.com/xmlschemas/TrainingCenterDatabasev2.xsd";

            //  create new serializer
            var serializer = new XmlSerializer(typeof(TrainingCenterDatabase_t));
            var settings = new XmlReaderSettings();

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", schemaUri);
            //schemaSet.Add("http://www.garmin.com/xmlschemas/ActivityExtension/v2", schemaUri);
            settings.Schemas.Add(schemaSet);


            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationFlags |= XmlSchemaValidationFlags.None;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            TrainingCenterDatabase_t tcd;
            using (XmlReader reader = XmlReader.Create(inputTcxFile, settings))
            {
                tcd = (TrainingCenterDatabase_t)serializer.Deserialize(reader);
            }

            return tcd;
        }

        /// <summary>
        /// Validation handler for XML document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            else
                Console.WriteLine("\tValidation error: " + args.Message);

        }

        /// <summary>
        /// Encode to a fit file
        /// </summary>
        /// <param name="db"></param>
        /// <param name="outputFileName"></param>
        public static void EncodeActivityFile(TrainingCenterDatabase_t db, string outputFileName)
        {
            /*
			string assemblyFilePath = Assembly.GetExecutingAssembly().GetName().CodeBase;
			string assemblyPath = assemblyFilePath.Replace(SysPath.GetFileName(assemblyFilePath), "");
			*/

            if (string.IsNullOrEmpty(outputFileName))
                outputFileName = "out";

            //outputFileName = assemblyPath + outputFileName;

            //  write FIT file
            Encode encoder = new Encode(ProtocolVersion.V20);
            SysFileStream fitDest = new SysFileStream(outputFileName + ".fit",
                                        SysFileMode.Create,
                                        SysFileAccess.ReadWrite,
                                        SysFileShare.Read);

            // Write our header
            encoder.Open(fitDest);

            // FIT file_id message
            FileIdMesg fileIdMesg = new FileIdMesg();
            fileIdMesg.SetType(File.Activity);  // Activity File = 4
            fileIdMesg.SetManufacturer(Manufacturer.Garmin);
            fileIdMesg.SetProduct(GarminProduct.Fr935);
            fileIdMesg.SetSerialNumber(3949668594);
            fileIdMesg.SetTimeCreated(new DateTime(db.Activities.Activity[0].Id));    // set from input file

            // Encode each message, a definition message is automatically generated and output if necessary
            encoder.OnMesgDefinition(new MesgDefinition(fileIdMesg));
            encoder.OnMesg(fileIdMesg);
            Utils.LogMessage(LogType.Information, "Wrote FileID");

            // FIT FileCreator
            FileCreatorMesg fileCreatorMesg = new FileCreatorMesg();
            fileCreatorMesg.SetSoftwareVersion(600);    // Garmin Connect
            encoder.OnMesgDefinition(new MesgDefinition(fileCreatorMesg));
            encoder.OnMesg(fileCreatorMesg);
            Utils.LogMessage(LogType.Information, "Wrote FileCreatorMesg");

            // FIT event message : not found in TCX
            EventMesg eventMesg = new EventMesg();
            eventMesg.SetTimestamp(new DateTime(db.Activities.Activity[0].Id));
            eventMesg.SetData(0);
            eventMesg.SetEvent(Event.Timer);
            eventMesg.SetEventType(EventType.Start);
            eventMesg.SetEventGroup(0);
            encoder.OnMesgDefinition(new MesgDefinition(eventMesg));
            encoder.OnMesg(eventMesg);
            Utils.LogMessage(LogType.Information, "Wrote EventMesg");

            // FIT deviceInfo message: not found in TCX
            DeviceInfoMesg devInfoMesg = new DeviceInfoMesg();
            devInfoMesg.SetTimestamp(new DateTime(db.Activities.Activity[0].Id));
            devInfoMesg.SetSerialNumber(3949668594);
            devInfoMesg.SetManufacturer(Manufacturer.Garmin);
            devInfoMesg.SetProduct(GarminProduct.Fr935);
            devInfoMesg.SetSoftwareVersion(6);
            devInfoMesg.SetDeviceIndex(0);
            devInfoMesg.SetSourceType(SourceType.Local);
            for (int i = 0; i < 4; i++) {
                encoder.OnMesgDefinition(new MesgDefinition(devInfoMesg));
                encoder.OnMesg(devInfoMesg);
                Utils.LogMessage(LogType.Information, "Wrote DeviceInfoMesg");
            }

            // FIT deviceSettings message: not found in TCX
            DeviceSettingsMesg devSettingsMesg = new DeviceSettingsMesg();
            devSettingsMesg.SetUtcOffset(0);
            devSettingsMesg.SetTimeOffset(7, 0);
            devSettingsMesg.SetAutoActivityDetect(0);
            devSettingsMesg.SetAutosyncMinSteps(2000);
            devSettingsMesg.SetAutosyncMinTime(240);
            devSettingsMesg.SetActiveTimeZone(0);
            devSettingsMesg.SetActivityTrackerEnabled(Bool.True);
            devSettingsMesg.SetMountingSide(Side.Left);
            devSettingsMesg.SetTimeMode(1, TimeMode.Utc);
            encoder.OnMesgDefinition(new MesgDefinition(devSettingsMesg));
            encoder.OnMesg(devSettingsMesg);
            Utils.LogMessage(LogType.Information, "Wrote DeviceSettingsMesg");

            // FIT UserProfile message: : not found in TCX
            UserProfileMesg userProfileMesg = new UserProfileMesg();
            userProfileMesg.SetActivityClass(ActivityClass.Level);
            encoder.OnMesgDefinition(new MesgDefinition(userProfileMesg));
            encoder.OnMesg(userProfileMesg);
            Utils.LogMessage(LogType.Information, "Wrote UserProfileMesg");

            // FIT Sport:
            SportMesg sportMesg = new SportMesg();
            sportMesg.SetSport(Sport.Running);
            sportMesg.SetSubSport(SubSport.Road);

            // Encode each message, a definition message is automatically generated and output if necessary
            encoder.OnMesgDefinition(new MesgDefinition(sportMesg));
            encoder.OnMesg(sportMesg);
            Utils.LogMessage(LogType.Information, "Wrote SportMesg");

            // create FIT record and lap message
            double totalTime = 0;
            foreach (Activity_t act in db.Activities.Activity)
            {
                foreach (ActivityLap_t lap in act.Lap)
                {
                    List<RecordMesg> records = new List<RecordMesg>();

                    // FIT Record message:
                    foreach (Trackpoint_t trackPoint in lap.Track)
                    {
                        RecordMesg recMesg = new RecordMesg();

                        recMesg.SetTimestamp(new DateTime(trackPoint.Time));
                        recMesg.SetPositionLat(Utils.ConvertTcxLatLongToFit(trackPoint.Position.LatitudeDegrees));
                        recMesg.SetPositionLong(Utils.ConvertTcxLatLongToFit(trackPoint.Position.LongitudeDegrees));
                        recMesg.SetDistance((float)trackPoint.DistanceMeters);
                        recMesg.SetAltitude((float)trackPoint.AltitudeMeters);
                        //recMesg.SetSpeed((float)trackPoint.Extensions.Any["Speed"]);
                        if (trackPoint.HeartRateBpm != null)
                            recMesg.SetHeartRate((byte)trackPoint.HeartRateBpm.Value);

                        // Extension
                        if (trackPoint.Extensions.Any[0].GetElementsByTagName("ns3:RunCadence") != null)
                            if (trackPoint.Extensions.Any[0].GetElementsByTagName("ns3:RunCadence").Count == 1)
                            {
                                int cadence = 0;
                                int.TryParse((trackPoint.Extensions.Any[0].GetElementsByTagName("ns3:RunCadence")[0].InnerText), out cadence);
                                recMesg.SetCadence((byte)cadence);
                            }

                        if (trackPoint.Extensions.Any[0].GetElementsByTagName("ns3:Speed") != null)
                            if (trackPoint.Extensions.Any[0].GetElementsByTagName("ns3:Speed").Count == 1)
                            {
                                double speed = 0;
                                double.TryParse((trackPoint.Extensions.Any[0].GetElementsByTagName("ns3:Speed")[0].InnerText), out speed);
                                recMesg.SetSpeed((float)speed);
                            }

                        encoder.OnMesgDefinition(new MesgDefinition(recMesg));
                        encoder.OnMesg(recMesg);
                        Utils.LogMessage(LogType.Information, string.Format("Wrote RecMesg: {0}", recMesg.GetTimestamp().ToString()));
                    }

                    LapMesg lapMesg = new LapMesg();
                    lapMesg.SetTimestamp(new DateTime(lap.StartTime));
                    lapMesg.SetStartTime(new DateTime(lap.StartTime));
                    lapMesg.SetTotalMovingTime((float)lap.TotalTimeSeconds);
                    lapMesg.SetStartPositionLat(Utils.ConvertTcxLatLongToFit(lap.Track[0].Position.LatitudeDegrees));
                    lapMesg.SetStartPositionLong(Utils.ConvertTcxLatLongToFit(lap.Track[0].Position.LongitudeDegrees));
                    lapMesg.SetSport(Sport.Running);
                    lapMesg.SetSubSport(SubSport.Road);
                    // TODO: EndPosition
                    lapMesg.SetTotalElapsedTime((float)lap.TotalTimeSeconds);
                    totalTime += lap.TotalTimeSeconds;
                    // TODO: The rest

                    encoder.OnMesgDefinition(new MesgDefinition(lapMesg));
                    encoder.OnMesg(lapMesg);
                    Utils.LogMessage(LogType.Information, "Wrote LapMesg");
                }
            }

            // FIT Session: not found in tcx
            // FIT Activity
            ActivityMesg activityMesg = new ActivityMesg();
            activityMesg.SetTimestamp(new DateTime(db.Activities.Activity[0].Id));
            activityMesg.SetTotalTimerTime((float)totalTime);
            activityMesg.SetLocalTimestamp(new DateTime(db.Activities.Activity[0].Id).GetTimeStamp() + (uint)totalTime);
            activityMesg.SetNumSessions(1);
            activityMesg.SetType(Activity.Manual);
            activityMesg.SetEvent(Event.Activity);
            activityMesg.SetEventType(EventType.Stop);
            //activityMesg.SetTotalTimerTime(db.Activities.Activity[0].Training.);

            encoder.OnMesgDefinition(new MesgDefinition(activityMesg));
            encoder.OnMesg(activityMesg);
            Utils.LogMessage(LogType.Information, "Wrote ActivityMesg");

            // Update header datasize and file CRC
            encoder.Close();
            fitDest.Close();

            Console.WriteLine("Encoded FIT file " + outputFileName + ".fit");
        }
    }
}
