using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.XPath;
using GarFit.TCX2;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit.TCX {
	public static class TcxLoader {		
		/*public static XmlDocument GetTcxDoc(string tcxFile) {
			try {
				var settings = new XmlReaderSettings();
				settings.Schemas.Add(@"http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2",
					@"http://www.garmin.com/xmlschemas/TrainingCenterDatabasev2.xsd");
				settings.ValidationType = ValidationType.Schema;
				
				XmlReader reader = XmlReader.Create(tcxFile, settings);
				var document = new XmlDocument();
				document.Load(reader);
				
				// validate document
				var eventHandler = new ValidationEventHandler(ValidationEventHandler);
				document.Validate(eventHandler);
				
				// close reader
				reader.Close();
				
				return document;
			} catch (Exception ex) {
				//Console.WriteLine(ex.Message);
				throw ex;
			}
		}*/
		
		

		internal static TcxActivity CreateTestData() {
			TcxActivity activity = new TcxActivity("2018-07-28T22:12:29.000Z");

			// create Lap1.
			TcxLap lap1 = new TcxLap("2018-07-28T22:12:29.000Z");
			lap1.DistanceMeters = 1000;
			lap1.MaximumSpeed = 2.7060000896453853;
			lap1.Calories = 59;
			lap1.AverageHeartRateBpm = 130;
			lap1.MaximumHeartRateBpm = 139;

			// lap1.track1
			TcxTrack track1 = new TcxTrack();

			// create lap1.track1.trackPoint1
			TcxTrackPoint trackPoint1 = new TcxTrackPoint("2018-07-28T22:12:29.000Z") {
				AltitudeMeters = 7.800000190734863,
				DistanceMeters = 1.659999966621399,
				HeartRateBpm = 88,
				Speed = 1.222000002861023,
				RunCadence = 56
			};
			trackPoint1.AddPosition(new TcxPosition(10.602569477632642, 107.5583509169519));

			// add trackpoint1 to track1
			track1.TrackPoints.Add(trackPoint1);

			// create lap1.track1.trackPoint2
			TcxTrackPoint trackPoint2 = new TcxTrackPoint("2018-07-28T22:12:30.000Z") {
				AltitudeMeters = 6.800000190734863,
				DistanceMeters = 3.630000114440918,
				HeartRateBpm = 91,
				Speed = 1.1660000085830688,
				RunCadence = 56
			};
			trackPoint2.AddPosition(new TcxPosition(10.602549696341157, 107.55837748758495));

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
