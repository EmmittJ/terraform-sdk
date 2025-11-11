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
public class TerraformReference<T> : TerraformValue<T>
{
    private readonly TerraformConstruct _construct;
    private readonly string _attributeName;

    /// <summary>
    /// Creates a new reference to a resource attribute.
    /// </summary>
    /// <param name="construct">The construct being referenced.</param>
    /// <param name="attributeName">The attribute name (as it appears in HCL, e.g., "name", "id").</param>
    public TerraformReference(TerraformConstruct construct, string attributeName)
        : base(CreateReferenceResolvable(construct, attributeName))
    {
        _construct = construct ?? throw new ArgumentNullException(nameof(construct));
        _attributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
    }

    /// <summary>
    /// Creates the resolvable that produces the reference identifier.
    /// </summary>
    private static ITerraformResolvable CreateReferenceResolvable(
        TerraformConstruct construct,
        string attributeName)
    {
        return new TerraformReferenceResolvable(construct, attributeName);
    }

    /// <summary>
    /// Gets the construct being referenced.
    /// </summary>
    public TerraformConstruct Construct => _construct;

    /// <summary>
    /// Gets the attribute name being referenced.
    /// </summary>
    public string AttributeName => _attributeName;
}

/// <summary>
/// Internal resolvable that produces a reference identifier expression.
/// </summary>
internal class TerraformReferenceResolvable : ITerraformResolvable
{
    private readonly TerraformConstruct _construct;
    private readonly string _attributeName;

    public TerraformReferenceResolvable(TerraformConstruct construct, string attributeName)
    {
        _construct = construct;
        _attributeName = attributeName;
    }

    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        // Generate reference: resource_type.resource_name.attribute_name
        var reference = _construct.AsReference();

        // If attribute is not empty, append it
        if (!string.IsNullOrEmpty(_attributeName))
        {
            // Get the identifier string from the reference
            var identifier = reference.ToHcl(TerraformContext.Temporary());

            // Append attribute name
            return TerraformExpression.Identifier($"{identifier}.{_attributeName}");
        }

        return reference;
    }
}
