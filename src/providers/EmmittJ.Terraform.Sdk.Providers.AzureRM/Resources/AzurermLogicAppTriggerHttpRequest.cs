using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppTriggerHttpRequestTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_trigger_http_request resource.
/// </summary>
public class AzurermLogicAppTriggerHttpRequest : TerraformResource
{
    public AzurermLogicAppTriggerHttpRequest(string name) : base("azurerm_logic_app_trigger_http_request", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    [TerraformPropertyName("logic_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogicAppId { get; set; }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [TerraformPropertyName("method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Method { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The relative_path attribute.
    /// </summary>
    [TerraformPropertyName("relative_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RelativePath { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [TerraformPropertyName("schema")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Schema { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogicAppTriggerHttpRequestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The callback_url attribute.
    /// </summary>
    [TerraformPropertyName("callback_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CallbackUrl => new TerraformReference(this, "callback_url");

}
