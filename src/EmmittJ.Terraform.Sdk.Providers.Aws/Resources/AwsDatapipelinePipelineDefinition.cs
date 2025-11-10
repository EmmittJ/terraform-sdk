using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_object in .
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionParameterObjectBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

}

/// <summary>
/// Block type for parameter_value in .
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionParameterValueBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StringValue is required")]
    public required TerraformProperty<string> StringValue
    {
        get => GetProperty<TerraformProperty<string>>("string_value");
        set => WithProperty("string_value", value);
    }

}

/// <summary>
/// Block type for pipeline_object in .
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionPipelineObjectBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    public required TerraformProperty<string> PipelineId
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

    /// <summary>
    /// Block for parameter_object.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDatapipelinePipelineDefinitionParameterObjectBlock>? ParameterObject
    {
        get => GetProperty<HashSet<AwsDatapipelinePipelineDefinitionParameterObjectBlock>>("parameter_object");
        set => this.WithProperty("parameter_object", value);
    }

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDatapipelinePipelineDefinitionParameterValueBlock>? ParameterValue
    {
        get => GetProperty<HashSet<AwsDatapipelinePipelineDefinitionParameterValueBlock>>("parameter_value");
        set => this.WithProperty("parameter_value", value);
    }

    /// <summary>
    /// Block for pipeline_object.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PipelineObject block(s) required")]
    public HashSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlock>? PipelineObject
    {
        get => GetProperty<HashSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlock>>("pipeline_object");
        set => this.WithProperty("pipeline_object", value);
    }

}
