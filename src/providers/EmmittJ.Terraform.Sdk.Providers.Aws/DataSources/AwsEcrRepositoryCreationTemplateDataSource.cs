using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_repository_creation_template.
/// </summary>
public partial class AwsEcrRepositoryCreationTemplateDataSource : TerraformDataSource
{
    public AwsEcrRepositoryCreationTemplateDataSource(string name) : base("aws_ecr_repository_creation_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformProperty("prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ResourceTags { get; set; }

    /// <summary>
    /// The applied_for attribute.
    /// </summary>
    [TerraformProperty("applied_for")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AppliedFor { get; }

    /// <summary>
    /// The custom_role_arn attribute.
    /// </summary>
    [TerraformProperty("custom_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomRoleArn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionConfiguration { get; }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    [TerraformProperty("image_tag_mutability")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageTagMutability { get; }

    /// <summary>
    /// The image_tag_mutability_exclusion_filter attribute.
    /// </summary>
    [TerraformProperty("image_tag_mutability_exclusion_filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ImageTagMutabilityExclusionFilter { get; }

    /// <summary>
    /// The lifecycle_policy attribute.
    /// </summary>
    [TerraformProperty("lifecycle_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LifecyclePolicy { get; }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [TerraformProperty("registry_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistryId { get; }

    /// <summary>
    /// The repository_policy attribute.
    /// </summary>
    [TerraformProperty("repository_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RepositoryPolicy { get; }

}
