using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dry_run_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOrgPolicyPolicyDryRunSpecBlock() : TerraformBlock("dry_run_spec")
{

    /// <summary>
    /// Determines the inheritance behavior for this policy. If &#39;inherit_from_parent&#39; is true, policy rules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can be set only for policies which configure list constraints.
    /// </summary>
    [TerraformProperty("inherit_from_parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InheritFromParent { get; set; }

    /// <summary>
    /// Ignores policies set above this resource and restores the &#39;constraint_default&#39; enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, &#39;rules&#39; must be empty and &#39;inherit_from_parent&#39; must be set to false.
    /// </summary>
    [TerraformProperty("reset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Reset { get; set; }


}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOrgPolicyPolicySpecBlock() : TerraformBlock("spec")
{

    /// <summary>
    /// Determines the inheritance behavior for this &#39;Policy&#39;. If &#39;inherit_from_parent&#39; is true, PolicyRules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this Policy becomes the new root for evaluation. This field can be set only for Policies which configure list constraints.
    /// </summary>
    [TerraformProperty("inherit_from_parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InheritFromParent { get; set; }

    /// <summary>
    /// Ignores policies set above this resource and restores the &#39;constraint_default&#39; enforcement behavior of the specific &#39;Constraint&#39; at this resource. This field can be set in policies for either list or boolean constraints. If set, &#39;rules&#39; must be empty and &#39;inherit_from_parent&#39; must be set to false.
    /// </summary>
    [TerraformProperty("reset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Reset { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOrgPolicyPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_org_policy_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOrgPolicyPolicy : TerraformResource
{
    public GoogleOrgPolicyPolicy(string name) : base("google_org_policy_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * &#39;projects/{project_number}/policies/{constraint_name}&#39; * &#39;folders/{folder_id}/policies/{constraint_name}&#39; * &#39;organizations/{organization_id}/policies/{constraint_name}&#39; For example, &amp;quot;projects/123/policies/compute.disableSerialPortAccess&amp;quot;. Note: &#39;projects/{project_id}/policies/{constraint_name}&#39; is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for dry_run_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DryRunSpec block(s) allowed")]
    [TerraformProperty("dry_run_spec")]
    public TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlock> DryRunSpec { get; set; } = new();

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    [TerraformProperty("spec")]
    public TerraformList<GoogleOrgPolicyPolicySpecBlock> Spec { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleOrgPolicyPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This &#39;etag&#39; is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

}
