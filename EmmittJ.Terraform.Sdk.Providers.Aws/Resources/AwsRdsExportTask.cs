using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("failure_cause");
        this.DeclareOutput("id");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("snapshot_time");
        this.DeclareOutput("source_type");
        this.DeclareOutput("status");
        this.DeclareOutput("task_end_time");
        this.DeclareOutput("task_start_time");
        this.DeclareOutput("warning_message");
    }

    /// <summary>
    /// The export_only attribute.
    /// </summary>
    public List<string>? ExportOnly
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("export_only")?.Value;
        set => this.WithProperty("export_only", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The export_task_identifier attribute.
    /// </summary>
    public string? ExportTaskIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_task_identifier")?.Value;
        set => this.WithProperty("export_task_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public string? S3BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_name")?.Value;
        set => this.WithProperty("s3_bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public string? S3Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_prefix")?.Value;
        set => this.WithProperty("s3_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public string? SourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arn")?.Value;
        set => this.WithProperty("source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
