namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for Terraform constructs that can provision infrastructure (resources and data sources).
/// Provides meta-arguments (count, for_each, depends_on, provider) and output attribute management.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TerraformProvisionableConstruct"/> class.
/// </remarks>
/// <param name="constructType">The type of the construct (e.g., "aws_vpc").</param>
/// <param name="constructName">The name of the construct.</param>
public abstract class TerraformProvisionableConstruct(string constructType, string constructName) : NamedTerraformConstruct(constructName)
{
    private TerraformValue<TerraformExpression>? _count;
    private TerraformValue<TerraformExpression>? _forEach;

    /// <summary>
    /// Gets the type of this construct (e.g., "aws_vpc", "azurerm_resource_group").
    /// </summary>
    public string ConstructType { get; } = constructType ?? throw new ArgumentNullException(nameof(constructType));

    /// <summary>
    /// Gets the fully qualified Terraform resource address (e.g., "aws_vpc.main", "data.aws_ami.ubuntu").
    /// </summary>
    public string ResourceAddress => $"{ConstructType}.{ConstructName}";

    /// <summary>
    /// Gets or sets the count meta-argument.
    /// Can be a number or an expression.
    /// </summary>
    public TerraformValue<TerraformExpression>? Count
    {
        get => _count;
        set => _count = value;
    }

    /// <summary>
    /// Gets or sets the for_each meta-argument.
    /// Can be a set, map, or an expression.
    /// </summary>
    public TerraformValue<TerraformExpression>? ForEach
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
    /// Preparation phase - prepares all meta-arguments and properties.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        base.Prepare(context);

        // TerraformValue<T> structs don't need preparation - they're resolved during serialization
    }

    /// <summary>
    /// Writes meta-arguments to HCL (count, for_each, depends_on, provider, lifecycle).
    /// </summary>
    protected void WriteMetaArguments(System.Text.StringBuilder sb, ITerraformContext context)
    {
        if (_count != null)
        {
            var countExpr = TerraformValueResolver.ResolveValue(_count, context);
            sb.AppendLine($"{context.Indent}count = {countExpr.ToHcl(context)}");
        }

        if (_forEach != null)
        {
            var forEachExpr = TerraformValueResolver.ResolveValue(_forEach, context);
            sb.AppendLine($"{context.Indent}for_each = {forEachExpr.ToHcl(context)}");
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
            sb.Append(dynamicBlock.ToHcl(context));
        }
    }
}
