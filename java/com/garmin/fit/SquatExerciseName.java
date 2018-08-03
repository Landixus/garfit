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

public class SquatExerciseName {
    public static final int LEG_PRESS = 0;
    public static final int BACK_SQUAT_WITH_BODY_BAR = 1;
    public static final int BACK_SQUATS = 2;
    public static final int WEIGHTED_BACK_SQUATS = 3;
    public static final int BALANCING_SQUAT = 4;
    public static final int WEIGHTED_BALANCING_SQUAT = 5;
    public static final int BARBELL_BACK_SQUAT = 6;
    public static final int BARBELL_BOX_SQUAT = 7;
    public static final int BARBELL_FRONT_SQUAT = 8;
    public static final int BARBELL_HACK_SQUAT = 9;
    public static final int BARBELL_HANG_SQUAT_SNATCH = 10;
    public static final int BARBELL_LATERAL_STEP_UP = 11;
    public static final int BARBELL_QUARTER_SQUAT = 12;
    public static final int BARBELL_SIFF_SQUAT = 13;
    public static final int BARBELL_SQUAT_SNATCH = 14;
    public static final int BARBELL_SQUAT_WITH_HEELS_RAISED = 15;
    public static final int BARBELL_STEPOVER = 16;
    public static final int BARBELL_STEP_UP = 17;
    public static final int BENCH_SQUAT_WITH_ROTATIONAL_CHOP = 18;
    public static final int WEIGHTED_BENCH_SQUAT_WITH_ROTATIONAL_CHOP = 19;
    public static final int BODY_WEIGHT_WALL_SQUAT = 20;
    public static final int WEIGHTED_WALL_SQUAT = 21;
    public static final int BOX_STEP_SQUAT = 22;
    public static final int WEIGHTED_BOX_STEP_SQUAT = 23;
    public static final int BRACED_SQUAT = 24;
    public static final int CROSSED_ARM_BARBELL_FRONT_SQUAT = 25;
    public static final int CROSSOVER_DUMBBELL_STEP_UP = 26;
    public static final int DUMBBELL_FRONT_SQUAT = 27;
    public static final int DUMBBELL_SPLIT_SQUAT = 28;
    public static final int DUMBBELL_SQUAT = 29;
    public static final int DUMBBELL_SQUAT_CLEAN = 30;
    public static final int DUMBBELL_STEPOVER = 31;
    public static final int DUMBBELL_STEP_UP = 32;
    public static final int ELEVATED_SINGLE_LEG_SQUAT = 33;
    public static final int WEIGHTED_ELEVATED_SINGLE_LEG_SQUAT = 34;
    public static final int FIGURE_FOUR_SQUATS = 35;
    public static final int WEIGHTED_FIGURE_FOUR_SQUATS = 36;
    public static final int GOBLET_SQUAT = 37;
    public static final int KETTLEBELL_SQUAT = 38;
    public static final int KETTLEBELL_SWING_OVERHEAD = 39;
    public static final int KETTLEBELL_SWING_WITH_FLIP_TO_SQUAT = 40;
    public static final int LATERAL_DUMBBELL_STEP_UP = 41;
    public static final int ONE_LEGGED_SQUAT = 42;
    public static final int OVERHEAD_DUMBBELL_SQUAT = 43;
    public static final int OVERHEAD_SQUAT = 44;
    public static final int PARTIAL_SINGLE_LEG_SQUAT = 45;
    public static final int WEIGHTED_PARTIAL_SINGLE_LEG_SQUAT = 46;
    public static final int PISTOL_SQUAT = 47;
    public static final int WEIGHTED_PISTOL_SQUAT = 48;
    public static final int PLIE_SLIDES = 49;
    public static final int WEIGHTED_PLIE_SLIDES = 50;
    public static final int PLIE_SQUAT = 51;
    public static final int WEIGHTED_PLIE_SQUAT = 52;
    public static final int PRISONER_SQUAT = 53;
    public static final int WEIGHTED_PRISONER_SQUAT = 54;
    public static final int SINGLE_LEG_BENCH_GET_UP = 55;
    public static final int WEIGHTED_SINGLE_LEG_BENCH_GET_UP = 56;
    public static final int SINGLE_LEG_BENCH_SQUAT = 57;
    public static final int WEIGHTED_SINGLE_LEG_BENCH_SQUAT = 58;
    public static final int SINGLE_LEG_SQUAT_ON_SWISS_BALL = 59;
    public static final int WEIGHTED_SINGLE_LEG_SQUAT_ON_SWISS_BALL = 60;
    public static final int SQUAT = 61;
    public static final int WEIGHTED_SQUAT = 62;
    public static final int SQUATS_WITH_BAND = 63;
    public static final int STAGGERED_SQUAT = 64;
    public static final int WEIGHTED_STAGGERED_SQUAT = 65;
    public static final int STEP_UP = 66;
    public static final int WEIGHTED_STEP_UP = 67;
    public static final int SUITCASE_SQUATS = 68;
    public static final int SUMO_SQUAT = 69;
    public static final int SUMO_SQUAT_SLIDE_IN = 70;
    public static final int WEIGHTED_SUMO_SQUAT_SLIDE_IN = 71;
    public static final int SUMO_SQUAT_TO_HIGH_PULL = 72;
    public static final int SUMO_SQUAT_TO_STAND = 73;
    public static final int WEIGHTED_SUMO_SQUAT_TO_STAND = 74;
    public static final int SUMO_SQUAT_WITH_ROTATION = 75;
    public static final int WEIGHTED_SUMO_SQUAT_WITH_ROTATION = 76;
    public static final int SWISS_BALL_BODY_WEIGHT_WALL_SQUAT = 77;
    public static final int WEIGHTED_SWISS_BALL_WALL_SQUAT = 78;
    public static final int THRUSTERS = 79;
    public static final int UNEVEN_SQUAT = 80;
    public static final int WEIGHTED_UNEVEN_SQUAT = 81;
    public static final int WAIST_SLIMMING_SQUAT = 82;
    public static final int WALL_BALL = 83;
    public static final int WIDE_STANCE_BARBELL_SQUAT = 84;
    public static final int WIDE_STANCE_GOBLET_SQUAT = 85;
    public static final int ZERCHER_SQUAT = 86;
    public static final int INVALID = Fit.UINT16_INVALID;

    private static final Map<Integer, String> stringMap;

    static {
        stringMap = new HashMap<Integer, String>();
        stringMap.put(LEG_PRESS, "LEG_PRESS");
        stringMap.put(BACK_SQUAT_WITH_BODY_BAR, "BACK_SQUAT_WITH_BODY_BAR");
        stringMap.put(BACK_SQUATS, "BACK_SQUATS");
        stringMap.put(WEIGHTED_BACK_SQUATS, "WEIGHTED_BACK_SQUATS");
        stringMap.put(BALANCING_SQUAT, "BALANCING_SQUAT");
        stringMap.put(WEIGHTED_BALANCING_SQUAT, "WEIGHTED_BALANCING_SQUAT");
        stringMap.put(BARBELL_BACK_SQUAT, "BARBELL_BACK_SQUAT");
        stringMap.put(BARBELL_BOX_SQUAT, "BARBELL_BOX_SQUAT");
        stringMap.put(BARBELL_FRONT_SQUAT, "BARBELL_FRONT_SQUAT");
        stringMap.put(BARBELL_HACK_SQUAT, "BARBELL_HACK_SQUAT");
        stringMap.put(BARBELL_HANG_SQUAT_SNATCH, "BARBELL_HANG_SQUAT_SNATCH");
        stringMap.put(BARBELL_LATERAL_STEP_UP, "BARBELL_LATERAL_STEP_UP");
        stringMap.put(BARBELL_QUARTER_SQUAT, "BARBELL_QUARTER_SQUAT");
        stringMap.put(BARBELL_SIFF_SQUAT, "BARBELL_SIFF_SQUAT");
        stringMap.put(BARBELL_SQUAT_SNATCH, "BARBELL_SQUAT_SNATCH");
        stringMap.put(BARBELL_SQUAT_WITH_HEELS_RAISED, "BARBELL_SQUAT_WITH_HEELS_RAISED");
        stringMap.put(BARBELL_STEPOVER, "BARBELL_STEPOVER");
        stringMap.put(BARBELL_STEP_UP, "BARBELL_STEP_UP");
        stringMap.put(BENCH_SQUAT_WITH_ROTATIONAL_CHOP, "BENCH_SQUAT_WITH_ROTATIONAL_CHOP");
        stringMap.put(WEIGHTED_BENCH_SQUAT_WITH_ROTATIONAL_CHOP, "WEIGHTED_BENCH_SQUAT_WITH_ROTATIONAL_CHOP");
        stringMap.put(BODY_WEIGHT_WALL_SQUAT, "BODY_WEIGHT_WALL_SQUAT");
        stringMap.put(WEIGHTED_WALL_SQUAT, "WEIGHTED_WALL_SQUAT");
        stringMap.put(BOX_STEP_SQUAT, "BOX_STEP_SQUAT");
        stringMap.put(WEIGHTED_BOX_STEP_SQUAT, "WEIGHTED_BOX_STEP_SQUAT");
        stringMap.put(BRACED_SQUAT, "BRACED_SQUAT");
        stringMap.put(CROSSED_ARM_BARBELL_FRONT_SQUAT, "CROSSED_ARM_BARBELL_FRONT_SQUAT");
        stringMap.put(CROSSOVER_DUMBBELL_STEP_UP, "CROSSOVER_DUMBBELL_STEP_UP");
        stringMap.put(DUMBBELL_FRONT_SQUAT, "DUMBBELL_FRONT_SQUAT");
        stringMap.put(DUMBBELL_SPLIT_SQUAT, "DUMBBELL_SPLIT_SQUAT");
        stringMap.put(DUMBBELL_SQUAT, "DUMBBELL_SQUAT");
        stringMap.put(DUMBBELL_SQUAT_CLEAN, "DUMBBELL_SQUAT_CLEAN");
        stringMap.put(DUMBBELL_STEPOVER, "DUMBBELL_STEPOVER");
        stringMap.put(DUMBBELL_STEP_UP, "DUMBBELL_STEP_UP");
        stringMap.put(ELEVATED_SINGLE_LEG_SQUAT, "ELEVATED_SINGLE_LEG_SQUAT");
        stringMap.put(WEIGHTED_ELEVATED_SINGLE_LEG_SQUAT, "WEIGHTED_ELEVATED_SINGLE_LEG_SQUAT");
        stringMap.put(FIGURE_FOUR_SQUATS, "FIGURE_FOUR_SQUATS");
        stringMap.put(WEIGHTED_FIGURE_FOUR_SQUATS, "WEIGHTED_FIGURE_FOUR_SQUATS");
        stringMap.put(GOBLET_SQUAT, "GOBLET_SQUAT");
        stringMap.put(KETTLEBELL_SQUAT, "KETTLEBELL_SQUAT");
        stringMap.put(KETTLEBELL_SWING_OVERHEAD, "KETTLEBELL_SWING_OVERHEAD");
        stringMap.put(KETTLEBELL_SWING_WITH_FLIP_TO_SQUAT, "KETTLEBELL_SWING_WITH_FLIP_TO_SQUAT");
        stringMap.put(LATERAL_DUMBBELL_STEP_UP, "LATERAL_DUMBBELL_STEP_UP");
        stringMap.put(ONE_LEGGED_SQUAT, "ONE_LEGGED_SQUAT");
        stringMap.put(OVERHEAD_DUMBBELL_SQUAT, "OVERHEAD_DUMBBELL_SQUAT");
        stringMap.put(OVERHEAD_SQUAT, "OVERHEAD_SQUAT");
        stringMap.put(PARTIAL_SINGLE_LEG_SQUAT, "PARTIAL_SINGLE_LEG_SQUAT");
        stringMap.put(WEIGHTED_PARTIAL_SINGLE_LEG_SQUAT, "WEIGHTED_PARTIAL_SINGLE_LEG_SQUAT");
        stringMap.put(PISTOL_SQUAT, "PISTOL_SQUAT");
        stringMap.put(WEIGHTED_PISTOL_SQUAT, "WEIGHTED_PISTOL_SQUAT");
        stringMap.put(PLIE_SLIDES, "PLIE_SLIDES");
        stringMap.put(WEIGHTED_PLIE_SLIDES, "WEIGHTED_PLIE_SLIDES");
        stringMap.put(PLIE_SQUAT, "PLIE_SQUAT");
        stringMap.put(WEIGHTED_PLIE_SQUAT, "WEIGHTED_PLIE_SQUAT");
        stringMap.put(PRISONER_SQUAT, "PRISONER_SQUAT");
        stringMap.put(WEIGHTED_PRISONER_SQUAT, "WEIGHTED_PRISONER_SQUAT");
        stringMap.put(SINGLE_LEG_BENCH_GET_UP, "SINGLE_LEG_BENCH_GET_UP");
        stringMap.put(WEIGHTED_SINGLE_LEG_BENCH_GET_UP, "WEIGHTED_SINGLE_LEG_BENCH_GET_UP");
        stringMap.put(SINGLE_LEG_BENCH_SQUAT, "SINGLE_LEG_BENCH_SQUAT");
        stringMap.put(WEIGHTED_SINGLE_LEG_BENCH_SQUAT, "WEIGHTED_SINGLE_LEG_BENCH_SQUAT");
        stringMap.put(SINGLE_LEG_SQUAT_ON_SWISS_BALL, "SINGLE_LEG_SQUAT_ON_SWISS_BALL");
        stringMap.put(WEIGHTED_SINGLE_LEG_SQUAT_ON_SWISS_BALL, "WEIGHTED_SINGLE_LEG_SQUAT_ON_SWISS_BALL");
        stringMap.put(SQUAT, "SQUAT");
        stringMap.put(WEIGHTED_SQUAT, "WEIGHTED_SQUAT");
        stringMap.put(SQUATS_WITH_BAND, "SQUATS_WITH_BAND");
        stringMap.put(STAGGERED_SQUAT, "STAGGERED_SQUAT");
        stringMap.put(WEIGHTED_STAGGERED_SQUAT, "WEIGHTED_STAGGERED_SQUAT");
        stringMap.put(STEP_UP, "STEP_UP");
        stringMap.put(WEIGHTED_STEP_UP, "WEIGHTED_STEP_UP");
        stringMap.put(SUITCASE_SQUATS, "SUITCASE_SQUATS");
        stringMap.put(SUMO_SQUAT, "SUMO_SQUAT");
        stringMap.put(SUMO_SQUAT_SLIDE_IN, "SUMO_SQUAT_SLIDE_IN");
        stringMap.put(WEIGHTED_SUMO_SQUAT_SLIDE_IN, "WEIGHTED_SUMO_SQUAT_SLIDE_IN");
        stringMap.put(SUMO_SQUAT_TO_HIGH_PULL, "SUMO_SQUAT_TO_HIGH_PULL");
        stringMap.put(SUMO_SQUAT_TO_STAND, "SUMO_SQUAT_TO_STAND");
        stringMap.put(WEIGHTED_SUMO_SQUAT_TO_STAND, "WEIGHTED_SUMO_SQUAT_TO_STAND");
        stringMap.put(SUMO_SQUAT_WITH_ROTATION, "SUMO_SQUAT_WITH_ROTATION");
        stringMap.put(WEIGHTED_SUMO_SQUAT_WITH_ROTATION, "WEIGHTED_SUMO_SQUAT_WITH_ROTATION");
        stringMap.put(SWISS_BALL_BODY_WEIGHT_WALL_SQUAT, "SWISS_BALL_BODY_WEIGHT_WALL_SQUAT");
        stringMap.put(WEIGHTED_SWISS_BALL_WALL_SQUAT, "WEIGHTED_SWISS_BALL_WALL_SQUAT");
        stringMap.put(THRUSTERS, "THRUSTERS");
        stringMap.put(UNEVEN_SQUAT, "UNEVEN_SQUAT");
        stringMap.put(WEIGHTED_UNEVEN_SQUAT, "WEIGHTED_UNEVEN_SQUAT");
        stringMap.put(WAIST_SLIMMING_SQUAT, "WAIST_SLIMMING_SQUAT");
        stringMap.put(WALL_BALL, "WALL_BALL");
        stringMap.put(WIDE_STANCE_BARBELL_SQUAT, "WIDE_STANCE_BARBELL_SQUAT");
        stringMap.put(WIDE_STANCE_GOBLET_SQUAT, "WIDE_STANCE_GOBLET_SQUAT");
        stringMap.put(ZERCHER_SQUAT, "ZERCHER_SQUAT");
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
