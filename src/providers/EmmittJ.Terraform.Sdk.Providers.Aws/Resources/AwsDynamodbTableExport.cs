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
    public TerraformValue<string> ExportFromTime
    {
        get => new TerraformReference<string>(this, "export_from_time");
        set => SetArgument("export_from_time", value);
    }

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    public TerraformValue<string> ExportToTime
    {
        get => new TerraformReference<string>(this, "export_to_time");
        set => SetArgument("export_to_time", value);
    }

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    public TerraformValue<string> ExportViewType
    {
        get => new TerraformReference<string>(this, "export_view_type");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<string>(this, "export_format");
        set => SetArgument("export_format", value);
    }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    public TerraformValue<string> ExportTime
    {
        get => new TerraformReference<string>(this, "export_time");
        set => SetArgument("export_time", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public TerraformValue<string> ExportType
    {
        get => new TerraformReference<string>(this, "export_type");
        set => SetArgument("export_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => new TerraformReference<string>(this, "s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string> S3BucketOwner
    {
        get => new TerraformReference<string>(this, "s3_bucket_owner");
        set => SetArgument("s3_bucket_owner", value);
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
    /// The s3_sse_algorithm attribute.
    /// </summary>
    public TerraformValue<string> S3SseAlgorithm
    {
        get => new TerraformReference<string>(this, "s3_sse_algorithm");
        set => SetArgument("s3_sse_algorithm", value);
    }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? S3SseKmsKeyId
    {
        get => new TerraformReference<string>(this, "s3_sse_kms_key_id");
        set => SetArgument("s3_sse_kms_key_id", value);
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    public required TerraformValue<string> TableArn
    {
        get => new TerraformReference<string>(this, "table_arn");
        set => SetArgument("table_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The billed_size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> BilledSizeInBytes
    {
        get => new TerraformReference<double>(this, "billed_size_in_bytes");
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string> EndTime
    {
        get => new TerraformReference<string>(this, "end_time");
    }

    /// <summary>
    /// The export_status attribute.
    /// </summary>
    public TerraformValue<string> ExportStatus
    {
        get => new TerraformReference<string>(this, "export_status");
    }

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    public TerraformValue<double> ItemCount
    {
        get => new TerraformReference<double>(this, "item_count");
    }

    /// <summary>
    /// The manifest_files_s3_key attribute.
    /// </summary>
    public TerraformValue<string> ManifestFilesS3Key
    {
        get => new TerraformReference<string>(this, "manifest_files_s3_key");
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

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
