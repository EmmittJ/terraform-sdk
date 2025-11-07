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
    public TerraformLiteralProperty<string>? ExportFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_format");
        set => this.WithProperty("export_format", value);
    }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExportTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_time");
        set => this.WithProperty("export_time", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExportType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_type");
        set => this.WithProperty("export_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3BucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_owner");
        set => this.WithProperty("s3_bucket_owner", value);
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
    /// The s3_sse_algorithm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3SseAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_sse_algorithm");
        set => this.WithProperty("s3_sse_algorithm", value);
    }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3SseKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_sse_kms_key_id");
        set => this.WithProperty("s3_sse_kms_key_id", value);
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_arn");
        set => this.WithProperty("table_arn", value);
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
