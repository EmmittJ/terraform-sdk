using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image_pipeline.
/// </summary>
public class AwsImagebuilderImagePipelineDataSource : TerraformDataSource
{
    public AwsImagebuilderImagePipelineDataSource(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("container_recipe_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerRecipeArn => new TerraformReference(this, "container_recipe_arn");

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
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("distribution_configuration_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DistributionConfigurationArn => new TerraformReference(this, "distribution_configuration_arn");

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_image_metadata_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnhancedImageMetadataEnabled => new TerraformReference(this, "enhanced_image_metadata_enabled");

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_recipe_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageRecipeArn => new TerraformReference(this, "image_recipe_arn");

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformPropertyName("image_scanning_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ImageScanningConfiguration => new TerraformReference(this, "image_scanning_configuration");

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    [TerraformPropertyName("image_tests_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ImageTestsConfiguration => new TerraformReference(this, "image_tests_configuration");

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_configuration_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InfrastructureConfigurationArn => new TerraformReference(this, "infrastructure_configuration_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Schedule => new TerraformReference(this, "schedule");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
