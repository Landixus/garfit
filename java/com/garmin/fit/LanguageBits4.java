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

public class LanguageBits4 {
    public static final short BRAZILIAN_PORTUGUESE = 0x01;
    public static final short INDONESIAN = 0x02;
    public static final short MALAYSIAN = 0x04;
    public static final short VIETNAMESE = 0x08;
    public static final short BURMESE = 0x10;
    public static final short MONGOLIAN = 0x20;
    public static final short INVALID = Fit.UINT8Z_INVALID;

    private static final Map<Short, String> stringMap;

    static {
        stringMap = new HashMap<Short, String>();
        stringMap.put(BRAZILIAN_PORTUGUESE, "BRAZILIAN_PORTUGUESE");
        stringMap.put(INDONESIAN, "INDONESIAN");
        stringMap.put(MALAYSIAN, "MALAYSIAN");
        stringMap.put(VIETNAMESE, "VIETNAMESE");
        stringMap.put(BURMESE, "BURMESE");
        stringMap.put(MONGOLIAN, "MONGOLIAN");
    }


    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value, or empty if unknown
     */
    public static String getStringFromValue( Short value ) {
        if( stringMap.containsKey( value ) ) {
            return stringMap.get( value );
        }

        return "";
    }

    /**
     * Retrieves a value given a string representation
     * @return The value or INVALID if unkwown
     */
    public static Short getValueFromString( String value ) {
        for( Map.Entry<Short, String> entry : stringMap.entrySet() ) {
            if( entry.getValue().equals( value ) ) {
                return entry.getKey();
            }
        }

        return INVALID;
    }

}
