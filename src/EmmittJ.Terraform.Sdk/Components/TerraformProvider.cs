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
    public TerraformProperty<string>? Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
    {
        return TerraformExpression.Identifier(this, provider =>
        {
            if (provider.Alias?.LiteralValue is { } aliasValue)
            {
                return $"{provider.ConstructName}.{aliasValue}";
            }
            return provider.ConstructName;
        });
    }
}
