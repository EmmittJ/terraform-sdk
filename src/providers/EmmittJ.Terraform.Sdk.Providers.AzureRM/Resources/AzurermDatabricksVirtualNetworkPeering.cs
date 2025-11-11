using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_databricks_virtual_network_peering resource.
/// </summary>
public partial class AzurermDatabricksVirtualNetworkPeering : TerraformResource
{
    public AzurermDatabricksVirtualNetworkPeering(string name) : base("azurerm_databricks_virtual_network_peering", name)
    {
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    [TerraformProperty("allow_forwarded_traffic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowForwardedTraffic { get; set; }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    [TerraformProperty("allow_gateway_transit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowGatewayTransit { get; set; }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    [TerraformProperty("allow_virtual_network_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowVirtualNetworkAccess { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The remote_address_space_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressSpacePrefixes is required")]
    [TerraformProperty("remote_address_space_prefixes")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? RemoteAddressSpacePrefixes { get; set; }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    [TerraformProperty("remote_virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RemoteVirtualNetworkId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    [TerraformProperty("use_remote_gateways")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseRemoteGateways { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_space_prefixes attribute.
    /// </summary>
    [TerraformProperty("address_space_prefixes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AddressSpacePrefixes { get; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualNetworkId { get; }

}
