namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform provider configuration block.
/// </summary>
public class TerraformProvider(string name) : NamedTerraformConstruct(name)
{
    /// <inheritdoc/>
    protected override string BlockType => "provider";

    /// <inheritdoc/>
    protected override string[] Labels => [Name];

    /// <summary>
    /// Gets or sets the alias for this provider instance.
    /// </summary>
    public TerraformLiteralProperty<string>? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias");
        set => WithPropertyInternal("alias", value);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier(Alias?.Value != null ? $"{Name}.{Alias.Value}" : Name);
}
