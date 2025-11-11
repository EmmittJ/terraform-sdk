using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EncryptionType { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for image_tag_mutability_exclusion_filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    [TerraformProperty("filter_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FilterType { get; set; }

}

/// <summary>
/// Manages a aws_ecr_repository_creation_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcrRepositoryCreationTemplate : TerraformResource
{
    public AwsEcrRepositoryCreationTemplate(string name) : base("aws_ecr_repository_creation_template", name)
    {
    }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliedFor is required")]
    [TerraformProperty("applied_for")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AppliedFor { get; set; }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformProperty("custom_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomRoleArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    [TerraformProperty("image_tag_mutability")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageTagMutability { get; set; }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformProperty("lifecycle_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LifecyclePolicy { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformProperty("prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    [TerraformProperty("repository_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RepositoryPolicy { get; set; }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    public TerraformList<TerraformBlock<AwsEcrRepositoryCreationTemplateEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for image_tag_mutability_exclusion_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    [TerraformProperty("image_tag_mutability_exclusion_filter")]
    public TerraformList<TerraformBlock<AwsEcrRepositoryCreationTemplateImageTagMutabilityExclusionFilterBlock>>? ImageTagMutabilityExclusionFilter { get; set; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegistryId { get; }

}
