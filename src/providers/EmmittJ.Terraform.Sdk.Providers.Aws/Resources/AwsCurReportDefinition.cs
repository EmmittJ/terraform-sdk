using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cur_report_definition resource.
/// </summary>
public class AwsCurReportDefinition : TerraformResource
{
    public AwsCurReportDefinition(string name) : base("aws_cur_report_definition", name)
    {
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    [TerraformPropertyName("additional_artifacts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AdditionalArtifacts { get; set; }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalSchemaElements is required")]
    [TerraformPropertyName("additional_schema_elements")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AdditionalSchemaElements { get; set; }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    [TerraformPropertyName("compression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Compression { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    [TerraformPropertyName("refresh_closed_reports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RefreshClosedReports { get; set; }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    [TerraformPropertyName("report_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReportName { get; set; }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    [TerraformPropertyName("report_versioning")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReportVersioning { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformPropertyName("s3_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> S3Bucket { get; set; }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    [TerraformPropertyName("s3_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> S3Prefix { get; set; }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    [TerraformPropertyName("s3_region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> S3Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    [TerraformPropertyName("time_unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeUnit { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
