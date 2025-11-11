using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsDlmLifecyclePolicyPolicyDetailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    [TerraformProperty("copy_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CopyTags { get; set; }

    /// <summary>
    /// The create_interval attribute.
    /// </summary>
    [TerraformProperty("create_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CreateInterval { get; set; }

    /// <summary>
    /// The extend_deletion attribute.
    /// </summary>
    [TerraformProperty("extend_deletion")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ExtendDeletion { get; set; }

    /// <summary>
    /// The policy_language attribute.
    /// </summary>
    [TerraformProperty("policy_language")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PolicyLanguage { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PolicyType { get; set; }

    /// <summary>
    /// The resource_locations attribute.
    /// </summary>
    [TerraformProperty("resource_locations")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> ResourceLocations { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformProperty("resource_types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ResourceTypes { get; set; }

    /// <summary>
    /// The retain_interval attribute.
    /// </summary>
    [TerraformProperty("retain_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetainInterval { get; set; }

    /// <summary>
    /// The target_tags attribute.
    /// </summary>
    [TerraformProperty("target_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? TargetTags { get; set; }

}

/// <summary>
/// Manages a aws_dlm_lifecycle_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDlmLifecyclePolicy : TerraformResource
{
    public AwsDlmLifecyclePolicy(string name) : base("aws_dlm_lifecycle_policy", name)
    {
    }

    /// <summary>
    /// The default_policy attribute.
    /// </summary>
    [TerraformProperty("default_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultPolicy { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for policy_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyDetails block(s) allowed")]
    [TerraformProperty("policy_details")]
    public TerraformList<TerraformBlock<AwsDlmLifecyclePolicyPolicyDetailsBlock>>? PolicyDetails { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
