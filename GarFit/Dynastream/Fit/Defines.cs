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
    public enum ProtocolVersion
    {
        V10,
        V20
    }

    public static class ProtocolVersionExtensions
    {
        private class DetailedProtocolVersion
        {
            public byte MajorVersion { get; private set; }
            public byte MinorVersion { get; private set; }

            public byte Version
            {
                get
                {
                    return (byte) ((MajorVersion << Fit.ProtocolVersionMajorShift) |
                        MinorVersion);
                }
            }

            public DetailedProtocolVersion(byte major, byte minor)
            {
                MajorVersion = major;
                MinorVersion = minor;
            }
        }

        public static byte GetMajorVersion(this ProtocolVersion protocolVersion)
        {
            return s_versionMap[protocolVersion].MajorVersion;
        }

        public static byte GetMinorVersion(this ProtocolVersion protocolVersion)
        {
            return s_versionMap[protocolVersion].MinorVersion;
        }

        public static byte GetVersionByte(this ProtocolVersion protocolVersion)

        {
            return s_versionMap[protocolVersion].Version;
        }

        private static readonly Dictionary<ProtocolVersion, DetailedProtocolVersion> s_versionMap =
            new Dictionary<ProtocolVersion, DetailedProtocolVersion>
            {
                {ProtocolVersion.V10, new DetailedProtocolVersion(1, 0)},
                {ProtocolVersion.V20, new DetailedProtocolVersion(2, 0)}
            };
    }


    public class Fit
    {
        public const byte ProtocolVersionMajorShift = 4;
        public const byte ProtocolVersionMajorMask = (0x0F << ProtocolVersionMajorShift);

        public static readonly byte ProtocolVersion = Dynastream.Fit.ProtocolVersion.V20.GetVersionByte();
        public static readonly byte ProtocolMajorVersion = Dynastream.Fit.ProtocolVersion.V20.GetMajorVersion();
        public static readonly byte ProtocolMinorVersion = Dynastream.Fit.ProtocolVersion.V20.GetMinorVersion();

        public const ushort ProfileVersion = ((ProfileMajorVersion * 100) + ProfileMinorVersion);
        public const ushort ProfileMajorVersion = 20;
        public const ushort ProfileMinorVersion = 67;

        public const byte HeaderTypeMask = 0xF0;
        public const byte CompressedHeaderMask = 0x80;
        public const byte CompressedTimeMask = 0x1F;
        public const byte CompressedLocalMesgNumMask = 0x60;

        public const byte MesgDefinitionMask = 0x40;
        public const byte DevDataMask = 0x20;
        public const byte MesgHeaderMask = 0x00;
        public const byte LocalMesgNumMask = 0x0F;
        public const byte MaxLocalMesgs = LocalMesgNumMask + 1;

        public const byte MesgDefinitionReserved = 0x00;
        public const byte LittleEndian = 0x00;
        public const byte BigEndian = 0x01;

        public const byte MaxMesgSize = 255;
        public const byte MaxFieldSize = 255;

        public const byte HeaderWithCRCSize = 14;
        public const byte HeaderWithoutCRCSize = (HeaderWithCRCSize - 2);

        public const byte FieldNumInvalid = 255;
        public const byte FieldNumTimeStamp = 253;

        public const ushort SubfieldIndexMainField = SubfieldIndexActiveSubfield + 1;
        public const ushort SubfieldIndexActiveSubfield = 0xFFFE;
        public const string SubfieldNameMainField = "";

        public static FitType[] BaseType = new FitType[]
        {
            new FitType(false, 0x00, "enum", (byte)0xFF, 1, false, false),
            new FitType(false, 0x01, "sint8", (sbyte)0x7F, 1, true, true),
            new FitType(false, 0x02, "uint8", (byte)0xFF, 1, false, true),
            new FitType(true, 0x83, "sint16", (short)0x7FFF, 2, true, true),
            new FitType(true, 0x84, "uint16", (ushort)0xFFFF, 2, false, true),
            new FitType(true, 0x85, "sint32", (int)0x7FFFFFFF, 4, true, true),
            new FitType(true, 0x86, "uint32", (uint)0xFFFFFFFF, 4, false, true),
            new FitType(false, 0x07, "string", (byte)0x00, 1, false, false),
            new FitType(true, 0x88, "float32", BitConverter.ToSingle(new byte[] {0xFF, 0xFF, 0xFF, 0xFF}, 0), 4, true, false),
            new FitType(true, 0x89, "float64", BitConverter.ToDouble(new byte[] {0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF}, 0), 8, true, false),
            new FitType(false, 0x0A, "uint8z", (byte)0x00, 1, false, true),
            new FitType(true, 0x8B, "uint16z", (ushort)0x0000, 2, false, true),
            new FitType(true, 0x8C, "uint32z", (uint)0x00000000, 4, false, true),
            new FitType(false, 0x0D, "byte", (byte)0xFF, 1, false, false),
            new FitType(true, 0x8E, "sint64", (long)0x7FFFFFFFFFFFFFFFL, 8, true, true),
            new FitType(true, 0x8F, "uint64", (ulong)0xFFFFFFFFFFFFFFFFL, 8, false, true),
            new FitType(true, 0x90, "uint64z", (ulong)0x0000000000000000L, 8, false, true),
        };


        public struct FitType
        {
            public bool endianAbility;
            public byte baseTypeField;
            public string typeName;
            public object invalidValue;
            public byte size;
            public bool isSigned;
            public bool isInteger;

            public FitType(bool endianAbility, byte baseTypeField, string typeName, object invalidValue, byte size, bool isSigned, bool isInt)
            {
                this.endianAbility = endianAbility;
                this.baseTypeField = baseTypeField;
                this.typeName = typeName;
                this.invalidValue = invalidValue;
                this.size = size;
                this.isSigned = isSigned;
                this.isInteger = isInt;
            }
        }

        // Index into the BaseTypes array
        public const byte Enum = 0x00;
        public const byte SInt8 = 0x01;
        public const byte UInt8 = 0x02;
        public const byte SInt16 = 0x03;
        public const byte UInt16 = 0x04;
        public const byte SInt32 = 0x05;
        public const byte UInt32 = 0x06;
        public const byte String = 0x07;
        public const byte Float32 = 0x08;
        public const byte Float64 = 0x09;
        public const byte UInt8z = 0x0A;
        public const byte UInt16z = 0x0B;
        public const byte UInt32z = 0x0C;
        public const byte Byte = 0x0D;
        public const byte SInt64 = 0x0E;
        public const byte UInt64 = 0x0F;
        public const byte UInt64z = 0x10;

        // And this with the type defn to get the index
        public const byte BaseTypeNumMask = 0x1F;
    }
}
