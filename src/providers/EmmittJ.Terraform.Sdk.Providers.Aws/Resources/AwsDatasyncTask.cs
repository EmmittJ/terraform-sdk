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
        set => SetProperty("filter_type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("filter_type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("atime", value);
    }

    /// <summary>
    /// The bytes_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? BytesPerSecond
    {
        set => SetProperty("bytes_per_second", value);
    }

    /// <summary>
    /// The gid attribute.
    /// </summary>
    public TerraformProperty<string>? Gid
    {
        set => SetProperty("gid", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformProperty<string>? LogLevel
    {
        set => SetProperty("log_level", value);
    }

    /// <summary>
    /// The mtime attribute.
    /// </summary>
    public TerraformProperty<string>? Mtime
    {
        set => SetProperty("mtime", value);
    }

    /// <summary>
    /// The object_tags attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectTags
    {
        set => SetProperty("object_tags", value);
    }

    /// <summary>
    /// The overwrite_mode attribute.
    /// </summary>
    public TerraformProperty<string>? OverwriteMode
    {
        set => SetProperty("overwrite_mode", value);
    }

    /// <summary>
    /// The posix_permissions attribute.
    /// </summary>
    public TerraformProperty<string>? PosixPermissions
    {
        set => SetProperty("posix_permissions", value);
    }

    /// <summary>
    /// The preserve_deleted_files attribute.
    /// </summary>
    public TerraformProperty<string>? PreserveDeletedFiles
    {
        set => SetProperty("preserve_deleted_files", value);
    }

    /// <summary>
    /// The preserve_devices attribute.
    /// </summary>
    public TerraformProperty<string>? PreserveDevices
    {
        set => SetProperty("preserve_devices", value);
    }

    /// <summary>
    /// The security_descriptor_copy_flags attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityDescriptorCopyFlags
    {
        set => SetProperty("security_descriptor_copy_flags", value);
    }

    /// <summary>
    /// The task_queueing attribute.
    /// </summary>
    public TerraformProperty<string>? TaskQueueing
    {
        set => SetProperty("task_queueing", value);
    }

    /// <summary>
    /// The transfer_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TransferMode
    {
        set => SetProperty("transfer_mode", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    public TerraformProperty<string>? Uid
    {
        set => SetProperty("uid", value);
    }

    /// <summary>
    /// The verify_mode attribute.
    /// </summary>
    public TerraformProperty<string>? VerifyMode
    {
        set => SetProperty("verify_mode", value);
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
        set => SetProperty("schedule_expression", value);
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
        set => SetProperty("output_type", value);
    }

    /// <summary>
    /// The report_level attribute.
    /// </summary>
    public TerraformProperty<string>? ReportLevel
    {
        set => SetProperty("report_level", value);
    }

    /// <summary>
    /// The s3_object_versioning attribute.
    /// </summary>
    public TerraformProperty<string>? S3ObjectVersioning
    {
        set => SetProperty("s3_object_versioning", value);
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
        set => SetProperty("create", value);
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
        SetOutput("arn");
        SetOutput("cloudwatch_log_group_arn");
        SetOutput("destination_location_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("source_location_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("task_mode");
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformProperty<string> CloudwatchLogGroupArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloudwatch_log_group_arn");
        set => SetProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The destination_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationLocationArn is required")]
    public required TerraformProperty<string> DestinationLocationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_location_arn");
        set => SetProperty("destination_location_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceLocationArn is required")]
    public required TerraformProperty<string> SourceLocationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_location_arn");
        set => SetProperty("source_location_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The task_mode attribute.
    /// </summary>
    public TerraformProperty<string> TaskMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_mode");
        set => SetProperty("task_mode", value);
    }

    /// <summary>
    /// Block for excludes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Excludes block(s) allowed")]
    public List<AwsDatasyncTaskExcludesBlock>? Excludes
    {
        set => SetProperty("excludes", value);
    }

    /// <summary>
    /// Block for includes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Includes block(s) allowed")]
    public List<AwsDatasyncTaskIncludesBlock>? Includes
    {
        set => SetProperty("includes", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsDatasyncTaskOptionsBlock>? Options
    {
        set => SetProperty("options", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AwsDatasyncTaskScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for task_report_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskReportConfig block(s) allowed")]
    public List<AwsDatasyncTaskTaskReportConfigBlock>? TaskReportConfig
    {
        set => SetProperty("task_report_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatasyncTaskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
