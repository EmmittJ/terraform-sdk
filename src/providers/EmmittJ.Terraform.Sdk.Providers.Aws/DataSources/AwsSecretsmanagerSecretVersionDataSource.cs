using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_version.
/// </summary>
public partial class AwsSecretsmanagerSecretVersionDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretVersionDataSource(string name) : base("aws_secretsmanager_secret_version", name)
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
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformProperty("secret_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VersionId { get; set; }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    [TerraformProperty("version_stage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VersionStage { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    [TerraformProperty("secret_binary")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretBinary { get; }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    [TerraformProperty("secret_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretString { get; }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    [TerraformProperty("version_stages")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> VersionStages { get; }

}
