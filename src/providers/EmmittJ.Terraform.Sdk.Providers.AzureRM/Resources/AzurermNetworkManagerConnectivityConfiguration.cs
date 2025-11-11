using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for applies_to_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    [TerraformProperty("global_mesh_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GlobalMeshEnabled { get; set; }

    /// <summary>
    /// The group_connectivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupConnectivity is required")]
    [TerraformProperty("group_connectivity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GroupConnectivity { get; set; }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    [TerraformProperty("network_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkGroupId { get; set; }

    /// <summary>
    /// The use_hub_gateway attribute.
    /// </summary>
    [TerraformProperty("use_hub_gateway")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseHubGateway { get; set; }

}

/// <summary>
/// Block type for hub in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfigurationHubBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_network_manager_connectivity_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetworkManagerConnectivityConfiguration : TerraformResource
{
    public AzurermNetworkManagerConnectivityConfiguration(string name) : base("azurerm_network_manager_connectivity_configuration", name)
    {
    }

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectivityTopology is required")]
    [TerraformProperty("connectivity_topology")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectivityTopology { get; set; }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    [TerraformProperty("delete_existing_peering_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteExistingPeeringEnabled { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    [TerraformProperty("global_mesh_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GlobalMeshEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    [TerraformProperty("network_manager_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkManagerId { get; set; }

    /// <summary>
    /// Block for applies_to_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliesToGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AppliesToGroup block(s) required")]
    [TerraformProperty("applies_to_group")]
    public TerraformList<TerraformBlock<AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock>>? AppliesToGroup { get; set; }

    /// <summary>
    /// Block for hub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hub block(s) allowed")]
    [TerraformProperty("hub")]
    public TerraformList<TerraformBlock<AzurermNetworkManagerConnectivityConfigurationHubBlock>>? Hub { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
