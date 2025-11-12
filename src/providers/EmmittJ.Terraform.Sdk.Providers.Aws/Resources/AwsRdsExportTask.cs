using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsExportTaskTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_rds_export_task resource.
/// </summary>
public partial class AwsRdsExportTask : TerraformResource
{
    public AwsRdsExportTask(string name) : base("aws_rds_export_task", name)
    {
    }

    /// <summary>
    /// The export_only attribute.
    /// </summary>
    [TerraformProperty("export_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExportOnly { get; set; }

    /// <summary>
    /// The export_task_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportTaskIdentifier is required")]
    [TerraformProperty("export_task_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExportTaskIdentifier { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformProperty("iam_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformProperty("kms_key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformProperty("s3_bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> S3Prefix { get; set; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    [TerraformProperty("source_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRdsExportTaskTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The failure_cause attribute.
    /// </summary>
    [TerraformProperty("failure_cause")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FailureCause { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The percent_progress attribute.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The snapshot_time attribute.
    /// </summary>
    [TerraformProperty("snapshot_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnapshotTime { get; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [TerraformProperty("source_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceType { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The task_end_time attribute.
    /// </summary>
    [TerraformProperty("task_end_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TaskEndTime { get; }

    /// <summary>
    /// The task_start_time attribute.
    /// </summary>
    [TerraformProperty("task_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TaskStartTime { get; }

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    [TerraformProperty("warning_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WarningMessage { get; }

}
