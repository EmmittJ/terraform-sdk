using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for incremental_export_specification in AwsDynamodbTableExport.
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableExportIncrementalExportSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "incremental_export_specification";

    /// <summary>
    /// The export_from_time attribute.
    /// </summary>
    public TerraformValue<string>? ExportFromTime
    {
        get => GetArgument<TerraformValue<string>>("export_from_time");
        set => SetArgument("export_from_time", value);
    }

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    public TerraformValue<string>? ExportToTime
    {
        get => GetArgument<TerraformValue<string>>("export_to_time");
        set => SetArgument("export_to_time", value);
    }

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    public TerraformValue<string>? ExportViewType
    {
        get => GetArgument<TerraformValue<string>>("export_view_type");
        set => SetArgument("export_view_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDynamodbTableExport.
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_dynamodb_table_export Terraform resource.
/// Manages a aws_dynamodb_table_export resource.
/// </summary>
public partial class AwsDynamodbTableExport(string name) : TerraformResource("aws_dynamodb_table_export", name)
{
    /// <summary>
    /// The export_format attribute.
    /// </summary>
    public TerraformValue<string>? ExportFormat
    {
        get => GetArgument<TerraformValue<string>>("export_format");
        set => SetArgument("export_format", value);
    }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    public TerraformValue<string>? ExportTime
    {
        get => GetArgument<TerraformValue<string>>("export_time");
        set => SetArgument("export_time", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public TerraformValue<string>? ExportType
    {
        get => GetArgument<TerraformValue<string>>("export_type");
        set => SetArgument("export_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? S3BucketOwner
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket_owner");
        set => SetArgument("s3_bucket_owner", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3Prefix
    {
        get => GetArgument<TerraformValue<string>>("s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

    /// <summary>
    /// The s3_sse_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? S3SseAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("s3_sse_algorithm");
        set => SetArgument("s3_sse_algorithm", value);
    }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? S3SseKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("s3_sse_kms_key_id");
        set => SetArgument("s3_sse_kms_key_id", value);
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    public required TerraformValue<string> TableArn
    {
        get => GetArgument<TerraformValue<string>>("table_arn");
        set => SetArgument("table_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The billed_size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> BilledSizeInBytes
        => AsReference("billed_size_in_bytes");

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string> EndTime
        => AsReference("end_time");

    /// <summary>
    /// The export_status attribute.
    /// </summary>
    public TerraformValue<string> ExportStatus
        => AsReference("export_status");

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    public TerraformValue<double> ItemCount
        => AsReference("item_count");

    /// <summary>
    /// The manifest_files_s3_key attribute.
    /// </summary>
    public TerraformValue<string> ManifestFilesS3Key
        => AsReference("manifest_files_s3_key");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
        => AsReference("start_time");

    /// <summary>
    /// IncrementalExportSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalExportSpecification block(s) allowed")]
    public TerraformList<AwsDynamodbTableExportIncrementalExportSpecificationBlock>? IncrementalExportSpecification
    {
        get => GetArgument<TerraformList<AwsDynamodbTableExportIncrementalExportSpecificationBlock>>("incremental_export_specification");
        set => SetArgument("incremental_export_specification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDynamodbTableExportTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDynamodbTableExportTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
