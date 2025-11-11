using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_type.
/// </summary>
public partial class AwsCloudformationTypeDataSource : TerraformDataSource
{
    public AwsCloudformationTypeDataSource(string name) : base("aws_cloudformation_type", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformProperty("type_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TypeName { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionId { get; set; }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    [TerraformProperty("default_version_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultVersionId { get; }

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    [TerraformProperty("deprecated_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeprecatedStatus { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformProperty("documentation_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DocumentationUrl { get; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("execution_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExecutionRoleArn { get; }

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    [TerraformProperty("is_default_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsDefaultVersion { get; }

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    [TerraformProperty("logging_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LoggingConfig { get; }

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    [TerraformProperty("provisioning_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProvisioningType { get; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformProperty("schema")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Schema { get; }

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    [TerraformProperty("source_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceUrl { get; }

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    [TerraformProperty("type_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TypeArn { get; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Visibility { get; }

}
