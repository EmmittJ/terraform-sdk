using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dry_run_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicyDryRunSpecBlock : TerraformBlock
{
    /// <summary>
    /// An opaque tag indicating the current version of the policy, used for concurrency control. This field is ignored if used in a &#39;CreatePolicy&#39; request. When the policy&#39; is returned from either a &#39;GetPolicy&#39; or a &#39;ListPolicies&#39; request, this &#39;etag&#39; indicates the version of the current policy to use when executing a read-modify-write loop. When the policy is returned from a &#39;GetEffectivePolicy&#39; request, the &#39;etag&#39; will be unset.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => WithProperty("etag", value);
    }

    /// <summary>
    /// Determines the inheritance behavior for this policy. If &#39;inherit_from_parent&#39; is true, policy rules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can be set only for policies which configure list constraints.
    /// </summary>
    public TerraformProperty<bool>? InheritFromParent
    {
        get => GetProperty<TerraformProperty<bool>>("inherit_from_parent");
        set => WithProperty("inherit_from_parent", value);
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the &#39;constraint_default&#39; enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, &#39;rules&#39; must be empty and &#39;inherit_from_parent&#39; must be set to false.
    /// </summary>
    public TerraformProperty<bool>? Reset
    {
        get => GetProperty<TerraformProperty<bool>>("reset");
        set => WithProperty("reset", value);
    }

    /// <summary>
    /// Output only. The time stamp this was previously updated. This represents the last time a call to &#39;CreatePolicy&#39; or &#39;UpdatePolicy&#39; was made for that policy.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        get => GetProperty<TerraformProperty<string>>("update_time");
        set => WithProperty("update_time", value);
    }

}

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicySpecBlock : TerraformBlock
{
    /// <summary>
    /// An opaque tag indicating the current version of the &#39;Policy&#39;, used for concurrency control. This field is ignored if used in a &#39;CreatePolicy&#39; request. When the &#39;Policy&#39; is returned from either a &#39;GetPolicy&#39; or a &#39;ListPolicies&#39; request, this &#39;etag&#39; indicates the version of the current &#39;Policy&#39; to use when executing a read-modify-write loop. When the &#39;Policy&#39; is returned from a &#39;GetEffectivePolicy&#39; request, the &#39;etag&#39; will be unset.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => WithProperty("etag", value);
    }

    /// <summary>
    /// Determines the inheritance behavior for this &#39;Policy&#39;. If &#39;inherit_from_parent&#39; is true, PolicyRules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this Policy becomes the new root for evaluation. This field can be set only for Policies which configure list constraints.
    /// </summary>
    public TerraformProperty<bool>? InheritFromParent
    {
        get => GetProperty<TerraformProperty<bool>>("inherit_from_parent");
        set => WithProperty("inherit_from_parent", value);
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the &#39;constraint_default&#39; enforcement behavior of the specific &#39;Constraint&#39; at this resource. This field can be set in policies for either list or boolean constraints. If set, &#39;rules&#39; must be empty and &#39;inherit_from_parent&#39; must be set to false.
    /// </summary>
    public TerraformProperty<bool>? Reset
    {
        get => GetProperty<TerraformProperty<bool>>("reset");
        set => WithProperty("reset", value);
    }

    /// <summary>
    /// Output only. The time stamp this was previously updated. This represents the last time a call to &#39;CreatePolicy&#39; or &#39;UpdatePolicy&#39; was made for that &#39;Policy&#39;.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        get => GetProperty<TerraformProperty<string>>("update_time");
        set => WithProperty("update_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOrgPolicyPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_org_policy_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOrgPolicyPolicy : TerraformResource
{
    public GoogleOrgPolicyPolicy(string name) : base("google_org_policy_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("etag");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * &#39;projects/{project_number}/policies/{constraint_name}&#39; * &#39;folders/{folder_id}/policies/{constraint_name}&#39; * &#39;organizations/{organization_id}/policies/{constraint_name}&#39; For example, &amp;quot;projects/123/policies/compute.disableSerialPortAccess&amp;quot;. Note: &#39;projects/{project_id}/policies/{constraint_name}&#39; is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for dry_run_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DryRunSpec block(s) allowed")]
    public List<GoogleOrgPolicyPolicyDryRunSpecBlock>? DryRunSpec
    {
        get => GetProperty<List<GoogleOrgPolicyPolicyDryRunSpecBlock>>("dry_run_spec");
        set => this.WithProperty("dry_run_spec", value);
    }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public List<GoogleOrgPolicyPolicySpecBlock>? Spec
    {
        get => GetProperty<List<GoogleOrgPolicyPolicySpecBlock>>("spec");
        set => this.WithProperty("spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOrgPolicyPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOrgPolicyPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This &#39;etag&#39; is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
