using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceHybridConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_app_service_hybrid_connection resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppServiceHybridConnection : TerraformResource
{
    public AzurermAppServiceHybridConnection(string name) : base("azurerm_app_service_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    [TerraformProperty("app_service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppServiceName { get; set; }

    /// <summary>
    /// The hostname attribute.
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
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The relay_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformProperty("relay_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RelayId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The send_key_name attribute.
    /// </summary>
    [TerraformProperty("send_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SendKeyName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppServiceHybridConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformProperty("namespace_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NamespaceName { get; }

    /// <summary>
    /// The relay_name attribute.
    /// </summary>
    [TerraformProperty("relay_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RelayName { get; }

    /// <summary>
    /// The send_key_value attribute.
    /// </summary>
    [TerraformProperty("send_key_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SendKeyValue { get; }

    /// <summary>
    /// The service_bus_namespace attribute.
    /// </summary>
    [TerraformProperty("service_bus_namespace")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceBusNamespace { get; }

    /// <summary>
    /// The service_bus_suffix attribute.
    /// </summary>
    [TerraformProperty("service_bus_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceBusSuffix { get; }

}
