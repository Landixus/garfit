#region Copyright
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

#endregion

using System;
using System.Collections.Generic;

namespace Dynastream.Fit
{
    public abstract class FieldBase
    {
        #region Fields
        private readonly List<object> values;
        #endregion

        #region Properties
        public abstract string Name { get; }
        public abstract byte Type { get; }
        public abstract double Scale { get; }
        public abstract double Offset { get; }
        public abstract string Units { get; }
        #endregion

        #region Constructors

        protected FieldBase(FieldBase other)
            : this()
        {
            if (other != null)
            {
                foreach (object obj in other.values)
                {
                    values.Add(obj);
                }
            }
        }

        protected FieldBase()
        {
            values = new List<object>();
        }
        #endregion

        #region Methods

        internal abstract Subfield GetSubfield(string subfieldName);
        internal abstract Subfield GetSubfield(int subfieldIndex);

        public string GetName()
        {
            return GetName((Subfield)null);
        }

        public string GetName(byte subfieldIndex)
        {
            return GetName(GetSubfield(subfieldIndex));
        }

        public string GetName(string subFieldName)
        {
            return GetName(GetSubfield(subFieldName));
        }

        private string GetName(Subfield subfield)
        {
            return subfield == null ? Name : subfield.Name;
        }

        public new byte GetType()
        {
            return GetType((Subfield)null);
        }

        public byte GetType(byte subfieldIndex)
        {
            return GetType(GetSubfield(subfieldIndex));
        }

        public byte GetType(string subFieldName)
        {
            return GetType(GetSubfield(subFieldName));
        }

        private byte GetType(Subfield subfield)
        {
            return subfield == null ? Type : subfield.Type;
        }

        public string GetUnits()
        {
            return GetUnits((Subfield)null);
        }

        public string GetUnits(byte subfieldIndex)
        {
            return GetUnits(GetSubfield(subfieldIndex));
        }

        public string GetUnits(string subFieldName)
        {
            return GetUnits(GetSubfield(subFieldName));
        }

        private string GetUnits(Subfield subfield)
        {
            return subfield == null ? Units : subfield.Units;
        }

        public byte GetSize()
        {
            byte size = 0;

            switch (Type & Fit.BaseTypeNumMask)
            {
                case Fit.Enum:
                case Fit.SInt8:
                case Fit.UInt8:
                case Fit.SInt16:
                case Fit.UInt16:
                case Fit.SInt32:
                case Fit.UInt32:
                case Fit.Float32:
                case Fit.Float64:
                case Fit.UInt8z:
                case Fit.UInt16z:
                case Fit.UInt32z:
                case Fit.SInt64:
                case Fit.UInt64:
                case Fit.UInt64z:
                case Fit.Byte:
                    size = (byte)(GetNumValues() * Fit.BaseType[Type & Fit.BaseTypeNumMask].size);
                    break;

                case Fit.String:
                    // Each string may be of differing length
                    // The fit binary must also include a null terminator
                    foreach (byte[] element in values)
                    {
                        size += (byte)(element.Length);
                    }
                    break;

                default:
                    break;
            }
            return size;
        }

        internal bool IsSigned()
        {
            return IsSigned((Subfield)null);
        }

        internal bool IsSigned(int subfieldIndex)
        {
            return IsSigned(GetSubfield(subfieldIndex));
        }

        internal bool IsSigned(string subfieldName)
        {
            return IsSigned(GetSubfield(subfieldName));
        }

        internal bool IsSigned(Subfield subfield)
        {
            byte type = subfield == null ? Type : subfield.Type;
            type &= Fit.BaseTypeNumMask;
            return Fit.BaseType[type].isSigned;
        }

        public void AddValue(Object value)
        {
            values.Add(value);
        }

        public int GetNumValues()
        {
            return values.Count;
        }

        public long? GetBitsValue(int offset, int bits, byte componentType)
        {
            long? value = 0;
            long data = 0;
            long mask;
            int index = 0;
            int bitsInValue = 0;
            int bitsInData;

            // Ensure the destination type can hold the desired number of bits.
            // We don't support arrays in the destination at this time.
            if ((Fit.BaseType[componentType & Fit.BaseTypeNumMask].size * 8) < bits)
            {
                bits = Fit.BaseType[componentType & Fit.BaseTypeNumMask].size * 8;
            }

            if (values.Count == 0)
                return null;

            while (bitsInValue < bits)
            {
                // If we run out of bits it likely is because our profile is newer and defines
                // additional components not present in the field
                if (index == values.Count)
                    return null;

                data = Convert.ToInt64(this.values[index++]);

                // Shift data to reach desired bits starting at 'offset'
                // If offset is larger than the containing types size,
                // we must grab additional elements
                data >>= offset;
                bitsInData = Fit.BaseType[Type & Fit.BaseTypeNumMask].size * 8 - offset;
                offset -= Fit.BaseType[Type & Fit.BaseTypeNumMask].size * 8;

                if (bitsInData > 0)
                {
                    // We have reached desired data, pull off bits until we
                    // get enough
                    offset = 0;
                    // If there are more bits available in data than we need
                    // just capture those we need
                    if (bitsInData > (bits - bitsInValue))
                    {
                        bitsInData = bits - bitsInValue;
                    }
                    mask = (1L << bitsInData) - 1;
                    value |= ((data & mask) << bitsInValue);
                    bitsInValue += bitsInData;
                }
            }

            // Sign extend if needed
            if (Fit.BaseType[componentType & Fit.BaseTypeNumMask].isSigned == true &&
                Fit.BaseType[componentType & Fit.BaseTypeNumMask].isInteger == true)
            {
                long signBit = (1L << (bits - 1));

                if ((value & signBit) != 0)
                {
                    value = -signBit + (value & (signBit - 1));
                }
            }
            return value;
        }

        public object GetValue()
        {
            return GetValue(0, (Subfield)null);
        }

        public object GetValue(int index)
        {
            return GetValue(index, (Subfield)null);
        }

        public object GetValue(int index, int subfieldIndex)
        {
            return GetValue(index, GetSubfield(subfieldIndex));
        }

        public object GetValue(int index, string subfieldName)
        {
            return GetValue(index, GetSubfield(subfieldName));
        }

        public object GetValue(int index, Subfield subfield)
        {
            double scale, offset;

            if (index >= values.Count || index < 0)
            {
                return null;
            }

            if (subfield == null)
            {
                scale = Scale;
                offset = Offset;
            }
            else
            {
                scale = subfield.Scale;
                offset = subfield.Offset;
            }

            object value;
            bool castToFloat = false;

            switch (Type & Fit.BaseTypeNumMask)
            {
                case Fit.Enum:
                case Fit.Byte:
                case Fit.UInt8:
                case Fit.UInt8z:
                    value = Convert.ToByte(values[index]);
                    if (((byte)value == (byte)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.SInt8:
                    value = Convert.ToSByte(values[index]);
                    if (((sbyte)value == (sbyte)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.SInt16:
                    value = Convert.ToInt16(values[index]);
                    if (((short)value == (short)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.UInt16:
                case Fit.UInt16z:
                    value = Convert.ToUInt16(values[index]);
                    if (((ushort)value == (ushort)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.SInt32:
                    value = Convert.ToInt32(values[index]);
                    if (((int)value == (int)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.UInt32:
                case Fit.UInt32z:
                    value = Convert.ToUInt32(values[index]);
                    if (((uint)value == (uint)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.SInt64:
                    value = Convert.ToInt64(values[index]);
                    if (((long)value == (long)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.UInt64:
                case Fit.UInt64z:
                    value = Convert.ToUInt64(values[index]);
                    if (((ulong)value == (ulong)Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.Float32:
                    value = Convert.ToSingle(values[index]);
                    if (float.IsNaN((float)value) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.Float64:
                    value = Convert.ToDouble(values[index]);
                    if (double.IsNaN((double)value) &&
                       (scale != 1.0))
                        castToFloat = true;
                    break;

                case Fit.String:
                    value = values[index];
                    break;

                default:
                    value = null;
                    break;
            }

            if (castToFloat == true)
            {
                //Cast to Single Precision (float) since its expecting a float value if scale > 1
                value = Convert.ToSingle(value);
                return value;
            }

            if (IsNumeric())
            {
                if (scale != 1.0 || Offset != 0.0)
                {
                    value = (float)((Convert.ToSingle(value) / scale) - offset);
                }
            }
            return value;
        }

        public void SetValue(object value)
        {
            SetValue(0, value, (Subfield)null);
        }

        public void SetValue(object value, int subfieldIndex)
        {
            SetValue(0, value, GetSubfield(subfieldIndex));
        }

        public void SetValue(object value, string subfieldName)
        {
            SetValue(0, value, GetSubfield(subfieldName));
        }

        public void SetValue(int index, object value)
        {
            SetValue(index, value, (Subfield)null);
        }

        public void SetValue(int index, object value, int subfieldIndex)
        {
            SetValue(index, value, GetSubfield(subfieldIndex));
        }

        public void SetValue(int index, object value, string subfieldName)
        {
            SetValue(index, value, GetSubfield(subfieldName));
        }

        public void SetValue(int index, object value, Subfield subfield)
        {
            double scale, offset;

            while (index >= GetNumValues())
            {
                // Add placeholders of the correct type so GetSize() will
                // still compute correctly
                switch (Type & Fit.BaseTypeNumMask)
                {
                    case Fit.Enum:
                    case Fit.Byte:
                    case Fit.UInt8:
                    case Fit.UInt8z:
                        values.Add(new byte());
                        break;

                    case Fit.SInt8:
                        values.Add(new sbyte());
                        break;

                    case Fit.SInt16:
                        values.Add(new short());
                        break;

                    case Fit.UInt16:
                    case Fit.UInt16z:
                        values.Add(new ushort());
                        break;

                    case Fit.SInt32:
                        values.Add(new int());
                        break;

                    case Fit.UInt32:
                    case Fit.UInt32z:
                        values.Add(new uint());
                        break;

                    case Fit.SInt64:
                        values.Add(new long());
                        break;

                    case Fit.UInt64:
                    case Fit.UInt64z:
                        values.Add(new ulong());
                        break;

                    case Fit.Float32:
                        values.Add(new float());
                        break;

                    case Fit.Float64:
                        values.Add(new double());
                        break;

                    case Fit.String:
                        values.Add(new byte[0]);
                        break;

                    default:
                        break;
                }
            }

            if (subfield == null)
            {
                scale = Scale;
                offset = Offset;
            }
            else
            {
                scale = subfield.Scale;
                offset = Offset;
            }

            // Cast to long as scale and offset only apply to integer based types
            // and we want to make sure we have maximum precision.
            long invalidValue = 0;
            long castedValue = 0;

            if (IsNumeric())
            {
                // Cast to long as scale and offset only apply to integer based types
                // and we want to make sure we have maximum precision.
                invalidValue = (long)Convert.ToDouble(Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue);
                castedValue = (long)Convert.ToDouble(value);

                // If the field is numeric, check if the value is less than the base
                // type's invalid value. For "z" base types where 0 is invalid, check
                // that the value is > 0. Apply scale and offset if valid.
                if ( (  castedValue < invalidValue ) ||
                   ( ( invalidValue == 0 ) && ( castedValue > 0 ) ) )
                {
                    if (scale != 1.0 || Offset != 0.0)
                    {
                        value = Convert.ToSingle(value);
                        value = ((float)value + offset) * scale;
                    }
                }
            }

            // Must convert value back to the base type, if there was a scale or offset it will
            // have been converted to float.  Caller also may have passed in an unexpected type.
            bool success = false;

            switch (Type & Fit.BaseTypeNumMask)
            {
                case Fit.Enum:
                case Fit.Byte:
                case Fit.UInt8:
                case Fit.UInt8z:
                    if ( ( Convert.ToDouble(value) >= byte.MinValue ) && ( Convert.ToDouble(value) <= byte.MaxValue ) )
                    {
                        value = Convert.ToByte(value);
                        success = true;
                    }
                    break;

                case Fit.SInt8:
                    if ( ( Convert.ToDouble(value) >= sbyte.MinValue ) && ( Convert.ToDouble(value) <= sbyte.MaxValue ) )
                    {
                        value = Convert.ToSByte(value);
                        success = true;
                    }
                    break;

                case Fit.SInt16:
                    if ( ( Convert.ToDouble(value) >= short.MinValue) && ( Convert.ToDouble(value) <= short.MaxValue ) )
                    {
                        value = Convert.ToInt16(value);
                        success = true;
                    }
                    break;

                case Fit.UInt16:
                case Fit.UInt16z:
                    if ( ( Convert.ToDouble(value) >= ushort.MinValue ) && ( Convert.ToDouble(value) <= ushort.MaxValue ) )
                    {
                        value = Convert.ToUInt16(value);
                        success = true;
                    }
                    break;

                case Fit.SInt32:
                    if ( ( Convert.ToDouble(value) >= int.MinValue ) && ( Convert.ToDouble(value) <= int.MaxValue ) )
                    {
                        value = Convert.ToInt32(value);
                        success = true;
                    }
                    break;

                case Fit.UInt32:
                case Fit.UInt32z:
                    if ( ( Convert.ToDouble(value) >= uint.MinValue ) && ( Convert.ToDouble(value) <= uint.MaxValue ) )
                    {
                        value = Convert.ToUInt32(value);
                        success = true;
                    }
                    break;

                case Fit.SInt64:
                    value = Convert.ToInt64(value);
                    success = true;
                    break;

                case Fit.UInt64:
                case Fit.UInt64z:
                    value = Convert.ToUInt64(value);
                    success = true;
                    break;

                case Fit.Float32:
                    if ( ( Convert.ToDouble(value) >= float.MinValue ) && ( Convert.ToDouble(value) <= float.MaxValue ) )
                    {
                        value = Convert.ToSingle(value);
                        success = true;
                    }
                    break;

                case Fit.Float64:
                    if ( ( (double)value >= double.MinValue ) && ( (double)value <= double.MaxValue ) )
                    {
                        value = Convert.ToDouble(value);
                        success = true;
                    }
                    break;

                case Fit.String:
                    success = true;
                    break;

                default:
                    break;
            }

            // If the conversion failed, set the value to invalid
            if (success == false)
            {
                value = Fit.BaseType[Type & Fit.BaseTypeNumMask].invalidValue;
            }
            values[index] = value;
        }

        public void SetRawValue(int index, object value)
        {
            while (index >= GetNumValues())
            {
                // Add placeholders of the correct type so GetSize() will
                // still compute correctly
                switch (Type & Fit.BaseTypeNumMask)
                {
                    case Fit.Enum:
                    case Fit.Byte:
                    case Fit.UInt8:
                    case Fit.UInt8z:
                        values.Add(new byte());
                        break;

                    case Fit.SInt8:
                        values.Add(new sbyte());
                        break;

                    case Fit.SInt16:
                        values.Add(new short());
                        break;

                    case Fit.UInt16:
                    case Fit.UInt16z:
                        values.Add(new ushort());
                        break;

                    case Fit.SInt32:
                        values.Add(new int());
                        break;

                    case Fit.UInt32:
                    case Fit.UInt32z:
                        values.Add(new uint());
                        break;

                    case Fit.SInt64:
                        values.Add(new long());
                        break;

                    case Fit.UInt64:
                    case Fit.UInt64z:
                        values.Add(new ulong());
                        break;

                    case Fit.Float32:
                        values.Add(new float());
                        break;

                    case Fit.Float64:
                        values.Add(new double());
                        break;

                    case Fit.String:
                        values.Add(new byte[0]);
                        break;

                    default:
                        break;
                }
            }
            // Must convert value back to the base type, caller may have passed in an unexpected type.
            switch (Type & Fit.BaseTypeNumMask)
            {
                case Fit.Enum:
                case Fit.Byte:
                case Fit.UInt8:
                case Fit.UInt8z:
                    value = Convert.ToByte(value);
                    break;

                case Fit.SInt8:
                    value = Convert.ToSByte(value);
                    break;

                case Fit.SInt16:
                    value = Convert.ToInt16(value);
                    break;

                case Fit.UInt16:
                case Fit.UInt16z:
                    value = Convert.ToUInt16(value);
                    break;

                case Fit.SInt32:
                    value = Convert.ToInt32(value);
                    break;

                case Fit.UInt32:
                case Fit.UInt32z:
                    value = Convert.ToUInt32(value);
                    break;

                case Fit.SInt64:
                    value = Convert.ToInt64(value);
                    break;

                case Fit.UInt64:
                case Fit.UInt64z:
                    value = Convert.ToUInt64(value);
                    break;

                case Fit.Float32:
                    value = Convert.ToSingle(value);
                    break;

                case Fit.Float64:
                    value = Convert.ToDouble(value);
                    break;

                default:
                    break;

            }
            values[index] = value;
        }

        public object GetRawValue(int index)
        {
            if (index >= values.Count || index < 0)
            {
                return null;
            }
            object value = values[index];
            return value;
        }

        public bool IsNumeric()
        {
            bool isNumeric;
            switch (Type & Fit.BaseTypeNumMask)
            {
                case Fit.Enum:
                case Fit.String:
                    isNumeric = false;
                    break;

                case Fit.SInt8:
                case Fit.UInt8:
                case Fit.SInt16:
                case Fit.UInt16:
                case Fit.SInt32:
                case Fit.UInt32:
                case Fit.Float32:
                case Fit.Float64:
                case Fit.UInt8z:
                case Fit.UInt16z:
                case Fit.UInt32z:
                case Fit.Byte:
                case Fit.SInt64:
                case Fit.UInt64:
                case Fit.UInt64z:
                    isNumeric = true;
                    break;

                default:
                    throw new FitException("Field:IsNumeric - Unexpected Fit Type" + this.Type);

            }
            return isNumeric;
        }
        #endregion

    }
} // namespace
