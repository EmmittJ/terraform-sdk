using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for incremental_export_specification in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableExportIncrementalExportSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The export_from_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExportFromTime
    {
        get => GetProperty<TerraformProperty<string>>("export_from_time");
        set => WithProperty("export_from_time", value);
    }

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToTime
    {
        get => GetProperty<TerraformProperty<string>>("export_to_time");
        set => WithProperty("export_to_time", value);
    }

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    public TerraformProperty<string>? ExportViewType
    {
        get => GetProperty<TerraformProperty<string>>("export_view_type");
        set => WithProperty("export_view_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_dynamodb_table_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<string>? ExportFormat
    {
        get => GetProperty<TerraformProperty<string>>("export_format");
        set => this.WithProperty("export_format", value);
    }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExportTime
    {
        get => GetProperty<TerraformProperty<string>>("export_time");
        set => this.WithProperty("export_time", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public TerraformProperty<string>? ExportType
    {
        get => GetProperty<TerraformProperty<string>>("export_type");
        set => this.WithProperty("export_type", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformProperty<string> S3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? S3BucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket_owner");
        set => this.WithProperty("s3_bucket_owner", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? S3Prefix
    {
        get => GetProperty<TerraformProperty<string>>("s3_prefix");
        set => this.WithProperty("s3_prefix", value);
    }

    /// <summary>
    /// The s3_sse_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? S3SseAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("s3_sse_algorithm");
        set => this.WithProperty("s3_sse_algorithm", value);
    }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? S3SseKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("s3_sse_kms_key_id");
        set => this.WithProperty("s3_sse_kms_key_id", value);
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    public required TerraformProperty<string> TableArn
    {
        get => GetProperty<TerraformProperty<string>>("table_arn");
        set => this.WithProperty("table_arn", value);
    }

    /// <summary>
    /// Block for incremental_export_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalExportSpecification block(s) allowed")]
    public List<AwsDynamodbTableExportIncrementalExportSpecificationBlock>? IncrementalExportSpecification
    {
        get => GetProperty<List<AwsDynamodbTableExportIncrementalExportSpecificationBlock>>("incremental_export_specification");
        set => this.WithProperty("incremental_export_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDynamodbTableExportTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDynamodbTableExportTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
