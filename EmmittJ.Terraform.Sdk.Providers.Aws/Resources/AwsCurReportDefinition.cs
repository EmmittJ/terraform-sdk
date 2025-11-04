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
    public HashSet<string>? AdditionalArtifacts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_artifacts")?.Value;
        set => this.WithProperty("additional_artifacts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public HashSet<string>? AdditionalSchemaElements
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_schema_elements")?.Value;
        set => this.WithProperty("additional_schema_elements", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public string? Compression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression")?.Value;
        set => this.WithProperty("compression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public string? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format")?.Value;
        set => this.WithProperty("format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public bool? RefreshClosedReports
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("refresh_closed_reports")?.Value;
        set => this.WithProperty("refresh_closed_reports", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The report_name attribute.
    /// </summary>
    public string? ReportName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("report_name")?.Value;
        set => this.WithProperty("report_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public string? ReportVersioning
    {
        get => GetProperty<TerraformLiteralProperty<string>>("report_versioning")?.Value;
        set => this.WithProperty("report_versioning", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public string? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket")?.Value;
        set => this.WithProperty("s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public string? S3Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_prefix")?.Value;
        set => this.WithProperty("s3_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public string? S3Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_region")?.Value;
        set => this.WithProperty("s3_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public string? TimeUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_unit")?.Value;
        set => this.WithProperty("time_unit", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
