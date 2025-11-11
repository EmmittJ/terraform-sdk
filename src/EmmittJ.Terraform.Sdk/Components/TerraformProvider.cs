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
    [TerraformPropertyName("alias")]
    public TerraformValue<string>? Alias { get; set; }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
    {
        return TerraformExpression.Identifier(this, provider =>
        {
            // For now, we can't easily extract the literal value from TerraformValue<T>
            // So we'll just use the provider name
            // TODO: Consider if we need to support alias in references
            return provider.ConstructName;
        });
    }
}
