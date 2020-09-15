
// CppString.cs - generated by the SLK parser generator 

namespace Cpp.Parser {

class CppString {

private static string[] Nonterminal_name ={"0"

,"PROGRAM"
,"STATEMENTS"
,"STATEMENT"
,"FUNCTION_STATEMENT"
,"FUNCTION_STATEMENT_DESC"
,"FUNCTION_CALLS"
,"FUNCTION_EX_CALL"
,"FUNCTION_EX_CALL_SPECIAL"
,"FUNCTION_PARAMS"
,"STATIC_MEMBER_DESC"
,"MEMBER_DESC"
,"MEMBER_DESC2"
,"MEMBER_DESC3"
,"MEMBER_DESC4"
,"FUNCTION_ID"
,"SEP"
,"SEP_STATEMENT_*"
,"FUNCTION_EX_CALL_*"
,"FUNCTION_EX_CALL_2_*"
,"FUNCTION_PARAMS_opt"
,"FUNCTION_PARAMS_2_opt"
,"FUNCTION_PARAMS_3_opt"
,"FUNCTION_PARAMS_4_opt"
,"FUNCTION_PARAMS_5_opt"
,"FUNCTION_PARAMS_6_opt"
,"FUNCTION_PARAMS_7_opt"
,"FUNCTION_PARAMS_8_opt"
,"FUNCTION_PARAMS_9_opt"
,"FUNCTION_PARAMS_10_opt"
,"FUNCTION_PARAMS_11_opt"
,"FUNCTION_PARAMS_12_opt"
};

private static string[] Terminal_name ={"0"

,"("
,")"
,"["
,"]"
,"::"
,"."
,"POINTER"
,"PERIOD_STAR"
,"POINTER_STAR"
,"{"
,"}"
,"BRACKET_COLON_BEGIN"
,"BRACKET_COLON_END"
,"ANGLE_BRACKET_COLON_BEGIN"
,"ANGLE_BRACKET_COLON_END"
,"ANGLE_BRACKET_PERCENT_BEGIN"
,"ANGLE_BRACKET_PERCENT_END"
,"IDENTIFIER"
,"STRING"
,"NUMBER"
,","
,";"
,"END_OF_SLK_INPUT"
};

private static string[] Action_name ={"0"

,"_action_endStatement"
,"_action_beginStatement"
,"_action_cppOnFunctionBegin"
,"_action_addFunction"
,"_action_cppOnFunctionEnd"
,"_action_setFunctionId"
,"_action_markParenthesisParam"
,"_action_buildHighOrderFunction"
,"_action_markBracketParam"
,"_action_markStatement"
,"_action_markBracketColonParam"
,"_action_markAngleBracketColonParam"
,"_action_markAngleBracketPercentParam"
,"_action_markColonColonParam"
,"_action_setMemberId"
,"_action_markPeriodParam"
,"_action_markPointerParam"
,"_action_markPeriodStarParam"
,"_action_markPointerStarParam"
,"_action_pushId"
,"_action_pushStr"
,"_action_pushNum"
};

private static string[] Production_name ={"0"

,"PROGRAM --> STATEMENTS"
,"STATEMENTS --> STATEMENT SEP_STATEMENT_*"
,"STATEMENT --> FUNCTION_STATEMENT"
,"FUNCTION_STATEMENT --> FUNCTION_STATEMENT_DESC _action_endStatement"
,"FUNCTION_STATEMENT_DESC --> _action_beginStatement FUNCTION_CALLS"
,"FUNCTION_CALLS --> FUNCTION_EX_CALL_*"
,"FUNCTION_CALLS --> _action_cppOnFunctionBegin _action_addFunction FUNCTION_EX_CALL_SPECIAL _action_cppOnFunctionEnd FUNCTION_EX_CALL_2_*"
,"FUNCTION_EX_CALL --> FUNCTION_ID _action_setFunctionId FUNCTION_PARAMS_opt"
,"FUNCTION_EX_CALL_SPECIAL --> FUNCTION_PARAMS"
,"FUNCTION_PARAMS --> _action_markParenthesisParam ( STATEMENTS ) FUNCTION_PARAMS_2_opt"
,"FUNCTION_PARAMS --> _action_markBracketParam [ STATEMENTS ] FUNCTION_PARAMS_3_opt"
,"FUNCTION_PARAMS --> :: STATIC_MEMBER_DESC FUNCTION_PARAMS_4_opt"
,"FUNCTION_PARAMS --> . MEMBER_DESC FUNCTION_PARAMS_5_opt"
,"FUNCTION_PARAMS --> POINTER MEMBER_DESC2 FUNCTION_PARAMS_6_opt"
,"FUNCTION_PARAMS --> PERIOD_STAR MEMBER_DESC3 FUNCTION_PARAMS_7_opt"
,"FUNCTION_PARAMS --> POINTER_STAR MEMBER_DESC4 FUNCTION_PARAMS_8_opt"
,"FUNCTION_PARAMS --> _action_markStatement { STATEMENTS } FUNCTION_PARAMS_9_opt"
,"FUNCTION_PARAMS --> _action_markBracketColonParam BRACKET_COLON_BEGIN STATEMENTS BRACKET_COLON_END FUNCTION_PARAMS_10_opt"
,"FUNCTION_PARAMS --> _action_markAngleBracketColonParam ANGLE_BRACKET_COLON_BEGIN STATEMENTS ANGLE_BRACKET_COLON_END FUNCTION_PARAMS_11_opt"
,"FUNCTION_PARAMS --> _action_markAngleBracketPercentParam ANGLE_BRACKET_PERCENT_BEGIN STATEMENTS ANGLE_BRACKET_PERCENT_END FUNCTION_PARAMS_12_opt"
,"STATIC_MEMBER_DESC --> _action_markColonColonParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"MEMBER_DESC --> _action_markPeriodParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"MEMBER_DESC2 --> _action_markPointerParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"MEMBER_DESC3 --> _action_markPeriodStarParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"MEMBER_DESC4 --> _action_markPointerStarParam _action_beginStatement _action_addFunction FUNCTION_ID _action_setMemberId _action_endStatement"
,"FUNCTION_ID --> IDENTIFIER _action_pushId"
,"FUNCTION_ID --> STRING _action_pushStr"
,"FUNCTION_ID --> NUMBER _action_pushNum"
,"SEP --> ,"
,"SEP --> ;"
,"SEP_STATEMENT_* --> SEP STATEMENT SEP_STATEMENT_*"
,"SEP_STATEMENT_* -->"
,"FUNCTION_EX_CALL_* --> _action_cppOnFunctionBegin _action_addFunction FUNCTION_EX_CALL _action_cppOnFunctionEnd FUNCTION_EX_CALL_*"
,"FUNCTION_EX_CALL_* -->"
,"FUNCTION_EX_CALL_2_* --> _action_cppOnFunctionBegin _action_addFunction FUNCTION_EX_CALL _action_cppOnFunctionEnd FUNCTION_EX_CALL_2_*"
,"FUNCTION_EX_CALL_2_* -->"
,"FUNCTION_PARAMS_opt --> FUNCTION_PARAMS"
,"FUNCTION_PARAMS_opt -->"
,"FUNCTION_PARAMS_2_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_2_opt -->"
,"FUNCTION_PARAMS_3_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_3_opt -->"
,"FUNCTION_PARAMS_4_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_4_opt -->"
,"FUNCTION_PARAMS_5_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_5_opt -->"
,"FUNCTION_PARAMS_6_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_6_opt -->"
,"FUNCTION_PARAMS_7_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_7_opt -->"
,"FUNCTION_PARAMS_8_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_8_opt -->"
,"FUNCTION_PARAMS_9_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_9_opt -->"
,"FUNCTION_PARAMS_10_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_10_opt -->"
,"FUNCTION_PARAMS_11_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_11_opt -->"
,"FUNCTION_PARAMS_12_opt --> _action_buildHighOrderFunction FUNCTION_PARAMS"
,"FUNCTION_PARAMS_12_opt -->"
};

private const short   START_SYMBOL = 24;
private const short   START_ACTION = 55;
private const short   END_ACTION = 77;

public static string  GetSymbolName ( short symbol )
{
  if ( symbol >= START_ACTION && symbol < END_ACTION ) {
      return ( Action_name [symbol - (START_ACTION-1)] );
  } else if ( symbol >= START_SYMBOL ) {
      return ( Nonterminal_name [symbol - (START_SYMBOL-1)] );
  } else if ( symbol > 0 ) {
      return ( Terminal_name [ symbol ] );
  }
  return ( "not a symbol" );
}

public static string  GetProductionName ( short production_number )
{
  return ( Production_name [production_number] );
}


};


}