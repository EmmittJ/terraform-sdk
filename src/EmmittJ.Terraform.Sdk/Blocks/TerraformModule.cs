using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform module call - a top-level block for reusing configurations.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Modules are containers for multiple resources that are used together.
/// A module consists of a collection of .tf files kept together in a directory.
/// Modules support depends_on, count, for_each, and providers meta-arguments.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/module"/></para>
/// </remarks>
public class TerraformModule :
    TerraformBlock,
    ITerraformHasDependsOn,
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasProviders
{
    /// <summary>
    /// Gets the module name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the block type keyword for modules.
    /// </summary>
    public override string BlockType => "module";

    /// <summary>
    /// Gets the block labels (just the module name).
    /// </summary>
    public override string[] BlockLabels => [Name];

    /// <summary>
    /// Gets the Terraform reference identifier for this module (e.g., "module.vpc").
    /// </summary>
    public override string ReferenceIdentifier => $"module.{Name}";

    /// <summary>
    /// Initializes a new instance of TerraformModule.
    /// </summary>
    /// <param name="name">The name of the module instance.</param>
    public TerraformModule(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets or sets the source of the module.
    /// Can be a local path, registry source, git URL, etc.
    /// </summary>
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Gets or sets the version constraint for the module (optional).
    /// Only applicable for registry modules.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>?>("version");
        set => SetArgument("version", value);
    }

    // Meta-argument properties

    /// <summary>
    /// Gets or sets the list of resources this depends on.
    /// Use this meta-argument when a module relies on some other resource's behavior
    /// but doesn't access any of that resource's data in its arguments.
    /// </summary>
    public TerraformList<string>? DependsOn
    {
        get => GetArgument<TerraformList<string>?>("depends_on");
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// Gets or sets the count meta-argument.
    /// Accepts a whole number, and creates that many instances of the module.
    /// </summary>
    public TerraformValue<int>? Count
    {
        get => GetArgument<TerraformValue<int>?>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Gets or sets the for_each meta-argument.
    /// Accepts a map or a set of strings, and creates an instance for each item.
    /// </summary>
    public TerraformValue<object>? ForEach
    {
        get => GetArgument<TerraformValue<object>?>("for_each");
        set => SetArgument("for_each", value);
    }

    /// <summary>
    /// Gets or sets the provider mappings for this module.
    /// Maps child module provider configuration names to parent provider configuration references.
    /// </summary>
    public TerraformMap<string>? Providers
    {
        get => GetArgument<TerraformMap<string>?>("providers");
        set => SetArgument("providers", value);
    }
}
