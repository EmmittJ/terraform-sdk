using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cur_report_definition Terraform resource.
/// Manages a aws_cur_report_definition resource.
/// </summary>
public partial class AwsCurReportDefinition(string name) : TerraformResource("aws_cur_report_definition", name)
{
    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    public TerraformSet<string>? AdditionalArtifacts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_artifacts").ResolveNodes(ctx));
        set => SetArgument("additional_artifacts", value);
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalSchemaElements is required")]
    public required TerraformSet<string> AdditionalSchemaElements
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_schema_elements").ResolveNodes(ctx));
        set => SetArgument("additional_schema_elements", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformValue<string> Compression
    {
        get => new TerraformReference<string>(this, "compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformValue<bool>? RefreshClosedReports
    {
        get => new TerraformReference<bool>(this, "refresh_closed_reports");
        set => SetArgument("refresh_closed_reports", value);
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
    /// The report_versioning attribute.
    /// </summary>
    public TerraformValue<string>? ReportVersioning
    {
        get => new TerraformReference<string>(this, "report_versioning");
        set => SetArgument("report_versioning", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => new TerraformReference<string>(this, "s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    public required TerraformValue<string> S3Prefix
    {
        get => new TerraformReference<string>(this, "s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    public required TerraformValue<string> S3Region
    {
        get => new TerraformReference<string>(this, "s3_region");
        set => SetArgument("s3_region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformValue<string> TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
        set => SetArgument("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
