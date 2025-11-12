namespace EmmittJ.Terraform.Sdk;

using EmmittJ.Terraform.Sdk.Constructs.MetaArguments;

/// <summary>
/// Represents a Terraform module call - a top-level construct for reusing configurations.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Modules are containers for multiple resources that are used together.
/// A module consists of a collection of .tf files kept together in a directory.
/// Modules support depends_on, count, and for_each meta-arguments.
/// </remarks>
public partial class TerraformModule :
    TerraformBlock,
    ITerraformHasDependsOn,
    ITerraformHasCount,
    ITerraformHasForEach
{
    /// <summary>
    /// Gets the module name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of TerraformModule.
    /// </summary>
    /// <param name="name">The name of the module instance.</param>
    public TerraformModule(string name) : base("")
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets or sets the source of the module.
    /// Can be a local path, registry source, git URL, etc.
    /// </summary>
    [TerraformProperty("source")]
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// Gets or sets the version constraint for the module (optional).
    /// Only applicable for registry modules.
    /// </summary>
    [TerraformProperty("version")]
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Resolves to a TerraformConstructExpression representing the module block.
    /// Overrides the base Resolve() to return a construct expression instead of a map expression.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformConstructExpression with block type "module" and label [name].</returns>
    public override TerraformExpression Resolve(ITerraformResolveContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in construct expression with module name
        return new TerraformConstructExpression("module", [Name], bodyMap);
    }

    /// <summary>
    /// Generates a reference to this module (e.g., "module.vpc").
    /// Used when referencing this module's outputs in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this module.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"module.{Name}");
}
