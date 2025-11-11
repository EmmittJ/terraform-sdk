using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceHybridConnectionTimeoutsBlock
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
/// Manages a azurerm_app_service_hybrid_connection resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAppServiceHybridConnection : TerraformResource
{
    public AzurermAppServiceHybridConnection(string name) : base("azurerm_app_service_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    [TerraformPropertyName("app_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppServiceName { get; set; }

    /// <summary>
    /// The hostname attribute.
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
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The relay_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformPropertyName("relay_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RelayId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The send_key_name attribute.
    /// </summary>
    [TerraformPropertyName("send_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SendKeyName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceHybridConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformPropertyName("namespace_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamespaceName => new TerraformReference(this, "namespace_name");

    /// <summary>
    /// The relay_name attribute.
    /// </summary>
    [TerraformPropertyName("relay_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RelayName => new TerraformReference(this, "relay_name");

    /// <summary>
    /// The send_key_value attribute.
    /// </summary>
    [TerraformPropertyName("send_key_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SendKeyValue => new TerraformReference(this, "send_key_value");

    /// <summary>
    /// The service_bus_namespace attribute.
    /// </summary>
    [TerraformPropertyName("service_bus_namespace")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceBusNamespace => new TerraformReference(this, "service_bus_namespace");

    /// <summary>
    /// The service_bus_suffix attribute.
    /// </summary>
    [TerraformPropertyName("service_bus_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceBusSuffix => new TerraformReference(this, "service_bus_suffix");

}
