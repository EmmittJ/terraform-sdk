using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datapipeline_pipeline_definition resource.
/// </summary>
public class AwsDatapipelinePipelineDefinition : TerraformResource
{
    public AwsDatapipelinePipelineDefinition(string name) : base("aws_datapipeline_pipeline_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The pipeline_id attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineId
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_id");
        set => this.WithProperty("pipeline_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
