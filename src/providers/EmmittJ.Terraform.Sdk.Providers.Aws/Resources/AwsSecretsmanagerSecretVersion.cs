using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_version resource.
/// </summary>
public class AwsSecretsmanagerSecretVersion : TerraformResource
{
    public AwsSecretsmanagerSecretVersion(string name) : base("aws_secretsmanager_secret_version", name)
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
    /// The secret_binary attribute.
    /// </summary>
    [TerraformPropertyName("secret_binary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretBinary { get; set; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformPropertyName("secret_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    [TerraformPropertyName("secret_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretString { get; set; }

    /// <summary>
    /// The secret_string_wo attribute.
    /// </summary>
    [TerraformPropertyName("secret_string_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretStringWo { get; set; }

    /// <summary>
    /// The secret_string_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("secret_string_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SecretStringWoVersion { get; set; }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    [TerraformPropertyName("version_stages")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> VersionStages { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The has_secret_string_wo attribute.
    /// </summary>
    [TerraformPropertyName("has_secret_string_wo")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasSecretStringWo => new TerraformReference(this, "has_secret_string_wo");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionId => new TerraformReference(this, "version_id");

}
