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
import java.math.BigInteger;


public class BloodPressureMesg extends Mesg {

    
    public static final int TimestampFieldNum = 253;
    
    public static final int SystolicPressureFieldNum = 0;
    
    public static final int DiastolicPressureFieldNum = 1;
    
    public static final int MeanArterialPressureFieldNum = 2;
    
    public static final int Map3SampleMeanFieldNum = 3;
    
    public static final int MapMorningValuesFieldNum = 4;
    
    public static final int MapEveningValuesFieldNum = 5;
    
    public static final int HeartRateFieldNum = 6;
    
    public static final int HeartRateTypeFieldNum = 7;
    
    public static final int StatusFieldNum = 8;
    
    public static final int UserProfileIndexFieldNum = 9;
    

    protected static final  Mesg bloodPressureMesg;
    static {
        // blood_pressure
        bloodPressureMesg = new Mesg("blood_pressure", MesgNum.BLOOD_PRESSURE);
        bloodPressureMesg.addField(new Field("timestamp", TimestampFieldNum, 134, 1, 0, "s", false, Profile.Type.DATE_TIME));
        
        bloodPressureMesg.addField(new Field("systolic_pressure", SystolicPressureFieldNum, 132, 1, 0, "mmHg", false, Profile.Type.UINT16));
        
        bloodPressureMesg.addField(new Field("diastolic_pressure", DiastolicPressureFieldNum, 132, 1, 0, "mmHg", false, Profile.Type.UINT16));
        
        bloodPressureMesg.addField(new Field("mean_arterial_pressure", MeanArterialPressureFieldNum, 132, 1, 0, "mmHg", false, Profile.Type.UINT16));
        
        bloodPressureMesg.addField(new Field("map_3_sample_mean", Map3SampleMeanFieldNum, 132, 1, 0, "mmHg", false, Profile.Type.UINT16));
        
        bloodPressureMesg.addField(new Field("map_morning_values", MapMorningValuesFieldNum, 132, 1, 0, "mmHg", false, Profile.Type.UINT16));
        
        bloodPressureMesg.addField(new Field("map_evening_values", MapEveningValuesFieldNum, 132, 1, 0, "mmHg", false, Profile.Type.UINT16));
        
        bloodPressureMesg.addField(new Field("heart_rate", HeartRateFieldNum, 2, 1, 0, "bpm", false, Profile.Type.UINT8));
        
        bloodPressureMesg.addField(new Field("heart_rate_type", HeartRateTypeFieldNum, 0, 1, 0, "", false, Profile.Type.HR_TYPE));
        
        bloodPressureMesg.addField(new Field("status", StatusFieldNum, 0, 1, 0, "", false, Profile.Type.BP_STATUS));
        
        bloodPressureMesg.addField(new Field("user_profile_index", UserProfileIndexFieldNum, 132, 1, 0, "", false, Profile.Type.MESSAGE_INDEX));
        
    }

    public BloodPressureMesg() {
        super(Factory.createMesg(MesgNum.BLOOD_PRESSURE));
    }

    public BloodPressureMesg(final Mesg mesg) {
        super(mesg);
    }


    /**
     * Get timestamp field
     * Units: s
     *
     * @return timestamp
     */
    public DateTime getTimestamp() {
        return timestampToDateTime(getFieldLongValue(253, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD));
    }

    /**
     * Set timestamp field
     * Units: s
     *
     * @param timestamp
     */
    public void setTimestamp(DateTime timestamp) {
        setFieldValue(253, 0, timestamp.getTimestamp(), Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get systolic_pressure field
     * Units: mmHg
     *
     * @return systolic_pressure
     */
    public Integer getSystolicPressure() {
        return getFieldIntegerValue(0, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set systolic_pressure field
     * Units: mmHg
     *
     * @param systolicPressure
     */
    public void setSystolicPressure(Integer systolicPressure) {
        setFieldValue(0, 0, systolicPressure, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get diastolic_pressure field
     * Units: mmHg
     *
     * @return diastolic_pressure
     */
    public Integer getDiastolicPressure() {
        return getFieldIntegerValue(1, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set diastolic_pressure field
     * Units: mmHg
     *
     * @param diastolicPressure
     */
    public void setDiastolicPressure(Integer diastolicPressure) {
        setFieldValue(1, 0, diastolicPressure, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get mean_arterial_pressure field
     * Units: mmHg
     *
     * @return mean_arterial_pressure
     */
    public Integer getMeanArterialPressure() {
        return getFieldIntegerValue(2, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set mean_arterial_pressure field
     * Units: mmHg
     *
     * @param meanArterialPressure
     */
    public void setMeanArterialPressure(Integer meanArterialPressure) {
        setFieldValue(2, 0, meanArterialPressure, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get map_3_sample_mean field
     * Units: mmHg
     *
     * @return map_3_sample_mean
     */
    public Integer getMap3SampleMean() {
        return getFieldIntegerValue(3, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set map_3_sample_mean field
     * Units: mmHg
     *
     * @param map3SampleMean
     */
    public void setMap3SampleMean(Integer map3SampleMean) {
        setFieldValue(3, 0, map3SampleMean, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get map_morning_values field
     * Units: mmHg
     *
     * @return map_morning_values
     */
    public Integer getMapMorningValues() {
        return getFieldIntegerValue(4, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set map_morning_values field
     * Units: mmHg
     *
     * @param mapMorningValues
     */
    public void setMapMorningValues(Integer mapMorningValues) {
        setFieldValue(4, 0, mapMorningValues, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get map_evening_values field
     * Units: mmHg
     *
     * @return map_evening_values
     */
    public Integer getMapEveningValues() {
        return getFieldIntegerValue(5, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set map_evening_values field
     * Units: mmHg
     *
     * @param mapEveningValues
     */
    public void setMapEveningValues(Integer mapEveningValues) {
        setFieldValue(5, 0, mapEveningValues, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get heart_rate field
     * Units: bpm
     *
     * @return heart_rate
     */
    public Short getHeartRate() {
        return getFieldShortValue(6, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set heart_rate field
     * Units: bpm
     *
     * @param heartRate
     */
    public void setHeartRate(Short heartRate) {
        setFieldValue(6, 0, heartRate, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get heart_rate_type field
     *
     * @return heart_rate_type
     */
    public HrType getHeartRateType() {
        Short value = getFieldShortValue(7, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return HrType.getByValue(value);
    }

    /**
     * Set heart_rate_type field
     *
     * @param heartRateType
     */
    public void setHeartRateType(HrType heartRateType) {
        setFieldValue(7, 0, heartRateType.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get status field
     *
     * @return status
     */
    public BpStatus getStatus() {
        Short value = getFieldShortValue(8, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        if (value == null) {
            return null;
        }
        return BpStatus.getByValue(value);
    }

    /**
     * Set status field
     *
     * @param status
     */
    public void setStatus(BpStatus status) {
        setFieldValue(8, 0, status.value, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get user_profile_index field
     * Comment: Associates this blood pressure message to a user.  This corresponds to the index of the user profile message in the blood pressure file.
     *
     * @return user_profile_index
     */
    public Integer getUserProfileIndex() {
        return getFieldIntegerValue(9, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set user_profile_index field
     * Comment: Associates this blood pressure message to a user.  This corresponds to the index of the user profile message in the blood pressure file.
     *
     * @param userProfileIndex
     */
    public void setUserProfileIndex(Integer userProfileIndex) {
        setFieldValue(9, 0, userProfileIndex, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

}
