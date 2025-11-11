using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlock
{
    /// <summary>
    /// The bytes_scanned_cutoff_per_query attribute.
    /// </summary>
    [TerraformPropertyName("bytes_scanned_cutoff_per_query")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>
    /// The enforce_workgroup_configuration attribute.
    /// </summary>
    [TerraformPropertyName("enforce_workgroup_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformPropertyName("execution_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionRole { get; set; }

    /// <summary>
    /// The publish_cloudwatch_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("publish_cloudwatch_metrics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// The requester_pays_enabled attribute.
    /// </summary>
    [TerraformPropertyName("requester_pays_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequesterPaysEnabled { get; set; }

}

/// <summary>
/// Manages a aws_athena_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAthenaWorkgroup : TerraformResource
{
    public AwsAthenaWorkgroup(string name) : base("aws_athena_workgroup", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsAthenaWorkgroupConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
