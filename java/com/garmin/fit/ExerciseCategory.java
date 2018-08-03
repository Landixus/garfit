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


package com.garmin.fit;

import java.util.HashMap;
import java.util.Map;

public class ExerciseCategory {
    public static final int BENCH_PRESS = 0;
    public static final int CALF_RAISE = 1;
    public static final int CARDIO = 2;
    public static final int CARRY = 3;
    public static final int CHOP = 4;
    public static final int CORE = 5;
    public static final int CRUNCH = 6;
    public static final int CURL = 7;
    public static final int DEADLIFT = 8;
    public static final int FLYE = 9;
    public static final int HIP_RAISE = 10;
    public static final int HIP_STABILITY = 11;
    public static final int HIP_SWING = 12;
    public static final int HYPEREXTENSION = 13;
    public static final int LATERAL_RAISE = 14;
    public static final int LEG_CURL = 15;
    public static final int LEG_RAISE = 16;
    public static final int LUNGE = 17;
    public static final int OLYMPIC_LIFT = 18;
    public static final int PLANK = 19;
    public static final int PLYO = 20;
    public static final int PULL_UP = 21;
    public static final int PUSH_UP = 22;
    public static final int ROW = 23;
    public static final int SHOULDER_PRESS = 24;
    public static final int SHOULDER_STABILITY = 25;
    public static final int SHRUG = 26;
    public static final int SIT_UP = 27;
    public static final int SQUAT = 28;
    public static final int TOTAL_BODY = 29;
    public static final int TRICEPS_EXTENSION = 30;
    public static final int WARM_UP = 31;
    public static final int RUN = 32;
    public static final int UNKNOWN = 65534;
    public static final int INVALID = Fit.UINT16_INVALID;

    private static final Map<Integer, String> stringMap;

    static {
        stringMap = new HashMap<Integer, String>();
        stringMap.put(BENCH_PRESS, "BENCH_PRESS");
        stringMap.put(CALF_RAISE, "CALF_RAISE");
        stringMap.put(CARDIO, "CARDIO");
        stringMap.put(CARRY, "CARRY");
        stringMap.put(CHOP, "CHOP");
        stringMap.put(CORE, "CORE");
        stringMap.put(CRUNCH, "CRUNCH");
        stringMap.put(CURL, "CURL");
        stringMap.put(DEADLIFT, "DEADLIFT");
        stringMap.put(FLYE, "FLYE");
        stringMap.put(HIP_RAISE, "HIP_RAISE");
        stringMap.put(HIP_STABILITY, "HIP_STABILITY");
        stringMap.put(HIP_SWING, "HIP_SWING");
        stringMap.put(HYPEREXTENSION, "HYPEREXTENSION");
        stringMap.put(LATERAL_RAISE, "LATERAL_RAISE");
        stringMap.put(LEG_CURL, "LEG_CURL");
        stringMap.put(LEG_RAISE, "LEG_RAISE");
        stringMap.put(LUNGE, "LUNGE");
        stringMap.put(OLYMPIC_LIFT, "OLYMPIC_LIFT");
        stringMap.put(PLANK, "PLANK");
        stringMap.put(PLYO, "PLYO");
        stringMap.put(PULL_UP, "PULL_UP");
        stringMap.put(PUSH_UP, "PUSH_UP");
        stringMap.put(ROW, "ROW");
        stringMap.put(SHOULDER_PRESS, "SHOULDER_PRESS");
        stringMap.put(SHOULDER_STABILITY, "SHOULDER_STABILITY");
        stringMap.put(SHRUG, "SHRUG");
        stringMap.put(SIT_UP, "SIT_UP");
        stringMap.put(SQUAT, "SQUAT");
        stringMap.put(TOTAL_BODY, "TOTAL_BODY");
        stringMap.put(TRICEPS_EXTENSION, "TRICEPS_EXTENSION");
        stringMap.put(WARM_UP, "WARM_UP");
        stringMap.put(RUN, "RUN");
        stringMap.put(UNKNOWN, "UNKNOWN");
    }


    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value, or empty if unknown
     */
    public static String getStringFromValue( Integer value ) {
        if( stringMap.containsKey( value ) ) {
            return stringMap.get( value );
        }

        return "";
    }

    /**
     * Retrieves a value given a string representation
     * @return The value or INVALID if unkwown
     */
    public static Integer getValueFromString( String value ) {
        for( Map.Entry<Integer, String> entry : stringMap.entrySet() ) {
            if( entry.getValue().equals( value ) ) {
                return entry.getKey();
            }
        }

        return INVALID;
    }

}
