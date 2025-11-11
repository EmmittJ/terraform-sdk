using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationTypeLoggingConfigBlock
{
    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    [TerraformPropertyName("log_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogGroupName { get; set; }

    /// <summary>
    /// The log_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogRoleArn is required")]
    [TerraformPropertyName("log_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogRoleArn { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationType : TerraformResource
{
    public AwsCloudformationType(string name) : base("aws_cloudformation_type", name)
    {
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionRoleArn { get; set; }

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
    /// The schema_handler_package attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaHandlerPackage is required")]
    [TerraformPropertyName("schema_handler_package")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SchemaHandlerPackage { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Type { get; set; } = default!;

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    [TerraformPropertyName("type_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TypeName { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<AwsCloudformationTypeLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    [TerraformPropertyName("default_version_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultVersionId => new TerraformReference(this, "default_version_id");

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    [TerraformPropertyName("deprecated_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeprecatedStatus => new TerraformReference(this, "deprecated_status");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformPropertyName("documentation_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DocumentationUrl => new TerraformReference(this, "documentation_url");

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    [TerraformPropertyName("is_default_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsDefaultVersion => new TerraformReference(this, "is_default_version");

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProvisioningType => new TerraformReference(this, "provisioning_type");

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Schema => new TerraformReference(this, "schema");

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    [TerraformPropertyName("source_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceUrl => new TerraformReference(this, "source_url");

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    [TerraformPropertyName("type_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TypeArn => new TerraformReference(this, "type_arn");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionId => new TerraformReference(this, "version_id");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Visibility => new TerraformReference(this, "visibility");

}
