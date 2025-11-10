using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageImageScanningConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The image_scanning_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_scanning_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ImageScanningEnabled { get; set; }

}

/// <summary>
/// Block type for image_tests_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageImageTestsConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The image_tests_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_tests_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ImageTestsEnabled { get; set; }

    /// <summary>
    /// The timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("timeout_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeoutMinutes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsImagebuilderImageTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Block type for workflow in .
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImageWorkflowBlock : ITerraformBlock
{
    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    [TerraformPropertyName("on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnFailure { get; set; }

    /// <summary>
    /// The parallel_group attribute.
    /// </summary>
    [TerraformPropertyName("parallel_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParallelGroup { get; set; }

    /// <summary>
    /// The workflow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowArn is required")]
    [TerraformPropertyName("workflow_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkflowArn { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_image resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderImage : TerraformResource
{
    public AwsImagebuilderImage(string name) : base("aws_imagebuilder_image", name)
    {
    }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("container_recipe_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerRecipeArn { get; set; }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("distribution_configuration_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DistributionConfigurationArn { get; set; }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_image_metadata_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformPropertyName("execution_role")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExecutionRole { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_role");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_recipe_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageRecipeArn { get; set; }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureConfigurationArn is required")]
    [TerraformPropertyName("infrastructure_configuration_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InfrastructureConfigurationArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

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
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    [TerraformPropertyName("image_scanning_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderImageImageScanningConfigurationBlock>>? ImageScanningConfiguration { get; set; } = new();

    /// <summary>
    /// Block for image_tests_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTestsConfiguration block(s) allowed")]
    [TerraformPropertyName("image_tests_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderImageImageTestsConfigurationBlock>>? ImageTestsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsImagebuilderImageTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workflow.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("workflow")]
    public TerraformSet<TerraformBlock<AwsImagebuilderImageWorkflowBlock>>? Workflow { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_created");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    [TerraformPropertyName("os_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_version");

    /// <summary>
    /// The output_resources attribute.
    /// </summary>
    [TerraformPropertyName("output_resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OutputResources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "output_resources");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Platform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
