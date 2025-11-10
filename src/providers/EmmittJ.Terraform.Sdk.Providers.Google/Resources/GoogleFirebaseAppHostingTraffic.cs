using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rollout_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficRolloutPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies a branch that triggers a new build to be started with this
    /// policy. If not set, no automatic rollouts will happen.
    /// </summary>
    public TerraformProperty<string>? CodebaseBranch
    {
        get => GetProperty<TerraformProperty<string>>("codebase_branch");
        set => WithProperty("codebase_branch", value);
    }

    /// <summary>
    /// A flag that, if true, prevents rollouts from being created via this RolloutPolicy.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => WithProperty("disabled", value);
    }

    /// <summary>
    /// If disabled is set, the time at which the rollouts were disabled.
    /// </summary>
    public TerraformProperty<string>? DisabledTime
    {
        get => GetProperty<TerraformProperty<string>>("disabled_time");
        set => WithProperty("disabled_time", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingTrafficTargetBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingTrafficTimeoutsBlock : TerraformBlock
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
/// Manages a google_firebase_app_hosting_traffic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirebaseAppHostingTraffic : TerraformResource
{
    public GoogleFirebaseAppHostingTraffic(string name) : base("google_firebase_app_hosting_traffic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("current");
        this.WithOutput("delete_time");
        this.WithOutput("etag");
        this.WithOutput("name");
        this.WithOutput("uid");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Id of the backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformProperty<string> Backend
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backend");
        set => this.WithProperty("backend", value);
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
    /// The location the Backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for rollout_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutPolicy block(s) allowed")]
    public List<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock>? RolloutPolicy
    {
        get => GetProperty<List<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock>>("rollout_policy");
        set => this.WithProperty("rollout_policy", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<GoogleFirebaseAppHostingTrafficTargetBlock>? Target
    {
        get => GetProperty<List<GoogleFirebaseAppHostingTrafficTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaseAppHostingTrafficTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFirebaseAppHostingTrafficTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time at which the backend was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Current state of traffic allocation for the backend.
    /// When setting &#39;target&#39;, this field may differ for some time until the desired state is reached.
    /// </summary>
    public TerraformExpression Current => this["current"];

    /// <summary>
    /// Time at which the backend was deleted.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. The resource name of the backend traffic config
    /// 
    /// Format:
    /// 
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/traffic&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time at which the backend was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
