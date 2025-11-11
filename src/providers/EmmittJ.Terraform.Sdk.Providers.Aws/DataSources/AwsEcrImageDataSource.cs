using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_image.
/// </summary>
public partial class AwsEcrImageDataSource : TerraformDataSource
{
    public AwsEcrImageDataSource(string name) : base("aws_ecr_image", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    [TerraformProperty("image_digest")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ImageDigest { get; set; }

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    [TerraformProperty("image_tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageTag { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MostRecent { get; set; }

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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The image_pushed_at attribute.
    /// </summary>
    [TerraformProperty("image_pushed_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ImagePushedAt { get; }

    /// <summary>
    /// The image_size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("image_size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ImageSizeInBytes { get; }

    /// <summary>
    /// The image_tags attribute.
    /// </summary>
    [TerraformProperty("image_tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ImageTags { get; }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformProperty("image_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageUri { get; }

}
