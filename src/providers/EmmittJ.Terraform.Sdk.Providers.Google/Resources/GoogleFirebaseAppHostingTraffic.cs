using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rollout_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirebaseAppHostingTrafficRolloutPolicyBlock() : TerraformBlock("rollout_policy")
{
    /// <summary>
    /// Specifies a branch that triggers a new build to be started with this
    /// policy. If not set, no automatic rollouts will happen.
    /// </summary>
    [TerraformProperty("codebase_branch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CodebaseBranch { get; set; }

    /// <summary>
    /// A flag that, if true, prevents rollouts from being created via this RolloutPolicy.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }


}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirebaseAppHostingTrafficTargetBlock() : TerraformBlock("target")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppHostingTrafficTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_firebase_app_hosting_traffic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleFirebaseAppHostingTraffic : TerraformResource
{
    public GoogleFirebaseAppHostingTraffic(string name) : base("google_firebase_app_hosting_traffic", name)
    {
    }

    /// <summary>
    /// Id of the backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    [TerraformProperty("backend")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Backend { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location the Backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for rollout_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutPolicy block(s) allowed")]
    [TerraformProperty("rollout_policy")]
    public TerraformList<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock> RolloutPolicy { get; set; } = new();

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformProperty("target")]
    public TerraformList<GoogleFirebaseAppHostingTrafficTargetBlock> Target { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirebaseAppHostingTrafficTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Current state of traffic allocation for the backend.
    /// When setting &#39;target&#39;, this field may differ for some time until the desired state is reached.
    /// </summary>
    [TerraformProperty("current")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Current { get; }

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Identifier. The resource name of the backend traffic config
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/traffic&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
