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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformPropertyName("prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> ResourceTags { get; set; } = default!;

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [TerraformPropertyName("applied_for")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AppliedFor => new TerraformReference(this, "applied_for");

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomRoleArn => new TerraformReference(this, "custom_role_arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionConfiguration => new TerraformReference(this, "encryption_configuration");

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
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecyclePolicy => new TerraformReference(this, "lifecycle_policy");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegistryId => new TerraformReference(this, "registry_id");

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    [TerraformPropertyName("repository_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RepositoryPolicy => new TerraformReference(this, "repository_policy");

}
