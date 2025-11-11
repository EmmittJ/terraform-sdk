using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_version.
/// </summary>
public class AwsSecretsmanagerSecretVersionDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretVersionDataSource(string name) : base("aws_secretsmanager_secret_version", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformPropertyName("secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VersionId { get; set; } = default!;

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    [TerraformPropertyName("version_stage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionStage { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    [TerraformPropertyName("secret_binary")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretBinary => new TerraformReference(this, "secret_binary");

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    [TerraformPropertyName("secret_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretString => new TerraformReference(this, "secret_string");

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    [TerraformPropertyName("version_stages")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VersionStages => new TerraformReference(this, "version_stages");

}
