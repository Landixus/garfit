﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = Dynastream.Fit.DateTime;
using SysDateTime = System.DateTime;

using FitLatitudeDegrees = System.UInt32;
using FitLongtitudeDegrees = System.UInt32;

namespace GarFit.TCX
{
	public class TcxLap
	{
		#region Fields
		private uint timestamp;
		private DateTime startTime;
		private List<TcxTrack> tracks;
		private double totalTimeSeconds = 0;

		private FitLatitudeDegrees startPositionLat;
		private FitLongtitudeDegrees startPositionLong;
		#endregion
		
		public uint Timestamp { get { return this.timestamp; } }
		public DateTime StartTime { get { return this.startTime; } }
		public double TotalTimeSeconds { get { return this.totalTimeSeconds; } }
		public double DistanceMeters { set; get; }
		public double MaximumSpeed { set; get; }
		public int Calories { set; get; }
		public int AverageHeartRateBpm { set; get; }
		public int MaximumHeartRateBpm { set; get; }
		public string Intensity { set; get; }
		public int TriggerMethod { get { return 2; } }

		// start: extensions
		public double AvgSpeed { set; get; }
		public int AvgRunCadence { set; get; }
		public int MaxRunCadence { set; get; }
		//  end: extensions
		
		
		public FitLatitudeDegrees StartPositionLat { get { return this.startPositionLat; } }
		public FitLongtitudeDegrees StartPositionLong{ get { return this.startPositionLong; } }
		
		// = tcx*(2^31)/180
		public uint EndPositionLat;
		// = tcx*(2^31)/180
		public uint EndPositionLong;
		// = tcx*(2^31)/180
		public float TotalElapsedTime;
		// from
		public float TotalTimerTime;
		public int TotalDistance = 1000;
 
		//public Index0 TotalCycles"" Field#10) Value: 572 (raw value 572)
		//
		//public int TotalCalories"" Field#11) Value: 65 (raw value 65)	// calculate
		//public float AvgSpeed"" Field#13) Value: 2.361 (raw value 2361)
		//public float MaxSpeed"" Field#14) Value: 2.65 (raw value 2650)
 
		// default
		public float TotalAscent = 0;
		//default
		public float TotalDescent = 0;
		//default
		public int Event = 9;
		// default
		public int EventType = 1;
		
		// calculate from track
		public int AvgHeartRate;
		// calculate from track
		public int MaxHeartRate;
		// calculate from track
		public int AvgCadence;
		// calculate from track
		public int MaxCadence;
		
		public int Sport = 1;
		// default
		public int SubSport = 0;
		// default
 
		//public Index0 AvgFractionalCadence"" Field#80) Value: 0.015625 (raw value 2)
		//public Index0 MaxFractionalCadence"" Field#81) Value: 0.5 (raw value 64)
 
		public int AvgCadencePosition = 255;
		// default
		public int MaxCadencePosition = 255;
		// default
 
		//public Index0 EnhancedAvgSpeed"" Field#110) Value: 2.361 (raw value 2361)
		//public Index0 EnhancedMaxSpeed"" Field#111) Value: 2.65 (raw value 2650)

		public List<TcxTrack> Tracks { get { return this.tracks; } }
		
		#region Field Accessor
		#endregion

		/// <summary>
		/// constructor
		/// </summary>
		public TcxLap(string dateTimeString)
		{
			// init list of tracks
			this.tracks = new List<TcxTrack>();
			
			// init fields
			this.startTime = TcxUtility.ToFitTime(dateTimeString);
			this.timestamp = this.startTime.GetTimeStamp();
		}

		/// <summary>
		/// Add track to list
		/// </summary>
		/// <param name="track"></param>
		public void AddTrack(TcxTrack track)
		{
			this.tracks.Add(track);
			this._calculate();
		}

		/// <summary>
		/// self calculate
		/// </summary>
		void _calculate()
		{
			// get first track and last track
			TcxTrack firstTrack = null;
			TcxTrack lastTrack = null;
			
			//	if there is only 1 track
			if (this.tracks.Count() == 1) {
				firstTrack = this.tracks[0];
				lastTrack = this.tracks[0];
			} else {
				firstTrack = this.tracks[0];
				lastTrack = this.tracks[this.tracks.Count() - 1];
			}
			
			// calculate totalTimeSeconds from lastTrack
			this.totalTimeSeconds += lastTrack.TotalTimeSeconds;
			
			// assign startPosition Lat & Long
			if (this.tracks.Count() == 1) {
				this.startPositionLat = firstTrack.StartPositionLat;
				this.startPositionLong = firstTrack.StartPositionLong;
			}
			
			// TODO: assign lastPosition Lat & Long
			
		}
	}
}
