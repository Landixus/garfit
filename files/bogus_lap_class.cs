class Lap {
	TotalTimeSeconds
	DistanceMeters
	MaximumSpeed
	Calories
	AverageHeartRateBpm
	MaximumHeartRateBpm
	Intensity
	TriggerMethod = 2 // manual
	
	// extensions
	AvgSpeed
	AvgRunCadence
	MaxRunCadence
		
	public uint Timestamp; // = (tcx-date(1989,31,12))*86400
 public uint StartTime; // = (tcx-date(1989,31,12))*86400
 public uint StartPositionLat;	// = tcx*(2^31)/180
 public uint StartPositionLong;	// = tcx*(2^31)/180
 public uint EndPositionLat;	// = tcx*(2^31)/180
 public uint EndPositionLong;	// = tcx*(2^31)/180
 public float TotalElapsedTime; // from 
 public float TotalTimerTime;
 public int TotalDistance=1000;
 
 public Index0 TotalCycles"" Field#10) Value: 572 (raw value 572)
 
 public int TotalCalories"" Field#11) Value: 65 (raw value 65)	// calculate
 public float AvgSpeed"" Field#13) Value: 2.361 (raw value 2361)
 public float MaxSpeed"" Field#14) Value: 2.65 (raw value 2650)
 
 public float TotalAscent=0; //default
 public float TotalDescent=0; //default
 public int Event = 9;// default
 public int EventType=1;// default
 
 public int AvgHeartRate; // calculate from track
 public int MaxHeartRate; // calculate from track
 public int AvgCadence; // calculate from track
 public int MaxCadence; // calculate from track
 public int Sport=1;// default
 public int SubSport=0;// default
 
 public Index0 AvgFractionalCadence"" Field#80) Value: 0.015625 (raw value 2)
 public Index0 MaxFractionalCadence"" Field#81) Value: 0.5 (raw value 64)
 
 public int AvgCadencePosition=255; // default
 public int AvgCadencePosition=255; // default
 public int MaxCadencePosition=255; // default
 public int MaxCadencePosition=255; // default
 
 public Index0 EnhancedAvgSpeed"" Field#110) Value: 2.361 (raw value 2361)
 public Index0 EnhancedMaxSpeed"" Field#111) Value: 2.65 (raw value 2650)
}