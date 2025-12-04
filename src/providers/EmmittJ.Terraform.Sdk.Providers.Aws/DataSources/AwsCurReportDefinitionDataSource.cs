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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    public required TerraformValue<string> ReportName
    {
        get => GetArgument<TerraformValue<string>>("report_name");
        set => SetArgument("report_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    public TerraformSet<string> AdditionalArtifacts
        => AsReference("additional_artifacts");

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public TerraformSet<string> AdditionalSchemaElements
        => AsReference("additional_schema_elements");

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformValue<string> Compression
        => AsReference("compression");

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string> Format
        => AsReference("format");

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformValue<bool> RefreshClosedReports
        => AsReference("refresh_closed_reports");

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformValue<string> ReportVersioning
        => AsReference("report_versioning");

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string> S3Bucket
        => AsReference("s3_bucket");

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3Prefix
        => AsReference("s3_prefix");

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformValue<string> S3Region
        => AsReference("s3_region");

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformValue<string> TimeUnit
        => AsReference("time_unit");

}
