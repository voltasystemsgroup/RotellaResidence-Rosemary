using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_INTEGRA_DTR_70_4_V1_2_FEEDBACK
{
    public class UserModuleClass_INTEGRA_DTR_70_4_V1_2_FEEDBACK : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput NET_FF_REW_PUSHED;
        Crestron.Logos.SplusObjects.AnalogInput TUNER_BAND_IN;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput SLEEP_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput MAIN_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_2_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_3_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_4_VOLUME_IN;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_3_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_4_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_ALBUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_PLAY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_REPEAT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_SHUFFLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TRACK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> NET_CURSOR_POSITION_LINE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NET_LINE_TEXT;
        ushort ITEMP = 0;
        ushort ISLEEP = 0;
        ushort IFLAG1 = 0;
        ushort A = 0;
        ushort IVOL = 0;
        ushort IVOL2 = 0;
        ushort IVOL3 = 0;
        ushort IVOL4 = 0;
        ushort ITEMP1 = 0;
        ushort ICURSORPOSITION = 0;
        ushort ITEMP2 = 0;
        ushort ITEMP3 = 0;
        ushort INETDELAY = 0;
        ushort ISEMAPHORE = 0;
        CrestronString STEMP;
        CrestronString STEMP1;
        CrestronString STUNER;
        CrestronString STUNERZONE;
        CrestronString STUNER4;
        CrestronString STUNER3;
        CrestronString [] SLINETEXT;
        CrestronString SNATARTIST;
        CrestronString SNATALBUM;
        CrestronString SNATTITLE;
        CrestronString SNATTIME;
        CrestronString SNATPLAY;
        CrestronString SNATREPEAT;
        CrestronString SNATSHUFFLE;
        CrestronString SNATTRACK;
        object NET_FF_REW_PUSHED_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 87;
                CreateWait ( "WNETDELAY" , 500 , WNETDELAY_Callback ) ;
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public void WNETDELAY_CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 89;
            INETDELAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 90;
            NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
object NET_FF_REW_PUSHED_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 96;
        CancelWait ( "WNETDELAY" ) ; 
        __context__.SourceCodeLine = 97;
        INETDELAY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 102;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 104;
            ISEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 105;
            while ( Functions.TestForTrue  ( ( 1)  ) ) 
                { 
                __context__.SourceCodeLine = 107;
                STEMP  .UpdateValue ( Functions.Gather ( "\u001A" , FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( Functions.Length( STEMP ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLP" , STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 112;
                        ITEMP1 = (ushort) ( Functions.Find( "!1SLP" , STEMP ) ) ; 
                        __context__.SourceCodeLine = 113;
                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SLP" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                        __context__.SourceCodeLine = 114;
                        ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                        __context__.SourceCodeLine = 115;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ISLEEP))  ) ) 
                            { 
                            __context__.SourceCodeLine = 117;
                            ISLEEP = (ushort) ( ITEMP ) ; 
                            __context__.SourceCodeLine = 118;
                            SLEEP_TIME  .Value = (ushort) ( ISLEEP ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 120;
                        STEMP1  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 121;
                        STEMP  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 123;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1MVL" , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 125;
                            ITEMP1 = (ushort) ( Functions.Find( "!1MVL" , STEMP ) ) ; 
                            __context__.SourceCodeLine = 126;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1MVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                            __context__.SourceCodeLine = 127;
                            ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 128;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL))  ) ) 
                                { 
                                __context__.SourceCodeLine = 130;
                                IVOL = (ushort) ( ITEMP ) ; 
                                __context__.SourceCodeLine = 131;
                                MAIN_VOLUME_IN  .Value = (ushort) ( IVOL ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 133;
                            STEMP1  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 134;
                            STEMP  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 136;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1ZVL" , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 138;
                                ITEMP1 = (ushort) ( Functions.Find( "!1ZVL" , STEMP ) ) ; 
                                __context__.SourceCodeLine = 139;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1ZVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                __context__.SourceCodeLine = 140;
                                ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                __context__.SourceCodeLine = 141;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL2))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 143;
                                    IVOL2 = (ushort) ( ITEMP ) ; 
                                    __context__.SourceCodeLine = 144;
                                    ZONE_2_VOLUME_IN  .Value = (ushort) ( IVOL2 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 146;
                                STEMP1  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 147;
                                STEMP  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 149;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL3" , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 151;
                                    ITEMP1 = (ushort) ( Functions.Find( "!1VL3" , STEMP ) ) ; 
                                    __context__.SourceCodeLine = 152;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL3" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                    __context__.SourceCodeLine = 153;
                                    ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                    __context__.SourceCodeLine = 154;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL3))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 156;
                                        IVOL3 = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 157;
                                        ZONE_3_VOLUME_IN  .Value = (ushort) ( IVOL3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 159;
                                    STEMP1  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 160;
                                    STEMP  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 162;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL4" , STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 164;
                                        ITEMP1 = (ushort) ( Functions.Find( "!1VL4" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 165;
                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL4" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                        __context__.SourceCodeLine = 166;
                                        ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                        __context__.SourceCodeLine = 167;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL4))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 169;
                                            IVOL4 = (ushort) ( ITEMP ) ; 
                                            __context__.SourceCodeLine = 170;
                                            ZONE_4_VOLUME_IN  .Value = (ushort) ( IVOL4 ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 172;
                                        STEMP1  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 173;
                                        STEMP  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 175;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUN" , STEMP ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 177;
                                            ITEMP1 = (ushort) ( Functions.Find( "!1TUN" , STEMP ) ) ; 
                                            __context__.SourceCodeLine = 178;
                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUN" )) - ITEMP1) ) )  ) ; 
                                            __context__.SourceCodeLine = 179;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER != STEMP1))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 181;
                                                MakeString ( STUNER , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                __context__.SourceCodeLine = 182;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 184;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNER ,  (int) ( (Functions.Length( STUNER ) - 2) ) ) , Functions.Right ( STUNER ,  (int) ( 2 ) ) ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 188;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", STUNER ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            __context__.SourceCodeLine = 191;
                                            STEMP1  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 192;
                                            STEMP  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 194;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUZ" , STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 196;
                                                ITEMP1 = (ushort) ( Functions.Find( "!1TUZ" , STEMP ) ) ; 
                                                __context__.SourceCodeLine = 197;
                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUZ" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUZ" )) - ITEMP1) ) )  ) ; 
                                                __context__.SourceCodeLine = 198;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNERZONE != STEMP1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 200;
                                                    MakeString ( STUNERZONE , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                    __context__.SourceCodeLine = 201;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 203;
                                                        MakeString ( TUNER_ZONE_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNERZONE ,  (int) ( (Functions.Length( STUNERZONE ) - 2) ) ) , Functions.Right ( STUNERZONE ,  (int) ( 2 ) ) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 207;
                                                        MakeString ( TUNER_ZONE_FREQUENCY__DOLLAR__ , "{0} kHz", STUNERZONE ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                __context__.SourceCodeLine = 210;
                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 211;
                                                STEMP  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 213;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU3" , STEMP ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 215;
                                                    ITEMP1 = (ushort) ( Functions.Find( "!1TU3" , STEMP ) ) ; 
                                                    __context__.SourceCodeLine = 216;
                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU3" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU3" )) - ITEMP1) ) )  ) ; 
                                                    __context__.SourceCodeLine = 217;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER3 != STEMP1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 219;
                                                        MakeString ( STUNER3 , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                        __context__.SourceCodeLine = 220;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 222;
                                                            MakeString ( TUNER_ZONE_3_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNER3 ,  (int) ( (Functions.Length( STUNER3 ) - 2) ) ) , Functions.Right ( STUNER3 ,  (int) ( 2 ) ) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 226;
                                                            MakeString ( TUNER_ZONE_3_FREQUENCY__DOLLAR__ , "{0} kHz", STUNER3 ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 229;
                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                    __context__.SourceCodeLine = 230;
                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 232;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU4" , STEMP ) > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 234;
                                                        ITEMP1 = (ushort) ( Functions.Find( "!1TU4" , STEMP ) ) ; 
                                                        __context__.SourceCodeLine = 235;
                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU4" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU4" )) - ITEMP1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 236;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER3 != STEMP1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 238;
                                                            MakeString ( STUNER4 , "{0:d}", (short)Functions.Atoi( STEMP1 )) ; 
                                                            __context__.SourceCodeLine = 239;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNER_BAND_IN  .UshortValue == 1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 241;
                                                                MakeString ( TUNER_ZONE_4_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( STUNER4 ,  (int) ( (Functions.Length( STUNER4 ) - 2) ) ) , Functions.Right ( STUNER4 ,  (int) ( 2 ) ) ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 245;
                                                                MakeString ( TUNER_ZONE_4_FREQUENCY__DOLLAR__ , "{0} kHz", STUNER4 ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 248;
                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 249;
                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 251;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSA" , STEMP ) > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 253;
                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NLSA" , STEMP ) ) ; 
                                                            __context__.SourceCodeLine = 254;
                                                            ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 5 ) ) ) + 1) ) ; 
                                                            __context__.SourceCodeLine = 255;
                                                            ITEMP3 = (ushort) ( Functions.Find( "\u001A" , STEMP ) ) ; 
                                                            __context__.SourceCodeLine = 256;
                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( (ITEMP3 - 9) ) )  ) ; 
                                                            __context__.SourceCodeLine = 257;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLINETEXT[ ITEMP2 ] != STEMP1))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 259;
                                                                SLINETEXT [ ITEMP2 ]  .UpdateValue ( STEMP1  ) ; 
                                                                __context__.SourceCodeLine = 260;
                                                                NET_LINE_TEXT [ ITEMP2]  .UpdateValue ( SLINETEXT [ ITEMP2 ]  ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 263;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSU" , STEMP ) > 0 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 265;
                                                                ITEMP1 = (ushort) ( Functions.Find( "!1NLSU" , STEMP ) ) ; 
                                                                __context__.SourceCodeLine = 266;
                                                                ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 8 ) ) ) + 1) ) ; 
                                                                __context__.SourceCodeLine = 267;
                                                                ITEMP3 = (ushort) ( Functions.Find( "\u001A" , STEMP ) ) ; 
                                                                __context__.SourceCodeLine = 268;
                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( (ITEMP3 - 9) ) )  ) ; 
                                                                __context__.SourceCodeLine = 269;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLINETEXT[ ITEMP2 ] != STEMP1))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 271;
                                                                    SLINETEXT [ ITEMP2 ]  .UpdateValue ( STEMP1  ) ; 
                                                                    __context__.SourceCodeLine = 272;
                                                                    NET_LINE_TEXT [ ITEMP2]  .UpdateValue ( SLINETEXT [ ITEMP2 ]  ) ; 
                                                                    } 
                                                                
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 275;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSC" , STEMP ) > 0 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 277;
                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1NLSC" , STEMP ) ) ; 
                                                                    __context__.SourceCodeLine = 278;
                                                                    ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 8 ) ) ) + 1) ) ; 
                                                                    __context__.SourceCodeLine = 279;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( STEMP , (int)( 7 ) , (int)( 1 ) ) == "-"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 281;
                                                                        ITEMP2 = (ushort) ( 0 ) ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 283;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICURSORPOSITION != ITEMP2))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 285;
                                                                        ICURSORPOSITION = (ushort) ( ITEMP2 ) ; 
                                                                        __context__.SourceCodeLine = 286;
                                                                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                                                                        ushort __FN_FOREND_VAL__1 = (ushort)10; 
                                                                        int __FN_FORSTEP_VAL__1 = (int)1; 
                                                                        for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 288;
                                                                            NET_CURSOR_POSITION_LINE [ A]  .Value = (ushort) ( 0 ) ; 
                                                                            __context__.SourceCodeLine = 286;
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 290;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURSORPOSITION > 0 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 292;
                                                                            NET_CURSOR_POSITION_LINE [ ICURSORPOSITION]  .Value = (ushort) ( 1 ) ; 
                                                                            } 
                                                                        
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 295;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "P" , Functions.Mid( STEMP , (int)( 8 ) , (int)( 1 ) ) ) > 0 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 297;
                                                                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                                                        ushort __FN_FOREND_VAL__2 = (ushort)10; 
                                                                        int __FN_FORSTEP_VAL__2 = (int)1; 
                                                                        for ( A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (A  >= __FN_FORSTART_VAL__2) && (A  <= __FN_FOREND_VAL__2) ) : ( (A  <= __FN_FORSTART_VAL__2) && (A  >= __FN_FOREND_VAL__2) ) ; A  += (ushort)__FN_FORSTEP_VAL__2) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 299;
                                                                            SLINETEXT [ A ]  .UpdateValue ( ""  ) ; 
                                                                            __context__.SourceCodeLine = 300;
                                                                            NET_LINE_TEXT [ A]  .UpdateValue ( SLINETEXT [ A ]  ) ; 
                                                                            __context__.SourceCodeLine = 297;
                                                                            } 
                                                                        
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 304;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NAT" , STEMP ) > 0 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 306;
                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1NAT" , STEMP ) ) ; 
                                                                        __context__.SourceCodeLine = 307;
                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NAT" )) - ITEMP1) ) )  ) ; 
                                                                        __context__.SourceCodeLine = 308;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATARTIST != STEMP1))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 310;
                                                                            SNATARTIST  .UpdateValue ( STEMP1  ) ; 
                                                                            __context__.SourceCodeLine = 311;
                                                                            NAT_ARTIST__DOLLAR__  .UpdateValue ( SNATARTIST  ) ; 
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 313;
                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                        __context__.SourceCodeLine = 314;
                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 316;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NAL" , STEMP ) > 0 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 318;
                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NAL" , STEMP ) ) ; 
                                                                            __context__.SourceCodeLine = 319;
                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NAL" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NAL" )) - ITEMP1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 320;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATALBUM != STEMP1))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 322;
                                                                                SNATALBUM  .UpdateValue ( STEMP1  ) ; 
                                                                                __context__.SourceCodeLine = 323;
                                                                                NAT_ALBUM__DOLLAR__  .UpdateValue ( SNATALBUM  ) ; 
                                                                                } 
                                                                            
                                                                            __context__.SourceCodeLine = 325;
                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                            __context__.SourceCodeLine = 326;
                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 328;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTI" , STEMP ) > 0 ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 330;
                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1NTI" , STEMP ) ) ; 
                                                                                __context__.SourceCodeLine = 331;
                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTI" )) - ITEMP1) ) )  ) ; 
                                                                                __context__.SourceCodeLine = 332;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTITLE != STEMP1))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 334;
                                                                                    SNATTITLE  .UpdateValue ( STEMP1  ) ; 
                                                                                    __context__.SourceCodeLine = 335;
                                                                                    NAT_TITLE__DOLLAR__  .UpdateValue ( SNATTITLE  ) ; 
                                                                                    } 
                                                                                
                                                                                __context__.SourceCodeLine = 337;
                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                __context__.SourceCodeLine = 338;
                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 340;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTM" , STEMP ) > 0 ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 342;
                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1NTM" , STEMP ) ) ; 
                                                                                    __context__.SourceCodeLine = 343;
                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTM" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTM" )) - ITEMP1) ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 344;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTIME != STEMP1))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 346;
                                                                                        SNATTIME  .UpdateValue ( STEMP1  ) ; 
                                                                                        __context__.SourceCodeLine = 347;
                                                                                        NAT_TIME__DOLLAR__  .UpdateValue ( SNATTIME  ) ; 
                                                                                        } 
                                                                                    
                                                                                    __context__.SourceCodeLine = 349;
                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 350;
                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 352;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTR" , STEMP ) > 0 ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 354;
                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1NTR" , STEMP ) ) ; 
                                                                                        __context__.SourceCodeLine = 355;
                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTR" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTR" )) - ITEMP1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 356;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTRACK != STEMP1))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 358;
                                                                                            SNATTRACK  .UpdateValue ( STEMP1  ) ; 
                                                                                            __context__.SourceCodeLine = 359;
                                                                                            NAT_TRACK__DOLLAR__  .UpdateValue ( SNATTRACK  ) ; 
                                                                                            } 
                                                                                        
                                                                                        __context__.SourceCodeLine = 361;
                                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 362;
                                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 364;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NST" , STEMP ) > 0 ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 366;
                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NAT" , STEMP ) ) ; 
                                                                                            __context__.SourceCodeLine = 367;
                                                                                            STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 6 ) ) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 368;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATPLAY != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 370;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STEMP1 == "P") ) && Functions.TestForTrue ( Functions.BoolToInt (INETDELAY != 1) )) ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 372;
                                                                                                    SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                    __context__.SourceCodeLine = 373;
                                                                                                    NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 375;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STEMP1 == "P") ) && Functions.TestForTrue ( Functions.BoolToInt (INETDELAY == 1) )) ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 377;
                                                                                                        SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 381;
                                                                                                        SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                        __context__.SourceCodeLine = 382;
                                                                                                        NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 385;
                                                                                            STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 7 ) ) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 386;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATREPEAT != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 388;
                                                                                                SNATREPEAT  .UpdateValue ( STEMP1  ) ; 
                                                                                                __context__.SourceCodeLine = 389;
                                                                                                NAT_REPEAT__DOLLAR__  .UpdateValue ( SNATREPEAT  ) ; 
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 391;
                                                                                            STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 8 ) ) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 392;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATSHUFFLE != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 394;
                                                                                                SNATSHUFFLE  .UpdateValue ( STEMP1  ) ; 
                                                                                                __context__.SourceCodeLine = 395;
                                                                                                NAT_SHUFFLE__DOLLAR__  .UpdateValue ( SNATSHUFFLE  ) ; 
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 397;
                                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                                            __context__.SourceCodeLine = 398;
                                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                                            } 
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 105;
                } 
            
            __context__.SourceCodeLine = 402;
            ISEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 412;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 413;
        STEMP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 414;
        STEMP1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 415;
        ITEMP = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 416;
        INETDELAY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 417;
        ISEMAPHORE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNERZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNER4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    SNATARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATALBUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATPLAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATREPEAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATSHUFFLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATTRACK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SLINETEXT  = new CrestronString[ 11 ];
    for( uint i = 0; i < 11; i++ )
        SLINETEXT [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    
    NET_FF_REW_PUSHED = new Crestron.Logos.SplusObjects.DigitalInput( NET_FF_REW_PUSHED__DigitalInput__, this );
    m_DigitalInputList.Add( NET_FF_REW_PUSHED__DigitalInput__, NET_FF_REW_PUSHED );
    
    NET_CURSOR_POSITION_LINE = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NET_CURSOR_POSITION_LINE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( NET_CURSOR_POSITION_LINE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( NET_CURSOR_POSITION_LINE__DigitalOutput__ + i, NET_CURSOR_POSITION_LINE[i+1] );
    }
    
    TUNER_BAND_IN = new Crestron.Logos.SplusObjects.AnalogInput( TUNER_BAND_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TUNER_BAND_IN__AnalogSerialInput__, TUNER_BAND_IN );
    
    SLEEP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( SLEEP_TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SLEEP_TIME__AnalogSerialOutput__, SLEEP_TIME );
    
    MAIN_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( MAIN_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAIN_VOLUME_IN__AnalogSerialOutput__, MAIN_VOLUME_IN );
    
    ZONE_2_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_2_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_2_VOLUME_IN__AnalogSerialOutput__, ZONE_2_VOLUME_IN );
    
    ZONE_3_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_3_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_3_VOLUME_IN__AnalogSerialOutput__, ZONE_3_VOLUME_IN );
    
    ZONE_4_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_4_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_4_VOLUME_IN__AnalogSerialOutput__, ZONE_4_VOLUME_IN );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_3_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_3_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_4_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_4_FREQUENCY__DOLLAR__ );
    
    NAT_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_ARTIST__DOLLAR____AnalogSerialOutput__, NAT_ARTIST__DOLLAR__ );
    
    NAT_ALBUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_ALBUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_ALBUM__DOLLAR____AnalogSerialOutput__, NAT_ALBUM__DOLLAR__ );
    
    NAT_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TITLE__DOLLAR____AnalogSerialOutput__, NAT_TITLE__DOLLAR__ );
    
    NAT_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TIME__DOLLAR____AnalogSerialOutput__, NAT_TIME__DOLLAR__ );
    
    NAT_PLAY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_PLAY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_PLAY__DOLLAR____AnalogSerialOutput__, NAT_PLAY__DOLLAR__ );
    
    NAT_REPEAT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_REPEAT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_REPEAT__DOLLAR____AnalogSerialOutput__, NAT_REPEAT__DOLLAR__ );
    
    NAT_SHUFFLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__, NAT_SHUFFLE__DOLLAR__ );
    
    NAT_TRACK__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TRACK__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TRACK__DOLLAR____AnalogSerialOutput__, NAT_TRACK__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    NET_LINE_TEXT = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NET_LINE_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NET_LINE_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NET_LINE_TEXT__AnalogSerialOutput__ + i, NET_LINE_TEXT[i+1] );
    }
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    WNETDELAY_Callback = new WaitFunction( WNETDELAY_CallbackFn );
    
    NET_FF_REW_PUSHED.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NET_FF_REW_PUSHED_OnRelease_0, false ) );
    NET_FF_REW_PUSHED.OnDigitalPush.Add( new InputChangeHandlerWrapper( NET_FF_REW_PUSHED_OnPush_1, false ) );
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_INTEGRA_DTR_70_4_V1_2_FEEDBACK ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WNETDELAY_Callback;


const uint NET_FF_REW_PUSHED__DigitalInput__ = 0;
const uint TUNER_BAND_IN__AnalogSerialInput__ = 0;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 1;
const uint SLEEP_TIME__AnalogSerialOutput__ = 0;
const uint MAIN_VOLUME_IN__AnalogSerialOutput__ = 1;
const uint ZONE_2_VOLUME_IN__AnalogSerialOutput__ = 2;
const uint ZONE_3_VOLUME_IN__AnalogSerialOutput__ = 3;
const uint ZONE_4_VOLUME_IN__AnalogSerialOutput__ = 4;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 5;
const uint TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 6;
const uint TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 7;
const uint TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 8;
const uint NAT_ARTIST__DOLLAR____AnalogSerialOutput__ = 9;
const uint NAT_ALBUM__DOLLAR____AnalogSerialOutput__ = 10;
const uint NAT_TITLE__DOLLAR____AnalogSerialOutput__ = 11;
const uint NAT_TIME__DOLLAR____AnalogSerialOutput__ = 12;
const uint NAT_PLAY__DOLLAR____AnalogSerialOutput__ = 13;
const uint NAT_REPEAT__DOLLAR____AnalogSerialOutput__ = 14;
const uint NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__ = 15;
const uint NAT_TRACK__DOLLAR____AnalogSerialOutput__ = 16;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 17;
const uint NET_CURSOR_POSITION_LINE__DigitalOutput__ = 0;
const uint NET_LINE_TEXT__AnalogSerialOutput__ = 18;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
