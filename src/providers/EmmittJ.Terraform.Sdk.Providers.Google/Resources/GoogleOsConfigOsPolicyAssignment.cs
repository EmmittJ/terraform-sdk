using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock() : TerraformBlock("instance_filter")
{
    /// <summary>
    /// Target all VMs in the project. If true, no other criteria is permitted.
    /// </summary>
    [TerraformProperty("all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? All { get; set; }

}

/// <summary>
/// Block type for os_policies in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock() : TerraformBlock("os_policies")
{
    /// <summary>
    /// This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to &#39;true&#39; if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    [TerraformProperty("allow_no_resource_group_match")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowNoResourceGroupMatch { get; set; }

    /// <summary>
    /// Policy description. Length of the description is limited to 1024 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id of the OS policy with the following restrictions:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the assignment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Policy mode Possible values: [&amp;quot;MODE_UNSPECIFIED&amp;quot;, &amp;quot;VALIDATION&amp;quot;, &amp;quot;ENFORCEMENT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for rollout in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOsConfigOsPolicyAssignmentRolloutBlock() : TerraformBlock("rollout")
{
    /// <summary>
    /// This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the &#39;disruption_budget&#39; at least until this duration of time has passed after configuration changes are applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinWaitDuration is required")]
    [TerraformProperty("min_wait_duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MinWaitDuration { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOsConfigOsPolicyAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_os_config_os_policy_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOsConfigOsPolicyAssignment : TerraformResource
{
    public GoogleOsConfigOsPolicyAssignment(string name) : base("google_os_config_os_policy_assignment", name)
    {
    }

    /// <summary>
    /// OS policy assignment description. Length of the description is limited to 1024 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Set to true to skip awaiting rollout during resource creation and update.
    /// </summary>
    [TerraformProperty("skip_await_rollout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipAwaitRollout { get; set; }

    /// <summary>
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    [TerraformProperty("instance_filter")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock> InstanceFilter { get; set; } = new();

    /// <summary>
    /// Block for os_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsPolicies block(s) required")]
    [TerraformProperty("os_policies")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock> OsPolicies { get; set; } = new();

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rollout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    [TerraformProperty("rollout")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentRolloutBlock> Rollout { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleOsConfigOsPolicyAssignmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision.
    /// For a given OS policy assignment, there is only one revision with a value of &#39;true&#39; for this field.
    /// </summary>
    [TerraformProperty("baseline")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Baseline { get; }

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    [TerraformProperty("deleted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Deleted { get; }

    /// <summary>
    /// The etag for this OS policy assignment. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress for the revision. This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// Output only. The timestamp that the revision was created.
    /// </summary>
    [TerraformProperty("revision_create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionCreateTime { get; }

    /// <summary>
    /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment
    /// </summary>
    [TerraformProperty("revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionId { get; }

    /// <summary>
    /// Output only. OS policy assignment rollout state
    /// </summary>
    [TerraformProperty("rollout_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RolloutState { get; }

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

}
