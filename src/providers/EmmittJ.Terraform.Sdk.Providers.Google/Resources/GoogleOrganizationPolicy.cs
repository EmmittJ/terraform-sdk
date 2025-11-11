using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for boolean_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOrganizationPolicyBooleanPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, then the Policy is enforced. If false, then any configuration is acceptable.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enforced is required")]
    [TerraformProperty("enforced")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enforced { get; set; }

}

/// <summary>
/// Block type for list_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOrganizationPolicyListPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// If set to true, the values from the effective Policy of the parent resource are inherited, meaning the values set in this Policy are added to the values inherited up the hierarchy.
    /// </summary>
    [TerraformProperty("inherit_from_parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InheritFromParent { get; set; }

    /// <summary>
    /// The Google Cloud Console will try to default to a configuration that matches the value specified in this field.
    /// </summary>
    [TerraformProperty("suggested_value")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SuggestedValue { get; set; }

}

/// <summary>
/// Block type for restore_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOrganizationPolicyRestorePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// May only be set to true. If set, then the default Policy is restored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Default is required")]
    [TerraformProperty("default")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Default { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOrganizationPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_organization_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOrganizationPolicy : TerraformResource
{
    public GoogleOrganizationPolicy(string name) : base("google_organization_policy", name)
    {
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    [TerraformProperty("constraint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Constraint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Version { get; set; }

    /// <summary>
    /// Block for boolean_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BooleanPolicy block(s) allowed")]
    [TerraformProperty("boolean_policy")]
    public TerraformList<TerraformBlock<GoogleOrganizationPolicyBooleanPolicyBlock>>? BooleanPolicy { get; set; }

    /// <summary>
    /// Block for list_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ListPolicy block(s) allowed")]
    [TerraformProperty("list_policy")]
    public TerraformList<TerraformBlock<GoogleOrganizationPolicyListPolicyBlock>>? ListPolicy { get; set; }

    /// <summary>
    /// Block for restore_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestorePolicy block(s) allowed")]
    [TerraformProperty("restore_policy")]
    public TerraformList<TerraformBlock<GoogleOrganizationPolicyRestorePolicyBlock>>? RestorePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleOrganizationPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
