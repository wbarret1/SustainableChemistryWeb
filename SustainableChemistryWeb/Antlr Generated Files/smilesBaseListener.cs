//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\wbarr\Source\Repos\SustainableChemistryWeb\SustainableChemistryWeb\ChemInfo\smiles.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace foo {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IsmilesListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class smilesBaseListener : IsmilesListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.smiles"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSmiles([NotNull] smilesParser.SmilesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.smiles"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSmiles([NotNull] smilesParser.SmilesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChain([NotNull] smilesParser.ChainContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChain([NotNull] smilesParser.ChainContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.branched_atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBranched_atom([NotNull] smilesParser.Branched_atomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.branched_atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBranched_atom([NotNull] smilesParser.Branched_atomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.branch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBranch([NotNull] smilesParser.BranchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.branch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBranch([NotNull] smilesParser.BranchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.ringbond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRingbond([NotNull] smilesParser.RingbondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.ringbond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRingbond([NotNull] smilesParser.RingbondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.bond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBond([NotNull] smilesParser.BondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.bond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBond([NotNull] smilesParser.BondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.dot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDot([NotNull] smilesParser.DotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.dot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDot([NotNull] smilesParser.DotContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] smilesParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] smilesParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.symbol"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSymbol([NotNull] smilesParser.SymbolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.symbol"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSymbol([NotNull] smilesParser.SymbolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.organic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrganic([NotNull] smilesParser.OrganicContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.organic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrganic([NotNull] smilesParser.OrganicContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.aromatic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAromatic([NotNull] smilesParser.AromaticContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.aromatic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAromatic([NotNull] smilesParser.AromaticContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.halogen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHalogen([NotNull] smilesParser.HalogenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.halogen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHalogen([NotNull] smilesParser.HalogenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.chiral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChiral([NotNull] smilesParser.ChiralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.chiral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChiral([NotNull] smilesParser.ChiralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.charge"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharge([NotNull] smilesParser.ChargeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.charge"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharge([NotNull] smilesParser.ChargeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.hcount"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHcount([NotNull] smilesParser.HcountContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.hcount"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHcount([NotNull] smilesParser.HcountContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.atomclass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtomclass([NotNull] smilesParser.AtomclassContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.atomclass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtomclass([NotNull] smilesParser.AtomclassContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.isotope"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIsotope([NotNull] smilesParser.IsotopeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.isotope"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIsotope([NotNull] smilesParser.IsotopeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="smilesParser.element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElement([NotNull] smilesParser.ElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="smilesParser.element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElement([NotNull] smilesParser.ElementContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace foo
