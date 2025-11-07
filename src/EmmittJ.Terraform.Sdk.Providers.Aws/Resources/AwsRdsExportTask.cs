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
    public TerraformLiteralProperty<List<string>>? ExportOnly
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("export_only");
        set => this.WithProperty("export_only", value);
    }

    /// <summary>
    /// The export_task_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExportTaskIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_task_identifier");
        set => this.WithProperty("export_task_identifier", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_name");
        set => this.WithProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_prefix");
        set => this.WithProperty("s3_prefix", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arn");
        set => this.WithProperty("source_arn", value);
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
