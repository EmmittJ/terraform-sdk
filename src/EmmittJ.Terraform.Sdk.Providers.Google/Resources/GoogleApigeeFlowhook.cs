using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    }

    /// <summary>
    /// Flag that specifies whether execution should continue if the flow hook throws an exception. Set to true to continue execution. Set to false to stop execution if the flow hook throws an exception. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? ContinueOnError
    {
        get => GetProperty<TerraformProperty<bool>>("continue_on_error");
        set => this.WithProperty("continue_on_error", value);
    }

    /// <summary>
    /// Description of the flow hook.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// Where in the API call flow the flow hook is invoked. Must be one of PreProxyFlowHook, PostProxyFlowHook, PreTargetFlowHook, or PostTargetFlowHook.
    /// </summary>
    public TerraformProperty<string>? FlowHookPoint
    {
        get => GetProperty<TerraformProperty<string>>("flow_hook_point");
        set => this.WithProperty("flow_hook_point", value);
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
    /// The Apigee Organization associated with the environment
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Id of the Sharedflow attaching to a flowhook point.
    /// </summary>
    public TerraformProperty<string>? Sharedflow
    {
        get => GetProperty<TerraformProperty<string>>("sharedflow");
        set => this.WithProperty("sharedflow", value);
    }

}
