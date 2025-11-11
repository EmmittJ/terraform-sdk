using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parallelism_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelineParallelismConfigurationBlock
{
    /// <summary>
    /// The max_parallel_execution_steps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxParallelExecutionSteps is required")]
    [TerraformPropertyName("max_parallel_execution_steps")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxParallelExecutionSteps { get; set; }

}

/// <summary>
/// Block type for pipeline_definition_s3_location in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelinePipelineDefinitionS3LocationBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectKey is required")]
    [TerraformPropertyName("object_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ObjectKey { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionId { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerPipeline : TerraformResource
{
    public AwsSagemakerPipeline(string name) : base("aws_sagemaker_pipeline", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The pipeline_definition attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_definition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PipelineDefinition { get; set; }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PipelineDescription { get; set; }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineDisplayName is required")]
    [TerraformPropertyName("pipeline_display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PipelineDisplayName { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    [TerraformPropertyName("pipeline_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PipelineName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for parallelism_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    [TerraformPropertyName("parallelism_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerPipelineParallelismConfigurationBlock>>? ParallelismConfiguration { get; set; }

    /// <summary>
    /// Block for pipeline_definition_s3_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineDefinitionS3Location block(s) allowed")]
    [TerraformPropertyName("pipeline_definition_s3_location")]
    public TerraformList<TerraformBlock<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>>? PipelineDefinitionS3Location { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
