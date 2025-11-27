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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    public required TerraformValue<string> ReportName
    {
        get => new TerraformReference<string>(this, "report_name");
        set => SetArgument("report_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    public TerraformSet<string> AdditionalArtifacts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_artifacts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public TerraformSet<string> AdditionalSchemaElements
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_schema_elements").ResolveNodes(ctx));
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformValue<string> Compression
    {
        get => new TerraformReference<string>(this, "compression");
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformValue<bool> RefreshClosedReports
    {
        get => new TerraformReference<bool>(this, "refresh_closed_reports");
    }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformValue<string> ReportVersioning
    {
        get => new TerraformReference<string>(this, "report_versioning");
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string> S3Bucket
    {
        get => new TerraformReference<string>(this, "s3_bucket");
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string> S3Prefix
    {
        get => new TerraformReference<string>(this, "s3_prefix");
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformValue<string> S3Region
    {
        get => new TerraformReference<string>(this, "s3_region");
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformValue<string> TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
    }

}
