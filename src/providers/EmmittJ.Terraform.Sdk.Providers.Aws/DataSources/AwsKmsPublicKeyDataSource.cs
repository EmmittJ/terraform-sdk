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
    public TerraformProperty<List<TerraformProperty<string>>>? GrantTokens { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformPropertyName("customer_master_key_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerMasterKeySpec => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_master_key_spec");

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("encryption_algorithms")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> EncryptionAlgorithms => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "encryption_algorithms");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformPropertyName("key_usage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyUsage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_usage");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformPropertyName("public_key_pem")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicKeyPem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key_pem");

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    [TerraformPropertyName("signing_algorithms")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SigningAlgorithms => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "signing_algorithms");

}
