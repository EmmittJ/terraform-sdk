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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The additional_artifacts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AdditionalArtifacts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("additional_artifacts");
        set => this.WithProperty("additional_artifacts", value);
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalSchemaElements is required")]
    public HashSet<TerraformProperty<string>>? AdditionalSchemaElements
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("additional_schema_elements");
        set => this.WithProperty("additional_schema_elements", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformProperty<string> Compression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("compression");
        set => this.WithProperty("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetRequiredProperty<TerraformProperty<string>>("format");
        set => this.WithProperty("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformProperty<bool>? RefreshClosedReports
    {
        get => GetProperty<TerraformProperty<bool>>("refresh_closed_reports");
        set => this.WithProperty("refresh_closed_reports", value);
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    public required TerraformProperty<string> ReportName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("report_name");
        set => this.WithProperty("report_name", value);
    }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformProperty<string>? ReportVersioning
    {
        get => GetProperty<TerraformProperty<string>>("report_versioning");
        set => this.WithProperty("report_versioning", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformProperty<string> S3Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    public required TerraformProperty<string> S3Prefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_prefix");
        set => this.WithProperty("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    public required TerraformProperty<string> S3Region
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_region");
        set => this.WithProperty("s3_region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeUnit is required")]
    public required TerraformProperty<string> TimeUnit
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time_unit");
        set => this.WithProperty("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
