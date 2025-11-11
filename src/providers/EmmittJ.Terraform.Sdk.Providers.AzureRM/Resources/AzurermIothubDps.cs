using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_filter_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubDpsIpFilterRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    [TerraformProperty("ip_mask")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpMask { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformProperty("target")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Target { get; set; }

}

/// <summary>
/// Block type for linked_hub in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubDpsLinkedHubBlock : TerraformBlockBase
{
    /// <summary>
    /// The allocation_weight attribute.
    /// </summary>
    [TerraformProperty("allocation_weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AllocationWeight { get; set; }

    /// <summary>
    /// The apply_allocation_policy attribute.
    /// </summary>
    [TerraformProperty("apply_allocation_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyAllocationPolicy { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformProperty("connection_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionString { get; set; }


    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubDpsSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIothubDpsTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_iothub_dps resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermIothubDps : TerraformResource
{
    public AzurermIothubDps(string name) : base("azurerm_iothub_dps", name)
    {
    }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    [TerraformProperty("allocation_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationPolicy { get; set; }

    /// <summary>
    /// The data_residency_enabled attribute.
    /// </summary>
    [TerraformProperty("data_residency_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DataResidencyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ip_filter_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ip_filter_rule")]
    public partial TerraformList<TerraformBlock<AzurermIothubDpsIpFilterRuleBlock>>? IpFilterRule { get; set; }

    /// <summary>
    /// Block for linked_hub.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("linked_hub")]
    public partial TerraformList<TerraformBlock<AzurermIothubDpsLinkedHubBlock>>? LinkedHub { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public partial TerraformList<TerraformBlock<AzurermIothubDpsSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermIothubDpsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    [TerraformProperty("device_provisioning_host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeviceProvisioningHostName { get; }

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    [TerraformProperty("id_scope")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdScope { get; }

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    [TerraformProperty("service_operations_host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceOperationsHostName { get; }

}
