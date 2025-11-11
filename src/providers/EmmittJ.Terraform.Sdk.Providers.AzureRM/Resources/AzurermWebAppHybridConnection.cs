using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWebAppHybridConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_web_app_hybrid_connection resource.
/// </summary>
public partial class AzurermWebAppHybridConnection : TerraformResource
{
    public AzurermWebAppHybridConnection(string name) : base("azurerm_web_app_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformProperty("relay_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RelayId { get; set; }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    [TerraformProperty("send_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SendKeyName { get; set; }

    /// <summary>
    /// The ID of the Web App for this Hybrid Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    [TerraformProperty("web_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WebAppId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermWebAppHybridConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    [TerraformProperty("namespace_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NamespaceName { get; }

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    [TerraformProperty("relay_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RelayName { get; }

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    [TerraformProperty("send_key_value")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SendKeyValue { get; }

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    [TerraformProperty("service_bus_namespace")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceBusNamespace { get; }

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    [TerraformProperty("service_bus_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceBusSuffix { get; }

}
