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
    private TerraformProperty? _count;
    private TerraformProperty? _forEach;

    /// <summary>
    /// Gets the type of this construct (e.g., "aws_vpc", "azurerm_resource_group").
    /// </summary>
    public string Type { get; } = type ?? throw new ArgumentNullException(nameof(type));

    /// <summary>
    /// Gets or sets the count meta-argument.
    /// Can be a number or an expression.
    /// </summary>
    public TerraformProperty? Count
    {
        get => _count;
        set => _count = value;
    }

    /// <summary>
    /// Gets or sets the for_each meta-argument.
    /// Can be a set, map, or an expression.
    /// </summary>
    public TerraformProperty? ForEach
    {
        get => _forEach;
        set => _forEach = value;
    }

    /// <summary>
    /// Gets or sets the provider meta-argument.
    /// </summary>
    public string? Provider { get; set; }

    /// <summary>
    /// Gets the list of resources this depends on.
    /// </summary>
    public List<string> DependsOn { get; } = [];

    /// <summary>
    /// Gets or sets the lifecycle configuration for this resource.
    /// </summary>
    public TerraformLifecycleConfig? Lifecycle { get; set; }

    /// <summary>
    /// Gets the list of dynamic blocks for this resource.
    /// Dynamic blocks generate nested blocks conditionally based on a collection.
    /// </summary>
    public List<TerraformDynamicBlock> DynamicBlocks { get; } = new();

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
    public TerraformReferenceExpression GetOutput(string attributeName)
    {
        if (!_declaredOutputs.Contains(attributeName))
        {
            throw new TerraformConfigurationException(
                $"Attribute '{attributeName}' has not been declared as an output for {GetConstructTypeLabel()} '{Type}.{Name}'. " +
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

    /// <summary>
    /// Gets the label for this construct type (e.g., "resource", "data source") for error messages.
    /// </summary>
    protected abstract string GetConstructTypeLabel();

    /// <summary>
    /// Preparation phase - prepares all meta-arguments and properties.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        base.Prepare(context);

        _count?.Prepare(context);
        _forEach?.Prepare(context);
    }

    /// <summary>
    /// Writes meta-arguments to HCL (count, for_each, depends_on, provider, lifecycle).
    /// </summary>
    protected void WriteMetaArguments(System.Text.StringBuilder sb, ITerraformContext context)
    {
        if (_count != null)
        {
            sb.AppendLine($"{context.Indent}count = {_count.Resolve(context).ToHcl(context)}");
        }

        if (_forEach != null)
        {
            sb.AppendLine($"{context.Indent}for_each = {_forEach.Resolve(context).ToHcl(context)}");
        }

        if (DependsOn.Count > 0)
        {
            var deps = string.Join(", ", DependsOn);
            sb.AppendLine($"{context.Indent}depends_on = [{deps}]");
        }

        if (Provider != null)
        {
            sb.AppendLine($"{context.Indent}provider = {Provider}");
        }

        if (Lifecycle != null && Lifecycle.HasConfiguration())
        {
            sb.Append(Lifecycle.ToBlockExpression().ToHcl(context));
        }

        // Dynamic blocks
        foreach (var dynamicBlock in DynamicBlocks)
        {
            sb.AppendLine();
            sb.Append(dynamicBlock.Resolve(context));
        }
    }
}
