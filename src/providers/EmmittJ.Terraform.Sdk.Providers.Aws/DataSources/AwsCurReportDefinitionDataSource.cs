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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    [TerraformPropertyName("report_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReportName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    [TerraformPropertyName("additional_artifacts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AdditionalArtifacts => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "additional_artifacts");

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [TerraformPropertyName("additional_schema_elements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AdditionalSchemaElements => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "additional_schema_elements");

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [TerraformPropertyName("compression")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Compression => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compression");

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformPropertyName("format")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Format => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "format");

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    [TerraformPropertyName("refresh_closed_reports")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RefreshClosedReports => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "refresh_closed_reports");

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    [TerraformPropertyName("report_versioning")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReportVersioning => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "report_versioning");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> S3Bucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_bucket");

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> S3Prefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_prefix");

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [TerraformPropertyName("s3_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> S3Region => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "s3_region");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [TerraformPropertyName("time_unit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeUnit => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_unit");

}
