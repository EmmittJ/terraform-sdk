using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_version ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsSecretsmanagerSecretVersionEphemeralResource : TerraformEphemeralResource
{
    public AwsSecretsmanagerSecretVersionEphemeralResource(string name) : base("aws_secretsmanager_secret_version", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformPropertyName("secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecretId { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VersionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    [TerraformPropertyName("version_stage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VersionStage { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_stage");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    [TerraformPropertyName("secret_binary")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretBinary => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_binary");

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    [TerraformPropertyName("secret_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_string");

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    [TerraformPropertyName("version_stages")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VersionStages => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "version_stages");

}
