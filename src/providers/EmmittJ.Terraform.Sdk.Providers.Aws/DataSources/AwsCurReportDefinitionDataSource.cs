using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cur_report_definition Terraform data source.
/// Retrieves information about a aws_cur_report_definition.
/// </summary>
public partial class AwsCurReportDefinitionDataSource(string name) : TerraformDataSource("aws_cur_report_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    public required TerraformValue<string> ReportName
    {
        get => GetRequiredArgument<TerraformValue<string>>("report_name");
        set => SetArgument("report_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    public TerraformSet<string> AdditionalArtifacts
        => CreateReference("additional_artifacts");

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public TerraformSet<string> AdditionalSchemaElements
        => CreateReference("additional_schema_elements");

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformValue<string> Compression
        => CreateReference("compression");

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string> Format
        => CreateReference("format");

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformValue<bool> RefreshClosedReports
        => CreateReference("refresh_closed_reports");

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformValue<string> ReportVersioning
        => CreateReference("report_versioning");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string> S3Bucket
        => CreateReference("s3_bucket");

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3Prefix
        => CreateReference("s3_prefix");

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformValue<string> S3Region
        => CreateReference("s3_region");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformValue<string> TimeUnit
        => CreateReference("time_unit");

}
