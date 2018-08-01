using System;
using System.Collections.Generic;
using GarFit.TCX;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit.TCX
{
    public class TcxActivity
    {
    	// private fields
    	private DateTime id;
    	private uint timestamp;
    	private List<TcxLap> laps;        

    	public DateTime Id { get { return this.id; } }
    	public uint Timestamp { get {return this.timestamp; } }
        public double TotalTimerTime; // calculate
        public uint LocalTimestamp; // calculate
        public int NumSessions { get { return 1; } } // calculate but now let it = 1
        public int Type { get { return 0; } }
        public int Event { get { return 26; } }
        public int EventType { get { return 1; } } // default
        public List<TcxLap> Laps { get { return this.laps; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dateTimeString"></param>
        public TcxActivity(string dateTimeString)
        {
        	// create new List of laps
            this.laps = new List<TcxLap>();
            
            // init fields
            this.id = TcxUtility.ToFitTime(dateTimeString);
            this.timestamp = TcxUtility.ToFitTime(dateTimeString).GetTimeStamp();
            this.LocalTimestamp = this.Timestamp;
        }

        /// <summary>
        /// Add lap to LapCollections
        /// </summary>
        /// <param name="lap"></param>
        public void AddLap(TcxLap lap)
        {
            this.laps.Add(lap);
            this._calculate(lap);
        }

        /// <summary>
        /// Calculate the numbers after added new lap
        /// </summary>
        /// <param name="lap"></param>
        private void _calculate(TcxLap lap)
        {
            this.TotalTimerTime += lap.TotalTimeSeconds;
        }
    }
}
