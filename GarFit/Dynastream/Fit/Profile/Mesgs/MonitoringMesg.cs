#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2018 Garmin Canada Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 20.67Release
// Tag = production/akw/20.67.00-0-g3059ce1
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the Monitoring profile message.
    /// </summary>
    public class MonitoringMesg : Mesg
    {
        #region Fields
        static class CyclesSubfield
        {
            public static ushort Steps = 0;
            public static ushort Strokes = 1;
            public static ushort Subfields = 2;
            public static ushort Active = Fit.SubfieldIndexActiveSubfield;
            public static ushort MainField = Fit.SubfieldIndexMainField;
        }
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="MonitoringMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Timestamp = 253;
            public const byte DeviceIndex = 0;
            public const byte Calories = 1;
            public const byte Distance = 2;
            public const byte Cycles = 3;
            public const byte ActiveTime = 4;
            public const byte ActivityType = 5;
            public const byte ActivitySubtype = 6;
            public const byte ActivityLevel = 7;
            public const byte Distance16 = 8;
            public const byte Cycles16 = 9;
            public const byte ActiveTime16 = 10;
            public const byte LocalTimestamp = 11;
            public const byte Temperature = 12;
            public const byte TemperatureMin = 14;
            public const byte TemperatureMax = 15;
            public const byte ActivityTime = 16;
            public const byte ActiveCalories = 19;
            public const byte CurrentActivityTypeIntensity = 24;
            public const byte TimestampMin8 = 25;
            public const byte Timestamp16 = 26;
            public const byte HeartRate = 27;
            public const byte Intensity = 28;
            public const byte DurationMin = 29;
            public const byte Duration = 30;
            public const byte Ascent = 31;
            public const byte Descent = 32;
            public const byte ModerateActivityMinutes = 33;
            public const byte VigorousActivityMinutes = 34;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public MonitoringMesg() : base(Profile.GetMesg(MesgNum.Monitoring))
        {
        }

        public MonitoringMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(253, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field
        /// Units: s
        /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DeviceIndex field
        /// Comment: Associates this data to device_info message.  Not required for file with single device (sensor).</summary>
        /// <returns>Returns nullable byte representing the DeviceIndex field</returns>
        public byte? GetDeviceIndex()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set DeviceIndex field
        /// Comment: Associates this data to device_info message.  Not required for file with single device (sensor).</summary>
        /// <param name="deviceIndex_">Nullable field value to be set</param>
        public void SetDeviceIndex(byte? deviceIndex_)
        {
            SetFieldValue(0, 0, deviceIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Calories field
        /// Units: kcal
        /// Comment: Accumulated total calories.  Maintained by MonitoringReader for each activity_type.  See SDK documentation</summary>
        /// <returns>Returns nullable ushort representing the Calories field</returns>
        public ushort? GetCalories()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Calories field
        /// Units: kcal
        /// Comment: Accumulated total calories.  Maintained by MonitoringReader for each activity_type.  See SDK documentation</summary>
        /// <param name="calories_">Nullable field value to be set</param>
        public void SetCalories(ushort? calories_)
        {
            SetFieldValue(1, 0, calories_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Distance field
        /// Units: m
        /// Comment: Accumulated distance.  Maintained by MonitoringReader for each activity_type.  See SDK documentation.</summary>
        /// <returns>Returns nullable float representing the Distance field</returns>
        public float? GetDistance()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Distance field
        /// Units: m
        /// Comment: Accumulated distance.  Maintained by MonitoringReader for each activity_type.  See SDK documentation.</summary>
        /// <param name="distance_">Nullable field value to be set</param>
        public void SetDistance(float? distance_)
        {
            SetFieldValue(2, 0, distance_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Cycles field
        /// Units: cycles
        /// Comment: Accumulated cycles.  Maintained by MonitoringReader for each activity_type.  See SDK documentation.</summary>
        /// <returns>Returns nullable float representing the Cycles field</returns>
        public float? GetCycles()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Cycles field
        /// Units: cycles
        /// Comment: Accumulated cycles.  Maintained by MonitoringReader for each activity_type.  See SDK documentation.</summary>
        /// <param name="cycles_">Nullable field value to be set</param>
        public void SetCycles(float? cycles_)
        {
            SetFieldValue(3, 0, cycles_, Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Retrieves the Steps subfield
        /// Units: steps</summary>
        /// <returns>Nullable uint representing the Steps subfield</returns>
        public uint? GetSteps()
        {
            Object val = GetFieldValue(3, 0, CyclesSubfield.Steps);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        ///
        /// Set Steps subfield
        /// Units: steps</summary>
        /// <param name="steps">Subfield value to be set</param>
        public void SetSteps(uint? steps)
        {
            SetFieldValue(3, 0, steps, CyclesSubfield.Steps);
        }

        /// <summary>
        /// Retrieves the Strokes subfield
        /// Units: strokes</summary>
        /// <returns>Nullable float representing the Strokes subfield</returns>
        public float? GetStrokes()
        {
            Object val = GetFieldValue(3, 0, CyclesSubfield.Strokes);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        ///
        /// Set Strokes subfield
        /// Units: strokes</summary>
        /// <param name="strokes">Subfield value to be set</param>
        public void SetStrokes(float? strokes)
        {
            SetFieldValue(3, 0, strokes, CyclesSubfield.Strokes);
        }
        ///<summary>
        /// Retrieves the ActiveTime field
        /// Units: s</summary>
        /// <returns>Returns nullable float representing the ActiveTime field</returns>
        public float? GetActiveTime()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set ActiveTime field
        /// Units: s</summary>
        /// <param name="activeTime_">Nullable field value to be set</param>
        public void SetActiveTime(float? activeTime_)
        {
            SetFieldValue(4, 0, activeTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivityType field</summary>
        /// <returns>Returns nullable ActivityType enum representing the ActivityType field</returns>
        public ActivityType? GetActivityType()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            ActivityType? value = obj == null ? (ActivityType?)null : (ActivityType)obj;
            return value;
        }

        /// <summary>
        /// Set ActivityType field</summary>
        /// <param name="activityType_">Nullable field value to be set</param>
        public void SetActivityType(ActivityType? activityType_)
        {
            SetFieldValue(5, 0, activityType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivitySubtype field</summary>
        /// <returns>Returns nullable ActivitySubtype enum representing the ActivitySubtype field</returns>
        public ActivitySubtype? GetActivitySubtype()
        {
            object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            ActivitySubtype? value = obj == null ? (ActivitySubtype?)null : (ActivitySubtype)obj;
            return value;
        }

        /// <summary>
        /// Set ActivitySubtype field</summary>
        /// <param name="activitySubtype_">Nullable field value to be set</param>
        public void SetActivitySubtype(ActivitySubtype? activitySubtype_)
        {
            SetFieldValue(6, 0, activitySubtype_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivityLevel field</summary>
        /// <returns>Returns nullable ActivityLevel enum representing the ActivityLevel field</returns>
        public ActivityLevel? GetActivityLevel()
        {
            object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            ActivityLevel? value = obj == null ? (ActivityLevel?)null : (ActivityLevel)obj;
            return value;
        }

        /// <summary>
        /// Set ActivityLevel field</summary>
        /// <param name="activityLevel_">Nullable field value to be set</param>
        public void SetActivityLevel(ActivityLevel? activityLevel_)
        {
            SetFieldValue(7, 0, activityLevel_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Distance16 field
        /// Units: 100 * m</summary>
        /// <returns>Returns nullable ushort representing the Distance16 field</returns>
        public ushort? GetDistance16()
        {
            Object val = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Distance16 field
        /// Units: 100 * m</summary>
        /// <param name="distance16_">Nullable field value to be set</param>
        public void SetDistance16(ushort? distance16_)
        {
            SetFieldValue(8, 0, distance16_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Cycles16 field
        /// Units: 2 * cycles (steps)</summary>
        /// <returns>Returns nullable ushort representing the Cycles16 field</returns>
        public ushort? GetCycles16()
        {
            Object val = GetFieldValue(9, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Cycles16 field
        /// Units: 2 * cycles (steps)</summary>
        /// <param name="cycles16_">Nullable field value to be set</param>
        public void SetCycles16(ushort? cycles16_)
        {
            SetFieldValue(9, 0, cycles16_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActiveTime16 field
        /// Units: s</summary>
        /// <returns>Returns nullable ushort representing the ActiveTime16 field</returns>
        public ushort? GetActiveTime16()
        {
            Object val = GetFieldValue(10, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ActiveTime16 field
        /// Units: s</summary>
        /// <param name="activeTime16_">Nullable field value to be set</param>
        public void SetActiveTime16(ushort? activeTime16_)
        {
            SetFieldValue(10, 0, activeTime16_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LocalTimestamp field
        /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
        /// <returns>Returns nullable uint representing the LocalTimestamp field</returns>
        public uint? GetLocalTimestamp()
        {
            Object val = GetFieldValue(11, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set LocalTimestamp field
        /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
        /// <param name="localTimestamp_">Nullable field value to be set</param>
        public void SetLocalTimestamp(uint? localTimestamp_)
        {
            SetFieldValue(11, 0, localTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Temperature field
        /// Units: C
        /// Comment: Avg temperature during the logging interval ended at timestamp</summary>
        /// <returns>Returns nullable float representing the Temperature field</returns>
        public float? GetTemperature()
        {
            Object val = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Temperature field
        /// Units: C
        /// Comment: Avg temperature during the logging interval ended at timestamp</summary>
        /// <param name="temperature_">Nullable field value to be set</param>
        public void SetTemperature(float? temperature_)
        {
            SetFieldValue(12, 0, temperature_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TemperatureMin field
        /// Units: C
        /// Comment: Min temperature during the logging interval ended at timestamp</summary>
        /// <returns>Returns nullable float representing the TemperatureMin field</returns>
        public float? GetTemperatureMin()
        {
            Object val = GetFieldValue(14, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TemperatureMin field
        /// Units: C
        /// Comment: Min temperature during the logging interval ended at timestamp</summary>
        /// <param name="temperatureMin_">Nullable field value to be set</param>
        public void SetTemperatureMin(float? temperatureMin_)
        {
            SetFieldValue(14, 0, temperatureMin_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TemperatureMax field
        /// Units: C
        /// Comment: Max temperature during the logging interval ended at timestamp</summary>
        /// <returns>Returns nullable float representing the TemperatureMax field</returns>
        public float? GetTemperatureMax()
        {
            Object val = GetFieldValue(15, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TemperatureMax field
        /// Units: C
        /// Comment: Max temperature during the logging interval ended at timestamp</summary>
        /// <param name="temperatureMax_">Nullable field value to be set</param>
        public void SetTemperatureMax(float? temperatureMax_)
        {
            SetFieldValue(15, 0, temperatureMax_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field ActivityTime</returns>
        public int GetNumActivityTime()
        {
            return GetNumFieldValues(16, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the ActivityTime field
        /// Units: minutes
        /// Comment: Indexed using minute_activity_level enum</summary>
        /// <param name="index">0 based index of ActivityTime element to retrieve</param>
        /// <returns>Returns nullable ushort representing the ActivityTime field</returns>
        public ushort? GetActivityTime(int index)
        {
            Object val = GetFieldValue(16, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ActivityTime field
        /// Units: minutes
        /// Comment: Indexed using minute_activity_level enum</summary>
        /// <param name="index">0 based index of activity_time</param>
        /// <param name="activityTime_">Nullable field value to be set</param>
        public void SetActivityTime(int index, ushort? activityTime_)
        {
            SetFieldValue(16, index, activityTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActiveCalories field
        /// Units: kcal</summary>
        /// <returns>Returns nullable ushort representing the ActiveCalories field</returns>
        public ushort? GetActiveCalories()
        {
            Object val = GetFieldValue(19, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ActiveCalories field
        /// Units: kcal</summary>
        /// <param name="activeCalories_">Nullable field value to be set</param>
        public void SetActiveCalories(ushort? activeCalories_)
        {
            SetFieldValue(19, 0, activeCalories_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the CurrentActivityTypeIntensity field
        /// Comment: Indicates single type / intensity for duration since last monitoring message.</summary>
        /// <returns>Returns nullable byte representing the CurrentActivityTypeIntensity field</returns>
        public byte? GetCurrentActivityTypeIntensity()
        {
            Object val = GetFieldValue(24, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set CurrentActivityTypeIntensity field
        /// Comment: Indicates single type / intensity for duration since last monitoring message.</summary>
        /// <param name="currentActivityTypeIntensity_">Nullable field value to be set</param>
        public void SetCurrentActivityTypeIntensity(byte? currentActivityTypeIntensity_)
        {
            SetFieldValue(24, 0, currentActivityTypeIntensity_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMin8 field
        /// Units: min</summary>
        /// <returns>Returns nullable byte representing the TimestampMin8 field</returns>
        public byte? GetTimestampMin8()
        {
            Object val = GetFieldValue(25, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set TimestampMin8 field
        /// Units: min</summary>
        /// <param name="timestampMin8_">Nullable field value to be set</param>
        public void SetTimestampMin8(byte? timestampMin8_)
        {
            SetFieldValue(25, 0, timestampMin8_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Timestamp16 field
        /// Units: s</summary>
        /// <returns>Returns nullable ushort representing the Timestamp16 field</returns>
        public ushort? GetTimestamp16()
        {
            Object val = GetFieldValue(26, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set Timestamp16 field
        /// Units: s</summary>
        /// <param name="timestamp16_">Nullable field value to be set</param>
        public void SetTimestamp16(ushort? timestamp16_)
        {
            SetFieldValue(26, 0, timestamp16_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the HeartRate field
        /// Units: bpm</summary>
        /// <returns>Returns nullable byte representing the HeartRate field</returns>
        public byte? GetHeartRate()
        {
            Object val = GetFieldValue(27, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set HeartRate field
        /// Units: bpm</summary>
        /// <param name="heartRate_">Nullable field value to be set</param>
        public void SetHeartRate(byte? heartRate_)
        {
            SetFieldValue(27, 0, heartRate_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Intensity field</summary>
        /// <returns>Returns nullable float representing the Intensity field</returns>
        public float? GetIntensity()
        {
            Object val = GetFieldValue(28, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Intensity field</summary>
        /// <param name="intensity_">Nullable field value to be set</param>
        public void SetIntensity(float? intensity_)
        {
            SetFieldValue(28, 0, intensity_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DurationMin field
        /// Units: min</summary>
        /// <returns>Returns nullable ushort representing the DurationMin field</returns>
        public ushort? GetDurationMin()
        {
            Object val = GetFieldValue(29, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set DurationMin field
        /// Units: min</summary>
        /// <param name="durationMin_">Nullable field value to be set</param>
        public void SetDurationMin(ushort? durationMin_)
        {
            SetFieldValue(29, 0, durationMin_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Duration field
        /// Units: s</summary>
        /// <returns>Returns nullable uint representing the Duration field</returns>
        public uint? GetDuration()
        {
            Object val = GetFieldValue(30, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Duration field
        /// Units: s</summary>
        /// <param name="duration_">Nullable field value to be set</param>
        public void SetDuration(uint? duration_)
        {
            SetFieldValue(30, 0, duration_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Ascent field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Ascent field</returns>
        public float? GetAscent()
        {
            Object val = GetFieldValue(31, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Ascent field
        /// Units: m</summary>
        /// <param name="ascent_">Nullable field value to be set</param>
        public void SetAscent(float? ascent_)
        {
            SetFieldValue(31, 0, ascent_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Descent field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Descent field</returns>
        public float? GetDescent()
        {
            Object val = GetFieldValue(32, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Descent field
        /// Units: m</summary>
        /// <param name="descent_">Nullable field value to be set</param>
        public void SetDescent(float? descent_)
        {
            SetFieldValue(32, 0, descent_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ModerateActivityMinutes field
        /// Units: minutes</summary>
        /// <returns>Returns nullable ushort representing the ModerateActivityMinutes field</returns>
        public ushort? GetModerateActivityMinutes()
        {
            Object val = GetFieldValue(33, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set ModerateActivityMinutes field
        /// Units: minutes</summary>
        /// <param name="moderateActivityMinutes_">Nullable field value to be set</param>
        public void SetModerateActivityMinutes(ushort? moderateActivityMinutes_)
        {
            SetFieldValue(33, 0, moderateActivityMinutes_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the VigorousActivityMinutes field
        /// Units: minutes</summary>
        /// <returns>Returns nullable ushort representing the VigorousActivityMinutes field</returns>
        public ushort? GetVigorousActivityMinutes()
        {
            Object val = GetFieldValue(34, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set VigorousActivityMinutes field
        /// Units: minutes</summary>
        /// <param name="vigorousActivityMinutes_">Nullable field value to be set</param>
        public void SetVigorousActivityMinutes(ushort? vigorousActivityMinutes_)
        {
            SetFieldValue(34, 0, vigorousActivityMinutes_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
