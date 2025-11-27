using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rollout_policy in GoogleFirebaseAppHostingTraffic.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficRolloutPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout_policy";

    /// <summary>
    /// Specifies a branch that triggers a new build to be started with this
    /// policy. If not set, no automatic rollouts will happen.
    /// </summary>
    public TerraformValue<string>? CodebaseBranch
    {
        get => new TerraformReference<string>(this, "codebase_branch");
        set => SetArgument("codebase_branch", value);
    }

    /// <summary>
    /// A flag that, if true, prevents rollouts from being created via this RolloutPolicy.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// If disabled is set, the time at which the rollouts were disabled.
    /// </summary>
    public TerraformValue<string> DisabledTime
    {
        get => new TerraformReference<string>(this, "disabled_time");
    }

}


/// <summary>
/// Block type for target in GoogleFirebaseAppHostingTraffic.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// Splits block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Splits is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Splits block(s) required")]
    public required TerraformList<GoogleFirebaseAppHostingTrafficTargetBlockSplitsBlock> Splits
    {
        get => GetRequiredArgument<TerraformList<GoogleFirebaseAppHostingTrafficTargetBlockSplitsBlock>>("splits");
        set => SetArgument("splits", value);
    }

}

/// <summary>
/// Block type for splits in GoogleFirebaseAppHostingTrafficTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficTargetBlockSplitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "splits";

    /// <summary>
    /// The build that traffic is being routed to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Build is required")]
    public required TerraformValue<string> Build
    {
        get => new TerraformReference<string>(this, "build");
        set => SetArgument("build", value);
    }

    /// <summary>
    /// The percentage of traffic to send to the build. Currently must be 100 or 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percent is required")]
    public required TerraformValue<double> Percent
    {
        get => new TerraformReference<double>(this, "percent");
        set => SetArgument("percent", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFirebaseAppHostingTraffic.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingTrafficTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_hosting_traffic Terraform resource.
/// Manages a google_firebase_app_hosting_traffic resource.
/// </summary>
public partial class GoogleFirebaseAppHostingTraffic(string name) : TerraformResource("google_firebase_app_hosting_traffic", name)
{
    /// <summary>
    /// Id of the backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformValue<string> Backend
    {
        get => new TerraformReference<string>(this, "backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location the Backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Current state of traffic allocation for the backend.
    /// When setting &#39;target&#39;, this field may differ for some time until the desired state is reached.
    /// </summary>
    public TerraformList<TerraformMap<object>> Current
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "current").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Identifier. The resource name of the backend traffic config
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/traffic&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// RolloutPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutPolicy block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock>? RolloutPolicy
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock>>("rollout_policy");
        set => SetArgument("rollout_policy", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public TerraformList<GoogleFirebaseAppHostingTrafficTargetBlock>? Target
    {
        get => GetArgument<TerraformList<GoogleFirebaseAppHostingTrafficTargetBlock>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppHostingTrafficTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppHostingTrafficTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
