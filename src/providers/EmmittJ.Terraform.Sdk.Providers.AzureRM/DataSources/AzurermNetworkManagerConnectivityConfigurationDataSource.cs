using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    [TerraformPropertyName("network_manager_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkManagerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    [TerraformPropertyName("applies_to_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AppliesToGroup => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "applies_to_group");

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_topology")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectivityTopology => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connectivity_topology");

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    [TerraformPropertyName("delete_existing_peering_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeleteExistingPeeringEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "delete_existing_peering_enabled");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    [TerraformPropertyName("global_mesh_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> GlobalMeshEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "global_mesh_enabled");

    /// <summary>
    /// The hub attribute.
    /// </summary>
    [TerraformPropertyName("hub")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Hub => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hub");

}
