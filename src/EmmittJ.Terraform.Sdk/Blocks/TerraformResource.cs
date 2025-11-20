using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform resource - a top-level block with type, name, and meta-arguments.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Resources are the most important element in Terraform. Each resource block describes one or more
/// infrastructure objects, such as virtual networks, compute instances, or higher-level components
/// such as DNS records.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/resource"/></para>
/// </remarks>
public class TerraformResource : TerraformBlock,
    ITerraformHasCount,
    ITerraformHasForEach,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasLifecycle
{
    /// <summary>
    /// Gets the resource type (e.g., "aws_vpc", "azurerm_resource_group").
    /// </summary>
    public string ResourceType { get; }

    /// <summary>
    /// Gets the resource name (unique within the configuration).
    /// </summary>
    public string ResourceName { get; }

    /// <summary>
    /// Gets the block type keyword for resources.
    /// </summary>
    public override string BlockType => "resource";

    /// <summary>
    /// Gets the block labels for this resource.
    /// </summary>
    public override string[] BlockLabels => [ResourceType, ResourceName];

    /// <summary>
    /// Initializes a new instance of TerraformResource.
    /// </summary>
    /// <param name="type">The resource type (e.g., "aws_vpc").</param>
    /// <param name="name">The resource name.</param>
    public TerraformResource(string type, string name)
    {
        ResourceType = type ?? throw new ArgumentNullException(nameof(type));
        ResourceName = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Generates a reference to this resource (e.g., "aws_vpc.main").
    /// This reference can be used to access the resource's attributes (output values like id, arn, etc.)
    /// in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this resource.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"{ResourceType}.{ResourceName}");

    /// <summary>
    /// Implicit conversion to TerraformExpression for natural reference usage.
    /// Allows using resources directly in expressions without calling AsReference().
    /// </summary>
    /// <param name="resource">The resource to convert.</param>
    /// <returns>A TerraformExpression representing the resource reference.</returns>
    public static implicit operator TerraformExpression(TerraformResource resource)
        => resource.AsReference();

    // Meta-argument properties

    /// <summary>
    /// Gets or sets the count meta-argument.
    /// Accepts a whole number, and creates that many instances of the resource.
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
    /// Gets or sets the list of resources this depends on.
    /// Use this meta-argument when a resource relies on some other resource's behavior
    /// but doesn't access any of that resource's data in its arguments.
    /// </summary>
    public TerraformList<string>? DependsOn
    {
        get => GetArgument<TerraformList<string>?>("depends_on");
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// Gets or sets the provider meta-argument.
    /// Specifies which provider configuration to use, overriding Terraform's default behavior.
    /// </summary>
    public TerraformValue<string>? Provider
    {
        get => GetArgument<TerraformValue<string>?>("provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// Gets or sets the lifecycle configuration for this resource.
    /// Allows customization of lifecycle behavior including create_before_destroy, prevent_destroy, and ignore_changes.
    /// </summary>
    public TerraformLifecycleConfig? Lifecycle
    {
        get => GetArgument<TerraformLifecycleConfig?>("lifecycle");
        set => SetArgument("lifecycle", value);
    }
}
