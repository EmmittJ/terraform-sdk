using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cur_report_definition.
/// </summary>
public partial class AwsCurReportDefinitionDataSource : TerraformDataSource
{
    public AwsCurReportDefinitionDataSource(string name) : base("aws_cur_report_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    [TerraformProperty("report_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReportName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    [TerraformProperty("additional_artifacts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AdditionalArtifacts { get; }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [TerraformProperty("additional_schema_elements")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AdditionalSchemaElements { get; }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [TerraformProperty("compression")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Compression { get; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformProperty("format")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Format { get; }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    [TerraformProperty("refresh_closed_reports")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RefreshClosedReports { get; }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    [TerraformProperty("report_versioning")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReportVersioning { get; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformProperty("s3_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3Bucket { get; }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3Prefix { get; }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [TerraformProperty("s3_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> S3Region { get; }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [TerraformProperty("time_unit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeUnit { get; }

}
