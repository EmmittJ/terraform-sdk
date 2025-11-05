namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform module block.
/// Modules allow you to reuse and compose Terraform configurations.
/// </summary>
public class TerraformModule : NamedTerraformConstruct, ITerraformResolvable<string>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformModule"/> class.
    /// </summary>
    /// <param name="name">The name of the module instance.</param>
    public TerraformModule(string name) : base(name)
    {
    }

    /// <inheritdoc/>
    protected override string BlockType => "module";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [ConstructName];

    /// <summary>
    /// Gets or sets the source of the module.
    /// Can be a local path, registry source, git URL, etc.
    /// </summary>
    public required TerraformLiteralProperty<string> Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source") ?? throw new InvalidOperationException("Source is required");
        set => WithPropertyInternal("source", value, priority: 0);
    }

    /// <summary>
    /// Gets or sets the version constraint for the module (optional).
    /// Only applicable for registry modules.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => WithPropertyInternal("version", value, priority: 1);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"module.{ConstructName}");
}
