using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_location in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmAssociationOutputLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformProperty("s3_bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_key_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [TerraformProperty("s3_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3Region { get; set; }

}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmAssociationTargetsBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Manages a aws_ssm_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmAssociation : TerraformResource
{
    public AwsSsmAssociation(string name) : base("aws_ssm_association", name)
    {
    }

    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    [TerraformProperty("apply_only_at_cron_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyOnlyAtCronInterval { get; set; }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    [TerraformProperty("association_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AssociationName { get; set; }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    [TerraformProperty("automation_target_parameter_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutomationTargetParameterName { get; set; }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    [TerraformProperty("compliance_severity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComplianceSeverity { get; set; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformProperty("document_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DocumentVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformProperty("max_concurrency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxConcurrency { get; set; }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    [TerraformProperty("max_errors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Parameters { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [TerraformProperty("schedule_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScheduleExpression { get; set; }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    [TerraformProperty("sync_compliance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SyncCompliance { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("wait_for_success_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? WaitForSuccessTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for output_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputLocation block(s) allowed")]
    [TerraformProperty("output_location")]
    public partial TerraformList<TerraformBlock<AwsSsmAssociationOutputLocationBlock>>? OutputLocation { get; set; }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    [TerraformProperty("targets")]
    public partial TerraformList<TerraformBlock<AwsSsmAssociationTargetsBlock>>? Targets { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationId { get; }

}
