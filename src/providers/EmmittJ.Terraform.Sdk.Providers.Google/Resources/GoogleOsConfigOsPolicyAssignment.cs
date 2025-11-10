using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Target all VMs in the project. If true, no other criteria is permitted.
    /// </summary>
    public TerraformProperty<bool>? All
    {
        set => SetProperty("all", value);
    }

}

/// <summary>
/// Block type for os_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to &#39;true&#39; if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    public TerraformProperty<bool>? AllowNoResourceGroupMatch
    {
        set => SetProperty("allow_no_resource_group_match", value);
    }

    /// <summary>
    /// Policy description. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id of the OS policy with the following restrictions:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the assignment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Policy mode Possible values: [&amp;quot;MODE_UNSPECIFIED&amp;quot;, &amp;quot;VALIDATION&amp;quot;, &amp;quot;ENFORCEMENT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for rollout in .
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentRolloutBlock : TerraformBlock
{
    /// <summary>
    /// This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the &#39;disruption_budget&#39; at least until this duration of time has passed after configuration changes are applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinWaitDuration is required")]
    public required TerraformProperty<string> MinWaitDuration
    {
        set => SetProperty("min_wait_duration", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_os_config_os_policy_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOsConfigOsPolicyAssignment : TerraformResource
{
    public GoogleOsConfigOsPolicyAssignment(string name) : base("google_os_config_os_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("baseline");
        SetOutput("deleted");
        SetOutput("etag");
        SetOutput("reconciling");
        SetOutput("revision_create_time");
        SetOutput("revision_id");
        SetOutput("rollout_state");
        SetOutput("uid");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("skip_await_rollout");
    }

    /// <summary>
    /// OS policy assignment description. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Set to true to skip awaiting rollout during resource creation and update.
    /// </summary>
    public TerraformProperty<bool> SkipAwaitRollout
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_await_rollout");
        set => SetProperty("skip_await_rollout", value);
    }

    /// <summary>
    /// Block for instance_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    public List<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock>? InstanceFilter
    {
        set => SetProperty("instance_filter", value);
    }

    /// <summary>
    /// Block for os_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsPolicies block(s) required")]
    public List<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock>? OsPolicies
    {
        set => SetProperty("os_policies", value);
    }

    /// <summary>
    /// Block for rollout.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rollout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public List<GoogleOsConfigOsPolicyAssignmentRolloutBlock>? Rollout
    {
        set => SetProperty("rollout", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOsConfigOsPolicyAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision.
    /// For a given OS policy assignment, there is only one revision with a value of &#39;true&#39; for this field.
    /// </summary>
    public TerraformExpression Baseline => this["baseline"];

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    public TerraformExpression Deleted => this["deleted"];

    /// <summary>
    /// The etag for this OS policy assignment. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress for the revision. This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. The timestamp that the revision was created.
    /// </summary>
    public TerraformExpression RevisionCreateTime => this["revision_create_time"];

    /// <summary>
    /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// Output only. OS policy assignment rollout state
    /// </summary>
    public TerraformExpression RolloutState => this["rollout_state"];

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
