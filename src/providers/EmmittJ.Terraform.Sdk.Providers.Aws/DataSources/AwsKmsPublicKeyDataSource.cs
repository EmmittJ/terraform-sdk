using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_public_key.
/// </summary>
public partial class AwsKmsPublicKeyDataSource : TerraformDataSource
{
    public AwsKmsPublicKeyDataSource(string name) : base("aws_kms_public_key", name)
    {
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformProperty("grant_tokens")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformProperty("customer_master_key_spec")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerMasterKeySpec { get; }

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    [TerraformProperty("encryption_algorithms")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> EncryptionAlgorithms { get; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformProperty("key_usage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyUsage { get; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicKey { get; }

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformProperty("public_key_pem")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicKeyPem { get; }

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    [TerraformProperty("signing_algorithms")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SigningAlgorithms { get; }

}
