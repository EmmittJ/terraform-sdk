namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform ephemeral resource block.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets
/// that don't persist in the Terraform state file.
/// </summary>
public class TerraformEphemeralResource(string type, string name) : TerraformBlock("")
{
    /// <summary>
    /// Gets the type of this ephemeral resource (e.g., "random_id").
    /// </summary>
    public string ConstructType { get; } = type ?? throw new ArgumentNullException(nameof(type));

    /// <summary>
    /// Gets the name of this ephemeral resource.
    /// </summary>
    public string ConstructName { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"ephemeral.{ConstructType}.{ConstructName}");

    /// <inheritdoc/>
    public override TerraformExpression Resolve(ITerraformContext context)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(context);

        // Ephemeral resources use "ephemeral" block type
        return new TerraformConstructExpression(
            blockType: "ephemeral",
            labels: [ConstructType, ConstructName],
            body: bodyMap
        );
    }
}
