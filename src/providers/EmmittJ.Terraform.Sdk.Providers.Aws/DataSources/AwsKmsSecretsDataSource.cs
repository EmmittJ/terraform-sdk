using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AwsKmsSecretsDataSourceSecretBlock : ITerraformBlock
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformPropertyName("context")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Context { get; set; }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("encryption_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformPropertyName("grant_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? GrantTokens { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformPropertyName("payload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Payload { get; set; }

}

/// <summary>
/// Retrieves information about a aws_kms_secrets.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKmsSecretsDataSource : TerraformDataSource
{
    public AwsKmsSecretsDataSource(string name) : base("aws_kms_secrets", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secret block(s) required")]
    [TerraformPropertyName("secret")]
    public TerraformSet<TerraformBlock<AwsKmsSecretsDataSourceSecretBlock>>? Secret { get; set; } = new();

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [TerraformPropertyName("plaintext")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Plaintext => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "plaintext");

}
