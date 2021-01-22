[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.02.26
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Hd
  Cmn1=	This module will help with the queueing of commands when controlling||1
  Cmn2=display\\devices. When a command needs to be sent, set the Requested||1
  Cmn3=input to any value\\except the ones listed below. When the Send||1
  Cmn4=input is pushed, the Requested value\\will be sent to the Send_Value||1
  Cmn5=output. The Send_Value output would get routed to an\\analog equate.
  Cmn6=||1The output of the analog equate would drive a serial I/O to send||1
  Cmn7=the\\proper command. When it is desired to have the command resent||1
  Cmn8=if the display device\\does not go to the desired state, set the||1
  Cmn9=Compare input high. When the Compare input\\is set high, the Command_To_Send||1
  Cmn10=output will remain high after the Send_Value gets\\set to the requested||1
  Cmn11=value. The next time the Send input is pushed, the module will\\
  Cmn12=set the Send_Value output to the Poll value listed below. After||1
  Cmn13=each command and\\poll value, the Send_Value output will be set||1
  Cmn14=to the clear value. Both the Requested\\and Current inputs should||1
  Cmn15=be set to the clear value at start up. This can be done\\using an||1
  Cmn16=analog initialize. The Command_To_Send output will be set high if||1
  Cmn17=the\\Requested value does not equal the Current value. It will be||1
  Cmn18=set low when the values\\are equal, when the command has been sent||1
  Cmn19=the maximum number of times or when the\\command has been sent and||1
  Cmn20=the Compare input is low. Therefore the Command_To_Send\\output||1
  Cmn21=could be used to drive an oscillator. This module is really designed||1
  Cmn22=to be\\used to queue command for one parameter of e display device||1
  Cmn23=like power OR input. In\\that case, the Command_To_Send output would||1
  Cmn24=probably drive an OR gate, which then\\would drive an oscillator.
  Cmn25=\\\\	CLEAR = 9999d\\	POLL = 999d\\	
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,310,718,756,854,
  Exclusions_CDS=5
  Inclusions_CDS=6
  Name=Compare - Command Queue (cm)
  SmplCName=Compare - Command Queue.csp
  Code=1
  SysRev5=3.090
  InputCue1=Send
  InputSigType1=Digital
  InputCue2=Compare
  InputSigType2=Digital
  OutputCue1=Command_To_Send
  OutputSigType1=Digital
  OutputCue2=Send_Next
  OutputSigType2=Digital
  InputList2Cue1=Requested
  InputList2SigType1=Analog
  InputList2Cue2=Current
  InputList2SigType2=Analog
  OutputList2Cue1=Send_Value
  OutputList2SigType1=Analog
  OutputList2Cue2=Clear_Current
  OutputList2SigType2=Analog
  OutputList2Cue3=Clear_Requested
  OutputList2SigType3=Analog
  ParamCue1=[Reference Name]
  MinVariableInputs=2
  MaxVariableInputs=2
  MinVariableInputsList2=2
  MaxVariableInputsList2=2
  MinVariableOutputs=2
  MaxVariableOutputs=2
  MinVariableOutputsList2=3
  MaxVariableOutputsList2=3
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=24
  Hint=
  PdfHelp=
  HelpID= 
  Render=4
  Smpl-C=16
  CompilerCode=-48
  CompilerParamCode=27
  CompilerParamCode5=14
  NumFixedParams=1
  Pp1=1
  MPp=1
  NVStorage=10
  ParamSigType1=String
  SmplCInputCue1=o#
  SmplCOutputCue1=i#
  SmplCInputList2Cue1=an#
  SmplCOutputList2Cue1=ai#
  SPlus2CompiledName=S2_Compare___Command_Queue
  SymJam=NonExclusive
  FileName=Compare - Command Queue.csh
  SIMPLPlusModuleEncoding=0
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
