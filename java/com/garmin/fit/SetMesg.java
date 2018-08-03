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


public class SetMesg extends Mesg {

    
    public static final int TimestampFieldNum = 254;
    
    public static final int DurationFieldNum = 0;
    
    public static final int RepetitionsFieldNum = 3;
    
    public static final int WeightFieldNum = 4;
    
    public static final int SetTypeFieldNum = 5;
    
    public static final int StartTimeFieldNum = 6;
    
    public static final int CategoryFieldNum = 7;
    
    public static final int CategorySubtypeFieldNum = 8;
    
    public static final int WeightDisplayUnitFieldNum = 9;
    
    public static final int MessageIndexFieldNum = 10;
    
    public static final int WktStepIndexFieldNum = 11;
    

    protected static final  Mesg setMesg;
    static {
        // set
        setMesg = new Mesg("set", MesgNum.SET);
        setMesg.addField(new Field("timestamp", TimestampFieldNum, 134, 1, 0, "", false, Profile.Type.DATE_TIME));
        
        setMesg.addField(new Field("duration", DurationFieldNum, 134, 1000, 0, "s", false, Profile.Type.UINT32));
        
        setMesg.addField(new Field("repetitions", RepetitionsFieldNum, 132, 1, 0, "", false, Profile.Type.UINT16));
        
        setMesg.addField(new Field("weight", WeightFieldNum, 132, 16, 0, "kg", false, Profile.Type.UINT16));
        
        setMesg.addField(new Field("set_type", SetTypeFieldNum, 2, 1, 0, "", false, Profile.Type.SET_TYPE));
        
        setMesg.addField(new Field("start_time", StartTimeFieldNum, 134, 1, 0, "", false, Profile.Type.DATE_TIME));
        
        setMesg.addField(new Field("category", CategoryFieldNum, 132, 1, 0, "", false, Profile.Type.EXERCISE_CATEGORY));
        
        setMesg.addField(new Field("category_subtype", CategorySubtypeFieldNum, 132, 1, 0, "", false, Profile.Type.UINT16));
        
        setMesg.addField(new Field("weight_display_unit", WeightDisplayUnitFieldNum, 132, 1, 0, "", false, Profile.Type.FIT_BASE_UNIT));
        
        setMesg.addField(new Field("message_index", MessageIndexFieldNum, 132, 1, 0, "", false, Profile.Type.MESSAGE_INDEX));
        
        setMesg.addField(new Field("wkt_step_index", WktStepIndexFieldNum, 132, 1, 0, "", false, Profile.Type.MESSAGE_INDEX));
        
    }

    public SetMesg() {
        super(Factory.createMesg(MesgNum.SET));
    }

    public SetMesg(final Mesg mesg) {
        super(mesg);
    }


    /**
     * Get timestamp field
     * Comment: Timestamp of the set
     *
     * @return timestamp
     */
    public DateTime getTimestamp() {
        return timestampToDateTime(getFieldLongValue(254, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD));
    }

    /**
     * Set timestamp field
     * Comment: Timestamp of the set
     *
     * @param timestamp
     */
    public void setTimestamp(DateTime timestamp) {
        setFieldValue(254, 0, timestamp.getTimestamp(), Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get duration field
     * Units: s
     *
     * @return duration
     */
    public Float getDuration() {
        return getFieldFloatValue(0, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set duration field
     * Units: s
     *
     * @param duration
     */
    public void setDuration(Float duration) {
        setFieldValue(0, 0, duration, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get repetitions field
     * Comment: # of repitions of the movement
     *
     * @return repetitions
     */
    public Integer getRepetitions() {
        return getFieldIntegerValue(3, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set repetitions field
     * Comment: # of repitions of the movement
     *
     * @param repetitions
     */
    public void setRepetitions(Integer repetitions) {
        setFieldValue(3, 0, repetitions, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get weight field
     * Units: kg
     * Comment: Amount of weight applied for the set
     *
     * @return weight
     */
    public Float getWeight() {
        return getFieldFloatValue(4, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set weight field
     * Units: kg
     * Comment: Amount of weight applied for the set
     *
     * @param weight
     */
    public void setWeight(Float weight) {
        setFieldValue(4, 0, weight, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get set_type field
     *
     * @return set_type
     */
    public Short getSetType() {
        return getFieldShortValue(5, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set set_type field
     *
     * @param setType
     */
    public void setSetType(Short setType) {
        setFieldValue(5, 0, setType, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get start_time field
     * Comment: Start time of the set
     *
     * @return start_time
     */
    public DateTime getStartTime() {
        return timestampToDateTime(getFieldLongValue(6, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD));
    }

    /**
     * Set start_time field
     * Comment: Start time of the set
     *
     * @param startTime
     */
    public void setStartTime(DateTime startTime) {
        setFieldValue(6, 0, startTime.getTimestamp(), Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    public Integer[] getCategory() {
        
        return getFieldIntegerValues(7, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        
    }

    /**
     * @return number of category
     */
    public int getNumCategory() {
        return getNumFieldValues(7, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get category field
     *
     * @param index of category
     * @return category
     */
    public Integer getCategory(int index) {
        return getFieldIntegerValue(7, index, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set category field
     *
     * @param index of category
     * @param category
     */
    public void setCategory(int index, Integer category) {
        setFieldValue(7, index, category, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    public Integer[] getCategorySubtype() {
        
        return getFieldIntegerValues(8, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        
    }

    /**
     * @return number of category_subtype
     */
    public int getNumCategorySubtype() {
        return getNumFieldValues(8, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get category_subtype field
     * Comment: Based on the associated category, see [category]_exercise_names
     *
     * @param index of category_subtype
     * @return category_subtype
     */
    public Integer getCategorySubtype(int index) {
        return getFieldIntegerValue(8, index, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set category_subtype field
     * Comment: Based on the associated category, see [category]_exercise_names
     *
     * @param index of category_subtype
     * @param categorySubtype
     */
    public void setCategorySubtype(int index, Integer categorySubtype) {
        setFieldValue(8, index, categorySubtype, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get weight_display_unit field
     *
     * @return weight_display_unit
     */
    public Integer getWeightDisplayUnit() {
        return getFieldIntegerValue(9, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set weight_display_unit field
     *
     * @param weightDisplayUnit
     */
    public void setWeightDisplayUnit(Integer weightDisplayUnit) {
        setFieldValue(9, 0, weightDisplayUnit, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get message_index field
     *
     * @return message_index
     */
    public Integer getMessageIndex() {
        return getFieldIntegerValue(10, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set message_index field
     *
     * @param messageIndex
     */
    public void setMessageIndex(Integer messageIndex) {
        setFieldValue(10, 0, messageIndex, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get wkt_step_index field
     *
     * @return wkt_step_index
     */
    public Integer getWktStepIndex() {
        return getFieldIntegerValue(11, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set wkt_step_index field
     *
     * @param wktStepIndex
     */
    public void setWktStepIndex(Integer wktStepIndex) {
        setFieldValue(11, 0, wktStepIndex, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

}
