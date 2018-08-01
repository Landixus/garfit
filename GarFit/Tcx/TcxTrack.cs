using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarFit.TCX
{
	public class TcxTrack
	{
		public double TotalTimeSeconds { get; }

		private List<TcxTrackPoint> trackPoints;

		public TcxTrack()
		{
			this.trackPoints = new List<TcxTrackPoint>();
		}

		public List<TcxTrackPoint> TrackPoints {
			get {
				return this.trackPoints;
			}
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
            
		}
	}
}
