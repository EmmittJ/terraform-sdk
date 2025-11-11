using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_object in .
/// Nesting mode: set
/// </summary>
public partial class AwsDatapipelinePipelineDefinitionParameterObjectBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for parameter_value in .
/// Nesting mode: set
/// </summary>
public partial class AwsDatapipelinePipelineDefinitionParameterValueBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StringValue is required")]
    [TerraformProperty("string_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StringValue { get; set; }

}

/// <summary>
/// Block type for pipeline_object in .
/// Nesting mode: set
/// </summary>
public partial class AwsDatapipelinePipelineDefinitionPipelineObjectBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_datapipeline_pipeline_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatapipelinePipelineDefinition : TerraformResource
{
    public AwsDatapipelinePipelineDefinition(string name) : base("aws_datapipeline_pipeline_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    [TerraformProperty("pipeline_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PipelineId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for parameter_object.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("parameter_object")]
    public partial TerraformSet<TerraformBlock<AwsDatapipelinePipelineDefinitionParameterObjectBlock>>? ParameterObject { get; set; }

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("parameter_value")]
    public partial TerraformSet<TerraformBlock<AwsDatapipelinePipelineDefinitionParameterValueBlock>>? ParameterValue { get; set; }

    /// <summary>
    /// Block for pipeline_object.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineObject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PipelineObject block(s) required")]
    [TerraformProperty("pipeline_object")]
    public partial TerraformSet<TerraformBlock<AwsDatapipelinePipelineDefinitionPipelineObjectBlock>>? PipelineObject { get; set; }

}
