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
    public bool? ContinueOnError
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("continue_on_error")?.Value;
        set => this.WithProperty("continue_on_error", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Description of the flow hook.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Where in the API call flow the flow hook is invoked. Must be one of PreProxyFlowHook, PostProxyFlowHook, PreTargetFlowHook, or PostTargetFlowHook.
    /// </summary>
    public string? FlowHookPoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("flow_hook_point")?.Value;
        set => this.WithProperty("flow_hook_point", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the environment
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Id of the Sharedflow attaching to a flowhook point.
    /// </summary>
    public string? Sharedflow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sharedflow")?.Value;
        set => this.WithProperty("sharedflow", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
