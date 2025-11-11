using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationTypeLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    [TerraformProperty("log_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogGroupName { get; set; }

    /// <summary>
    /// The log_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogRoleArn is required")]
    [TerraformProperty("log_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogRoleArn { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudformationType : TerraformResource
{
    public AwsCloudformationType(string name) : base("aws_cloudformation_type", name)
    {
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("execution_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionRoleArn { get; set; }

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
    /// The schema_handler_package attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaHandlerPackage is required")]
    [TerraformProperty("schema_handler_package")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SchemaHandlerPackage { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    [TerraformProperty("type_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TypeName { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public partial TerraformList<TerraformBlock<AwsCloudformationTypeLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    [TerraformProperty("default_version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultVersionId { get; }

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    [TerraformProperty("deprecated_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeprecatedStatus { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformProperty("documentation_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DocumentationUrl { get; }

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    [TerraformProperty("is_default_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsDefaultVersion { get; }

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    [TerraformProperty("provisioning_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProvisioningType { get; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformProperty("schema")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Schema { get; }

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    [TerraformProperty("source_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceUrl { get; }

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    [TerraformProperty("type_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TypeArn { get; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionId { get; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Visibility { get; }

}
