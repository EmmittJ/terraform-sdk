using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for incremental_export_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTableExportIncrementalExportSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The export_from_time attribute.
    /// </summary>
    [TerraformProperty("export_from_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExportFromTime { get; set; }

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    [TerraformProperty("export_to_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExportToTime { get; set; }

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    [TerraformProperty("export_view_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExportViewType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDynamodbTableExportTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_dynamodb_table_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDynamodbTableExport : TerraformResource
{
    public AwsDynamodbTableExport(string name) : base("aws_dynamodb_table_export", name)
    {
    }

    /// <summary>
    /// The export_format attribute.
    /// </summary>
    [TerraformProperty("export_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportFormat { get; set; }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    [TerraformProperty("export_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExportTime { get; set; }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    [TerraformProperty("export_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExportType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformProperty("s3_bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3Bucket { get; set; }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("s3_bucket_owner")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> S3BucketOwner { get; set; }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> S3Prefix { get; set; }

    /// <summary>
    /// The s3_sse_algorithm attribute.
    /// </summary>
    [TerraformProperty("s3_sse_algorithm")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> S3SseAlgorithm { get; set; }

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("s3_sse_kms_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? S3SseKmsKeyId { get; set; }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    [TerraformProperty("table_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableArn { get; set; }

    /// <summary>
    /// Block for incremental_export_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalExportSpecification block(s) allowed")]
    [TerraformProperty("incremental_export_specification")]
    public TerraformList<TerraformBlock<AwsDynamodbTableExportIncrementalExportSpecificationBlock>>? IncrementalExportSpecification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDynamodbTableExportTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The billed_size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("billed_size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BilledSizeInBytes { get; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformProperty("end_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndTime { get; }

    /// <summary>
    /// The export_status attribute.
    /// </summary>
    [TerraformProperty("export_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExportStatus { get; }

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    [TerraformProperty("item_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ItemCount { get; }

    /// <summary>
    /// The manifest_files_s3_key attribute.
    /// </summary>
    [TerraformProperty("manifest_files_s3_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ManifestFilesS3Key { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StartTime { get; }

}
