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


public enum TimeZone {
    ALMATY((short)0),
    BANGKOK((short)1),
    BOMBAY((short)2),
    BRASILIA((short)3),
    CAIRO((short)4),
    CAPE_VERDE_IS((short)5),
    DARWIN((short)6),
    ENIWETOK((short)7),
    FIJI((short)8),
    HONG_KONG((short)9),
    ISLAMABAD((short)10),
    KABUL((short)11),
    MAGADAN((short)12),
    MID_ATLANTIC((short)13),
    MOSCOW((short)14),
    MUSCAT((short)15),
    NEWFOUNDLAND((short)16),
    SAMOA((short)17),
    SYDNEY((short)18),
    TEHRAN((short)19),
    TOKYO((short)20),
    US_ALASKA((short)21),
    US_ATLANTIC((short)22),
    US_CENTRAL((short)23),
    US_EASTERN((short)24),
    US_HAWAII((short)25),
    US_MOUNTAIN((short)26),
    US_PACIFIC((short)27),
    OTHER((short)28),
    AUCKLAND((short)29),
    KATHMANDU((short)30),
    EUROPE_WESTERN_WET((short)31),
    EUROPE_CENTRAL_CET((short)32),
    EUROPE_EASTERN_EET((short)33),
    JAKARTA((short)34),
    PERTH((short)35),
    ADELAIDE((short)36),
    BRISBANE((short)37),
    TASMANIA((short)38),
    ICELAND((short)39),
    AMSTERDAM((short)40),
    ATHENS((short)41),
    BARCELONA((short)42),
    BERLIN((short)43),
    BRUSSELS((short)44),
    BUDAPEST((short)45),
    COPENHAGEN((short)46),
    DUBLIN((short)47),
    HELSINKI((short)48),
    LISBON((short)49),
    LONDON((short)50),
    MADRID((short)51),
    MUNICH((short)52),
    OSLO((short)53),
    PARIS((short)54),
    PRAGUE((short)55),
    REYKJAVIK((short)56),
    ROME((short)57),
    STOCKHOLM((short)58),
    VIENNA((short)59),
    WARSAW((short)60),
    ZURICH((short)61),
    QUEBEC((short)62),
    ONTARIO((short)63),
    MANITOBA((short)64),
    SASKATCHEWAN((short)65),
    ALBERTA((short)66),
    BRITISH_COLUMBIA((short)67),
    BOISE((short)68),
    BOSTON((short)69),
    CHICAGO((short)70),
    DALLAS((short)71),
    DENVER((short)72),
    KANSAS_CITY((short)73),
    LAS_VEGAS((short)74),
    LOS_ANGELES((short)75),
    MIAMI((short)76),
    MINNEAPOLIS((short)77),
    NEW_YORK((short)78),
    NEW_ORLEANS((short)79),
    PHOENIX((short)80),
    SANTA_FE((short)81),
    SEATTLE((short)82),
    WASHINGTON_DC((short)83),
    US_ARIZONA((short)84),
    CHITA((short)85),
    EKATERINBURG((short)86),
    IRKUTSK((short)87),
    KALININGRAD((short)88),
    KRASNOYARSK((short)89),
    NOVOSIBIRSK((short)90),
    PETROPAVLOVSK_KAMCHATSKIY((short)91),
    SAMARA((short)92),
    VLADIVOSTOK((short)93),
    MEXICO_CENTRAL((short)94),
    MEXICO_MOUNTAIN((short)95),
    MEXICO_PACIFIC((short)96),
    CAPE_TOWN((short)97),
    WINKHOEK((short)98),
    LAGOS((short)99),
    RIYAHD((short)100),
    VENEZUELA((short)101),
    AUSTRALIA_LH((short)102),
    SANTIAGO((short)103),
    MANUAL((short)253),
    AUTOMATIC((short)254),
    INVALID((short)255);

    protected short value;

    private TimeZone(short value) {
        this.value = value;
    }

    public static TimeZone getByValue(final Short value) {
        for (final TimeZone type : TimeZone.values()) {
            if (value == type.value)
                return type;
        }

        return TimeZone.INVALID;
    }

    /**
     * Retrieves the String Representation of the Value
     * @return The string representation of the value
     */
    public static String getStringFromValue( TimeZone value ) {
        return value.name();
    }

    public short getValue() {
        return value;
    }


}
