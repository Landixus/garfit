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

import java.io.OutputStream;

public class FieldDefinition extends FieldDefinitionBase {
    protected int num;
    protected int size;
    protected int type;

    protected FieldDefinition() {
        num = Fit.FIELD_NUM_INVALID;
        size = 0;
    }

    public FieldDefinition(Field field) {
        num = field.getNum();
        size = field.getSize();
        type = field.getType();
    }

    protected void write(OutputStream out) {
        try {
            out.write(num);
            out.write(size);
            out.write(type);
        } catch (java.io.IOException e) {
        }
    }

    public int getNum() {
        return num;
    }

    @Override
    public void setSize(int size) {
        this.size = size;
    }

    @Override
    public int getSize() {
        return size;
    }

    public int getType() {
        return type;
    }

    public boolean equals(Object o) {
        if (this == o) {
            return true;
        }

        if (!(o instanceof FieldDefinition)) {
            return false;
        }

        FieldDefinition other = (FieldDefinition)o;

        if (num != other.num) {
            return false;
        }

        if (size != other.size) {
            return false;
        }

        if (type != other.type) {
            return false;
        }

        return true;
    }

    public int hashCode() {
        int hashCode = 1;

        hashCode = (hashCode * 47) + new Integer(this.num).hashCode();
        hashCode = (hashCode * 31) + new Integer(this.size).hashCode();
        hashCode = (hashCode * 19) + new Integer(this.type).hashCode();

        return hashCode;
    }
}
