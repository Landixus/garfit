using System.Collections.Generic;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit.TCX
{
	public class TcxTrackPoint
	{
		private uint timestamp;
		private List<TcxPosition> positions;

		public uint Timestamp { get { return this.timestamp; } }
		public List<TcxPosition> Positions { get { return this.positions; } }
		public double AltitudeMeters { get; set; }
		public double DistanceMeters { get; set; }
		public int HeartRateBpm { get; set; }

		//public string SensorState { get; set; }
		//Field1 Index0 ("PositionLat" Field#0) Value: 123811718 (raw value 123811718)
		//Field2 Index0 ("PositionLong" Field#1) Value: 1277884156 (raw value 1277884156)
		              
		// tcx::DistanceMeters
		public double Distance;
 
		// tcx::AltitudeMeters
		public double Altitude;
 
		// tcx::ext::Speed
		public double Speed;
 
		// tcx::ext::RunCadence
		public int RunCadence { get; set; }
 
		//Field8 Index0 ("HeartRate" Field#3) Value: 88 (raw value 88)
		//Field9 Index0 ("Cadence" Field#4) Value: 54 (raw value 54)
		//Field10 Index0 ("Temperature" Field#13) Value: 33 (raw value 33)
		//Field11 Index0 ("FractionalCadence" Field#53) Value: 0 (raw value 0)
		//Field12 Index0 ("EnhancedAltitude" Field#78) Value: 7.2 (raw value 2536)
		//Field13 Index0 ("EnhancedSpeed" Field#73) Value: 1.726 (raw value 1726)

		/// <summary>
		/// constructor
		/// </summary>
		public TcxTrackPoint(string dateTimeString)
		{
			this.positions = new List<TcxPosition>();
			this.timestamp = TcxUtility.ToFitTime(dateTimeString).GetTimeStamp();
		}

		/// <summary>
		/// add position to list
		/// </summary>
		/// <param name="position"></param>
		public void AddPosition(TcxPosition position)
		{
			this.positions.Add(position);
			this._calculate();
		}

		/// <summary>
		/// self calculate
		/// </summary>
		private void _calculate()
		{
			// do nothing
		}
	}
}
