namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Interface for Terraform blocks that track their parent for reference chaining.
/// </summary>
/// <remarks>
/// <para>
/// Nested blocks implement this interface to enable automatic parent tracking when assigned
/// to a parent block's property. The parent is automatically set by <see cref="TerraformMap{T}.SetArgument"/>
/// when the block is assigned.
/// </para>
/// <para>
/// This enables type-safe reference chaining, where nested block properties can create references
/// like <c>resource.nested_block.attribute</c> by chaining through the parent's reference.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// var resource = new AzurermResourceGroup("rg")
/// {
///     Timeouts = new() { Create = "30m" }  // Parent auto-set here
/// };
///
/// // Reference chains through parent:
/// // resource.Timeouts.Create -> "azurerm_resource_group.rg.timeouts.create"
/// var timeout = resource.Timeouts.Create;
/// </code>
/// </example>
public interface ITerraformHasParent
{
    /// <summary>
    /// Gets or sets the parent block for reference chaining.
    /// Automatically set when this block is assigned to a parent's property.
    /// </summary>
    ITerraformReferenceable? ParentBlock { get; set; }

    /// <summary>
    /// Gets or sets the attribute name this value was assigned to in the parent (e.g., "ingress", "timeouts").
    /// Used for building references like <c>resource.ingress[0].fqdn</c>.
    /// Automatically set when this value is assigned to a parent's property via SetArgument.
    /// </summary>
    string? ParentAttributeName { get; set; }
}
