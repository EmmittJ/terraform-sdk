using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image_pipeline.
/// </summary>
public partial class AwsImagebuilderImagePipelineDataSource : TerraformDataSource
{
    public AwsImagebuilderImagePipelineDataSource(string name) : base("aws_imagebuilder_image_pipeline", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("container_recipe_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContainerRecipeArn { get; }

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
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("distribution_configuration_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DistributionConfigurationArn { get; }

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformProperty("enhanced_image_metadata_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnhancedImageMetadataEnabled { get; }

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformProperty("image_recipe_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageRecipeArn { get; }

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformProperty("image_scanning_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ImageScanningConfiguration { get; }

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    [TerraformProperty("image_tests_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ImageTestsConfiguration { get; }

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [TerraformProperty("infrastructure_configuration_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InfrastructureConfigurationArn { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Platform { get; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformProperty("schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Schedule { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
