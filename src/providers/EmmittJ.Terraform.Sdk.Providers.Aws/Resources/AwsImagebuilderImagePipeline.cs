using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageScanningConfigurationBlock
{
    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_scanning_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImageScanningEnabled { get; set; }

}

/// <summary>
/// Block type for image_tests_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineImageTestsConfigurationBlock
{
    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_tests_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImageTestsEnabled { get; set; }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("timeout_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineScheduleBlock
{
    /// <summary>
    /// The pipeline_execution_start_condition attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_execution_start_condition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PipelineExecutionStartCondition { get; set; }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    [TerraformPropertyName("schedule_expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScheduleExpression { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Timezone { get; set; } = default!;

}

/// <summary>
/// Block type for workflow in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImagePipelineWorkflowBlock
{
    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    [TerraformPropertyName("on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OnFailure { get; set; }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    [TerraformPropertyName("parallel_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParallelGroup { get; set; }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    [TerraformPropertyName("workflow_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkflowArn { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_image_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderImagePipeline : TerraformResource
{
    public AwsImagebuilderImagePipeline(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("container_recipe_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerRecipeArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("distribution_configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DistributionConfigurationArn { get; set; }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_image_metadata_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformPropertyName("execution_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_recipe_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageRecipeArn { get; set; }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    [TerraformPropertyName("infrastructure_configuration_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InfrastructureConfigurationArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

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
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    [TerraformPropertyName("image_scanning_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderImagePipelineImageScanningConfigurationBlock>>? ImageScanningConfiguration { get; set; }

    /// <summary>
    /// Block for image_tests_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    [TerraformPropertyName("image_tests_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderImagePipelineImageTestsConfigurationBlock>>? ImageTestsConfiguration { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AwsImagebuilderImagePipelineScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for workflow.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("workflow")]
    public TerraformList<TerraformBlock<AwsImagebuilderImagePipelineWorkflowBlock>>? Workflow { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateCreated => new TerraformReference(this, "date_created");

    /// <summary>
    /// The date_last_run attribute.
    /// </summary>
    [TerraformPropertyName("date_last_run")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateLastRun => new TerraformReference(this, "date_last_run");

    /// <summary>
    /// The date_next_run attribute.
    /// </summary>
    [TerraformPropertyName("date_next_run")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateNextRun => new TerraformReference(this, "date_next_run");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformPropertyName("date_updated")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateUpdated => new TerraformReference(this, "date_updated");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

}
