namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform module call - a top-level block for reusing configurations.
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
    ITerraformHasForEach,
    ITerraformTopLevelBlock
{
    /// <summary>
    /// Gets the module name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the block type keyword for modules.
    /// </summary>
    public string BlockType => "module";

    /// <summary>
    /// Gets the block labels for this module.
    /// </summary>
    public string[] BlockLabels => [Name];

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
    [TerraformArgument("source")]
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// Gets or sets the version constraint for the module (optional).
    /// Only applicable for registry modules.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Resolves to a TerraformBlockExpression representing the module block.
    /// Overrides the base Resolve() to return a block expression instead of a map expression.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformBlockExpression with block type "module" and label [name].</returns>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in block expression with module name
        return new TerraformTopLevelBlockExpression("module", [Name], bodyMap);
    }

    /// <summary>
    /// Generates a reference to this module (e.g., "module.vpc").
    /// Used when referencing this module's outputs in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this module.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"module.{Name}");
}
