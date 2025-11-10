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
    public void SetOutput(string attributeName)
    {
        _declaredOutputs.Add(attributeName);
    }

    /// <summary>
    /// Gets an output value by converting the reference expression to the target type.
    /// Uses implicit conversion operators on TerraformProperty to convert from TerraformExpression.
    /// </summary>
    /// <typeparam name="T">The target property type (e.g., TerraformProperty&lt;string&gt;)</typeparam>
    /// <param name="key">The output attribute name</param>
    /// <returns>The converted output value, or null if not found</returns>
    protected T? GetOutput<T>(string key)
        where T : class
    {
        return GetOutput(key) as T;
    }

    /// <summary>
    /// Gets a required output value by converting the reference expression to the target type.
    /// Uses implicit conversion operators on TerraformProperty to convert from TerraformExpression.
    /// Throws if the output is null after conversion.
    /// </summary>
    /// <typeparam name="T">The target property type (e.g., TerraformProperty&lt;string&gt;)</typeparam>
    /// <param name="key">The output attribute name</param>
    /// <returns>The converted output value</returns>
    /// <exception cref="InvalidOperationException">Thrown when the output value is null.</exception>
    protected T GetRequiredOutput<T>(string key)
        where T : class
    {
        return GetOutput<T>(key) ?? throw new InvalidOperationException($"Required output '{key}' is null.");
    }

    /// <summary>
    /// Gets a reference to an output attribute.
    /// </summary>
    public TerraformReferenceExpression GetOutput(string attributeName)
    {
        if (!_declaredOutputs.Contains(attributeName))
        {
            throw new TerraformStackException(
                $"Attribute '{attributeName}' has not been declared as an output for {BlockType} '{ConstructName}'. " +
                $"Use WithOutput(\"{attributeName}\") to declare it first, or check for typos in the attribute name.",
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
