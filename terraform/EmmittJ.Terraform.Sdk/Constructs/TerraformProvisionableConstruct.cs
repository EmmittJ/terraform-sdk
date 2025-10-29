namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for Terraform constructs that can provision infrastructure (resources and data sources).
/// Provides meta-arguments (count, for_each, depends_on, provider) and output attribute management.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TerraformProvisionableConstruct"/> class.
/// </remarks>
/// <param name="type">The type of the construct (e.g., "aws_vpc").</param>
/// <param name="name">The name of the construct.</param>
public abstract class TerraformProvisionableConstruct(string type, string name) : NamedTerraformConstruct(name)
{
    private readonly HashSet<string> _declaredOutputs = [];

    /// <summary>
    /// Gets the type of this construct (e.g., "aws_vpc", "azurerm_resource_group").
    /// </summary>
    public string Type { get; } = type ?? throw new ArgumentNullException(nameof(type));

    /// <summary>
    /// Gets or sets the count meta-argument.
    /// </summary>
    public TerraformValue<int> Count { get; set; } = new();

    /// <summary>
    /// Gets or sets the for_each meta-argument.
    /// </summary>
    public TerraformValue<object> ForEach { get; set; } = new();

    /// <summary>
    /// Gets or sets the provider meta-argument.
    /// </summary>
    public string? Provider { get; set; }

    /// <summary>
    /// Gets the list of resources this depends on.
    /// </summary>
    public List<string> DependsOn { get; } = [];

    /// <summary>
    /// Declares an output attribute for this construct.
    /// </summary>
    public void DeclareOutputInternal(string attributeName)
    {
        _declaredOutputs.Add(attributeName);
    }

    /// <summary>
    /// Gets a reference to an output attribute.
    /// </summary>
    public TerraformReference GetOutput(string attributeName)
    {
        if (!_declaredOutputs.Contains(attributeName))
        {
            throw new InvalidOperationException(
                $"Attribute '{attributeName}' has not been declared as an output for {GetConstructTypeLabel()} '{Type}.{Name}'. " +
                $"Call DeclareOutput(\"{attributeName}\") first.");
        }
        return new TerraformReference(this, attributeName);
    }

    /// <summary>
    /// Indexer for convenient property access.
    /// </summary>
    public TerraformReference this[string attributeName] => GetOutput(attributeName);

    /// <summary>
    /// Gets the label for this construct type (e.g., "resource", "data source") for error messages.
    /// </summary>
    protected abstract string GetConstructTypeLabel();

    /// <summary>
    /// Writes meta-arguments to HCL (count, for_each, depends_on, provider).
    /// </summary>
    protected void WriteMetaArguments(System.Text.StringBuilder sb, string indent)
    {
        if (!Count.IsEmpty)
        {
            sb.AppendLine($"{indent}count = {Count.Compile().ToHcl()}");
        }

        if (!ForEach.IsEmpty)
        {
            sb.AppendLine($"{indent}for_each = {ForEach.Compile().ToHcl()}");
        }

        if (DependsOn.Count > 0)
        {
            var deps = string.Join(", ", DependsOn);
            sb.AppendLine($"{indent}depends_on = [{deps}]");
        }

        if (Provider != null)
        {
            sb.AppendLine($"{indent}provider = {Provider}");
        }
    }

    /// <summary>
    /// Writes regular properties to HCL.
    /// </summary>
    protected void WriteProperties(System.Text.StringBuilder sb, string indent)
    {
        foreach (var (key, value) in Properties)
        {
            if (!value.IsEmpty)
            {
                var compiledExpr = value.Compile();

                // Check if this is a block (nested block syntax without '=')
                if (compiledExpr is TerraformBlock block)
                {
                    // Extract indent level from indent string
                    int indentLevel = indent.Length / 2;
                    sb.AppendLine($"{indent}{key} {block.ToHcl(indentLevel)}");
                }
                else
                {
                    sb.AppendLine($"{indent}{key} = {compiledExpr.ToHcl()}");
                }
            }
        }
    }
}
