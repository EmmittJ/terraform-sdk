using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeFlowhookTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_apigee_flowhook resource.
/// </summary>
public class GoogleApigeeFlowhook : TerraformResource
{
    public GoogleApigeeFlowhook(string name) : base("google_apigee_flowhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("continue_on_error");
        SetOutput("description");
        SetOutput("environment");
        SetOutput("flow_hook_point");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("sharedflow");
    }

    /// <summary>
    /// Flag that specifies whether execution should continue if the flow hook throws an exception. Set to true to continue execution. Set to false to stop execution if the flow hook throws an exception. Defaults to true.
    /// </summary>
    public TerraformProperty<bool> ContinueOnError
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("continue_on_error");
        set => SetProperty("continue_on_error", value);
    }

    /// <summary>
    /// Description of the flow hook.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// Where in the API call flow the flow hook is invoked. Must be one of PreProxyFlowHook, PostProxyFlowHook, PreTargetFlowHook, or PostTargetFlowHook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowHookPoint is required")]
    public required TerraformProperty<string> FlowHookPoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("flow_hook_point");
        set => SetProperty("flow_hook_point", value);
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
    /// The Apigee Organization associated with the environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Id of the Sharedflow attaching to a flowhook point.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sharedflow is required")]
    public required TerraformProperty<string> Sharedflow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sharedflow");
        set => SetProperty("sharedflow", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeFlowhookTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
