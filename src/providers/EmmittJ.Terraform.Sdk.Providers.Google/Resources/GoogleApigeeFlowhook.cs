using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeFlowhookTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_apigee_flowhook resource.
/// </summary>
public class GoogleApigeeFlowhook : TerraformResource
{
    public GoogleApigeeFlowhook(string name) : base("google_apigee_flowhook", name)
    {
    }

    /// <summary>
    /// Flag that specifies whether execution should continue if the flow hook throws an exception. Set to true to continue execution. Set to false to stop execution if the flow hook throws an exception. Defaults to true.
    /// </summary>
    [TerraformPropertyName("continue_on_error")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContinueOnError { get; set; }

    /// <summary>
    /// Description of the flow hook.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformPropertyName("environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Environment { get; set; }

    /// <summary>
    /// Where in the API call flow the flow hook is invoked. Must be one of PreProxyFlowHook, PostProxyFlowHook, PreTargetFlowHook, or PostTargetFlowHook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowHookPoint is required")]
    [TerraformPropertyName("flow_hook_point")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FlowHookPoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The Apigee Organization associated with the environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// Id of the Sharedflow attaching to a flowhook point.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sharedflow is required")]
    [TerraformPropertyName("sharedflow")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sharedflow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeFlowhookTimeoutsBlock>? Timeouts { get; set; } = new();

}
