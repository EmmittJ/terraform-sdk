namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for Terraform constructs that have a name identifier.
/// Includes resources, data sources, modules, and providers.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="NamedTerraformConstruct"/> class.
/// </remarks>
/// <param name="constructName">The name of the construct.</param>
public abstract class NamedTerraformConstruct(string constructName) : TerraformConstruct
{
    private readonly HashSet<string> _declaredOutputs = [];

    /// <summary>
    /// Gets the name of this construct.
    /// </summary>
    public string ConstructName { get; } = constructName ?? throw new ArgumentNullException(nameof(constructName));

    /// <summary>
    /// Declares an output attribute for this construct.
    /// </summary>
    internal void DeclareOutputInternal(string attributeName)
    {
        _declaredOutputs.Add(attributeName);
    }

    /// <summary>
    /// Gets a reference to an output attribute.
    /// </summary>
    public TerraformReferenceExpression GetOutput(string attributeName)
    {
        if (!_declaredOutputs.Contains(attributeName))
        {
            throw new TerraformConfigurationException(
                $"Attribute '{attributeName}' has not been declared as an output for {BlockType} '{ConstructName}'. " +
                $"Use DeclareOutput(\"{attributeName}\") to declare it first, or check for typos in the attribute name.",
                this,
                attributeName);
        }
        return new TerraformReferenceExpression(this, attributeName);
    }

    /// <summary>
    /// Indexer for convenient property access.
    /// </summary>
    public TerraformReferenceExpression this[string attributeName] => GetOutput(attributeName);
}
