using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for incremental_export_specification in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableExportIncrementalExportSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The export_from_time attribute.
    /// </summary>
    [TerraformPropertyName("export_from_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExportFromTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "export_from_time");

    /// <summary>
    /// The export_to_time attribute.
    /// </summary>
    [TerraformPropertyName("export_to_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExportToTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "export_to_time");

    /// <summary>
    /// The export_view_type attribute.
    /// </summary>
    [TerraformPropertyName("export_view_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExportViewType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "export_view_type");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableExportTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? ExportFormat { get; set; }

    /// <summary>
    /// The export_time attribute.
    /// </summary>
    [TerraformPropertyName("export_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExportTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "export_time");

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    [TerraformPropertyName("export_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExportType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "export_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformPropertyName("s3_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Bucket { get; set; }

    /// <summary>
    /// The s3_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket_owner")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> S3BucketOwner { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_bucket_owner");

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> S3Prefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_prefix");

    /// <summary>
    /// The s3_sse_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("s3_sse_algorithm")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> S3SseAlgorithm { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_sse_algorithm");

    /// <summary>
    /// The s3_sse_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("s3_sse_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3SseKmsKeyId { get; set; }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableArn is required")]
    [TerraformPropertyName("table_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableArn { get; set; }

    /// <summary>
    /// Block for incremental_export_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalExportSpecification block(s) allowed")]
    [TerraformPropertyName("incremental_export_specification")]
    public TerraformList<TerraformBlock<AwsDynamodbTableExportIncrementalExportSpecificationBlock>>? IncrementalExportSpecification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDynamodbTableExportTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The billed_size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("billed_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BilledSizeInBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "billed_size_in_bytes");

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_time");

    /// <summary>
    /// The export_status attribute.
    /// </summary>
    [TerraformPropertyName("export_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExportStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "export_status");

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    [TerraformPropertyName("item_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ItemCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "item_count");

    /// <summary>
    /// The manifest_files_s3_key attribute.
    /// </summary>
    [TerraformPropertyName("manifest_files_s3_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManifestFilesS3Key => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "manifest_files_s3_key");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

}
