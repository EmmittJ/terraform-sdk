using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AwsKmsSecretsEphemeralResourceSecretBlock
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformPropertyName("context")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Context { get; set; }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("encryption_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformPropertyName("grant_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformPropertyName("payload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Payload { get; set; }

}

/// <summary>
/// Manages a aws_kms_secrets ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsKmsSecretsEphemeralResource : TerraformEphemeralResource
{
    public AwsKmsSecretsEphemeralResource(string name) : base("aws_kms_secrets", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformSet<TerraformBlock<AwsKmsSecretsEphemeralResourceSecretBlock>>? Secret { get; set; }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [TerraformPropertyName("plaintext")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Plaintext => new TerraformReference(this, "plaintext");

}
