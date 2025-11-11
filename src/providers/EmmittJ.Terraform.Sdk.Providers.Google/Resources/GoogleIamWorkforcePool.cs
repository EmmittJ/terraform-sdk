using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_restrictions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIamWorkforcePoolAccessRestrictionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Disable programmatic sign-in by disabling token issue via the Security Token API endpoint.
    /// See [Security Token Service API](https://cloud.google.com/iam/docs/reference/sts/rest).
    /// </summary>
    [TerraformProperty("disable_programmatic_signin")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableProgrammaticSignin { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIamWorkforcePoolTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_iam_workforce_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIamWorkforcePool : TerraformResource
{
    public GoogleIamWorkforcePool(string name) : base("google_iam_workforce_pool", name)
    {
    }

    /// <summary>
    /// A user-specified description of the pool. Cannot exceed 256 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens,
    /// or use existing tokens to access resources. If the pool is re-enabled, existing tokens grant access again.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// A user-specified display name of the pool in Google Cloud Console. Cannot exceed 32 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The resource name of the parent. Format: &#39;organizations/{org-id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Duration that the Google Cloud access tokens, console sign-in sessions,
    /// and &#39;gcloud&#39; sign-in sessions from this pool are valid.
    /// Must be greater than 15 minutes (900s) and less than 12 hours (43200s).
    /// If &#39;sessionDuration&#39; is not configured, minted credentials have a default duration of one hour (3600s).
    /// A duration in seconds with up to nine fractional digits, ending with &#39;&#39;s&#39;&#39;. Example: &amp;quot;&#39;3.5s&#39;&amp;quot;.
    /// </summary>
    [TerraformProperty("session_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SessionDuration { get; set; }

    /// <summary>
    /// The name of the pool. The ID must be a globally unique string of 6 to 63 lowercase letters,
    /// digits, or hyphens. It must start with a letter, and cannot have a trailing hyphen.
    /// The prefix &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    [TerraformProperty("workforce_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkforcePoolId { get; set; }

    /// <summary>
    /// Block for access_restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessRestrictions block(s) allowed")]
    [TerraformProperty("access_restrictions")]
    public partial TerraformList<TerraformBlock<GoogleIamWorkforcePoolAccessRestrictionsBlock>>? AccessRestrictions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleIamWorkforcePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The resource name of the pool.
    /// Format: &#39;locations/{location}/workforcePools/{workforcePoolId}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The state of the pool.
    ///  * STATE_UNSPECIFIED: State unspecified.
    ///  * ACTIVE: The pool is active, and may be used in Google Cloud policies.
    ///  * DELETED: The pool is soft-deleted. Soft-deleted pools are permanently deleted
    ///    after approximately 30 days. You can restore a soft-deleted pool using
    ///    [workforcePools.undelete](https://cloud.google.com/iam/docs/reference/rest/v1/locations.workforcePools/undelete#google.iam.admin.v1.WorkforcePools.UndeleteWorkforcePool).
    ///    You cannot reuse the ID of a soft-deleted pool until it is permanently deleted.
    ///    While a pool is deleted, you cannot use it to exchange tokens, or use
    ///    existing tokens to access resources. If the pool is undeleted, existing
    ///    tokens grant access again.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
