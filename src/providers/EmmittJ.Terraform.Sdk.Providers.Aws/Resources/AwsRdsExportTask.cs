using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsExportTask.
/// Nesting mode: single
/// </summary>
public class AwsRdsExportTaskTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_rds_export_task Terraform resource.
/// Manages a aws_rds_export_task resource.
/// </summary>
public partial class AwsRdsExportTask(string name) : TerraformResource("aws_rds_export_task", name)
{
    /// <summary>
    /// The export_only attribute.
    /// </summary>
    public TerraformList<string>? ExportOnly
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "export_only").ResolveNodes(ctx));
        set => SetArgument("export_only", value);
    }

    /// <summary>
    /// The export_task_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportTaskIdentifier is required")]
    public required TerraformValue<string> ExportTaskIdentifier
    {
        get => new TerraformReference<string>(this, "export_task_identifier");
        set => SetArgument("export_task_identifier", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
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
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => new TerraformReference<string>(this, "s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3Prefix
    {
        get => new TerraformReference<string>(this, "s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    public required TerraformValue<string> SourceArn
    {
        get => new TerraformReference<string>(this, "source_arn");
        set => SetArgument("source_arn", value);
    }

    /// <summary>
    /// The failure_cause attribute.
    /// </summary>
    public TerraformValue<string> FailureCause
    {
        get => new TerraformReference<string>(this, "failure_cause");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The percent_progress attribute.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// The snapshot_time attribute.
    /// </summary>
    public TerraformValue<string> SnapshotTime
    {
        get => new TerraformReference<string>(this, "snapshot_time");
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformValue<string> SourceType
    {
        get => new TerraformReference<string>(this, "source_type");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The task_end_time attribute.
    /// </summary>
    public TerraformValue<string> TaskEndTime
    {
        get => new TerraformReference<string>(this, "task_end_time");
    }

    /// <summary>
    /// The task_start_time attribute.
    /// </summary>
    public TerraformValue<string> TaskStartTime
    {
        get => new TerraformReference<string>(this, "task_start_time");
    }

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    public TerraformValue<string> WarningMessage
    {
        get => new TerraformReference<string>(this, "warning_message");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsExportTaskTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsExportTaskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
