using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_value in .
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformProperty<string>? StringValue
    {
        set => SetProperty("string_value", value);
    }

}

/// <summary>
/// Retrieves information about a aws_datapipeline_pipeline_definition.
/// </summary>
public class AwsDatapipelinePipelineDefinitionDataSource : TerraformDataSource
{
    public AwsDatapipelinePipelineDefinitionDataSource(string name) : base("aws_datapipeline_pipeline_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("parameter_object");
        SetOutput("pipeline_object");
        SetOutput("id");
        SetOutput("pipeline_id");
        SetOutput("region");
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
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    public required TerraformProperty<string> PipelineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pipeline_id");
        set => SetProperty("pipeline_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock>? ParameterValue
    {
        set => SetProperty("parameter_value", value);
    }

    /// <summary>
    /// The parameter_object attribute.
    /// </summary>
    public TerraformExpression ParameterObject => this["parameter_object"];

    /// <summary>
    /// The pipeline_object attribute.
    /// </summary>
    public TerraformExpression PipelineObject => this["pipeline_object"];

}
