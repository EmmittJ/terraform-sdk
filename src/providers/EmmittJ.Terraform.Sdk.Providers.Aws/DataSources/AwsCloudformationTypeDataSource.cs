using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_type.
/// </summary>
public class AwsCloudformationTypeDataSource : TerraformDataSource
{
    public AwsCloudformationTypeDataSource(string name) : base("aws_cloudformation_type", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

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
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Type { get; set; } = default!;

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformPropertyName("type_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TypeName { get; set; } = default!;

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionId { get; set; }

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
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExecutionRoleArn => new TerraformReference(this, "execution_role_arn");

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    [TerraformPropertyName("is_default_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsDefaultVersion => new TerraformReference(this, "is_default_version");

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    [TerraformPropertyName("logging_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LoggingConfig => new TerraformReference(this, "logging_config");

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
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Visibility => new TerraformReference(this, "visibility");

}
