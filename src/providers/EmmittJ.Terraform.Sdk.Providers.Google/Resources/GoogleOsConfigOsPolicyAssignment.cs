using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// Target all VMs in the project. If true, no other criteria is permitted.
    /// </summary>
    [TerraformPropertyName("all")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? All { get; set; }

}

/// <summary>
/// Block type for os_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock : ITerraformBlock
{
    /// <summary>
    /// This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to &#39;true&#39; if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    [TerraformPropertyName("allow_no_resource_group_match")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowNoResourceGroupMatch { get; set; }

    /// <summary>
    /// Policy description. Length of the description is limited to 1024 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id of the OS policy with the following restrictions:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the assignment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Policy mode Possible values: [&amp;quot;MODE_UNSPECIFIED&amp;quot;, &amp;quot;VALIDATION&amp;quot;, &amp;quot;ENFORCEMENT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for rollout in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentRolloutBlock : ITerraformBlock
{
    /// <summary>
    /// This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the &#39;disruption_budget&#39; at least until this duration of time has passed after configuration changes are applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinWaitDuration is required")]
    [TerraformPropertyName("min_wait_duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MinWaitDuration { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_os_config_os_policy_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOsConfigOsPolicyAssignment : TerraformResource
{
    public GoogleOsConfigOsPolicyAssignment(string name) : base("google_os_config_os_policy_assignment", name)
    {
    }

    /// <summary>
    /// OS policy assignment description. Length of the description is limited to 1024 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Set to true to skip awaiting rollout during resource creation and update.
    /// </summary>
    [TerraformPropertyName("skip_await_rollout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipAwaitRollout { get; set; }

    /// <summary>
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    [TerraformPropertyName("instance_filter")]
    public TerraformList<TerraformBlock<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock>>? InstanceFilter { get; set; } = new();

    /// <summary>
    /// Block for os_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsPolicies block(s) required")]
    [TerraformPropertyName("os_policies")]
    public TerraformList<TerraformBlock<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock>>? OsPolicies { get; set; } = new();

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rollout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    [TerraformPropertyName("rollout")]
    public TerraformList<TerraformBlock<GoogleOsConfigOsPolicyAssignmentRolloutBlock>>? Rollout { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOsConfigOsPolicyAssignmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision.
    /// For a given OS policy assignment, there is only one revision with a value of &#39;true&#39; for this field.
    /// </summary>
    [TerraformPropertyName("baseline")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Baseline => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "baseline");

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    [TerraformPropertyName("deleted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Deleted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deleted");

    /// <summary>
    /// The etag for this OS policy assignment. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress for the revision. This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// Output only. The timestamp that the revision was created.
    /// </summary>
    [TerraformPropertyName("revision_create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RevisionCreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "revision_create_time");

    /// <summary>
    /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment
    /// </summary>
    [TerraformPropertyName("revision_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RevisionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "revision_id");

    /// <summary>
    /// Output only. OS policy assignment rollout state
    /// </summary>
    [TerraformPropertyName("rollout_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RolloutState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rollout_state");

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

}
