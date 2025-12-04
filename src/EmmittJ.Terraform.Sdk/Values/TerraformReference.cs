namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a reference to a Terraform resource attribute.
/// This is a specialized <see cref="TerraformValue{T}"/> that resolves to a resource attribute reference
/// (e.g., "azurerm_resource_group.my-rg.name").
/// </summary>
/// <typeparam name="T">The .NET type this attribute represents (string, double, bool, etc.).</typeparam>
/// <example>
/// <code>
/// var rg = new AzurermResourceGroup("rg") { Name = "my-rg" };
/// var app = new AzurermApp("app")
/// {
///     // rg.Name getter returns TerraformReference&lt;string&gt;
///     // which resolves to: azurerm_resource_group.rg.name
///     ResourceGroupName = rg.Name
/// };
/// </code>
/// </example>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/expressions/references"/></para>
/// </remarks>
public class TerraformReference<T> : TerraformValue<T>, ITerraformReferenceable, ITerraformHasParent
{
    private readonly ITerraformReferenceable _block;
    private readonly string _attributeName;

    /// <summary>
    /// Creates a new reference to a block attribute.
    /// </summary>
    /// <param name="block">The block being referenced.</param>
    /// <param name="attributeName">The attribute name (e.g., "id", "name", "read").</param>
    public TerraformReference(ITerraformReferenceable block, string attributeName)
    {
        _block = block ?? throw new ArgumentNullException(nameof(block));
        _attributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
    }

    /// <inheritdoc />
    public ITerraformReferenceable? ParentBlock
    {
        get => _block;
        set => throw new NotSupportedException("TerraformReference parent block is immutable.");
    }

    /// <inheritdoc />
    public string? ParentAttributeName
    {
        get => _attributeName;
        set => throw new NotSupportedException("TerraformReference parent attribute name is immutable.");
    }

    /// <summary>
    /// Returns the expression this reference represents.
    /// </summary>
    /// <returns>The reference expression.</returns>
    public TerraformExpression AsReference()
    {
        // Handle ITerraformNamedReferenceable (like locals) which provide their own AsReference(name) method
        if (_block is ITerraformNamedReferenceable namedBlock)
        {
            return namedBlock.AsReference(_attributeName);
        }

        // For regular blocks, get block reference and append attribute as member
        return _block.AsReference().Member(_attributeName);
    }

    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        yield return AsReference();
    }
}
