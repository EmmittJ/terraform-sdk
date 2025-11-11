using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_value in .
/// Nesting mode: set
/// </summary>
public partial class AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock : TerraformBlockBase
{


}

/// <summary>
/// Retrieves information about a aws_datapipeline_pipeline_definition.
/// </summary>
public partial class AwsDatapipelinePipelineDefinitionDataSource : TerraformDataSource
{
    public AwsDatapipelinePipelineDefinitionDataSource(string name) : base("aws_datapipeline_pipeline_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    [TerraformProperty("pipeline_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PipelineId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("parameter_value")]
    public TerraformSet<TerraformBlock<AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock>>? ParameterValue { get; set; }

    /// <summary>
    /// The parameter_object attribute.
    /// </summary>
    [TerraformProperty("parameter_object")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> ParameterObject { get; }

    /// <summary>
    /// The pipeline_object attribute.
    /// </summary>
    [TerraformProperty("pipeline_object")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> PipelineObject { get; }

}
