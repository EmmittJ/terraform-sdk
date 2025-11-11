using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cur_report_definition resource.
/// </summary>
public partial class AwsCurReportDefinition : TerraformResource
{
    public AwsCurReportDefinition(string name) : base("aws_cur_report_definition", name)
    {
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    [TerraformProperty("additional_artifacts")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AdditionalArtifacts { get; set; }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalSchemaElements is required")]
    [TerraformProperty("additional_schema_elements")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AdditionalSchemaElements { get; set; }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    [TerraformProperty("compression")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Compression { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    [TerraformProperty("refresh_closed_reports")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RefreshClosedReports { get; set; }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    [TerraformProperty("report_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReportName { get; set; }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    [TerraformProperty("report_versioning")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReportVersioning { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformProperty("s3_bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3Bucket { get; set; }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    [TerraformProperty("s3_prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3Prefix { get; set; }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    [TerraformProperty("s3_region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    [TerraformProperty("time_unit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TimeUnit { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
