using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeFlowhook.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeFlowhookTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_apigee_flowhook Terraform resource.
/// Manages a google_apigee_flowhook resource.
/// </summary>
public partial class GoogleApigeeFlowhook(string name) : TerraformResource("google_apigee_flowhook", name)
{
    /// <summary>
    /// Flag that specifies whether execution should continue if the flow hook throws an exception. Set to true to continue execution. Set to false to stop execution if the flow hook throws an exception. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? ContinueOnError
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_error");
        set => SetArgument("continue_on_error", value);
    }

    /// <summary>
    /// Description of the flow hook.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetRequiredArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// Where in the API call flow the flow hook is invoked. Must be one of PreProxyFlowHook, PostProxyFlowHook, PreTargetFlowHook, or PostTargetFlowHook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowHookPoint is required")]
    public required TerraformValue<string> FlowHookPoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("flow_hook_point");
        set => SetArgument("flow_hook_point", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Id of the Sharedflow attaching to a flowhook point.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sharedflow is required")]
    public required TerraformValue<string> Sharedflow
    {
        get => GetRequiredArgument<TerraformValue<string>>("sharedflow");
        set => SetArgument("sharedflow", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeFlowhookTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeFlowhookTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
