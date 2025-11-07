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
    public TerraformProperty<double>? MaxUnits
    {
        get => GetProperty<TerraformProperty<double>>("max_units");
        set => this.WithProperty("max_units", value);
    }

    /// <summary>
    /// The min_units attribute.
    /// </summary>
    public TerraformProperty<double>? MinUnits
    {
        get => GetProperty<TerraformProperty<double>>("min_units");
        set => this.WithProperty("min_units", value);
    }

    /// <summary>
    /// The pipeline_configuration_body attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineConfigurationBody
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_configuration_body");
        set => this.WithProperty("pipeline_configuration_body", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineName
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_name");
        set => this.WithProperty("pipeline_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
