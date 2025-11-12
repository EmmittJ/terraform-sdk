using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parallelism_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerPipelineParallelismConfigurationBlock() : TerraformBlock("parallelism_configuration")
{
    /// <summary>
    /// The max_parallel_execution_steps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxParallelExecutionSteps is required")]
    [TerraformProperty("max_parallel_execution_steps")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxParallelExecutionSteps { get; set; }

}

/// <summary>
/// Block type for pipeline_definition_s3_location in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerPipelinePipelineDefinitionS3LocationBlock() : TerraformBlock("pipeline_definition_s3_location")
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectKey is required")]
    [TerraformProperty("object_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObjectKey { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VersionId { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerPipeline : TerraformResource
{
    public AwsSagemakerPipeline(string name) : base("aws_sagemaker_pipeline", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pipeline_definition attribute.
    /// </summary>
    [TerraformProperty("pipeline_definition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PipelineDefinition { get; set; }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    [TerraformProperty("pipeline_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PipelineDescription { get; set; }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineDisplayName is required")]
    [TerraformProperty("pipeline_display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PipelineDisplayName { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    [TerraformProperty("pipeline_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PipelineName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for parallelism_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    [TerraformProperty("parallelism_configuration")]
    public TerraformList<AwsSagemakerPipelineParallelismConfigurationBlock> ParallelismConfiguration { get; set; } = new();

    /// <summary>
    /// Block for pipeline_definition_s3_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineDefinitionS3Location block(s) allowed")]
    [TerraformProperty("pipeline_definition_s3_location")]
    public TerraformList<AwsSagemakerPipelinePipelineDefinitionS3LocationBlock> PipelineDefinitionS3Location { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
