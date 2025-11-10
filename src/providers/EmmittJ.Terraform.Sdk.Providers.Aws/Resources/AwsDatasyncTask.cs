using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for excludes in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskExcludesBlock : ITerraformBlock
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [TerraformPropertyName("filter_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterType { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for includes in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskIncludesBlock : ITerraformBlock
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [TerraformPropertyName("filter_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterType { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The atime attribute.
    /// </summary>
    [TerraformPropertyName("atime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Atime { get; set; }

    /// <summary>
    /// The bytes_per_second attribute.
    /// </summary>
    [TerraformPropertyName("bytes_per_second")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BytesPerSecond { get; set; }

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [TerraformPropertyName("gid")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Gid { get; set; }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformPropertyName("log_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogLevel { get; set; }

    /// <summary>
    /// The mtime attribute.
    /// </summary>
    [TerraformPropertyName("mtime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mtime { get; set; }

    /// <summary>
    /// The object_tags attribute.
    /// </summary>
    [TerraformPropertyName("object_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectTags { get; set; }

    /// <summary>
    /// The overwrite_mode attribute.
    /// </summary>
    [TerraformPropertyName("overwrite_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OverwriteMode { get; set; }

    /// <summary>
    /// The posix_permissions attribute.
    /// </summary>
    [TerraformPropertyName("posix_permissions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PosixPermissions { get; set; }

    /// <summary>
    /// The preserve_deleted_files attribute.
    /// </summary>
    [TerraformPropertyName("preserve_deleted_files")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreserveDeletedFiles { get; set; }

    /// <summary>
    /// The preserve_devices attribute.
    /// </summary>
    [TerraformPropertyName("preserve_devices")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreserveDevices { get; set; }

    /// <summary>
    /// The security_descriptor_copy_flags attribute.
    /// </summary>
    [TerraformPropertyName("security_descriptor_copy_flags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecurityDescriptorCopyFlags { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "security_descriptor_copy_flags");

    /// <summary>
    /// The task_queueing attribute.
    /// </summary>
    [TerraformPropertyName("task_queueing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TaskQueueing { get; set; }

    /// <summary>
    /// The transfer_mode attribute.
    /// </summary>
    [TerraformPropertyName("transfer_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransferMode { get; set; }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uid { get; set; }

    /// <summary>
    /// The verify_mode attribute.
    /// </summary>
    [TerraformPropertyName("verify_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VerifyMode { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformPropertyName("schedule_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScheduleExpression { get; set; }

}

/// <summary>
/// Block type for task_report_config in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskTaskReportConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [TerraformPropertyName("output_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutputType { get; set; }

    /// <summary>
    /// The report_level attribute.
    /// </summary>
    [TerraformPropertyName("report_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReportLevel { get; set; }

    /// <summary>
    /// The s3_object_versioning attribute.
    /// </summary>
    [TerraformPropertyName("s3_object_versioning")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3ObjectVersioning { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatasyncTaskTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationLocationArn is required")]
    [TerraformPropertyName("destination_location_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationLocationArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceLocationArn is required")]
    [TerraformPropertyName("source_location_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceLocationArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The task_mode attribute.
    /// </summary>
    [TerraformPropertyName("task_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TaskMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "task_mode");

    /// <summary>
    /// Block for excludes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    [TerraformPropertyName("excludes")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskExcludesBlock>>? Excludes { get; set; } = new();

    /// <summary>
    /// Block for includes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    [TerraformPropertyName("includes")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskIncludesBlock>>? Includes { get; set; } = new();

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformPropertyName("options")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskOptionsBlock>>? Options { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for task_report_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskReportConfig block(s) allowed")]
    [TerraformPropertyName("task_report_config")]
    public TerraformList<TerraformBlock<AwsDatasyncTaskTaskReportConfigBlock>>? TaskReportConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDatasyncTaskTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
