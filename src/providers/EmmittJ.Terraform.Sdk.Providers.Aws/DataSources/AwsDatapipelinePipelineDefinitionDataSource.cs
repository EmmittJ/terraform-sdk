using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_value in .
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock
{


}

/// <summary>
/// Retrieves information about a aws_datapipeline_pipeline_definition.
/// </summary>
public class AwsDatapipelinePipelineDefinitionDataSource : TerraformDataSource
{
    public AwsDatapipelinePipelineDefinitionDataSource(string name) : base("aws_datapipeline_pipeline_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    [TerraformPropertyName("pipeline_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PipelineId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("parameter_value")]
    public TerraformSet<TerraformBlock<AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock>>? ParameterValue { get; set; }

    /// <summary>
    /// The parameter_object attribute.
    /// </summary>
    [TerraformPropertyName("parameter_object")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> ParameterObject => new TerraformReference(this, "parameter_object");

    /// <summary>
    /// The pipeline_object attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_object")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> PipelineObject => new TerraformReference(this, "pipeline_object");

}
