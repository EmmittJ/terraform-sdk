using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIamWorkloadIdentityPoolTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_iam_workload_identity_pool resource.
/// </summary>
public partial class GoogleIamWorkloadIdentityPool : TerraformResource
{
    public GoogleIamWorkloadIdentityPool(string name) : base("google_iam_workload_identity_pool", name)
    {
    }

    /// <summary>
    /// A description of the pool. Cannot exceed 256 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether the pool is disabled. You cannot use a disabled pool to exchange tokens, or use
    /// existing tokens to access resources. If the pool is re-enabled, existing tokens grant
    /// access again.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// A display name for the pool. Cannot exceed 32 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The ID to use for the pool, which becomes the final component of the resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// &#39;gcp-&#39; is reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadIdentityPoolId is required")]
    [TerraformProperty("workload_identity_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkloadIdentityPoolId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleIamWorkloadIdentityPoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the pool as
    /// &#39;projects/{project_number}/locations/global/workloadIdentityPools/{workload_identity_pool_id}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The state of the pool.
    /// * &#39;STATE_UNSPECIFIED&#39;: State unspecified.
    /// * &#39;ACTIVE&#39;: The pool is active, and may be used in Google Cloud policies.
    /// * &#39;DELETED&#39;: The pool is soft-deleted. Soft-deleted pools are permanently deleted after
    ///   approximately 30 days. You can restore a soft-deleted pool using
    ///   &#39;UndeleteWorkloadIdentityPool&#39;. You cannot reuse the ID of a soft-deleted pool until it is
    ///   permanently deleted. While a pool is deleted, you cannot use it to exchange tokens, or
    ///   use existing tokens to access resources. If the pool is undeleted, existing tokens grant
    ///   access again.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
