using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppHybridConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_function_app_hybrid_connection resource.
/// </summary>
public partial class AzurermFunctionAppHybridConnection : TerraformResource
{
    public AzurermFunctionAppHybridConnection(string name) : base("azurerm_function_app_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The ID of the Function App for this Hybrid Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformProperty("function_app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionAppId { get; set; }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformProperty("relay_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RelayId { get; set; }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    [TerraformProperty("send_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SendKeyName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFunctionAppHybridConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    [TerraformProperty("namespace_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NamespaceName { get; }

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    [TerraformProperty("relay_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RelayName { get; }

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    [TerraformProperty("send_key_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SendKeyValue { get; }

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    [TerraformProperty("service_bus_namespace")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceBusNamespace { get; }

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    [TerraformProperty("service_bus_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceBusSuffix { get; }

}
