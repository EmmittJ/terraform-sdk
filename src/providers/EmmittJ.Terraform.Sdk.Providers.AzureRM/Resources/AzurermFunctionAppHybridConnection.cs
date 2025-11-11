using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppHybridConnectionTimeoutsBlock
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
/// Manages a azurerm_function_app_hybrid_connection resource.
/// </summary>
public class AzurermFunctionAppHybridConnection : TerraformResource
{
    public AzurermFunctionAppHybridConnection(string name) : base("azurerm_function_app_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The ID of the Function App for this Hybrid Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformPropertyName("function_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionAppId { get; set; }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformPropertyName("relay_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RelayId { get; set; }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    [TerraformPropertyName("send_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SendKeyName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppHybridConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    [TerraformPropertyName("namespace_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamespaceName => new TerraformReference(this, "namespace_name");

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    [TerraformPropertyName("relay_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RelayName => new TerraformReference(this, "relay_name");

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    [TerraformPropertyName("send_key_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SendKeyValue => new TerraformReference(this, "send_key_value");

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    [TerraformPropertyName("service_bus_namespace")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceBusNamespace => new TerraformReference(this, "service_bus_namespace");

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    [TerraformPropertyName("service_bus_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceBusSuffix => new TerraformReference(this, "service_bus_suffix");

}
