namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform ephemeral resource block.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets
/// that don't persist in the Terraform state file.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/ephemeral"/></para>
/// </remarks>
public class TerraformEphemeralResource(string type, string name) : TerraformBlock()
{
    /// <summary>
    /// Gets the type of this ephemeral resource (e.g., "random_id").
    /// </summary>
    public string ResourceType { get; } = type ?? throw new ArgumentNullException(nameof(type));

    /// <summary>
    /// Gets the name of this ephemeral resource.
    /// </summary>
    public string ResourceName { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <summary>
    /// Gets the block type keyword for ephemeral resources.
    /// </summary>
    public override string BlockType => "ephemeral";

    /// <summary>
    /// Gets the block labels for this ephemeral resource.
    /// </summary>
    public override string[] BlockLabels => [ResourceType, ResourceName];

    /// <summary>
    /// Gets the Terraform reference identifier for this ephemeral resource (e.g., "ephemeral.aws_secretsmanager_secret_version.example").
    /// </summary>
    public override string ReferenceIdentifier => $"ephemeral.{ResourceType}.{ResourceName}";
}
