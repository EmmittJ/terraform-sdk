using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cur_report_definition.
/// </summary>
public class AwsCurReportDefinitionDataSource : TerraformDataSource
{
    public AwsCurReportDefinitionDataSource(string name) : base("aws_cur_report_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("additional_artifacts");
        this.DeclareOutput("additional_schema_elements");
        this.DeclareOutput("compression");
        this.DeclareOutput("format");
        this.DeclareOutput("refresh_closed_reports");
        this.DeclareOutput("report_versioning");
        this.DeclareOutput("s3_bucket");
        this.DeclareOutput("s3_prefix");
        this.DeclareOutput("s3_region");
        this.DeclareOutput("time_unit");
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
    /// The report_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportName is required")]
    public required TerraformProperty<string> ReportName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("report_name");
        set => this.WithProperty("report_name", value);
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
    /// The additional_artifacts attribute.
    /// </summary>
    public TerraformExpression AdditionalArtifacts => this["additional_artifacts"];

    /// <summary>
    /// The additional_schema_elements attribute.
    /// </summary>
    public TerraformExpression AdditionalSchemaElements => this["additional_schema_elements"];

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformExpression Compression => this["compression"];

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformExpression Format => this["format"];

    /// <summary>
    /// The refresh_closed_reports attribute.
    /// </summary>
    public TerraformExpression RefreshClosedReports => this["refresh_closed_reports"];

    /// <summary>
    /// The report_versioning attribute.
    /// </summary>
    public TerraformExpression ReportVersioning => this["report_versioning"];

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformExpression S3Bucket => this["s3_bucket"];

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformExpression S3Prefix => this["s3_prefix"];

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformExpression S3Region => this["s3_region"];

    /// <summary>
    /// The time_unit attribute.
    /// </summary>
    public TerraformExpression TimeUnit => this["time_unit"];

}
