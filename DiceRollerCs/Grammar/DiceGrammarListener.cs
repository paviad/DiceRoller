//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DiceGrammar.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Dice.Grammar {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DiceGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IDiceGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceGrammarParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInput([NotNull] DiceGrammarParser.InputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceGrammarParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInput([NotNull] DiceGrammarParser.InputContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MathNormal</c>
	/// labeled alternative in <see cref="DiceGrammarParser.math_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathNormal([NotNull] DiceGrammarParser.MathNormalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MathNormal</c>
	/// labeled alternative in <see cref="DiceGrammarParser.math_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathNormal([NotNull] DiceGrammarParser.MathNormalContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MathFunction</c>
	/// labeled alternative in <see cref="DiceGrammarParser.math_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathFunction([NotNull] DiceGrammarParser.MathFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MathFunction</c>
	/// labeled alternative in <see cref="DiceGrammarParser.math_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathFunction([NotNull] DiceGrammarParser.MathFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MultMult</c>
	/// labeled alternative in <see cref="DiceGrammarParser.mult_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultMult([NotNull] DiceGrammarParser.MultMultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultMult</c>
	/// labeled alternative in <see cref="DiceGrammarParser.mult_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultMult([NotNull] DiceGrammarParser.MultMultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MultNone</c>
	/// labeled alternative in <see cref="DiceGrammarParser.mult_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultNone([NotNull] DiceGrammarParser.MultNoneContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultNone</c>
	/// labeled alternative in <see cref="DiceGrammarParser.mult_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultNone([NotNull] DiceGrammarParser.MultNoneContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MultDiv</c>
	/// labeled alternative in <see cref="DiceGrammarParser.mult_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultDiv([NotNull] DiceGrammarParser.MultDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultDiv</c>
	/// labeled alternative in <see cref="DiceGrammarParser.mult_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultDiv([NotNull] DiceGrammarParser.MultDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="DiceGrammarParser.add_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSub([NotNull] DiceGrammarParser.AddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="DiceGrammarParser.add_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSub([NotNull] DiceGrammarParser.AddSubContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddNone</c>
	/// labeled alternative in <see cref="DiceGrammarParser.add_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddNone([NotNull] DiceGrammarParser.AddNoneContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddNone</c>
	/// labeled alternative in <see cref="DiceGrammarParser.add_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddNone([NotNull] DiceGrammarParser.AddNoneContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddAdd</c>
	/// labeled alternative in <see cref="DiceGrammarParser.add_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddAdd([NotNull] DiceGrammarParser.AddAddContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddAdd</c>
	/// labeled alternative in <see cref="DiceGrammarParser.add_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddAdd([NotNull] DiceGrammarParser.AddAddContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenParen</c>
	/// labeled alternative in <see cref="DiceGrammarParser.paren_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenParen([NotNull] DiceGrammarParser.ParenParenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenParen</c>
	/// labeled alternative in <see cref="DiceGrammarParser.paren_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenParen([NotNull] DiceGrammarParser.ParenParenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenNumber</c>
	/// labeled alternative in <see cref="DiceGrammarParser.paren_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenNumber([NotNull] DiceGrammarParser.ParenNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenNumber</c>
	/// labeled alternative in <see cref="DiceGrammarParser.paren_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenNumber([NotNull] DiceGrammarParser.ParenNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenGroup</c>
	/// labeled alternative in <see cref="DiceGrammarParser.paren_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenGroup([NotNull] DiceGrammarParser.ParenGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenGroup</c>
	/// labeled alternative in <see cref="DiceGrammarParser.paren_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenGroup([NotNull] DiceGrammarParser.ParenGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NexprParen</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNexprParen([NotNull] DiceGrammarParser.NexprParenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NexprParen</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNexprParen([NotNull] DiceGrammarParser.NexprParenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NexprNumber</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNexprNumber([NotNull] DiceGrammarParser.NexprNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NexprNumber</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNexprNumber([NotNull] DiceGrammarParser.NexprNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumberLiteral</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberLiteral([NotNull] DiceGrammarParser.NumberLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberLiteral</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberLiteral([NotNull] DiceGrammarParser.NumberLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumberMacro</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberMacro([NotNull] DiceGrammarParser.NumberMacroContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberMacro</c>
	/// labeled alternative in <see cref="DiceGrammarParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberMacro([NotNull] DiceGrammarParser.NumberMacroContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceGrammarParser.global_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_function([NotNull] DiceGrammarParser.Global_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceGrammarParser.global_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_function([NotNull] DiceGrammarParser.Global_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceGrammarParser.group_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_function([NotNull] DiceGrammarParser.Group_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceGrammarParser.group_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_function([NotNull] DiceGrammarParser.Group_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceGrammarParser.basic_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasic_function([NotNull] DiceGrammarParser.Basic_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceGrammarParser.basic_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasic_function([NotNull] DiceGrammarParser.Basic_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupGroup</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupGroup([NotNull] DiceGrammarParser.GroupGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupGroup</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupGroup([NotNull] DiceGrammarParser.GroupGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupBasic</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupBasic([NotNull] DiceGrammarParser.GroupBasicContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupBasic</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupBasic([NotNull] DiceGrammarParser.GroupBasicContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupInit</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll_inner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupInit([NotNull] DiceGrammarParser.GroupInitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupInit</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll_inner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupInit([NotNull] DiceGrammarParser.GroupInitContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupExtra</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll_inner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupExtra([NotNull] DiceGrammarParser.GroupExtraContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupExtra</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_roll_inner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupExtra([NotNull] DiceGrammarParser.GroupExtraContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupKeep</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupKeep([NotNull] DiceGrammarParser.GroupKeepContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupKeep</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupKeep([NotNull] DiceGrammarParser.GroupKeepContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupSuccess</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupSuccess([NotNull] DiceGrammarParser.GroupSuccessContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupSuccess</c>
	/// labeled alternative in <see cref="DiceGrammarParser.grouped_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupSuccess([NotNull] DiceGrammarParser.GroupSuccessContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicBasic</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicBasic([NotNull] DiceGrammarParser.BasicBasicContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicBasic</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicBasic([NotNull] DiceGrammarParser.BasicBasicContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicFudge</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicFudge([NotNull] DiceGrammarParser.BasicFudgeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicFudge</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_roll"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicFudge([NotNull] DiceGrammarParser.BasicFudgeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicReroll</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicReroll([NotNull] DiceGrammarParser.BasicRerollContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicReroll</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicReroll([NotNull] DiceGrammarParser.BasicRerollContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicExplode</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicExplode([NotNull] DiceGrammarParser.BasicExplodeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicExplode</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicExplode([NotNull] DiceGrammarParser.BasicExplodeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicKeep</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicKeep([NotNull] DiceGrammarParser.BasicKeepContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicKeep</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicKeep([NotNull] DiceGrammarParser.BasicKeepContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BasicSuccess</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicSuccess([NotNull] DiceGrammarParser.BasicSuccessContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BasicSuccess</c>
	/// labeled alternative in <see cref="DiceGrammarParser.basic_extras"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicSuccess([NotNull] DiceGrammarParser.BasicSuccessContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>KeepHigh</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeepHigh([NotNull] DiceGrammarParser.KeepHighContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>KeepHigh</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeepHigh([NotNull] DiceGrammarParser.KeepHighContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>KeepLow</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeepLow([NotNull] DiceGrammarParser.KeepLowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>KeepLow</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeepLow([NotNull] DiceGrammarParser.KeepLowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DropHigh</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropHigh([NotNull] DiceGrammarParser.DropHighContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DropHigh</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropHigh([NotNull] DiceGrammarParser.DropHighContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DropLow</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropLow([NotNull] DiceGrammarParser.DropLowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DropLow</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropLow([NotNull] DiceGrammarParser.DropLowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Advantage</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdvantage([NotNull] DiceGrammarParser.AdvantageContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Advantage</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdvantage([NotNull] DiceGrammarParser.AdvantageContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Disadvantage</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDisadvantage([NotNull] DiceGrammarParser.DisadvantageContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Disadvantage</c>
	/// labeled alternative in <see cref="DiceGrammarParser.keep_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDisadvantage([NotNull] DiceGrammarParser.DisadvantageContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RerollReroll</c>
	/// labeled alternative in <see cref="DiceGrammarParser.reroll_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRerollReroll([NotNull] DiceGrammarParser.RerollRerollContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RerollReroll</c>
	/// labeled alternative in <see cref="DiceGrammarParser.reroll_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRerollReroll([NotNull] DiceGrammarParser.RerollRerollContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RerollOnce</c>
	/// labeled alternative in <see cref="DiceGrammarParser.reroll_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRerollOnce([NotNull] DiceGrammarParser.RerollOnceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RerollOnce</c>
	/// labeled alternative in <see cref="DiceGrammarParser.reroll_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRerollOnce([NotNull] DiceGrammarParser.RerollOnceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Explode</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explode_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplode([NotNull] DiceGrammarParser.ExplodeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Explode</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explode_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplode([NotNull] DiceGrammarParser.ExplodeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Penetrate</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explode_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPenetrate([NotNull] DiceGrammarParser.PenetrateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Penetrate</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explode_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPenetrate([NotNull] DiceGrammarParser.PenetrateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DiceGrammarParser.success_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSuccess_expr([NotNull] DiceGrammarParser.Success_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DiceGrammarParser.success_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSuccess_expr([NotNull] DiceGrammarParser.Success_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CompImplicit</c>
	/// labeled alternative in <see cref="DiceGrammarParser.compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompImplicit([NotNull] DiceGrammarParser.CompImplicitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CompImplicit</c>
	/// labeled alternative in <see cref="DiceGrammarParser.compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompImplicit([NotNull] DiceGrammarParser.CompImplicitContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CompExplicit</c>
	/// labeled alternative in <see cref="DiceGrammarParser.compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompExplicit([NotNull] DiceGrammarParser.CompExplicitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CompExplicit</c>
	/// labeled alternative in <see cref="DiceGrammarParser.compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompExplicit([NotNull] DiceGrammarParser.CompExplicitContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Equals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquals([NotNull] DiceGrammarParser.EqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Equals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquals([NotNull] DiceGrammarParser.EqualsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Greater</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGreater([NotNull] DiceGrammarParser.GreaterContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Greater</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGreater([NotNull] DiceGrammarParser.GreaterContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Less</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLess([NotNull] DiceGrammarParser.LessContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Less</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLess([NotNull] DiceGrammarParser.LessContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GreaterEquals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGreaterEquals([NotNull] DiceGrammarParser.GreaterEqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GreaterEquals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGreaterEquals([NotNull] DiceGrammarParser.GreaterEqualsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LessEquals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLessEquals([NotNull] DiceGrammarParser.LessEqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LessEquals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLessEquals([NotNull] DiceGrammarParser.LessEqualsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NotEquals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotEquals([NotNull] DiceGrammarParser.NotEqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NotEquals</c>
	/// labeled alternative in <see cref="DiceGrammarParser.explicit_compare_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotEquals([NotNull] DiceGrammarParser.NotEqualsContext context);
}
} // namespace Dice.Grammar
