using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImagePipelineImageScanningConfigurationBlock() : TerraformBlock("image_scanning_configuration")
{
    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    [TerraformProperty("image_scanning_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImageScanningEnabled { get; set; }

}

/// <summary>
/// Block type for image_tests_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImagePipelineImageTestsConfigurationBlock() : TerraformBlock("image_tests_configuration")
{
    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    [TerraformProperty("image_tests_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImageTestsEnabled { get; set; }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("timeout_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImagePipelineScheduleBlock() : TerraformBlock("schedule")
{
    /// <summary>
    /// The pipeline_execution_start_condition attribute.
    /// </summary>
    [TerraformProperty("pipeline_execution_start_condition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PipelineExecutionStartCondition { get; set; }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformProperty("schedule_expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScheduleExpression { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Timezone { get; set; }

}

/// <summary>
/// Block type for workflow in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImagePipelineWorkflowBlock() : TerraformBlock("workflow")
{
    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    [TerraformProperty("on_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnFailure { get; set; }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    [TerraformProperty("parallel_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParallelGroup { get; set; }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    [TerraformProperty("workflow_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkflowArn { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_image_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsImagebuilderImagePipeline : TerraformResource
{
    public AwsImagebuilderImagePipeline(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("container_recipe_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerRecipeArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("distribution_configuration_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DistributionConfigurationArn { get; set; }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformProperty("enhanced_image_metadata_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformProperty("execution_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("image_recipe_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImageRecipeArn { get; set; }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    [TerraformProperty("infrastructure_configuration_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InfrastructureConfigurationArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

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
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    [TerraformProperty("image_scanning_configuration")]
    public TerraformList<AwsImagebuilderImagePipelineImageScanningConfigurationBlock> ImageScanningConfiguration { get; set; } = new();

    /// <summary>
    /// Block for image_tests_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    [TerraformProperty("image_tests_configuration")]
    public TerraformList<AwsImagebuilderImagePipelineImageTestsConfigurationBlock> ImageTestsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public TerraformList<AwsImagebuilderImagePipelineScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for workflow.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("workflow")]
    public TerraformList<AwsImagebuilderImagePipelineWorkflowBlock> Workflow { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The date_last_run attribute.
    /// </summary>
    [TerraformProperty("date_last_run")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateLastRun { get; }

    /// <summary>
    /// The date_next_run attribute.
    /// </summary>
    [TerraformProperty("date_next_run")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateNextRun { get; }

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformProperty("date_updated")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateUpdated { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Platform { get; }

}
