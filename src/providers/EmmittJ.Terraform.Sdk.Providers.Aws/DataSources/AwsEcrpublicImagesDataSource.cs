using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for image_ids in .
/// Nesting mode: list
/// </summary>
public class AwsEcrpublicImagesDataSourceImageIdsBlock
{
    /// <summary>
    /// Image digest.
    /// </summary>
    [TerraformPropertyName("image_digest")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageDigest { get; set; }

    /// <summary>
    /// Image tag.
    /// </summary>
    [TerraformPropertyName("image_tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageTag { get; set; }

}

/// <summary>
/// Provides details about AWS ECR Public Images in a public repository.
/// </summary>
public class AwsEcrpublicImagesDataSource : TerraformDataSource
{
    public AwsEcrpublicImagesDataSource(string name) : base("aws_ecrpublic_images", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// AWS account ID associated with the public registry that contains the repository. If not specified, the default public registry is assumed.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RegistryId { get; set; }

    /// <summary>
    /// Name of the public repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// Block for image_ids.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("image_ids")]
    public TerraformList<TerraformBlock<AwsEcrpublicImagesDataSourceImageIdsBlock>>? ImageIds { get; set; }

    /// <summary>
    /// The images attribute.
    /// </summary>
    [TerraformPropertyName("images")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Images => new TerraformReference(this, "images");

}
