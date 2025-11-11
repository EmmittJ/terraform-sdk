using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImageImageScanningConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    [TerraformProperty("image_scanning_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ImageScanningEnabled { get; set; }

}

/// <summary>
/// Block type for image_tests_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImageImageTestsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    [TerraformProperty("image_tests_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ImageTestsEnabled { get; set; }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("timeout_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsImagebuilderImageTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Block type for workflow in .
/// Nesting mode: set
/// </summary>
public partial class AwsImagebuilderImageWorkflowBlock : TerraformBlockBase
{
    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    [TerraformProperty("on_failure")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OnFailure { get; set; }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    [TerraformProperty("parallel_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ParallelGroup { get; set; }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    [TerraformProperty("workflow_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkflowArn { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsImagebuilderImage : TerraformResource
{
    public AwsImagebuilderImage(string name) : base("aws_imagebuilder_image", name)
    {
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("container_recipe_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerRecipeArn { get; set; }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("distribution_configuration_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DistributionConfigurationArn { get; set; }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformProperty("enhanced_image_metadata_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformProperty("execution_role")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExecutionRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("image_recipe_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageRecipeArn { get; set; }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    [TerraformProperty("infrastructure_configuration_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InfrastructureConfigurationArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    [TerraformProperty("image_scanning_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderImageImageScanningConfigurationBlock>>? ImageScanningConfiguration { get; set; }

    /// <summary>
    /// Block for image_tests_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    [TerraformProperty("image_tests_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderImageImageTestsConfigurationBlock>>? ImageTestsConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsImagebuilderImageTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for workflow.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("workflow")]
    public TerraformSet<TerraformBlock<AwsImagebuilderImageWorkflowBlock>>? Workflow { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    [TerraformProperty("os_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OsVersion { get; }

    /// <summary>
    /// The output_resources attribute.
    /// </summary>
    [TerraformProperty("output_resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> OutputResources { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Platform { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
