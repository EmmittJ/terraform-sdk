using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image.
/// </summary>
public class AwsImagebuilderImageDataSource : TerraformDataSource
{
    public AwsImagebuilderImageDataSource(string name) : base("aws_imagebuilder_image", name)
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
    /// The build_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("build_version_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BuildVersionArn => new TerraformReference(this, "build_version_arn");

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
    /// The os_version attribute.
    /// </summary>
    [TerraformPropertyName("os_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsVersion => new TerraformReference(this, "os_version");

    /// <summary>
    /// The output_resources attribute.
    /// </summary>
    [TerraformPropertyName("output_resources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OutputResources => new TerraformReference(this, "output_resources");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
