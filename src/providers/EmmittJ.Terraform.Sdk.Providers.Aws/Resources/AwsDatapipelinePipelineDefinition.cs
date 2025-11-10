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
        set => SetProperty("id", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StringValue is required")]
    public required TerraformProperty<string> StringValue
    {
        set => SetProperty("string_value", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Manages a aws_datapipeline_pipeline_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatapipelinePipelineDefinition : TerraformResource
{
    public AwsDatapipelinePipelineDefinition(string name) : base("aws_datapipeline_pipeline_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Block for parameter_object.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDatapipelinePipelineDefinitionParameterObjectBlock>? ParameterObject
    {
        set => SetProperty("parameter_object", value);
    }

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDatapipelinePipelineDefinitionParameterValueBlock>? ParameterValue
    {
        set => SetProperty("parameter_value", value);
    }

    /// <summary>
    /// Block for pipeline_object.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineObject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PipelineObject block(s) required")]
    public HashSet<AwsDatapipelinePipelineDefinitionPipelineObjectBlock>? PipelineObject
    {
        set => SetProperty("pipeline_object", value);
    }

}
