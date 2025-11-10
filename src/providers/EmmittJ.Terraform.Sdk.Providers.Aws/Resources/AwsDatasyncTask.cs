using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for excludes in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskExcludesBlock : TerraformBlock
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public TerraformProperty<string>? FilterType
    {
        get => GetProperty<TerraformProperty<string>>("filter_type");
        set => WithProperty("filter_type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for includes in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskIncludesBlock : TerraformBlock
{
    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    public TerraformProperty<string>? FilterType
    {
        get => GetProperty<TerraformProperty<string>>("filter_type");
        set => WithProperty("filter_type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The atime attribute.
    /// </summary>
    public TerraformProperty<string>? Atime
    {
        get => GetProperty<TerraformProperty<string>>("atime");
        set => WithProperty("atime", value);
    }

    /// <summary>
    /// The bytes_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? BytesPerSecond
    {
        get => GetProperty<TerraformProperty<double>>("bytes_per_second");
        set => WithProperty("bytes_per_second", value);
    }

    /// <summary>
    /// The gid attribute.
    /// </summary>
    public TerraformProperty<string>? Gid
    {
        get => GetProperty<TerraformProperty<string>>("gid");
        set => WithProperty("gid", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformProperty<string>? LogLevel
    {
        get => GetProperty<TerraformProperty<string>>("log_level");
        set => WithProperty("log_level", value);
    }

    /// <summary>
    /// The mtime attribute.
    /// </summary>
    public TerraformProperty<string>? Mtime
    {
        get => GetProperty<TerraformProperty<string>>("mtime");
        set => WithProperty("mtime", value);
    }

    /// <summary>
    /// The object_tags attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectTags
    {
        get => GetProperty<TerraformProperty<string>>("object_tags");
        set => WithProperty("object_tags", value);
    }

    /// <summary>
    /// The overwrite_mode attribute.
    /// </summary>
    public TerraformProperty<string>? OverwriteMode
    {
        get => GetProperty<TerraformProperty<string>>("overwrite_mode");
        set => WithProperty("overwrite_mode", value);
    }

    /// <summary>
    /// The posix_permissions attribute.
    /// </summary>
    public TerraformProperty<string>? PosixPermissions
    {
        get => GetProperty<TerraformProperty<string>>("posix_permissions");
        set => WithProperty("posix_permissions", value);
    }

    /// <summary>
    /// The preserve_deleted_files attribute.
    /// </summary>
    public TerraformProperty<string>? PreserveDeletedFiles
    {
        get => GetProperty<TerraformProperty<string>>("preserve_deleted_files");
        set => WithProperty("preserve_deleted_files", value);
    }

    /// <summary>
    /// The preserve_devices attribute.
    /// </summary>
    public TerraformProperty<string>? PreserveDevices
    {
        get => GetProperty<TerraformProperty<string>>("preserve_devices");
        set => WithProperty("preserve_devices", value);
    }

    /// <summary>
    /// The security_descriptor_copy_flags attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityDescriptorCopyFlags
    {
        get => GetProperty<TerraformProperty<string>>("security_descriptor_copy_flags");
        set => WithProperty("security_descriptor_copy_flags", value);
    }

    /// <summary>
    /// The task_queueing attribute.
    /// </summary>
    public TerraformProperty<string>? TaskQueueing
    {
        get => GetProperty<TerraformProperty<string>>("task_queueing");
        set => WithProperty("task_queueing", value);
    }

    /// <summary>
    /// The transfer_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TransferMode
    {
        get => GetProperty<TerraformProperty<string>>("transfer_mode");
        set => WithProperty("transfer_mode", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    public TerraformProperty<string>? Uid
    {
        get => GetProperty<TerraformProperty<string>>("uid");
        set => WithProperty("uid", value);
    }

    /// <summary>
    /// The verify_mode attribute.
    /// </summary>
    public TerraformProperty<string>? VerifyMode
    {
        get => GetProperty<TerraformProperty<string>>("verify_mode");
        set => WithProperty("verify_mode", value);
    }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("schedule_expression");
        set => WithProperty("schedule_expression", value);
    }

}

/// <summary>
/// Block type for task_report_config in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncTaskTaskReportConfigBlock : TerraformBlock
{
    /// <summary>
    /// The output_type attribute.
    /// </summary>
    public TerraformProperty<string>? OutputType
    {
        get => GetProperty<TerraformProperty<string>>("output_type");
        set => WithProperty("output_type", value);
    }

    /// <summary>
    /// The report_level attribute.
    /// </summary>
    public TerraformProperty<string>? ReportLevel
    {
        get => GetProperty<TerraformProperty<string>>("report_level");
        set => WithProperty("report_level", value);
    }

    /// <summary>
    /// The s3_object_versioning attribute.
    /// </summary>
    public TerraformProperty<string>? S3ObjectVersioning
    {
        get => GetProperty<TerraformProperty<string>>("s3_object_versioning");
        set => WithProperty("s3_object_versioning", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatasyncTaskTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_datasync_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncTask : TerraformResource
{
    public AwsDatasyncTask(string name) : base("aws_datasync_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLogGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_log_group_arn");
        set => this.WithProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationLocationArn is required")]
    public required TerraformProperty<string> DestinationLocationArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination_location_arn");
        set => this.WithProperty("destination_location_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceLocationArn is required")]
    public required TerraformProperty<string> SourceLocationArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_location_arn");
        set => this.WithProperty("source_location_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TaskMode
    {
        get => GetProperty<TerraformProperty<string>>("task_mode");
        set => this.WithProperty("task_mode", value);
    }

    /// <summary>
    /// Block for excludes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    public List<AwsDatasyncTaskExcludesBlock>? Excludes
    {
        get => GetProperty<List<AwsDatasyncTaskExcludesBlock>>("excludes");
        set => this.WithProperty("excludes", value);
    }

    /// <summary>
    /// Block for includes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    public List<AwsDatasyncTaskIncludesBlock>? Includes
    {
        get => GetProperty<List<AwsDatasyncTaskIncludesBlock>>("includes");
        set => this.WithProperty("includes", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsDatasyncTaskOptionsBlock>? Options
    {
        get => GetProperty<List<AwsDatasyncTaskOptionsBlock>>("options");
        set => this.WithProperty("options", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AwsDatasyncTaskScheduleBlock>? Schedule
    {
        get => GetProperty<List<AwsDatasyncTaskScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for task_report_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskReportConfig block(s) allowed")]
    public List<AwsDatasyncTaskTaskReportConfigBlock>? TaskReportConfig
    {
        get => GetProperty<List<AwsDatasyncTaskTaskReportConfigBlock>>("task_report_config");
        set => this.WithProperty("task_report_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatasyncTaskTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDatasyncTaskTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
