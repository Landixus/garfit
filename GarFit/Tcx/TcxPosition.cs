using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitLatitudeDegrees = System.UInt32;
using FitLongtitudeDegrees = System.UInt32;

namespace GarFit.TCX
{
	public class TcxPosition
	{
		private FitLatitudeDegrees latitudeDegrees;
		private FitLongtitudeDegrees longitudeDegrees;
		
		public FitLatitudeDegrees LatitudeDegrees { get { return this.latitudeDegrees; } }
		public FitLongtitudeDegrees LongitudeDegrees { get { return this.longitudeDegrees; } }
		
		public TcxPosition(double tcxLat, double tcxLong)
		{
			this.latitudeDegrees = (uint)(tcxLat * (2 ^ 31) / 180);
			this.longitudeDegrees = (uint)(tcxLong * (2 ^ 31) / 180);
		}
	}
}
