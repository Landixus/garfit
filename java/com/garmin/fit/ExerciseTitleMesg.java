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


public class ExerciseTitleMesg extends Mesg {

    
    public static final int MessageIndexFieldNum = 254;
    
    public static final int ExerciseCategoryFieldNum = 0;
    
    public static final int ExerciseNameFieldNum = 1;
    
    public static final int WktStepNameFieldNum = 2;
    

    protected static final  Mesg exerciseTitleMesg;
    static {
        // exercise_title
        exerciseTitleMesg = new Mesg("exercise_title", MesgNum.EXERCISE_TITLE);
        exerciseTitleMesg.addField(new Field("message_index", MessageIndexFieldNum, 132, 1, 0, "", false, Profile.Type.MESSAGE_INDEX));
        
        exerciseTitleMesg.addField(new Field("exercise_category", ExerciseCategoryFieldNum, 132, 1, 0, "", false, Profile.Type.EXERCISE_CATEGORY));
        
        exerciseTitleMesg.addField(new Field("exercise_name", ExerciseNameFieldNum, 132, 1, 0, "", false, Profile.Type.UINT16));
        
        exerciseTitleMesg.addField(new Field("wkt_step_name", WktStepNameFieldNum, 7, 1, 0, "", false, Profile.Type.STRING));
        
    }

    public ExerciseTitleMesg() {
        super(Factory.createMesg(MesgNum.EXERCISE_TITLE));
    }

    public ExerciseTitleMesg(final Mesg mesg) {
        super(mesg);
    }


    /**
     * Get message_index field
     *
     * @return message_index
     */
    public Integer getMessageIndex() {
        return getFieldIntegerValue(254, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set message_index field
     *
     * @param messageIndex
     */
    public void setMessageIndex(Integer messageIndex) {
        setFieldValue(254, 0, messageIndex, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get exercise_category field
     *
     * @return exercise_category
     */
    public Integer getExerciseCategory() {
        return getFieldIntegerValue(0, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set exercise_category field
     *
     * @param exerciseCategory
     */
    public void setExerciseCategory(Integer exerciseCategory) {
        setFieldValue(0, 0, exerciseCategory, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get exercise_name field
     *
     * @return exercise_name
     */
    public Integer getExerciseName() {
        return getFieldIntegerValue(1, 0, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set exercise_name field
     *
     * @param exerciseName
     */
    public void setExerciseName(Integer exerciseName) {
        setFieldValue(1, 0, exerciseName, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    public String[] getWktStepName() {
        
        return getFieldStringValues(2, Fit.SUBFIELD_INDEX_MAIN_FIELD);
        
    }

    /**
     * @return number of wkt_step_name
     */
    public int getNumWktStepName() {
        return getNumFieldValues(2, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Get wkt_step_name field
     *
     * @param index of wkt_step_name
     * @return wkt_step_name
     */
    public String getWktStepName(int index) {
        return getFieldStringValue(2, index, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

    /**
     * Set wkt_step_name field
     *
     * @param index of wkt_step_name
     * @param wktStepName
     */
    public void setWktStepName(int index, String wktStepName) {
        setFieldValue(2, index, wktStepName, Fit.SUBFIELD_INDEX_MAIN_FIELD);
    }

}
