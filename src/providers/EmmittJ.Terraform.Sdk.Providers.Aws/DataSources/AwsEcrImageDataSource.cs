using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_image.
/// </summary>
public class AwsEcrImageDataSource : TerraformDataSource
{
    public AwsEcrImageDataSource(string name) : base("aws_ecr_image", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    [TerraformPropertyName("image_digest")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ImageDigest { get; set; } = default!;

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    [TerraformPropertyName("image_tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageTag { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RegistryId { get; set; } = default!;

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The image_pushed_at attribute.
    /// </summary>
    [TerraformPropertyName("image_pushed_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ImagePushedAt => new TerraformReference(this, "image_pushed_at");

    /// <summary>
    /// The image_size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("image_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ImageSizeInBytes => new TerraformReference(this, "image_size_in_bytes");

    /// <summary>
    /// The image_tags attribute.
    /// </summary>
    [TerraformPropertyName("image_tags")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ImageTags => new TerraformReference(this, "image_tags");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageUri => new TerraformReference(this, "image_uri");

}
