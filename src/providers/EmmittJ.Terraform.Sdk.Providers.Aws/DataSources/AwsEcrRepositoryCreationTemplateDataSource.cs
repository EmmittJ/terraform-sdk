using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_repository_creation_template.
/// </summary>
public class AwsEcrRepositoryCreationTemplateDataSource : TerraformDataSource
{
    public AwsEcrRepositoryCreationTemplateDataSource(string name) : base("aws_ecr_repository_creation_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformPropertyName("prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ResourceTags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "resource_tags");

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [TerraformPropertyName("applied_for")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AppliedFor => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "applied_for");

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_role_arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_configuration");

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
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecyclePolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_policy");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_id");

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    [TerraformPropertyName("repository_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "repository_policy");

}
