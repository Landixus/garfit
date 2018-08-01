using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarFit.TCX
{
	public class TcxTrack
	{
		#region Fields
		private List<TcxTrackPoint> trackPoints = new List<TcxTrackPoint>();
		private uint startPositionLat = 0;
		private uint startPositionLong = 0;
		#endregion
		
		public double TotalTimeSeconds { get; }
		public uint StartPositionLat { get { return this.startPositionLat; } }
		public uint StartPositionLong { get { return this.startPositionLong; } }
		public List<TcxTrackPoint> TrackPoints { get { return this.trackPoints; } }

		/// <summary>
		/// Constructor
		/// </summary>
		public TcxTrack()		
		{
		}

		/// <summary>
		/// Add trackpoint 
		/// </summary>
		/// <param name="trackPoint"></param>
		public void AddTrackPoint(TcxTrackPoint trackPoint)
		{
			this.trackPoints.Add(trackPoint);
			this._calculate();
		}

		/// <summary>
		/// self calculate
		/// </summary>
		private void _calculate()
		{
			// assign startPosition lat & long
			if (this.trackPoints.Count() == 1 && this.trackPoints[0] != null) {
				if (this.trackPoints[0].Positions[0] != null) {
					TcxPosition startPosition = this.trackPoints[0].Positions[0];
					this.startPositionLat = (uint)startPosition.LatitudeDegrees;
					this.startPositionLong = (uint)startPosition.LongitudeDegrees;
				}
			}
		}
	}
}
