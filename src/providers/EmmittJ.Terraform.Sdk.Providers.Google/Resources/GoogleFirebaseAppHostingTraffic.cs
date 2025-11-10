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
        set => SetProperty("codebase_branch", value);
    }

    /// <summary>
    /// A flag that, if true, prevents rollouts from being created via this RolloutPolicy.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// If disabled is set, the time at which the rollouts were disabled.
    /// </summary>
    public TerraformProperty<string>? DisabledTime
    {
        set => SetProperty("disabled_time", value);
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
        SetOutput("create_time");
        SetOutput("current");
        SetOutput("delete_time");
        SetOutput("etag");
        SetOutput("name");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("backend");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Id of the backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformProperty<string> Backend
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend");
        set => SetProperty("backend", value);
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
    /// The location the Backend that this Traffic config applies to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for rollout_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutPolicy block(s) allowed")]
    public List<GoogleFirebaseAppHostingTrafficRolloutPolicyBlock>? RolloutPolicy
    {
        set => SetProperty("rollout_policy", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<GoogleFirebaseAppHostingTrafficTargetBlock>? Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaseAppHostingTrafficTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
