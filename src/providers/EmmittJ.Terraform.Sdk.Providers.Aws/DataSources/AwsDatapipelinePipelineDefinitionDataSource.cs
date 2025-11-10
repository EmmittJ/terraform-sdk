using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameter_value in .
/// Nesting mode: set
/// </summary>
public class AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    [TerraformPropertyName("string_value")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StringValue => new TerraformReferenceProperty<TerraformProperty<string>>("", "string_value");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The pipeline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineId is required")]
    [TerraformPropertyName("pipeline_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PipelineId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for parameter_value.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("parameter_value")]
    public TerraformSet<TerraformBlock<AwsDatapipelinePipelineDefinitionDataSourceParameterValueBlock>>? ParameterValue { get; set; } = new();

    /// <summary>
    /// The parameter_object attribute.
    /// </summary>
    [TerraformPropertyName("parameter_object")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ParameterObject => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "parameter_object");

    /// <summary>
    /// The pipeline_object attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_object")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PipelineObject => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "pipeline_object");

}
