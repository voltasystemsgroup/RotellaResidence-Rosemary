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

namespace UserModule_INTEGRA_DBS_301_PARSING
{
    public class UserModuleClass_INTEGRA_DBS_301_PARSING : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_FB;
        Crestron.Logos.SplusObjects.AnalogOutput TRANSPORT;
        Crestron.Logos.SplusObjects.AnalogOutput MEDIA;
        Crestron.Logos.SplusObjects.AnalogOutput DIMMER;
        Crestron.Logos.SplusObjects.AnalogOutput ASPECT;
        Crestron.Logos.SplusObjects.AnalogOutput HDMI_RESOLUTION;
        Crestron.Logos.SplusObjects.AnalogOutput HDMI_SETUP;
        Crestron.Logos.SplusObjects.AnalogOutput LANGUAGE;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_CURRENT;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_TOTAL;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_CURRENT;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_TOTAL;
        Crestron.Logos.SplusObjects.AnalogOutput TIME_HOURS;
        Crestron.Logos.SplusObjects.AnalogOutput TIME_MINUTES;
        Crestron.Logos.SplusObjects.AnalogOutput TIME_SECONDS;
        Crestron.Logos.SplusObjects.AnalogOutput TIME_TOTALSEC;
        CrestronString [] KEY__DOLLAR__;
        private void PARSE (  SplusExecutionContext __context__, CrestronString INPUT__DOLLAR__ , ushort TYPE ) 
            { 
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 29;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) == "FF\u001A"))  ) ) 
                {
                __context__.SourceCodeLine = 29;
                return ; 
                }
            
            __context__.SourceCodeLine = 30;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)TYPE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 01) ) ) ) 
                        { 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 02) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 38;
                        X = (ushort) ( Functions.Atoi( Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) ) ) ; 
                        __context__.SourceCodeLine = 39;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (X == 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 39;
                            POWER_FB  .Value = (ushort) ( 0 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 40;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( X < 4 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 42;
                            TRANSPORT  .Value = (ushort) ( X ) ; 
                            __context__.SourceCodeLine = 43;
                            POWER_FB  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 03) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 48;
                        MEDIA  .Value = (ushort) ( Functions.Atoi( Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 04) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 52;
                        DIMMER  .Value = (ushort) ( Functions.Atoi( Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 05) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 56;
                        ASPECT  .Value = (ushort) ( Functions.Atoi( Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 06) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 60;
                        TITLE_CURRENT  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 6 ) , (int)( 3 ) ) ) ) ; 
                        __context__.SourceCodeLine = 61;
                        TITLE_TOTAL  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 9 ) , (int)( 3 ) ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 07) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 65;
                        CHAPTER_CURRENT  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 6 ) , (int)( 3 ) ) ) ) ; 
                        __context__.SourceCodeLine = 66;
                        CHAPTER_TOTAL  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 9 ) , (int)( 3 ) ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 08) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 70;
                        TIME_HOURS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 6 ) , (int)( 1 ) ) ) ) ; 
                        __context__.SourceCodeLine = 71;
                        TIME_MINUTES  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 7 ) , (int)( 2 ) ) ) ) ; 
                        __context__.SourceCodeLine = 72;
                        TIME_SECONDS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( INPUT__DOLLAR__ , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                        __context__.SourceCodeLine = 73;
                        TIME_TOTALSEC  .Value = (ushort) ( ((((TIME_HOURS  .Value * 60) * 60) + (TIME_MINUTES  .Value * 60)) + TIME_SECONDS  .Value) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 09) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 77;
                        HDMI_RESOLUTION  .Value = (ushort) ( Functions.Atoi( Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) ) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 81;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( INPUT__DOLLAR__ , (int)( 6 ) , (int)( 2 ) ) == "EN"))  ) ) 
                            {
                            __context__.SourceCodeLine = 81;
                            LANGUAGE  .Value = (ushort) ( 1 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 82;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( INPUT__DOLLAR__ , (int)( 6 ) , (int)( 2 ) ) == "FR"))  ) ) 
                            {
                            __context__.SourceCodeLine = 82;
                            LANGUAGE  .Value = (ushort) ( 2 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 83;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( INPUT__DOLLAR__ , (int)( 6 ) , (int)( 2 ) ) == "SP"))  ) ) 
                            {
                            __context__.SourceCodeLine = 83;
                            LANGUAGE  .Value = (ushort) ( 3 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                        { 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 91;
                        HDMI_SETUP  .Value = (ushort) ( Functions.Atoi( Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) ) ) ; 
                        __context__.SourceCodeLine = 92;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( INPUT__DOLLAR__ , (int)( 3 ) ) == "OF\u001A"))  ) ) 
                            {
                            __context__.SourceCodeLine = 92;
                            HDMI_SETUP  .Value = (ushort) ( 7 ) ; 
                            }
                        
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        object RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort CTR = 0;
                
                CrestronString TEMP__DOLLAR__;
                TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
                
                
                __context__.SourceCodeLine = 101;
                TEMP__DOLLAR__  .UpdateValue ( Functions.Gather ( "\u001A" , RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 102;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)12; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( CTR  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (CTR  >= __FN_FORSTART_VAL__1) && (CTR  <= __FN_FOREND_VAL__1) ) : ( (CTR  <= __FN_FORSTART_VAL__1) && (CTR  >= __FN_FOREND_VAL__1) ) ; CTR  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 104;
                    if ( Functions.TestForTrue  ( ( Functions.Find( KEY__DOLLAR__[ CTR ] , TEMP__DOLLAR__ ))  ) ) 
                        {
                        __context__.SourceCodeLine = 104;
                        PARSE (  __context__ , TEMP__DOLLAR__, (ushort)( CTR )) ; 
                        }
                    
                    __context__.SourceCodeLine = 102;
                    } 
                
                __context__.SourceCodeLine = 106;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 106;
                    Print( ">>{0}<<", TEMP__DOLLAR__ ) ; 
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
            
            __context__.SourceCodeLine = 112;
            KEY__DOLLAR__ [ 00 ]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 113;
            KEY__DOLLAR__ [ 01 ]  .UpdateValue ( "SPM"  ) ; 
            __context__.SourceCodeLine = 114;
            KEY__DOLLAR__ [ 02 ]  .UpdateValue ( "SST"  ) ; 
            __context__.SourceCodeLine = 115;
            KEY__DOLLAR__ [ 03 ]  .UpdateValue ( "DST"  ) ; 
            __context__.SourceCodeLine = 116;
            KEY__DOLLAR__ [ 04 ]  .UpdateValue ( "MST"  ) ; 
            __context__.SourceCodeLine = 117;
            KEY__DOLLAR__ [ 05 ]  .UpdateValue ( "AST"  ) ; 
            __context__.SourceCodeLine = 118;
            KEY__DOLLAR__ [ 06 ]  .UpdateValue ( "STG"  ) ; 
            __context__.SourceCodeLine = 119;
            KEY__DOLLAR__ [ 07 ]  .UpdateValue ( "STC"  ) ; 
            __context__.SourceCodeLine = 120;
            KEY__DOLLAR__ [ 08 ]  .UpdateValue ( "SET"  ) ; 
            __context__.SourceCodeLine = 121;
            KEY__DOLLAR__ [ 09 ]  .UpdateValue ( "SMO"  ) ; 
            __context__.SourceCodeLine = 122;
            KEY__DOLLAR__ [ 10 ]  .UpdateValue ( "SCM"  ) ; 
            __context__.SourceCodeLine = 123;
            KEY__DOLLAR__ [ 11 ]  .UpdateValue ( "SCC"  ) ; 
            __context__.SourceCodeLine = 124;
            KEY__DOLLAR__ [ 12 ]  .UpdateValue ( "SMR"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        KEY__DOLLAR__  = new CrestronString[ 13 ];
        for( uint i = 0; i < 13; i++ )
            KEY__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        
        DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
        m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
        
        POWER_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( POWER_FB__DigitalOutput__, POWER_FB );
        
        TRANSPORT = new Crestron.Logos.SplusObjects.AnalogOutput( TRANSPORT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TRANSPORT__AnalogSerialOutput__, TRANSPORT );
        
        MEDIA = new Crestron.Logos.SplusObjects.AnalogOutput( MEDIA__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( MEDIA__AnalogSerialOutput__, MEDIA );
        
        DIMMER = new Crestron.Logos.SplusObjects.AnalogOutput( DIMMER__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( DIMMER__AnalogSerialOutput__, DIMMER );
        
        ASPECT = new Crestron.Logos.SplusObjects.AnalogOutput( ASPECT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( ASPECT__AnalogSerialOutput__, ASPECT );
        
        HDMI_RESOLUTION = new Crestron.Logos.SplusObjects.AnalogOutput( HDMI_RESOLUTION__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( HDMI_RESOLUTION__AnalogSerialOutput__, HDMI_RESOLUTION );
        
        HDMI_SETUP = new Crestron.Logos.SplusObjects.AnalogOutput( HDMI_SETUP__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( HDMI_SETUP__AnalogSerialOutput__, HDMI_SETUP );
        
        LANGUAGE = new Crestron.Logos.SplusObjects.AnalogOutput( LANGUAGE__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( LANGUAGE__AnalogSerialOutput__, LANGUAGE );
        
        TITLE_CURRENT = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_CURRENT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TITLE_CURRENT__AnalogSerialOutput__, TITLE_CURRENT );
        
        TITLE_TOTAL = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_TOTAL__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TITLE_TOTAL__AnalogSerialOutput__, TITLE_TOTAL );
        
        CHAPTER_CURRENT = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_CURRENT__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CHAPTER_CURRENT__AnalogSerialOutput__, CHAPTER_CURRENT );
        
        CHAPTER_TOTAL = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_TOTAL__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CHAPTER_TOTAL__AnalogSerialOutput__, CHAPTER_TOTAL );
        
        TIME_HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( TIME_HOURS__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TIME_HOURS__AnalogSerialOutput__, TIME_HOURS );
        
        TIME_MINUTES = new Crestron.Logos.SplusObjects.AnalogOutput( TIME_MINUTES__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TIME_MINUTES__AnalogSerialOutput__, TIME_MINUTES );
        
        TIME_SECONDS = new Crestron.Logos.SplusObjects.AnalogOutput( TIME_SECONDS__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TIME_SECONDS__AnalogSerialOutput__, TIME_SECONDS );
        
        TIME_TOTALSEC = new Crestron.Logos.SplusObjects.AnalogOutput( TIME_TOTALSEC__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( TIME_TOTALSEC__AnalogSerialOutput__, TIME_TOTALSEC );
        
        RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 200, this );
        m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
        
        
        RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_INTEGRA_DBS_301_PARSING ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint DEBUG__DigitalInput__ = 0;
    const uint RX__DOLLAR____AnalogSerialInput__ = 0;
    const uint POWER_FB__DigitalOutput__ = 0;
    const uint TRANSPORT__AnalogSerialOutput__ = 0;
    const uint MEDIA__AnalogSerialOutput__ = 1;
    const uint DIMMER__AnalogSerialOutput__ = 2;
    const uint ASPECT__AnalogSerialOutput__ = 3;
    const uint HDMI_RESOLUTION__AnalogSerialOutput__ = 4;
    const uint HDMI_SETUP__AnalogSerialOutput__ = 5;
    const uint LANGUAGE__AnalogSerialOutput__ = 6;
    const uint TITLE_CURRENT__AnalogSerialOutput__ = 7;
    const uint TITLE_TOTAL__AnalogSerialOutput__ = 8;
    const uint CHAPTER_CURRENT__AnalogSerialOutput__ = 9;
    const uint CHAPTER_TOTAL__AnalogSerialOutput__ = 10;
    const uint TIME_HOURS__AnalogSerialOutput__ = 11;
    const uint TIME_MINUTES__AnalogSerialOutput__ = 12;
    const uint TIME_SECONDS__AnalogSerialOutput__ = 13;
    const uint TIME_TOTALSEC__AnalogSerialOutput__ = 14;
    
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
