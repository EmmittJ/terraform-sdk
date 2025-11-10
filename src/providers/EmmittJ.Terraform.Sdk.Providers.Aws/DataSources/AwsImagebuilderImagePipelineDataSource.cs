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
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The container_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("container_recipe_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerRecipeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_recipe_arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_created");

    /// <summary>
    /// The date_last_run attribute.
    /// </summary>
    [TerraformPropertyName("date_last_run")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateLastRun => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_last_run");

    /// <summary>
    /// The date_next_run attribute.
    /// </summary>
    [TerraformPropertyName("date_next_run")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateNextRun => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_next_run");

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformPropertyName("date_updated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateUpdated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_updated");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The distribution_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("distribution_configuration_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DistributionConfigurationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "distribution_configuration_arn");

    /// <summary>
    /// The enhanced_image_metadata_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_image_metadata_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnhancedImageMetadataEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enhanced_image_metadata_enabled");

    /// <summary>
    /// The image_recipe_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_recipe_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageRecipeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_recipe_arn");

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformPropertyName("image_scanning_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ImageScanningConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "image_scanning_configuration");

    /// <summary>
    /// The image_tests_configuration attribute.
    /// </summary>
    [TerraformPropertyName("image_tests_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ImageTestsConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "image_tests_configuration");

    /// <summary>
    /// The infrastructure_configuration_arn attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_configuration_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InfrastructureConfigurationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "infrastructure_configuration_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Platform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform");

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Schedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "schedule");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
