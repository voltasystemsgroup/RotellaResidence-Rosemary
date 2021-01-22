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

namespace UserModule_INTEGRA_DTR_70_4_V1_2_PROCESSOR
{
    public class UserModuleClass_INTEGRA_DTR_70_4_V1_2_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DONE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TUNER_KEY;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogInput SELECTED_TUNER;
        Crestron.Logos.SplusObjects.BufferInput TUNER_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput VOLUME_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput TUNER_FREQUENCY_IN;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_FB;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort IVOL = 0;
        ushort IVOLCHANGING = 0;
        CrestronString SFREQ;
        CrestronString STUNER;
        CrestronString SVOLUME;
        CrestronString SFREQIN;
        object TUNER_KEY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ITEMP = 0;
                
                
                __context__.SourceCodeLine = 64;
                ITEMP = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 65;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != 100))  ) ) 
                    { 
                    __context__.SourceCodeLine = 67;
                    switch ((int)SELECTED_TUNER  .UshortValue)
                    
                        { 
                        case 1 : 
                        
                            { 
                            __context__.SourceCodeLine = 71;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 73;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 75;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 77;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 78;
                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                        __context__.SourceCodeLine = 79;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 83;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 86;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 88;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 90;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 91;
                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                            __context__.SourceCodeLine = 92;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 95;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 97;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 98;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQIN  ) ; 
                                            __context__.SourceCodeLine = 99;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 101;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 103;
                                                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 105;
                                                    SFREQ  .UpdateValue ( "0" + SFREQ  ) ; 
                                                    __context__.SourceCodeLine = 103;
                                                    } 
                                                
                                                __context__.SourceCodeLine = 107;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", STUNER , SFREQ ) ; 
                                                __context__.SourceCodeLine = 108;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 109;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 114;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 116;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 117;
                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                    __context__.SourceCodeLine = 118;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 122;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 125;
                            break ; 
                            } 
                        
                        goto case 2 ;
                        case 2 : 
                        
                            { 
                            __context__.SourceCodeLine = 129;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 131;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 133;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 135;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 136;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 5))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 138;
                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 2) ) ) , Functions.Right ( SFREQ ,  (int) ( 2 ) ) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 140;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 4))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 142;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 56) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 57) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 144;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 2) ) ) , Functions.Right ( SFREQ ,  (int) ( 2 ) ) ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 148;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) ) , Functions.Right ( SFREQ ,  (int) ( 1 ) ) ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 151;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 3))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 153;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 56) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 57) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 155;
                                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) ) , Functions.Right ( SFREQ ,  (int) ( 1 ) ) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 159;
                                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 162;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 2))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 164;
                                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 168;
                                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        __context__.SourceCodeLine = 170;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 174;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 177;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 179;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 181;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 182;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 5))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 184;
                                                MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 2) ) ) , Functions.Right ( SFREQ ,  (int) ( 2 ) ) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 186;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 4))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 188;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 56) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 57) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 190;
                                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 2) ) ) , Functions.Right ( SFREQ ,  (int) ( 2 ) ) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        { 
                                                        __context__.SourceCodeLine = 194;
                                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) ) , Functions.Right ( SFREQ ,  (int) ( 1 ) ) ) ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 197;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 3))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 199;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 56) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 57) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 201;
                                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) ) , Functions.Right ( SFREQ ,  (int) ( 1 ) ) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 205;
                                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                            } 
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 208;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 2))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 210;
                                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 214;
                                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            __context__.SourceCodeLine = 216;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 219;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 221;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 222;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQIN  ) ; 
                                            __context__.SourceCodeLine = 223;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 225;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 227;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 3))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 229;
                                                    SFREQ  .UpdateValue ( "0" + SFREQ + "0"  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 231;
                                                    if ( Functions.TestForTrue  ( ( (Functions.BoolToInt (Functions.Length( SFREQ ) == 4) & Functions.BoolToInt (Byte( SFREQ , (int)( 4 ) ) != 48)))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 233;
                                                        SFREQ  .UpdateValue ( SFREQ + "0"  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 235;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 4))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 237;
                                                            SFREQ  .UpdateValue ( "0" + SFREQ  ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                __context__.SourceCodeLine = 239;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", STUNER , SFREQ ) ; 
                                                __context__.SourceCodeLine = 240;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 241;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 245;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 250;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 252;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 253;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 5))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 255;
                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 2) ) ) , Functions.Right ( SFREQ ,  (int) ( 2 ) ) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 257;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 4))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 259;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 56) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 57) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 261;
                                                MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 2) ) ) , Functions.Right ( SFREQ ,  (int) ( 2 ) ) ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 265;
                                                MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) ) , Functions.Right ( SFREQ ,  (int) ( 1 ) ) ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 268;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 3))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 270;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 56) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( SFREQ , (int)( 1 ) ) == 57) )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 272;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0}.{1} MHz", Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) ) , Functions.Right ( SFREQ ,  (int) ( 1 ) ) ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 276;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                    } 
                                                
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 279;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 2))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 281;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                    } 
                                                
                                                else 
                                                    { 
                                                    __context__.SourceCodeLine = 285;
                                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    __context__.SourceCodeLine = 287;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 291;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 294;
                            break ; 
                            } 
                        
                        goto default;
                        default : 
                        
                            { 
                            __context__.SourceCodeLine = 298;
                            ITEMP = (ushort) ( 100 ) ; 
                            __context__.SourceCodeLine = 299;
                            break ; 
                            } 
                        break;
                        
                        } 
                        
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUME_UP_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 307;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOL < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 309;
                IVOLCHANGING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 310;
                IVOL = (ushort) ( (IVOL + 1) ) ; 
                __context__.SourceCodeLine = 311;
                VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
                __context__.SourceCodeLine = 312;
                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:X2}\r", SVOLUME , IVOL) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object VOLUME_DOWN_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 318;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOL > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 320;
            IVOLCHANGING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 321;
            IVOL = (ushort) ( (IVOL - 1) ) ; 
            __context__.SourceCodeLine = 322;
            VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
            __context__.SourceCodeLine = 323;
            MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:X2}\r", SVOLUME , IVOL) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_DONE_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 329;
        IVOLCHANGING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_IN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 334;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( VOLUME_IN  .UshortValue <= 100 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( VOLUME_IN  .UshortValue >= 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (IVOLCHANGING == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (VOLUME_IN  .UshortValue != IVOL) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 336;
            IVOL = (ushort) ( VOLUME_IN  .UshortValue ) ; 
            __context__.SourceCodeLine = 337;
            VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TUNER_COMMAND__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 343;
        STUNER  .UpdateValue ( TUNER_COMMAND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_COMMAND__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 348;
        SVOLUME  .UpdateValue ( VOLUME_COMMAND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TUNER_FREQUENCY_IN_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 353;
        SFREQIN  .UpdateValue ( TUNER_FREQUENCY_IN  ) ; 
        __context__.SourceCodeLine = 354;
        Functions.ClearBuffer ( TUNER_FREQUENCY_IN ) ; 
        __context__.SourceCodeLine = 355;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SFREQ ) == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 357;
            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQIN  ) ; 
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
        
        __context__.SourceCodeLine = 367;
        IVOLCHANGING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SFREQ  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    SVOLUME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    SFREQIN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DOWN__DigitalInput__, VOLUME_DOWN );
    
    VOLUME_DONE = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DONE__DigitalInput__, VOLUME_DONE );
    
    TUNER_KEY = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        TUNER_KEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TUNER_KEY__DigitalInput__ + i, TUNER_KEY__DigitalInput__, this );
        m_DigitalInputList.Add( TUNER_KEY__DigitalInput__ + i, TUNER_KEY[i+1] );
    }
    
    VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_IN__AnalogSerialInput__, VOLUME_IN );
    
    SELECTED_TUNER = new Crestron.Logos.SplusObjects.AnalogInput( SELECTED_TUNER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECTED_TUNER__AnalogSerialInput__, SELECTED_TUNER );
    
    VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_FB__AnalogSerialOutput__, VOLUME_FB );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    TUNER_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( TUNER_COMMAND__DOLLAR____AnalogSerialInput__, 6, this );
    m_StringInputList.Add( TUNER_COMMAND__DOLLAR____AnalogSerialInput__, TUNER_COMMAND__DOLLAR__ );
    
    VOLUME_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( VOLUME_COMMAND__DOLLAR____AnalogSerialInput__, 6, this );
    m_StringInputList.Add( VOLUME_COMMAND__DOLLAR____AnalogSerialInput__, VOLUME_COMMAND__DOLLAR__ );
    
    TUNER_FREQUENCY_IN = new Crestron.Logos.SplusObjects.BufferInput( TUNER_FREQUENCY_IN__AnalogSerialInput__, 10, this );
    m_StringInputList.Add( TUNER_FREQUENCY_IN__AnalogSerialInput__, TUNER_FREQUENCY_IN );
    
    
    for( uint i = 0; i < 13; i++ )
        TUNER_KEY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TUNER_KEY_OnPush_0, false ) );
        
    VOLUME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnPush_1, false ) );
    VOLUME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_DOWN_OnPush_2, false ) );
    VOLUME_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUME_DONE_OnRelease_3, false ) );
    VOLUME_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_IN_OnChange_4, false ) );
    TUNER_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TUNER_COMMAND__DOLLAR___OnChange_5, false ) );
    VOLUME_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VOLUME_COMMAND__DOLLAR___OnChange_6, false ) );
    TUNER_FREQUENCY_IN.OnSerialChange.Add( new InputChangeHandlerWrapper( TUNER_FREQUENCY_IN_OnChange_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_INTEGRA_DTR_70_4_V1_2_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOLUME_UP__DigitalInput__ = 0;
const uint VOLUME_DOWN__DigitalInput__ = 1;
const uint VOLUME_DONE__DigitalInput__ = 2;
const uint TUNER_KEY__DigitalInput__ = 3;
const uint VOLUME_IN__AnalogSerialInput__ = 0;
const uint SELECTED_TUNER__AnalogSerialInput__ = 1;
const uint TUNER_COMMAND__DOLLAR____AnalogSerialInput__ = 2;
const uint VOLUME_COMMAND__DOLLAR____AnalogSerialInput__ = 3;
const uint TUNER_FREQUENCY_IN__AnalogSerialInput__ = 4;
const uint VOLUME_FB__AnalogSerialOutput__ = 0;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 1;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 2;

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
