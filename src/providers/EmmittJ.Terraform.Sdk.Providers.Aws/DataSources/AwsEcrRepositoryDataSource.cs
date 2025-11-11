using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_repository.
/// </summary>
public partial class AwsEcrRepositoryDataSource : TerraformDataSource
{
    public AwsEcrRepositoryDataSource(string name) : base("aws_ecr_repository", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RegistryId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EncryptionConfiguration { get; }

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformProperty("image_scanning_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ImageScanningConfiguration { get; }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    [TerraformProperty("image_tag_mutability")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageTagMutability { get; }

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    [TerraformProperty("image_tag_mutability_exclusion_filter")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ImageTagMutabilityExclusionFilter { get; }

    /// <summary>
    /// The most_recent_image_tags attribute.
    /// </summary>
    [TerraformProperty("most_recent_image_tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> MostRecentImageTags { get; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformProperty("repository_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RepositoryUrl { get; }

}
