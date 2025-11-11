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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionConfiguration => new TerraformReference(this, "encryption_configuration");

    /// <summary>
    /// The image_scanning_configuration attribute.
    /// </summary>
    [TerraformPropertyName("image_scanning_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ImageScanningConfiguration => new TerraformReference(this, "image_scanning_configuration");

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    [TerraformPropertyName("image_tag_mutability")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageTagMutability => new TerraformReference(this, "image_tag_mutability");

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    [TerraformPropertyName("image_tag_mutability_exclusion_filter")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ImageTagMutabilityExclusionFilter => new TerraformReference(this, "image_tag_mutability_exclusion_filter");

    /// <summary>
    /// The most_recent_image_tags attribute.
    /// </summary>
    [TerraformPropertyName("most_recent_image_tags")]
    // Output-only attribute - read-only reference
    public TerraformList<string> MostRecentImageTags => new TerraformReference(this, "most_recent_image_tags");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformPropertyName("repository_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RepositoryUrl => new TerraformReference(this, "repository_url");

}
