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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_digest attribute.
    /// </summary>
    [TerraformPropertyName("image_digest")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ImageDigest { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_digest");

    /// <summary>
    /// The image_tag attribute.
    /// </summary>
    [TerraformPropertyName("image_tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageTag { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RegistryId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_id");

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

    /// <summary>
    /// The image_pushed_at attribute.
    /// </summary>
    [TerraformPropertyName("image_pushed_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ImagePushedAt => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "image_pushed_at");

    /// <summary>
    /// The image_size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("image_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ImageSizeInBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "image_size_in_bytes");

    /// <summary>
    /// The image_tags attribute.
    /// </summary>
    [TerraformPropertyName("image_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ImageTags => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "image_tags");

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [TerraformPropertyName("image_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_uri");

}
