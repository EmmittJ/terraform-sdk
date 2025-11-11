using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeFlowhookTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_apigee_flowhook resource.
/// </summary>
public partial class GoogleApigeeFlowhook : TerraformResource
{
    public GoogleApigeeFlowhook(string name) : base("google_apigee_flowhook", name)
    {
    }

    /// <summary>
    /// Flag that specifies whether execution should continue if the flow hook throws an exception. Set to true to continue execution. Set to false to stop execution if the flow hook throws an exception. Defaults to true.
    /// </summary>
    [TerraformProperty("continue_on_error")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContinueOnError { get; set; }

    /// <summary>
    /// Description of the flow hook.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformProperty("environment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// Where in the API call flow the flow hook is invoked. Must be one of PreProxyFlowHook, PostProxyFlowHook, PreTargetFlowHook, or PostTargetFlowHook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowHookPoint is required")]
    [TerraformProperty("flow_hook_point")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FlowHookPoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Id of the Sharedflow attaching to a flowhook point.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sharedflow is required")]
    [TerraformProperty("sharedflow")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sharedflow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleApigeeFlowhookTimeoutsBlock>? Timeouts { get; set; }

}
