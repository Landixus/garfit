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


public enum TurnType {
    ARRIVING_IDX((short)0),
    ARRIVING_LEFT_IDX((short)1),
    ARRIVING_RIGHT_IDX((short)2),
    ARRIVING_VIA_IDX((short)3),
    ARRIVING_VIA_LEFT_IDX((short)4),
    ARRIVING_VIA_RIGHT_IDX((short)5),
    BEAR_KEEP_LEFT_IDX((short)6),
    BEAR_KEEP_RIGHT_IDX((short)7),
    CONTINUE_IDX((short)8),
    EXIT_LEFT_IDX((short)9),
    EXIT_RIGHT_IDX((short)10),
    FERRY_IDX((short)11),
    ROUNDABOUT_45_IDX((short)12),
    ROUNDABOUT_90_IDX((short)13),
    ROUNDABOUT_135_IDX((short)14),
    ROUNDABOUT_180_IDX((short)15),
    ROUNDABOUT_225_IDX((short)16),
    ROUNDABOUT_270_IDX((short)17),
    ROUNDABOUT_315_IDX((short)18),
    ROUNDABOUT_360_IDX((short)19),
    ROUNDABOUT_NEG_45_IDX((short)20),
    ROUNDABOUT_NEG_90_IDX((short)21),
    ROUNDABOUT_NEG_135_IDX((short)22),
    ROUNDABOUT_NEG_180_IDX((short)23),
    ROUNDABOUT_NEG_225_IDX((short)24),
    ROUNDABOUT_NEG_270_IDX((short)25),
    ROUNDABOUT_NEG_315_IDX((short)26),
    ROUNDABOUT_NEG_360_IDX((short)27),
    ROUNDABOUT_GENERIC_IDX((short)28),
    ROUNDABOUT_NEG_GENERIC_IDX((short)29),
    SHARP_TURN_LEFT_IDX((short)30),
    SHARP_TURN_RIGHT_IDX((short)31),
    TURN_LEFT_IDX((short)32),
    TURN_RIGHT_IDX((short)33),
    UTURN_LEFT_IDX((short)34),
    UTURN_RIGHT_IDX((short)35),
    ICON_INV_IDX((short)36),
    ICON_IDX_CNT((short)37),
    INVALID((short)255);

    protected short value;

    private TurnType(short value) {
        this.value = value;
    }

    public static TurnType getByValue(final Short value) {
        for (final TurnType type : TurnType.values()) {
            if (value == type.value)
                return type;
        }

        return TurnType.INVALID;
    }

    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value
     */
    public static String getStringFromValue( TurnType value ) {
        return value.name();
    }

    public short getValue() {
        return value;
    }


}
