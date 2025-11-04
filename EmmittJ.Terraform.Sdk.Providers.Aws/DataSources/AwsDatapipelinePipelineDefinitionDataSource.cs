using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("parameter_object");
        this.DeclareOutput("pipeline_object");
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
    /// The pipeline_id attribute.
    /// </summary>
    public string? PipelineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_id")?.Value;
        set => this.WithProperty("pipeline_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
