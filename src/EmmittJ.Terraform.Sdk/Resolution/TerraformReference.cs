namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a reference to a Terraform resource attribute.
/// Resolves to a TerraformExpression (identifier) during synthesis.
/// </summary>
public class TerraformReference : ITerraformResolvable
{
    private readonly TerraformProvisionableConstruct _construct;
    private readonly string _attributeName;

    /// <summary>
    /// Creates a new TerraformReference to a specific attribute of a provisionable construct.
    /// </summary>
    /// <param name="construct">The Terraform provisionable construct (resource or data source) being referenced.</param>
    /// <param name="attributeName">The name of the attribute to reference.</param>
    /// <exception cref="ArgumentNullException">Thrown if construct or attributeName is null.</exception>
    public TerraformReference(TerraformProvisionableConstruct construct, string attributeName)
    {
        _construct = construct ?? throw new ArgumentNullException(nameof(construct));
        _attributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
    }

    /// <summary>
    /// Resolves this reference to an identifier expression.
    /// </summary>
    /// <param name="context">The resolution context (unused for references).</param>
    /// <returns>An identifier expression in the form: resource_type.resource_name.attribute_name</returns>
    public TerraformExpression Resolve(ITerraformResolveContext context)
    {
        // Create an identifier expression for this reference
        // Will be serialized to HCL like: azurerm_resource_group.rg.name
        return TerraformExpression.Identifier(
            $"{_construct.ConstructType}.{_construct.ConstructName}.{_attributeName}"
        );
    }
}
