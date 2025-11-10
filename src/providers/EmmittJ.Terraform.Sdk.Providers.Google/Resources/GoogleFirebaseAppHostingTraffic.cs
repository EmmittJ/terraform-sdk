using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rollout_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficRolloutPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies a branch that triggers a new build to be started with this
    /// policy. If not set, no automatic rollouts will happen.
    /// </summary>
    [TerraformPropertyName("codebase_branch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CodebaseBranch { get; set; }

    /// <summary>
    /// A flag that, if true, prevents rollouts from being created via this RolloutPolicy.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// If disabled is set, the time at which the rollouts were disabled.
    /// </summary>
    [TerraformPropertyName("disabled_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisabledTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "disabled_time");

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficTargetBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingTrafficTimeoutsBlock : ITerraformBlock
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
/// Manages a google_firebase_app_hosting_traffic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirebaseAppHostingTraffic : TerraformResource
{
    public GoogleFirebaseAppHostingTraffic(string name) : base("google_firebase_app_hosting_traffic", name)
    {
    }

    /// <summary>
    /// Id of the backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    [TerraformPropertyName("backend")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Backend { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location the Backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for rollout_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutPolicy block(s) allowed")]
    [TerraformPropertyName("rollout_policy")]
    public TerraformList<TerraformBlock<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock>>? RolloutPolicy { get; set; } = new();

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    [TerraformPropertyName("target")]
    public TerraformList<TerraformBlock<GoogleFirebaseAppHostingTrafficTargetBlock>>? Target { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirebaseAppHostingTrafficTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Current state of traffic allocation for the backend.
    /// When setting &#39;target&#39;, this field may differ for some time until the desired state is reached.
    /// </summary>
    [TerraformPropertyName("current")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Current => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "current");

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Identifier. The resource name of the backend traffic config
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/traffic&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
