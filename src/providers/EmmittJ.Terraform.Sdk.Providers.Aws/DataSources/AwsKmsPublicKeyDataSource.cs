using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_public_key.
/// </summary>
public class AwsKmsPublicKeyDataSource : TerraformDataSource
{
    public AwsKmsPublicKeyDataSource(string name) : base("aws_kms_public_key", name)
    {
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformPropertyName("grant_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformPropertyName("customer_master_key_spec")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerMasterKeySpec => new TerraformReference(this, "customer_master_key_spec");

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("encryption_algorithms")]
    // Output-only attribute - read-only reference
    public TerraformList<string> EncryptionAlgorithms => new TerraformReference(this, "encryption_algorithms");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformPropertyName("key_usage")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyUsage => new TerraformReference(this, "key_usage");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKey => new TerraformReference(this, "public_key");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformPropertyName("public_key_pem")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKeyPem => new TerraformReference(this, "public_key_pem");

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("signing_algorithms")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SigningAlgorithms => new TerraformReference(this, "signing_algorithms");

}
