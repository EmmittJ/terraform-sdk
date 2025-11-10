using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cur_report_definition resource.
/// </summary>
public class AwsCurReportDefinition : TerraformResource
{
    public AwsCurReportDefinition(string name) : base("aws_cur_report_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("additional_artifacts");
        SetOutput("additional_schema_elements");
        SetOutput("compression");
        SetOutput("format");
        SetOutput("id");
        SetOutput("refresh_closed_reports");
        SetOutput("report_name");
        SetOutput("report_versioning");
        SetOutput("s3_bucket");
        SetOutput("s3_prefix");
        SetOutput("s3_region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("time_unit");
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AdditionalArtifacts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("additional_artifacts");
        set => SetProperty("additional_artifacts", value);
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalSchemaElements is required")]
    public HashSet<TerraformProperty<string>> AdditionalSchemaElements
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("additional_schema_elements");
        set => SetProperty("additional_schema_elements", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformProperty<string> Compression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compression");
        set => SetProperty("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetRequiredOutput<TerraformProperty<string>>("format");
        set => SetProperty("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformProperty<bool> RefreshClosedReports
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("refresh_closed_reports");
        set => SetProperty("refresh_closed_reports", value);
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    public required TerraformProperty<string> ReportName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("report_name");
        set => SetProperty("report_name", value);
    }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformProperty<string> ReportVersioning
    {
        get => GetRequiredOutput<TerraformProperty<string>>("report_versioning");
        set => SetProperty("report_versioning", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformProperty<string> S3Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket");
        set => SetProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    public required TerraformProperty<string> S3Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_prefix");
        set => SetProperty("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    public required TerraformProperty<string> S3Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_region");
        set => SetProperty("s3_region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformProperty<string> TimeUnit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_unit");
        set => SetProperty("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
