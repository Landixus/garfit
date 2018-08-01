using System;
using System.Collections.Generic;
using System.Xml.Linq;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit.TCX
{
    public class TcxLoader
    {
        /// <summary>
        /// Load the Xml document for parsing
        /// </summary>
        /// <param name="sFile">Fully qualified file name (local)</param>
        /// <returns>XDocument</returns>
        private XDocument GetTcxDoc(string sFile)
        {
            XDocument tcxDoc = XDocument.Load(sFile);
            return tcxDoc;
        }

        /// <summary>
        /// Load the namespace for a standard GPX document
        /// </summary>
        /// <returns></returns>
        private XNamespace GetTcxNameSpace()
        {
            XNamespace tcx = XNamespace.Get("http://www.garmin.com/xmlschemas/TrainingCenterDatabasev2.xsd");
            return tcx;
        }

        internal static TcxActivity CreateTestData()
        {
            TcxActivity activity = new TcxActivity("2018-07-28T22:12:29.000Z");

            // create Lap1.
            TcxLap lap1 = new TcxLap();
            lap1.StartTime = TcxUtility.ToFitTime("2018-07-28T22:12:29.000Z");
            lap1.TotalTimeSeconds = 387;
            lap1.DistanceMeters = 1000;
            lap1.MaximumSpeed = 2.7060000896453853;
            lap1.Calories = 59;
            lap1.AverageHeartRateBpm = 130;
            lap1.MaximumHeartRateBpm = 139;
            lap1.Intensity = "Active";
            lap1.TriggerMethod = "Manual";

            // lap1.track1
            TcxTrack track1 = new TcxTrack();

            // create lap1.track1.trackPoint1
            TcxTrackPoint trackPoint1 = new TcxTrackPoint()
            {
                Timestamp = TcxUtility.ToFitTime("2018-07-28T22:12:29.000Z"),
                AltitudeMeters = 7.800000190734863,
                DistanceMeters = 1.659999966621399,
                HeartRateBpm = 88,
                Speed = 1.222000002861023,
                RunCadence = 56
            };
            trackPoint1.AddPosition(new TcxPosition()
            {
                LatitudeDegrees = 10.602569477632642,
                LongitudeDegrees = 107.5583509169519
            });

            // add trackpoint1 to track1
            track1.TrackPoints.Add(trackPoint1);

            // create lap1.track1.trackPoint2
            TcxTrackPoint trackPoint2 = new TcxTrackPoint()
            {
                Timestamp = TcxUtility.ToFitTime("2018-07-28T22:12:30.000Z"),
                AltitudeMeters = 6.800000190734863,
                DistanceMeters = 3.630000114440918,
                HeartRateBpm = 91,
                Speed = 1.1660000085830688,
                RunCadence = 56
            };
            trackPoint2.AddPosition(new TcxPosition()
            {
                LatitudeDegrees = 10.602549696341157,
                LongitudeDegrees = 107.55837748758495
            });

            // add trackpoint2 to track1
            track1.TrackPoints.Add(trackPoint2);

            // add track1 to lap1
            lap1.Tracks.Add(track1);

            // add lap to activity
            activity.Laps.Add(lap1);

            //  return
            return activity;
        }
    }
}
