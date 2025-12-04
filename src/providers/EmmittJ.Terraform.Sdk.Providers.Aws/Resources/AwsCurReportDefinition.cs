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
        get => GetArgument<TerraformSet<string>>("additional_artifacts");
        set => SetArgument("additional_artifacts", value);
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalSchemaElements is required")]
    public required TerraformSet<string> AdditionalSchemaElements
    {
        get => GetRequiredArgument<TerraformSet<string>>("additional_schema_elements");
        set => SetArgument("additional_schema_elements", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformValue<string> Compression
    {
        get => GetRequiredArgument<TerraformValue<string>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformValue<bool>? RefreshClosedReports
    {
        get => GetArgument<TerraformValue<bool>>("refresh_closed_reports");
        set => SetArgument("refresh_closed_reports", value);
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
    /// The report_versioning attribute.
    /// </summary>
    public TerraformValue<string>? ReportVersioning
    {
        get => GetArgument<TerraformValue<string>>("report_versioning");
        set => SetArgument("report_versioning", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    public required TerraformValue<string> S3Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    public required TerraformValue<string> S3Region
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_region");
        set => SetArgument("s3_region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformValue<string> TimeUnit
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_unit");
        set => SetArgument("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
