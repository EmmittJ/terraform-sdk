using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for excludes in AwsDatasyncTask.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskExcludesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excludes";

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public TerraformValue<string>? FilterType
    {
        get => new TerraformReference<string>(this, "filter_type");
        set => SetArgument("filter_type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for includes in AwsDatasyncTask.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskIncludesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "includes";

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public TerraformValue<string>? FilterType
    {
        get => new TerraformReference<string>(this, "filter_type");
        set => SetArgument("filter_type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for options in AwsDatasyncTask.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "options";

    /// <summary>
    /// The atime attribute.
    /// </summary>
    public TerraformValue<string>? Atime
    {
        get => new TerraformReference<string>(this, "atime");
        set => SetArgument("atime", value);
    }

    /// <summary>
    /// The bytes_per_second attribute.
    /// </summary>
    public TerraformValue<double>? BytesPerSecond
    {
        get => new TerraformReference<double>(this, "bytes_per_second");
        set => SetArgument("bytes_per_second", value);
    }

    /// <summary>
    /// The gid attribute.
    /// </summary>
    public TerraformValue<string>? Gid
    {
        get => new TerraformReference<string>(this, "gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string>? LogLevel
    {
        get => new TerraformReference<string>(this, "log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// The mtime attribute.
    /// </summary>
    public TerraformValue<string>? Mtime
    {
        get => new TerraformReference<string>(this, "mtime");
        set => SetArgument("mtime", value);
    }

    /// <summary>
    /// The object_tags attribute.
    /// </summary>
    public TerraformValue<string>? ObjectTags
    {
        get => new TerraformReference<string>(this, "object_tags");
        set => SetArgument("object_tags", value);
    }

    /// <summary>
    /// The overwrite_mode attribute.
    /// </summary>
    public TerraformValue<string>? OverwriteMode
    {
        get => new TerraformReference<string>(this, "overwrite_mode");
        set => SetArgument("overwrite_mode", value);
    }

    /// <summary>
    /// The posix_permissions attribute.
    /// </summary>
    public TerraformValue<string>? PosixPermissions
    {
        get => new TerraformReference<string>(this, "posix_permissions");
        set => SetArgument("posix_permissions", value);
    }

    /// <summary>
    /// The preserve_deleted_files attribute.
    /// </summary>
    public TerraformValue<string>? PreserveDeletedFiles
    {
        get => new TerraformReference<string>(this, "preserve_deleted_files");
        set => SetArgument("preserve_deleted_files", value);
    }

    /// <summary>
    /// The preserve_devices attribute.
    /// </summary>
    public TerraformValue<string>? PreserveDevices
    {
        get => new TerraformReference<string>(this, "preserve_devices");
        set => SetArgument("preserve_devices", value);
    }

    /// <summary>
    /// The security_descriptor_copy_flags attribute.
    /// </summary>
    public TerraformValue<string> SecurityDescriptorCopyFlags
    {
        get => new TerraformReference<string>(this, "security_descriptor_copy_flags");
        set => SetArgument("security_descriptor_copy_flags", value);
    }

    /// <summary>
    /// The task_queueing attribute.
    /// </summary>
    public TerraformValue<string>? TaskQueueing
    {
        get => new TerraformReference<string>(this, "task_queueing");
        set => SetArgument("task_queueing", value);
    }

    /// <summary>
    /// The transfer_mode attribute.
    /// </summary>
    public TerraformValue<string>? TransferMode
    {
        get => new TerraformReference<string>(this, "transfer_mode");
        set => SetArgument("transfer_mode", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    public TerraformValue<string>? Uid
    {
        get => new TerraformReference<string>(this, "uid");
        set => SetArgument("uid", value);
    }

    /// <summary>
    /// The verify_mode attribute.
    /// </summary>
    public TerraformValue<string>? VerifyMode
    {
        get => new TerraformReference<string>(this, "verify_mode");
        set => SetArgument("verify_mode", value);
    }

}


/// <summary>
/// Block type for schedule in AwsDatasyncTask.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

}


/// <summary>
/// Block type for task_report_config in AwsDatasyncTask.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskTaskReportConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_report_config";

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    public TerraformValue<string>? OutputType
    {
        get => new TerraformReference<string>(this, "output_type");
        set => SetArgument("output_type", value);
    }

    /// <summary>
    /// The report_level attribute.
    /// </summary>
    public TerraformValue<string>? ReportLevel
    {
        get => new TerraformReference<string>(this, "report_level");
        set => SetArgument("report_level", value);
    }

    /// <summary>
    /// The s3_object_versioning attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectVersioning
    {
        get => new TerraformReference<string>(this, "s3_object_versioning");
        set => SetArgument("s3_object_versioning", value);
    }

    /// <summary>
    /// ReportOverrides block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportOverrides block(s) allowed")]
    public TerraformList<AwsDatasyncTaskTaskReportConfigBlockReportOverridesBlock>? ReportOverrides
    {
        get => GetArgument<TerraformList<AwsDatasyncTaskTaskReportConfigBlockReportOverridesBlock>>("report_overrides");
        set => SetArgument("report_overrides", value);
    }

    /// <summary>
    /// S3Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Destination block(s) allowed")]
    public required TerraformList<AwsDatasyncTaskTaskReportConfigBlockS3DestinationBlock> S3Destination
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncTaskTaskReportConfigBlockS3DestinationBlock>>("s3_destination");
        set => SetArgument("s3_destination", value);
    }

}

/// <summary>
/// Block type for report_overrides in AwsDatasyncTaskTaskReportConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskTaskReportConfigBlockReportOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "report_overrides";

    /// <summary>
    /// The deleted_override attribute.
    /// </summary>
    public TerraformValue<string>? DeletedOverride
    {
        get => new TerraformReference<string>(this, "deleted_override");
        set => SetArgument("deleted_override", value);
    }

    /// <summary>
    /// The skipped_override attribute.
    /// </summary>
    public TerraformValue<string>? SkippedOverride
    {
        get => new TerraformReference<string>(this, "skipped_override");
        set => SetArgument("skipped_override", value);
    }

    /// <summary>
    /// The transferred_override attribute.
    /// </summary>
    public TerraformValue<string>? TransferredOverride
    {
        get => new TerraformReference<string>(this, "transferred_override");
        set => SetArgument("transferred_override", value);
    }

    /// <summary>
    /// The verified_override attribute.
    /// </summary>
    public TerraformValue<string>? VerifiedOverride
    {
        get => new TerraformReference<string>(this, "verified_override");
        set => SetArgument("verified_override", value);
    }

}

/// <summary>
/// Block type for s3_destination in AwsDatasyncTaskTaskReportConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskTaskReportConfigBlockS3DestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_destination";

    /// <summary>
    /// The bucket_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketAccessRoleArn is required")]
    public required TerraformValue<string> BucketAccessRoleArn
    {
        get => new TerraformReference<string>(this, "bucket_access_role_arn");
        set => SetArgument("bucket_access_role_arn", value);
    }

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketArn is required")]
    public required TerraformValue<string> S3BucketArn
    {
        get => new TerraformReference<string>(this, "s3_bucket_arn");
        set => SetArgument("s3_bucket_arn", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => new TerraformReference<string>(this, "subdirectory");
        set => SetArgument("subdirectory", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDatasyncTask.
/// Nesting mode: single
/// </summary>
public class AwsDatasyncTaskTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_datasync_task Terraform resource.
/// Manages a aws_datasync_task resource.
/// </summary>
public partial class AwsDatasyncTask(string name) : TerraformResource("aws_datasync_task", name)
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchLogGroupArn
    {
        get => new TerraformReference<string>(this, "cloudwatch_log_group_arn");
        set => SetArgument("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationLocationArn is required")]
    public required TerraformValue<string> DestinationLocationArn
    {
        get => new TerraformReference<string>(this, "destination_location_arn");
        set => SetArgument("destination_location_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceLocationArn is required")]
    public required TerraformValue<string> SourceLocationArn
    {
        get => new TerraformReference<string>(this, "source_location_arn");
        set => SetArgument("source_location_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The task_mode attribute.
    /// </summary>
    public TerraformValue<string> TaskMode
    {
        get => new TerraformReference<string>(this, "task_mode");
        set => SetArgument("task_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Excludes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    public TerraformList<AwsDatasyncTaskExcludesBlock>? Excludes
    {
        get => GetArgument<TerraformList<AwsDatasyncTaskExcludesBlock>>("excludes");
        set => SetArgument("excludes", value);
    }

    /// <summary>
    /// Includes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    public TerraformList<AwsDatasyncTaskIncludesBlock>? Includes
    {
        get => GetArgument<TerraformList<AwsDatasyncTaskIncludesBlock>>("includes");
        set => SetArgument("includes", value);
    }

    /// <summary>
    /// Options block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public TerraformList<AwsDatasyncTaskOptionsBlock>? Options
    {
        get => GetArgument<TerraformList<AwsDatasyncTaskOptionsBlock>>("options");
        set => SetArgument("options", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AwsDatasyncTaskScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AwsDatasyncTaskScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// TaskReportConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskReportConfig block(s) allowed")]
    public TerraformList<AwsDatasyncTaskTaskReportConfigBlock>? TaskReportConfig
    {
        get => GetArgument<TerraformList<AwsDatasyncTaskTaskReportConfigBlock>>("task_report_config");
        set => SetArgument("task_report_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatasyncTaskTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatasyncTaskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
