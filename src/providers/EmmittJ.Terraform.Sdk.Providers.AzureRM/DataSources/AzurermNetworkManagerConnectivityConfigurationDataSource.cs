using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_network_manager_connectivity_configuration.
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfigurationDataSource : TerraformDataSource
{
    public AzurermNetworkManagerConnectivityConfigurationDataSource(string name) : base("azurerm_network_manager_connectivity_configuration", name)
    {
    }

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
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    [TerraformProperty("network_manager_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkManagerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    [TerraformProperty("applies_to_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AppliesToGroup { get; }

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [TerraformProperty("connectivity_topology")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectivityTopology { get; }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    [TerraformProperty("delete_existing_peering_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeleteExistingPeeringEnabled { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    [TerraformProperty("global_mesh_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> GlobalMeshEnabled { get; }

    /// <summary>
    /// The hub attribute.
    /// </summary>
    [TerraformProperty("hub")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Hub { get; }

}
