namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for Terraform constructs that have a name identifier.
/// Includes resources, data sources, and providers.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="NamedTerraformConstruct"/> class.
/// </remarks>
/// <param name="constructName">The name of the construct.</param>
public abstract class NamedTerraformConstruct(string constructName) : TerraformConstruct
{
    /// <summary>
    /// Gets the name of this construct.
    /// </summary>
    public string ConstructName { get; } = constructName ?? throw new ArgumentNullException(nameof(constructName));
}
