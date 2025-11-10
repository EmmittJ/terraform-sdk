using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_repository.
/// </summary>
public class AwsEcrRepositoryDataSource : TerraformDataSource
{
    public AwsEcrRepositoryDataSource(string name) : base("aws_ecr_repository", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_configuration");

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformPropertyName("image_scanning_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ImageScanningConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "image_scanning_configuration");

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    [TerraformPropertyName("image_tag_mutability")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageTagMutability => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_tag_mutability");

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    [TerraformPropertyName("image_tag_mutability_exclusion_filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ImageTagMutabilityExclusionFilter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "image_tag_mutability_exclusion_filter");

    /// <summary>
    /// The most_recent_image_tags attribute.
    /// </summary>
    [TerraformPropertyName("most_recent_image_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> MostRecentImageTags => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "most_recent_image_tags");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformPropertyName("repository_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repository_url");

}
