using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkInterfaceBackendAddressPoolAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_network_interface_backend_address_pool_association resource.
/// </summary>
public partial class AzurermNetworkInterfaceBackendAddressPoolAssociation : TerraformResource
{
    public AzurermNetworkInterfaceBackendAddressPoolAssociation(string name) : base("azurerm_network_interface_backend_address_pool_association", name)
    {
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    [TerraformProperty("backend_address_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackendAddressPoolId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurationName is required")]
    [TerraformProperty("ip_configuration_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpConfigurationName { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkInterfaceBackendAddressPoolAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
