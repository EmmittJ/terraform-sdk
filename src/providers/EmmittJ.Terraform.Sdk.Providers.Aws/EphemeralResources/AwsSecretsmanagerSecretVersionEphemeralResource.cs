using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_version ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class AwsSecretsmanagerSecretVersionEphemeralResource : TerraformEphemeralResource
{
    public AwsSecretsmanagerSecretVersionEphemeralResource(string name) : base("aws_secretsmanager_secret_version", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformProperty("secret_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VersionId { get; set; }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    [TerraformProperty("version_stage")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VersionStage { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    [TerraformProperty("secret_binary")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretBinary { get; }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    [TerraformProperty("secret_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretString { get; }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    [TerraformProperty("version_stages")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> VersionStages { get; }

}
