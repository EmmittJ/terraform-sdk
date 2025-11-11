using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for incremental_export_specification in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableExportIncrementalExportSpecificationBlock
{
    /// <summary>
    /// The export_from_time attribute.
    /// </summary>
    [TerraformPropertyName("export_from_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExportFromTime { get; set; } = default!;

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    [TerraformPropertyName("export_to_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExportToTime { get; set; } = default!;

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    [TerraformPropertyName("export_view_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExportViewType { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableExportTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_dynamodb_table_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDynamodbTableExport : TerraformResource
{
    public AwsDynamodbTableExport(string name) : base("aws_dynamodb_table_export", name)
    {
    }

    /// <summary>
    /// The export_format attribute.
    /// </summary>
    [TerraformPropertyName("export_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportFormat { get; set; }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    [TerraformPropertyName("export_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExportTime { get; set; } = default!;

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    [TerraformPropertyName("export_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExportType { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformPropertyName("s3_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> S3Bucket { get; set; }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket_owner")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> S3BucketOwner { get; set; } = default!;

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> S3Prefix { get; set; } = default!;

    /// <summary>
    /// The s3_sse_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("s3_sse_algorithm")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> S3SseAlgorithm { get; set; } = default!;

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("s3_sse_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3SseKmsKeyId { get; set; }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    [TerraformPropertyName("table_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableArn { get; set; }

    /// <summary>
    /// Block for incremental_export_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalExportSpecification block(s) allowed")]
    [TerraformPropertyName("incremental_export_specification")]
    public TerraformList<TerraformBlock<AwsDynamodbTableExportIncrementalExportSpecificationBlock>>? IncrementalExportSpecification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDynamodbTableExportTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The billed_size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("billed_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BilledSizeInBytes => new TerraformReference(this, "billed_size_in_bytes");

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndTime => new TerraformReference(this, "end_time");

    /// <summary>
    /// The export_status attribute.
    /// </summary>
    [TerraformPropertyName("export_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExportStatus => new TerraformReference(this, "export_status");

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    [TerraformPropertyName("item_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ItemCount => new TerraformReference(this, "item_count");

    /// <summary>
    /// The manifest_files_s3_key attribute.
    /// </summary>
    [TerraformPropertyName("manifest_files_s3_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManifestFilesS3Key => new TerraformReference(this, "manifest_files_s3_key");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartTime => new TerraformReference(this, "start_time");

}
