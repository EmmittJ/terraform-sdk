using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cur_report_definition.
/// </summary>
public class AwsCurReportDefinitionDataSource : TerraformDataSource
{
    public AwsCurReportDefinitionDataSource(string name) : base("aws_cur_report_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    [TerraformPropertyName("report_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReportName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    [TerraformPropertyName("additional_artifacts")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AdditionalArtifacts => new TerraformReference(this, "additional_artifacts");

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [TerraformPropertyName("additional_schema_elements")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AdditionalSchemaElements => new TerraformReference(this, "additional_schema_elements");

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [TerraformPropertyName("compression")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Compression => new TerraformReference(this, "compression");

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformPropertyName("format")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Format => new TerraformReference(this, "format");

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    [TerraformPropertyName("refresh_closed_reports")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RefreshClosedReports => new TerraformReference(this, "refresh_closed_reports");

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    [TerraformPropertyName("report_versioning")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReportVersioning => new TerraformReference(this, "report_versioning");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3Bucket => new TerraformReference(this, "s3_bucket");

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3Prefix => new TerraformReference(this, "s3_prefix");

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [TerraformPropertyName("s3_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> S3Region => new TerraformReference(this, "s3_region");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [TerraformPropertyName("time_unit")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeUnit => new TerraformReference(this, "time_unit");

}
