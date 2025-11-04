using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_table_export resource.
/// </summary>
public class AwsDynamodbTableExport : TerraformResource
{
    public AwsDynamodbTableExport(string name) : base("aws_dynamodb_table_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("billed_size_in_bytes");
        this.DeclareOutput("end_time");
        this.DeclareOutput("export_status");
        this.DeclareOutput("item_count");
        this.DeclareOutput("manifest_files_s3_key");
        this.DeclareOutput("start_time");
    }

    /// <summary>
    /// The export_format attribute.
    /// </summary>
    public string? ExportFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_format")?.Value;
        set => this.WithProperty("export_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    public string? ExportTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_time")?.Value;
        set => this.WithProperty("export_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public string? ExportType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_type")?.Value;
        set => this.WithProperty("export_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public string? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket")?.Value;
        set => this.WithProperty("s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    public string? S3BucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_owner")?.Value;
        set => this.WithProperty("s3_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The s3_sse_algorithm attribute.
    /// </summary>
    public string? S3SseAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_sse_algorithm")?.Value;
        set => this.WithProperty("s3_sse_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    public string? S3SseKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_sse_kms_key_id")?.Value;
        set => this.WithProperty("s3_sse_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public string? TableArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_arn")?.Value;
        set => this.WithProperty("table_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The billed_size_in_bytes attribute.
    /// </summary>
    public TerraformExpression BilledSizeInBytes => this["billed_size_in_bytes"];

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformExpression EndTime => this["end_time"];

    /// <summary>
    /// The export_status attribute.
    /// </summary>
    public TerraformExpression ExportStatus => this["export_status"];

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    public TerraformExpression ItemCount => this["item_count"];

    /// <summary>
    /// The manifest_files_s3_key attribute.
    /// </summary>
    public TerraformExpression ManifestFilesS3Key => this["manifest_files_s3_key"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

}
