using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_value in AwsDatapipelinePipelineDefinitionDataSource.
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter_value";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string> StringValue
        => AsReference("string_value");

}


/// <summary>
/// Represents a aws_datapipeline_pipeline_definition Terraform data source.
/// Retrieves information about a aws_datapipeline_pipeline_definition.
/// </summary>
public partial class AwsDatapipelinePipelineDefinitionDataSource(string name) : TerraformDataSource("aws_datapipeline_pipeline_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    public required TerraformValue<string> PipelineId
    {
        get => GetRequiredArgument<TerraformValue<string>>("pipeline_id");
        set => SetArgument("pipeline_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The parameter_object attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ParameterObject
        => AsReference("parameter_object");

    /// <summary>
    /// The pipeline_object attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PipelineObject
        => AsReference("pipeline_object");

    /// <summary>
    /// ParameterValue block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock>? ParameterValue
    {
        get => GetArgument<TerraformSet<AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock>>("parameter_value");
        set => SetArgument("parameter_value", value);
    }

}
