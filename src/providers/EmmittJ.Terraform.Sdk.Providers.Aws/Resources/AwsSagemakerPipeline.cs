using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parallelism_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelineParallelismConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The max_parallel_execution_steps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxParallelExecutionSteps is required")]
    [TerraformPropertyName("max_parallel_execution_steps")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxParallelExecutionSteps { get; set; }

}

/// <summary>
/// Block type for pipeline_definition_s3_location in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerPipelinePipelineDefinitionS3LocationBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectKey is required")]
    [TerraformPropertyName("object_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ObjectKey { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionId { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The pipeline_definition attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_definition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PipelineDefinition { get; set; }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PipelineDescription { get; set; }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineDisplayName is required")]
    [TerraformPropertyName("pipeline_display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PipelineDisplayName { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    [TerraformPropertyName("pipeline_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PipelineName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for parallelism_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    [TerraformPropertyName("parallelism_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerPipelineParallelismConfigurationBlock>>? ParallelismConfiguration { get; set; } = new();

    /// <summary>
    /// Block for pipeline_definition_s3_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineDefinitionS3Location block(s) allowed")]
    [TerraformPropertyName("pipeline_definition_s3_location")]
    public TerraformList<TerraformBlock<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock>>? PipelineDefinitionS3Location { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
