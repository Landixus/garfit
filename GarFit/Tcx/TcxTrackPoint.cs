using System.Collections.Generic;
using DateTime = Dynastream.Fit.DateTime;

namespace GarFit.TCX
{
    public class TcxTrackPoint
    {
        private List<TcxPosition> positions;

        public DateTime Timestamp { set; get; }
        public List<TcxPosition> Positions
        {
            get
            {
                return this.positions;
            }
        }
        public double AltitudeMeters { get; set; }
        public double DistanceMeters { get; set; }
        public int HeartRateBpm { get; set; }

        // start: extensions
        public double Speed { get; set; }
        public int RunCadence { get; set; }
        // end: extensions
        //public string SensorState { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public TcxTrackPoint()
        {
            this.positions = new List<TcxPosition>();
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
        private void _calculate() {
            // do nothing
        }
    }
}
