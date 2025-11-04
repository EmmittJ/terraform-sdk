using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_osis_pipeline resource.
/// </summary>
public class AwsOsisPipeline : TerraformResource
{
    public AwsOsisPipeline(string name) : base("aws_osis_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("ingest_endpoint_urls");
        this.DeclareOutput("pipeline_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The max_units attribute.
    /// </summary>
    public double? MaxUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_units")?.Value;
        set => this.WithProperty("max_units", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_units attribute.
    /// </summary>
    public double? MinUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_units")?.Value;
        set => this.WithProperty("min_units", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The pipeline_configuration_body attribute.
    /// </summary>
    public string? PipelineConfigurationBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_configuration_body")?.Value;
        set => this.WithProperty("pipeline_configuration_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public string? PipelineName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_name")?.Value;
        set => this.WithProperty("pipeline_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ingest_endpoint_urls attribute.
    /// </summary>
    public TerraformExpression IngestEndpointUrls => this["ingest_endpoint_urls"];

    /// <summary>
    /// The pipeline_arn attribute.
    /// </summary>
    public TerraformExpression PipelineArn => this["pipeline_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
