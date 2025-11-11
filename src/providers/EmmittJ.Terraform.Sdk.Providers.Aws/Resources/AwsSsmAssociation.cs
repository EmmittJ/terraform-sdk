using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_location in .
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationOutputLocationBlock
{
    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [TerraformPropertyName("s3_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3Region { get; set; }

}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationTargetsBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Manages a aws_ssm_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmAssociation : TerraformResource
{
    public AwsSsmAssociation(string name) : base("aws_ssm_association", name)
    {
    }

    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    [TerraformPropertyName("apply_only_at_cron_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApplyOnlyAtCronInterval { get; set; }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    [TerraformPropertyName("association_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssociationName { get; set; }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    [TerraformPropertyName("automation_target_parameter_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutomationTargetParameterName { get; set; }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    [TerraformPropertyName("compliance_severity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComplianceSeverity { get; set; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformPropertyName("document_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DocumentVersion { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxConcurrency { get; set; }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    [TerraformPropertyName("max_errors")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Parameters { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [TerraformPropertyName("schedule_expression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScheduleExpression { get; set; }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    [TerraformPropertyName("sync_compliance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SyncCompliance { get; set; }

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
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_success_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? WaitForSuccessTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for output_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputLocation block(s) allowed")]
    [TerraformPropertyName("output_location")]
    public TerraformList<TerraformBlock<AwsSsmAssociationOutputLocationBlock>>? OutputLocation { get; set; }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    [TerraformPropertyName("targets")]
    public TerraformList<TerraformBlock<AwsSsmAssociationTargetsBlock>>? Targets { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssociationId => new TerraformReference(this, "association_id");

}
