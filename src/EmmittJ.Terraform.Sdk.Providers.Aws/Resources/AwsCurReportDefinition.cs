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
    public TerraformProperty<HashSet<string>>? AdditionalArtifacts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("additional_artifacts");
        set => this.WithProperty("additional_artifacts", value);
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AdditionalSchemaElements
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("additional_schema_elements");
        set => this.WithProperty("additional_schema_elements", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformProperty<string>? Compression
    {
        get => GetProperty<TerraformProperty<string>>("compression");
        set => this.WithProperty("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformProperty<string>? Format
    {
        get => GetProperty<TerraformProperty<string>>("format");
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
    public TerraformProperty<string>? ReportName
    {
        get => GetProperty<TerraformProperty<string>>("report_name");
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
    public TerraformProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? S3Prefix
    {
        get => GetProperty<TerraformProperty<string>>("s3_prefix");
        set => this.WithProperty("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformProperty<string>? S3Region
    {
        get => GetProperty<TerraformProperty<string>>("s3_region");
        set => this.WithProperty("s3_region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformProperty<string>? TimeUnit
    {
        get => GetProperty<TerraformProperty<string>>("time_unit");
        set => this.WithProperty("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
