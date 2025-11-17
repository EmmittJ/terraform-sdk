using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform output value - a top-level block for exposing values from a configuration.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Output values make information about your infrastructure available on the command line,
/// and can expose information for other Terraform configurations to use.
/// Output values support the depends_on meta-argument and precondition blocks.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/output"/></para>
/// </remarks>
public class TerraformOutput : TerraformBlock, ITerraformHasDependsOn
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
    public required TerraformValue<object> Value
    {
        get => GetRequiredArgument<TerraformValue<object>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>?>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Gets or sets whether the output is sensitive.
    /// </summary>
    public TerraformValue<bool>? Sensitive
    {
        get => GetArgument<TerraformValue<bool>?>("sensitive");
        set => SetArgument("sensitive", value);
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
        get => GetArgument<TerraformValue<bool>?>("ephemeral");
        set => SetArgument("ephemeral", value);
    }

    /// <summary>
    /// Gets the list of precondition blocks for this output.
    /// Preconditions validate the output value before exposing or storing it in state.
    /// </summary>
    public TerraformList<TerraformConditionBlock> Preconditions
    {
        get => GetArgument<TerraformList<TerraformConditionBlock>?>("precondition") ?? new TerraformList<TerraformConditionBlock>();
        set => SetArgument("precondition", value);
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
        var preconditionBlock = new TerraformConditionBlock("precondition")
        {
            Condition = TerraformExpression.Raw(condition),
            ErrorMessage = errorMessage
        };
        preconditions.Add(preconditionBlock);
        Preconditions = preconditions;
        return this;
    }

    /// <summary>
    /// Implicit conversion to TerraformExpression for natural reference usage.
    /// Allows using outputs directly in expressions without calling AsReference().
    /// </summary>
    /// <param name="output">The output to convert.</param>
    /// <returns>A TerraformExpression representing the output reference.</returns>
    public static implicit operator TerraformExpression(TerraformOutput output)
        => output.AsReference();

    // Meta-argument properties

    /// <summary>
    /// Gets or sets the list of resources this depends on.
    /// Use this meta-argument when an output relies on some other resource's behavior
    /// but doesn't access any of that resource's data in its arguments.
    /// </summary>
    public TerraformList<string>? DependsOn
    {
        get => GetArgument<TerraformList<string>?>("depends_on");
        set => SetArgument("depends_on", value);
    }
}

