using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_version resource.
/// </summary>
public partial class AwsSecretsmanagerSecretVersion : TerraformResource
{
    public AwsSecretsmanagerSecretVersion(string name) : base("aws_secretsmanager_secret_version", name)
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
    /// The secret_binary attribute.
    /// </summary>
    [TerraformProperty("secret_binary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretBinary { get; set; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformProperty("secret_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    [TerraformProperty("secret_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretString { get; set; }

    /// <summary>
    /// The secret_string_wo attribute.
    /// </summary>
    [TerraformProperty("secret_string_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretStringWo { get; set; }

    /// <summary>
    /// The secret_string_wo_version attribute.
    /// </summary>
    [TerraformProperty("secret_string_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SecretStringWoVersion { get; set; }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    [TerraformProperty("version_stages")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VersionStages { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The has_secret_string_wo attribute.
    /// </summary>
    [TerraformProperty("has_secret_string_wo")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HasSecretStringWo { get; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionId { get; }

}
