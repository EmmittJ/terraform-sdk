using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_ids in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcrpublicImagesDataSourceImageIdsBlock : TerraformBlockBase
{
    /// <summary>
    /// Image digest.
    /// </summary>
    [TerraformProperty("image_digest")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageDigest { get; set; }

    /// <summary>
    /// Image tag.
    /// </summary>
    [TerraformProperty("image_tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageTag { get; set; }

}

/// <summary>
/// Provides details about AWS ECR Public Images in a public repository.
/// </summary>
public partial class AwsEcrpublicImagesDataSource : TerraformDataSource
{
    public AwsEcrpublicImagesDataSource(string name) : base("aws_ecrpublic_images", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// AWS account ID associated with the public registry that contains the repository. If not specified, the default public registry is assumed.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RegistryId { get; set; }

    /// <summary>
    /// Name of the public repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// Block for image_ids.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("image_ids")]
    public TerraformList<TerraformBlock<AwsEcrpublicImagesDataSourceImageIdsBlock>>? ImageIds { get; set; }

    /// <summary>
    /// The images attribute.
    /// </summary>
    [TerraformProperty("images")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Images { get; }

}
