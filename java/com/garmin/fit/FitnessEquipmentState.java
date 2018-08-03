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


public enum FitnessEquipmentState {
    READY((short)0),
    IN_USE((short)1),
    PAUSED((short)2),
    UNKNOWN((short)3),
    INVALID((short)255);

    protected short value;

    private FitnessEquipmentState(short value) {
        this.value = value;
    }

    public static FitnessEquipmentState getByValue(final Short value) {
        for (final FitnessEquipmentState type : FitnessEquipmentState.values()) {
            if (value == type.value)
                return type;
        }

        return FitnessEquipmentState.INVALID;
    }

    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value
     */
    public static String getStringFromValue( FitnessEquipmentState value ) {
        return value.name();
    }

    public short getValue() {
        return value;
    }


}
