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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Type { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [TerraformPropertyName("type_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TypeName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type_name");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionId { get; set; }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    [TerraformPropertyName("default_version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultVersionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_version_id");

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    [TerraformPropertyName("deprecated_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeprecatedStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deprecated_status");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    [TerraformPropertyName("documentation_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DocumentationUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "documentation_url");

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_role_arn");

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    [TerraformPropertyName("is_default_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsDefaultVersion => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_default_version");

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    [TerraformPropertyName("logging_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LoggingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logging_config");

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProvisioningType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provisioning_type");

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Schema => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "schema");

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    [TerraformPropertyName("source_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_url");

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    [TerraformPropertyName("type_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TypeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type_arn");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Visibility => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "visibility");

}
