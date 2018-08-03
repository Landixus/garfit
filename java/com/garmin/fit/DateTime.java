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

public class DateTime {
    public static final long MIN = 0x10000000; // if date_time is < 0x10000000 then it is system time (seconds from device power on)
    public static final long INVALID = Fit.UINT32_INVALID;

    private static final Map<Long, String> stringMap;

    static {
        stringMap = new HashMap<Long, String>();
        stringMap.put(MIN, "MIN");
    }
    public static final long OFFSET = 631065600000l; // Offset between Garmin (FIT) time and Unix time in ms (Dec 31, 1989 - 00:00:00 January 1, 1970).

    private long timestamp;
    private double fractional_timestamp;

    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value, or empty if unknown
     */
    public static String getStringFromValue( Long value ) {
        if( stringMap.containsKey( value ) ) {
            return stringMap.get( value );
        }

        return "";
    }

    /**
     * Retrieves a value given a string representation
     * @return The value or INVALID if unkwown
     */
    public static Long getValueFromString( String value ) {
        for( Map.Entry<Long, String> entry : stringMap.entrySet() ) {
            if( entry.getValue().equals( value ) ) {
                return entry.getKey();
            }
        }

        return INVALID;
    }
    public DateTime(long timestamp) {
        this.timestamp = timestamp;
        this.fractional_timestamp = 0.0;
    }

    public DateTime(java.util.Date date) {
        this.timestamp = (date.getTime() - OFFSET) / 1000;
        this.fractional_timestamp = ((date.getTime() - OFFSET) % 1000) / 1000.0;
    }

    public DateTime(DateTime timestamp) {
        this(timestamp.getTimestamp(), timestamp.getFractionalTimestamp());
    }

    public DateTime(long timestamp, double fractional_timestamp) {
        this.timestamp = timestamp + (long) Math.floor(fractional_timestamp);
        this.fractional_timestamp = fractional_timestamp - Math.floor(fractional_timestamp);
    }

    public boolean equals(DateTime dateTime) {
        return (this.getTimestamp().equals(dateTime.getTimestamp()) && (this.getFractionalTimestamp().equals(dateTime.getFractionalTimestamp())));
    }

    public void convertSystemTimeToUTC(long offset) {
        if (timestamp < MIN) {
           timestamp += offset;
       }
    }

    public Double getFractionalTimestamp() {
        return new Double(this.fractional_timestamp);
    }

    public Long getTimestamp() {
        return new Long(timestamp);
    }

    public java.util.Date getDate() {
        // Express fractional component in (nearest) ms
        long fractional_ms = Math.round(fractional_timestamp * 1000);

        return new java.util.Date((timestamp * 1000) + fractional_ms + OFFSET);
    }

    public String toString() {
        return getDate().toString();
    }

    public void add(DateTime dateTime) {
        this.timestamp += dateTime.getTimestamp();
        this.fractional_timestamp += dateTime.getFractionalTimestamp();

        // Adjust fractional part to be less that 1
        this.timestamp += (long) Math.floor(this.fractional_timestamp);
        this.fractional_timestamp -= (float) Math.floor(this.fractional_timestamp);
    }

    public void add(long timestamp) {
        this.add(new DateTime(timestamp));
    }

    public void add(double fractional_timestamp) {
        this.add(new DateTime(0, fractional_timestamp));
    }

    // returns 0 if t1 is equal to target object; a value less that 0 if target object is numerically less t1
    // a value greater than 0 if target object is numerically greater than t1
    public int compareTo(DateTime t1) {
        // fractional_timestamp is guaranteed to be less that 1 which allows simplified comparison below
        if(this.timestamp == t1.getTimestamp()) {
            // Timestamps are equal; must compare fractional part.
            return Double.compare(this.fractional_timestamp, t1.getFractionalTimestamp());
        }
        else if(this.timestamp > t1.getTimestamp()) {
            return 1;
        }
        else {
            return -1;
        }
    }

}
