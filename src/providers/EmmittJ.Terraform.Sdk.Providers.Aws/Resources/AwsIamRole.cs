using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_policy in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsIamRoleInlinePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Policy { get; set; }

}

/// <summary>
/// Manages a aws_iam_role resource.
/// </summary>
public partial class AwsIamRole : TerraformResource
{
    public AwsIamRole(string name) : base("aws_iam_role", name)
    {
    }

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssumeRolePolicy is required")]
    [TerraformProperty("assume_role_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AssumeRolePolicy { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The force_detach_policies attribute.
    /// </summary>
    [TerraformProperty("force_detach_policies")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDetachPolicies { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_policy_arns attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("managed_policy_arns")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> ManagedPolicyArns { get; set; }

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    [TerraformProperty("max_session_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxSessionDuration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    [TerraformProperty("permissions_boundary")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PermissionsBoundary { get; set; }

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
    /// Block for inline_policy.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("inline_policy")]
    public TerraformSet<TerraformBlock<AwsIamRoleInlinePolicyBlock>>? InlinePolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UniqueId { get; }

}
