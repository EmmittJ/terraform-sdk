using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform output value - a top-level block for exposing values from a configuration.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Output values make information about your infrastructure available on the command line,
/// and can expose information for other Terraform configurations to use.
/// Output values support the depends_on meta-argument.
/// </remarks>
public partial class TerraformOutput : TerraformBlock, ITerraformHasDependsOn
{
    /// <summary>
    /// Gets the output name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the block type keyword for outputs.
    /// </summary>
    public override string BlockType => "output";

    /// <summary>
    /// Gets the block labels (just the output name).
    /// </summary>
    public override string[] BlockLabels => [Name];

    /// <summary>
    /// Initializes a new instance of TerraformOutput.
    /// </summary>
    /// <param name="name">The output name.</param>
    public TerraformOutput(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets or sets the output value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformValue<object>? Value
    {
        get => GetPropertyValue<TerraformValue<object>?>("value");
        set => SetPropertyValue("value", value);
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetPropertyValue<TerraformValue<string>?>("description");
        set => SetPropertyValue("description", value);
    }

    /// <summary>
    /// Gets or sets whether the output is sensitive.
    /// </summary>
    public TerraformValue<bool>? Sensitive
    {
        get => GetPropertyValue<TerraformValue<bool>?>("sensitive");
        set => SetPropertyValue("sensitive", value);
    }

    /// <summary>
    /// Gets or sets whether the output is ephemeral.
    /// Ephemeral outputs pass data between modules without persisting to state or plan files.
    /// Only applicable to child module outputs (not root module).
    /// Available in Terraform v1.10 and later.
    /// Default: false
    /// </summary>
    public TerraformValue<bool>? Ephemeral
    {
        get => GetPropertyValue<TerraformValue<bool>?>("ephemeral");
        set => SetPropertyValue("ephemeral", value);
    }

    /// <summary>
    /// Gets the list of precondition blocks for this output.
    /// Preconditions validate the output value before exposing or storing it in state.
    /// </summary>
    public TerraformList<TerraformConditionBlock> Preconditions
    {
        get => GetPropertyValue<TerraformList<TerraformConditionBlock>?>("precondition") ?? new TerraformList<TerraformConditionBlock>();
        set => SetPropertyValue("precondition", value);
    }

    /// <summary>
    /// Generates a reference to this output (e.g., "output.connection_string").
    /// Used when referencing this output's value in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this output.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"output.{Name}");

    /// <summary>
    /// Adds a precondition block to this output.
    /// </summary>
    /// <param name="condition">The condition expression that must evaluate to true.</param>
    /// <param name="errorMessage">The error message to display if the condition is false.</param>
    /// <returns>This output instance for fluent chaining.</returns>
    public TerraformOutput AddPrecondition(string condition, string errorMessage)
    {
        var preconditions = Preconditions;
        preconditions.Add(new TerraformConditionBlock("precondition", condition, errorMessage));
        Preconditions = preconditions;
        return this;
    }

    /// <summary>
    /// Resolves this output to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        if (GetPropertyValue<TerraformValue<object>?>("value") == null)
        {
            throw new InvalidOperationException($"Output '{Name}' must have a value set before it can be synthesized. Use the Value property to set the output value.");
        }

        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }

    /// <summary>
    /// Implicit conversion to TerraformExpression for natural reference usage.
    /// Allows using outputs directly in expressions without calling AsReference().
    /// </summary>
    /// <param name="output">The output to convert.</param>
    /// <returns>A TerraformExpression representing the output reference.</returns>
    public static implicit operator TerraformExpression(TerraformOutput output)
        => output.AsReference();
}
