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
    public TerraformLiteralProperty<HashSet<string>>? AdditionalArtifacts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_artifacts");
        set => this.WithProperty("additional_artifacts", value);
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AdditionalSchemaElements
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_schema_elements");
        set => this.WithProperty("additional_schema_elements", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Compression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression");
        set => this.WithProperty("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format");
        set => this.WithProperty("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RefreshClosedReports
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("refresh_closed_reports");
        set => this.WithProperty("refresh_closed_reports", value);
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReportName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("report_name");
        set => this.WithProperty("report_name", value);
    }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReportVersioning
    {
        get => GetProperty<TerraformLiteralProperty<string>>("report_versioning");
        set => this.WithProperty("report_versioning", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_prefix");
        set => this.WithProperty("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_region");
        set => this.WithProperty("s3_region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimeUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_unit");
        set => this.WithProperty("time_unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
