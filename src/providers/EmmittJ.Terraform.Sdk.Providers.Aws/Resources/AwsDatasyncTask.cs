using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for excludes in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskExcludesBlock
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [TerraformPropertyName("filter_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FilterType { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for includes in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskIncludesBlock
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [TerraformPropertyName("filter_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FilterType { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskOptionsBlock
{
    /// <summary>
    /// The atime attribute.
    /// </summary>
    [TerraformPropertyName("atime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Atime { get; set; }

    /// <summary>
    /// The bytes_per_second attribute.
    /// </summary>
    [TerraformPropertyName("bytes_per_second")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BytesPerSecond { get; set; }

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [TerraformPropertyName("gid")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Gid { get; set; }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformPropertyName("log_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogLevel { get; set; }

    /// <summary>
    /// The mtime attribute.
    /// </summary>
    [TerraformPropertyName("mtime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mtime { get; set; }

    /// <summary>
    /// The object_tags attribute.
    /// </summary>
    [TerraformPropertyName("object_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectTags { get; set; }

    /// <summary>
    /// The overwrite_mode attribute.
    /// </summary>
    [TerraformPropertyName("overwrite_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OverwriteMode { get; set; }

    /// <summary>
    /// The posix_permissions attribute.
    /// </summary>
    [TerraformPropertyName("posix_permissions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PosixPermissions { get; set; }

    /// <summary>
    /// The preserve_deleted_files attribute.
    /// </summary>
    [TerraformPropertyName("preserve_deleted_files")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreserveDeletedFiles { get; set; }

    /// <summary>
    /// The preserve_devices attribute.
    /// </summary>
    [TerraformPropertyName("preserve_devices")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreserveDevices { get; set; }

    /// <summary>
    /// The security_descriptor_copy_flags attribute.
    /// </summary>
    [TerraformPropertyName("security_descriptor_copy_flags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityDescriptorCopyFlags { get; set; } = default!;

    /// <summary>
    /// The task_queueing attribute.
    /// </summary>
    [TerraformPropertyName("task_queueing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TaskQueueing { get; set; }

    /// <summary>
    /// The transfer_mode attribute.
    /// </summary>
    [TerraformPropertyName("transfer_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransferMode { get; set; }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Uid { get; set; }

    /// <summary>
    /// The verify_mode attribute.
    /// </summary>
    [TerraformPropertyName("verify_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VerifyMode { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskScheduleBlock
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformPropertyName("schedule_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScheduleExpression { get; set; }

}

/// <summary>
/// Block type for task_report_config in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskTaskReportConfigBlock
{
    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [TerraformPropertyName("output_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutputType { get; set; }

    /// <summary>
    /// The report_level attribute.
    /// </summary>
    [TerraformPropertyName("report_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReportLevel { get; set; }

    /// <summary>
    /// The s3_object_versioning attribute.
    /// </summary>
    [TerraformPropertyName("s3_object_versioning")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3ObjectVersioning { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatasyncTaskTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datasync_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncTask : TerraformResource
{
    public AwsDatasyncTask(string name) : base("aws_datasync_task", name)
    {
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationLocationArn is required")]
    [TerraformPropertyName("destination_location_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DestinationLocationArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceLocationArn is required")]
    [TerraformPropertyName("source_location_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceLocationArn { get; set; }

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
    /// The task_mode attribute.
    /// </summary>
    [TerraformPropertyName("task_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TaskMode { get; set; } = default!;

    /// <summary>
    /// Block for excludes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    [TerraformPropertyName("excludes")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskExcludesBlock>>? Excludes { get; set; }

    /// <summary>
    /// Block for includes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    [TerraformPropertyName("includes")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskIncludesBlock>>? Includes { get; set; }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformPropertyName("options")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskOptionsBlock>>? Options { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for task_report_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskReportConfig block(s) allowed")]
    [TerraformPropertyName("task_report_config")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskTaskReportConfigBlock>>? TaskReportConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDatasyncTaskTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
