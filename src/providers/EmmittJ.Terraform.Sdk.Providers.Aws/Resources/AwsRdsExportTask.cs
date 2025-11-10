using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsExportTaskTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_rds_export_task resource.
/// </summary>
public class AwsRdsExportTask : TerraformResource
{
    public AwsRdsExportTask(string name) : base("aws_rds_export_task", name)
    {
    }

    /// <summary>
    /// The export_only attribute.
    /// </summary>
    [TerraformPropertyName("export_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExportOnly { get; set; }

    /// <summary>
    /// The export_task_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportTaskIdentifier is required")]
    [TerraformPropertyName("export_task_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExportTaskIdentifier { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformPropertyName("iam_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IamRoleArn { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformPropertyName("kms_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3BucketName { get; set; }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> S3Prefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_prefix");

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    [TerraformPropertyName("source_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsExportTaskTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The failure_cause attribute.
    /// </summary>
    [TerraformPropertyName("failure_cause")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureCause => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failure_cause");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The percent_progress attribute.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The snapshot_time attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnapshotTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "snapshot_time");

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [TerraformPropertyName("source_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_type");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The task_end_time attribute.
    /// </summary>
    [TerraformPropertyName("task_end_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TaskEndTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "task_end_time");

    /// <summary>
    /// The task_start_time attribute.
    /// </summary>
    [TerraformPropertyName("task_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TaskStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "task_start_time");

    /// <summary>
    /// The warning_message attribute.
    /// </summary>
    [TerraformPropertyName("warning_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WarningMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "warning_message");

}
