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


package com.garmin.fit.plugins.examples;

import com.garmin.fit.*;
import com.garmin.fit.plugins.*;
import com.garmin.fit.csv.MesgCSVWriter;

import java.io.FileInputStream;
import java.io.InputStream;

/**
 * Example demonstrating usage of BufferedMesgBroadcaster and
 * ThreeDSensorAdjustment plugin.
 *
 * The example applies the sensor calibration parameters to all 3D Sensor messages
 * (gyroscope_data or accelerometer_data) and outputs to to a CSV file.
 *
 */
public class ThreeDSensorAdjustmentExample implements FileIdMesgListener, AccelerometerDataMesgListener, GyroscopeDataMesgListener, ThreeDSensorCalibrationMesgListener {
    private MesgCSVWriter mesgWriter;

    public static void main(String[] args) {
        System.out.printf("FIT 3D Sensor Adjustment Example Application - Protocol %d.%d Profile %.2f %s\n", Fit.PROTOCOL_VERSION_MAJOR, Fit.PROTOCOL_VERSION_MINOR, Fit.PROFILE_VERSION / 100.0, Fit.PROFILE_TYPE);

        FileInputStream in;

        ThreeDSensorAdjustmentExample example = new ThreeDSensorAdjustmentExample();
        Decode decode = new Decode();
        BufferedMesgBroadcaster mesgBroadcaster = new BufferedMesgBroadcaster(decode);

        if (args.length != 1) {
            System.out .println("Usage: java -jar ThreeDSensorAdjustmentExample.jar <input file>.fit");
            return;
        }

        try {
            in = new FileInputStream(args[0]);
        }
        catch (java.io.IOException e) {
            throw new RuntimeException("Error opening file " + args[0]);
        }

        try {
            if (!decode.checkFileIntegrity((InputStream) in))
                throw new RuntimeException("FIT file integrity failed.");
        } catch (RuntimeException e) {
            System.err.print("Exception Checking File Integrity: ");
            System.err.println(e.getMessage());
        } finally {
            try {
                in.close();
            }
            catch (java.io.IOException e) {
                throw new RuntimeException(e);
            }
        }

        try {
            in = new FileInputStream(args[0]);
        } catch (java.io.IOException e) {
            throw new RuntimeException("Error opening file " + args[0] + " [2]");
        }

        String outputFile = args[0] + "-3DSensorAdjustmentExampleProcessed.csv";
        mesgBroadcaster.addListener((FileIdMesgListener) example);
        mesgBroadcaster.addListener((AccelerometerDataMesgListener) example);
        mesgBroadcaster.addListener((GyroscopeDataMesgListener) example);
        mesgBroadcaster.addListener((ThreeDSensorCalibrationMesgListener) example);

        try {
            example.mesgWriter = new MesgCSVWriter(outputFile);

            // Create plugin and register with mesgBroadcaster
            MesgBroadcastPlugin plugin = new ThreeDSensorAdjustmentPlugin();
            mesgBroadcaster.registerMesgBroadcastPlugin(plugin);

            mesgBroadcaster.run(in);      // Run decoder
            mesgBroadcaster.broadcast();  // End of file so flush pending data.
            example.mesgWriter.close();
        } catch (FitRuntimeException e) {
            System.err.print("Exception decoding file: ");
            System.err.println(e.getMessage());
        }

        System.out.println("Adjusted 3D sensor data from " + args[0] + " to " + outputFile);
    }

    public void onMesg(FileIdMesg mesg) {
        mesgWriter.onMesg(mesg);
    }

    public void onMesg(AccelerometerDataMesg mesg) {
        mesgWriter.onMesg(mesg);
    }

    public void onMesg(GyroscopeDataMesg mesg) {
        mesgWriter.onMesg(mesg);
    }

    public void onMesg(ThreeDSensorCalibrationMesg mesg) {
        mesgWriter.onMesg(mesg);
    }
}
