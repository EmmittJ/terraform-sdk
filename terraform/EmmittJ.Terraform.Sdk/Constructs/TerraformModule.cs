namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform module block.
/// Modules allow you to reuse and compose Terraform configurations.
/// </summary>
public class TerraformModule : NamedTerraformConstruct, ITerraformResolvable<string>
{
    private readonly HashSet<string> _declaredOutputs = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformModule"/> class.
    /// </summary>
    /// <param name="name">The name of the module instance.</param>
    public TerraformModule(string name) : base(name)
    {
    }

    /// <summary>
    /// Gets or sets the source of the module.
    /// Can be a local path, registry source, git URL, etc.
    /// </summary>
    public required string Source { get; set; }

    /// <summary>
    /// Gets or sets the version constraint for the module (optional).
    /// Only applicable for registry modules.
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// Declares an output from this module that can be referenced.
    /// </summary>
    /// <param name="outputName">The name of the module output.</param>
    public void DeclareOutput(string outputName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(outputName);
        _declaredOutputs.Add(outputName);
    }

    /// <summary>
    /// Gets a reference to a module output.
    /// The output must be declared first using DeclareOutput().
    /// </summary>
    /// <param name="outputName">The name of the module output.</param>
    /// <returns>A reference to the module output.</returns>
    public TerraformReferenceExpression GetOutput(string outputName)
    {
        if (!_declaredOutputs.Contains(outputName))
        {
            throw new TerraformConfigurationException(
                $"Output '{outputName}' has not been declared for module '{Name}'. " +
                $"Use DeclareOutput(\"{outputName}\") to declare it first, or check for typos in the output name.",
                this,
                outputName);
        }
        return new TerraformReferenceExpression(this, outputName);
    }

    /// <summary>
    /// Indexer for convenient output access.
    /// </summary>
    /// <param name="outputName">The name of the module output.</param>
    /// <returns>A reference to the module output.</returns>
    public TerraformReferenceExpression this[string outputName] => GetOutput(outputName);

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"module.{Name}");

    /// <summary>
    /// Preparation phase - prepare all input variables.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        foreach (var variable in Properties.Values)
        {
            if (variable is ITerraformPreparable preparable)
            {
                preparable.Prepare(context);
            }
        }
    }

    /// <summary>
    /// Resolution phase - generates the module block HCL.
    /// </summary>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}module \"{Name}\" {{");

        using (context.PushIndent())
        {
            // Source is required
            sb.AppendLine($"{context.Indent}source = \"{Source}\"");

            // Version is optional
            if (!string.IsNullOrWhiteSpace(Version))
            {
                sb.AppendLine($"{context.Indent}version = \"{Version}\"");
            }

            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}
