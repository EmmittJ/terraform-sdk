using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for excludes in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncTaskExcludesBlock() : TerraformBlock("excludes")
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [TerraformProperty("filter_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterType { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for includes in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncTaskIncludesBlock() : TerraformBlock("includes")
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [TerraformProperty("filter_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterType { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncTaskOptionsBlock() : TerraformBlock("options")
{
    /// <summary>
    /// The atime attribute.
    /// </summary>
    [TerraformProperty("atime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Atime { get; set; }

    /// <summary>
    /// The bytes_per_second attribute.
    /// </summary>
    [TerraformProperty("bytes_per_second")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BytesPerSecond { get; set; }

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [TerraformProperty("gid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Gid { get; set; }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformProperty("log_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogLevel { get; set; }

    /// <summary>
    /// The mtime attribute.
    /// </summary>
    [TerraformProperty("mtime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mtime { get; set; }

    /// <summary>
    /// The object_tags attribute.
    /// </summary>
    [TerraformProperty("object_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectTags { get; set; }

    /// <summary>
    /// The overwrite_mode attribute.
    /// </summary>
    [TerraformProperty("overwrite_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OverwriteMode { get; set; }

    /// <summary>
    /// The posix_permissions attribute.
    /// </summary>
    [TerraformProperty("posix_permissions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PosixPermissions { get; set; }

    /// <summary>
    /// The preserve_deleted_files attribute.
    /// </summary>
    [TerraformProperty("preserve_deleted_files")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreserveDeletedFiles { get; set; }

    /// <summary>
    /// The preserve_devices attribute.
    /// </summary>
    [TerraformProperty("preserve_devices")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreserveDevices { get; set; }

    /// <summary>
    /// The security_descriptor_copy_flags attribute.
    /// </summary>
    [TerraformProperty("security_descriptor_copy_flags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityDescriptorCopyFlags { get; set; }

    /// <summary>
    /// The task_queueing attribute.
    /// </summary>
    [TerraformProperty("task_queueing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TaskQueueing { get; set; }

    /// <summary>
    /// The transfer_mode attribute.
    /// </summary>
    [TerraformProperty("transfer_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransferMode { get; set; }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [TerraformProperty("uid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uid { get; set; }

    /// <summary>
    /// The verify_mode attribute.
    /// </summary>
    [TerraformProperty("verify_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VerifyMode { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncTaskScheduleBlock() : TerraformBlock("schedule")
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformProperty("schedule_expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScheduleExpression { get; set; }

}

/// <summary>
/// Block type for task_report_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncTaskTaskReportConfigBlock() : TerraformBlock("task_report_config")
{
    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [TerraformProperty("output_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutputType { get; set; }

    /// <summary>
    /// The report_level attribute.
    /// </summary>
    [TerraformProperty("report_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReportLevel { get; set; }

    /// <summary>
    /// The s3_object_versioning attribute.
    /// </summary>
    [TerraformProperty("s3_object_versioning")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3ObjectVersioning { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatasyncTaskTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datasync_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatasyncTask : TerraformResource
{
    public AwsDatasyncTask(string name) : base("aws_datasync_task", name)
    {
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_log_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationLocationArn is required")]
    [TerraformProperty("destination_location_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationLocationArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceLocationArn is required")]
    [TerraformProperty("source_location_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceLocationArn { get; set; }

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
    /// The task_mode attribute.
    /// </summary>
    [TerraformProperty("task_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TaskMode { get; set; }

    /// <summary>
    /// Block for excludes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    [TerraformProperty("excludes")]
    public TerraformList<AwsDatasyncTaskExcludesBlock> Excludes { get; set; } = new();

    /// <summary>
    /// Block for includes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    [TerraformProperty("includes")]
    public TerraformList<AwsDatasyncTaskIncludesBlock> Includes { get; set; } = new();

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformProperty("options")]
    public TerraformList<AwsDatasyncTaskOptionsBlock> Options { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public TerraformList<AwsDatasyncTaskScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for task_report_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskReportConfig block(s) allowed")]
    [TerraformProperty("task_report_config")]
    public TerraformList<AwsDatasyncTaskTaskReportConfigBlock> TaskReportConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDatasyncTaskTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
