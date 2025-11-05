namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform provider configuration block.
/// </summary>
public class TerraformProvider(string name) : NamedTerraformConstruct(name)
{
    /// <inheritdoc/>
    public override string BlockType => "provider";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [ConstructName];

    /// <summary>
    /// Gets or sets the alias for this provider instance.
    /// </summary>
    public TerraformLiteralProperty<string>? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier(Alias?.Value != null ? $"{ConstructName}.{Alias.Value}" : ConstructName);
}
