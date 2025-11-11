using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image.
/// </summary>
public partial class AwsImagebuilderImageDataSource : TerraformDataSource
{
    public AwsImagebuilderImageDataSource(string name) : base("aws_imagebuilder_image", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The build_version_arn attribute.
    /// </summary>
    [TerraformProperty("build_version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BuildVersionArn { get; }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("container_recipe_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContainerRecipeArn { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("distribution_configuration_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DistributionConfigurationArn { get; }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformProperty("enhanced_image_metadata_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnhancedImageMetadataEnabled { get; }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("image_recipe_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageRecipeArn { get; }

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformProperty("image_scanning_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ImageScanningConfiguration { get; }

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    [TerraformProperty("image_tests_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ImageTestsConfiguration { get; }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("infrastructure_configuration_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InfrastructureConfigurationArn { get; }

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
