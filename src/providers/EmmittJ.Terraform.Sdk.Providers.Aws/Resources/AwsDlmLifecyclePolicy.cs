using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_details in .
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlock
{
    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTags { get; set; }

    /// <summary>
    /// The create_interval attribute.
    /// </summary>
    [TerraformPropertyName("create_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CreateInterval { get; set; }

    /// <summary>
    /// The extend_deletion attribute.
    /// </summary>
    [TerraformPropertyName("extend_deletion")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExtendDeletion { get; set; }

    /// <summary>
    /// The policy_language attribute.
    /// </summary>
    [TerraformPropertyName("policy_language")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PolicyLanguage { get; set; } = default!;

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyType { get; set; }

    /// <summary>
    /// The resource_locations attribute.
    /// </summary>
    [TerraformPropertyName("resource_locations")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ResourceLocations { get; set; } = default!;

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceType { get; set; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformPropertyName("resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ResourceTypes { get; set; }

    /// <summary>
    /// The retain_interval attribute.
    /// </summary>
    [TerraformPropertyName("retain_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetainInterval { get; set; }

    /// <summary>
    /// The target_tags attribute.
    /// </summary>
    [TerraformPropertyName("target_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? TargetTags { get; set; }

}

/// <summary>
/// Manages a aws_dlm_lifecycle_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDlmLifecyclePolicy : TerraformResource
{
    public AwsDlmLifecyclePolicy(string name) : base("aws_dlm_lifecycle_policy", name)
    {
    }

    /// <summary>
    /// The default_policy attribute.
    /// </summary>
    [TerraformPropertyName("default_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultPolicy { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for policy_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyDetails block(s) allowed")]
    [TerraformPropertyName("policy_details")]
    public TerraformList<TerraformBlock<AwsDlmLifecyclePolicyPolicyDetailsBlock>>? PolicyDetails { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
