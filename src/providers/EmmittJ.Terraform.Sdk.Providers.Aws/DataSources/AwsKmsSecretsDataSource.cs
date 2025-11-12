using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public partial class AwsKmsSecretsDataSourceSecretBlock() : TerraformBlock("secret")
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformProperty("context")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Context { get; set; }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [TerraformProperty("encryption_algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformProperty("grant_tokens")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformProperty("key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformProperty("payload")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Payload { get; set; }

}

/// <summary>
/// Retrieves information about a aws_kms_secrets.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKmsSecretsDataSource : TerraformDataSource
{
    public AwsKmsSecretsDataSource(string name) : base("aws_kms_secrets", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secret block(s) required")]
    [TerraformProperty("secret")]
    public required TerraformSet<AwsKmsSecretsDataSourceSecretBlock> Secret { get; set; } = new();

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [TerraformProperty("plaintext")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Plaintext { get; }

}
