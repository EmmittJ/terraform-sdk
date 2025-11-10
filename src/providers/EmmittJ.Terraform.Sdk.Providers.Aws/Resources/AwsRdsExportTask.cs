using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsExportTaskTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_rds_export_task resource.
/// </summary>
public class AwsRdsExportTask : TerraformResource
{
    public AwsRdsExportTask(string name) : base("aws_rds_export_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("failure_cause");
        SetOutput("id");
        SetOutput("percent_progress");
        SetOutput("snapshot_time");
        SetOutput("source_type");
        SetOutput("status");
        SetOutput("task_end_time");
        SetOutput("task_start_time");
        SetOutput("warning_message");
        SetOutput("export_only");
        SetOutput("export_task_identifier");
        SetOutput("iam_role_arn");
        SetOutput("kms_key_id");
        SetOutput("region");
        SetOutput("s3_bucket_name");
        SetOutput("s3_prefix");
        SetOutput("source_arn");
    }

    /// <summary>
    /// The export_only attribute.
    /// </summary>
    public List<TerraformProperty<string>> ExportOnly
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("export_only");
        set => SetProperty("export_only", value);
    }

    /// <summary>
    /// The export_task_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportTaskIdentifier is required")]
    public required TerraformProperty<string> ExportTaskIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_task_identifier");
        set => SetProperty("export_task_identifier", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
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
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket_name");
        set => SetProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string> S3Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_prefix");
        set => SetProperty("s3_prefix", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    public required TerraformProperty<string> SourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_arn");
        set => SetProperty("source_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsExportTaskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The failure_cause attribute.
    /// </summary>
    public TerraformExpression FailureCause => this["failure_cause"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The percent_progress attribute.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The snapshot_time attribute.
    /// </summary>
    public TerraformExpression SnapshotTime => this["snapshot_time"];

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformExpression SourceType => this["source_type"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The task_end_time attribute.
    /// </summary>
    public TerraformExpression TaskEndTime => this["task_end_time"];

    /// <summary>
    /// The task_start_time attribute.
    /// </summary>
    public TerraformExpression TaskStartTime => this["task_start_time"];

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    public TerraformExpression WarningMessage => this["warning_message"];

}
