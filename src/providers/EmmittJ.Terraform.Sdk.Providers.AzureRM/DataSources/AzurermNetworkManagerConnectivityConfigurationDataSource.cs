using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_network_manager_connectivity_configuration.
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationDataSource : TerraformDataSource
{
    public AzurermNetworkManagerConnectivityConfigurationDataSource(string name) : base("azurerm_network_manager_connectivity_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    [TerraformPropertyName("network_manager_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkManagerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    [TerraformPropertyName("applies_to_group")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AppliesToGroup => new TerraformReference(this, "applies_to_group");

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_topology")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectivityTopology => new TerraformReference(this, "connectivity_topology");

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    [TerraformPropertyName("delete_existing_peering_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeleteExistingPeeringEnabled => new TerraformReference(this, "delete_existing_peering_enabled");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    [TerraformPropertyName("global_mesh_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> GlobalMeshEnabled => new TerraformReference(this, "global_mesh_enabled");

    /// <summary>
    /// The hub attribute.
    /// </summary>
    [TerraformPropertyName("hub")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Hub => new TerraformReference(this, "hub");

}
