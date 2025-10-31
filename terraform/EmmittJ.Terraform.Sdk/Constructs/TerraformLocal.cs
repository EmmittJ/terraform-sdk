namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
public class TerraformLocal : TerraformConstruct
{
    /// <inheritdoc/>
    protected override string BlockType => "locals";

    /// <inheritdoc/>
    protected override string[] Labels => Array.Empty<string>();

    /// <summary>
    /// Gets a reference to a local value.
    /// </summary>
    public TerraformReferenceExpression this[string name]
    {
        get
        {
            if (!Properties.ContainsKey(name))
            {
                throw new TerraformConfigurationException(
                    $"Local value '{name}' has not been defined. " +
                    $"Use Set(\"{name}\", value) to define it first.",
                    this,
                    name);
            }
            return new TerraformReferenceExpression(this, name);
        }
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier("local");

    /// <summary>
    /// Gets the reference expression for a specific local value.
    /// </summary>
    public TerraformExpression AsReference(string name)
        => TerraformExpression.Identifier($"local.{name}");
}
