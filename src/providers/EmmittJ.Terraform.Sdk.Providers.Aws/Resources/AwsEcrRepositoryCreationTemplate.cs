using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncryptionType { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKey { get; set; } = default!;

}

/// <summary>
/// Block type for image_tag_mutability_exclusion_filter in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    [TerraformPropertyName("filter_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FilterType { get; set; }

}

/// <summary>
/// Manages a aws_ecr_repository_creation_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcrRepositoryCreationTemplate : TerraformResource
{
    public AwsEcrRepositoryCreationTemplate(string name) : base("aws_ecr_repository_creation_template", name)
    {
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliedFor is required")]
    [TerraformPropertyName("applied_for")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AppliedFor { get; set; }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomRoleArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    [TerraformPropertyName("image_tag_mutability")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageTagMutability { get; set; }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LifecyclePolicy { get; set; }

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
    /// The repository_policy attribute.
    /// </summary>
    [TerraformPropertyName("repository_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RepositoryPolicy { get; set; }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for image_tag_mutability_exclusion_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    [TerraformPropertyName("image_tag_mutability_exclusion_filter")]
    public TerraformList<TerraformBlock<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>>? ImageTagMutabilityExclusionFilter { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformPropertyName("registry_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegistryId => new TerraformReference(this, "registry_id");

}
