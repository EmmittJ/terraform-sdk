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
        set => SetProperty("export_from_time", value);
    }

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExportToTime
    {
        set => SetProperty("export_to_time", value);
    }

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    public TerraformProperty<string>? ExportViewType
    {
        set => SetProperty("export_view_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("arn");
        SetOutput("billed_size_in_bytes");
        SetOutput("end_time");
        SetOutput("export_status");
        SetOutput("item_count");
        SetOutput("manifest_files_s3_key");
        SetOutput("start_time");
        SetOutput("export_format");
        SetOutput("export_time");
        SetOutput("export_type");
        SetOutput("id");
        SetOutput("region");
        SetOutput("s3_bucket");
        SetOutput("s3_bucket_owner");
        SetOutput("s3_prefix");
        SetOutput("s3_sse_algorithm");
        SetOutput("s3_sse_kms_key_id");
        SetOutput("table_arn");
    }

    /// <summary>
    /// The export_format attribute.
    /// </summary>
    public TerraformProperty<string> ExportFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_format");
        set => SetProperty("export_format", value);
    }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    public TerraformProperty<string> ExportTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_time");
        set => SetProperty("export_time", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public TerraformProperty<string> ExportType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_type");
        set => SetProperty("export_type", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformProperty<string> S3Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket");
        set => SetProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string> S3BucketOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket_owner");
        set => SetProperty("s3_bucket_owner", value);
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
    /// The s3_sse_algorithm attribute.
    /// </summary>
    public TerraformProperty<string> S3SseAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_sse_algorithm");
        set => SetProperty("s3_sse_algorithm", value);
    }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> S3SseKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_sse_kms_key_id");
        set => SetProperty("s3_sse_kms_key_id", value);
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    public required TerraformProperty<string> TableArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_arn");
        set => SetProperty("table_arn", value);
    }

    /// <summary>
    /// Block for incremental_export_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalExportSpecification block(s) allowed")]
    public List<AwsDynamodbTableExportIncrementalExportSpecificationBlock>? IncrementalExportSpecification
    {
        set => SetProperty("incremental_export_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDynamodbTableExportTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
