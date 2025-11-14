using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    [TerraformArgument("network_manager_id")]
    public required TerraformValue<string> NetworkManagerId
    {
        get => new TerraformReference<string>(this, "network_manager_id");
        set => SetArgument("network_manager_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    [TerraformArgument("applies_to_group")]
    public TerraformList<object> AppliesToGroup
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "applies_to_group").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [TerraformArgument("connectivity_topology")]
    public TerraformValue<string> ConnectivityTopology
    {
        get => new TerraformReference<string>(this, "connectivity_topology");
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    [TerraformArgument("delete_existing_peering_enabled")]
    public TerraformValue<bool> DeleteExistingPeeringEnabled
    {
        get => new TerraformReference<bool>(this, "delete_existing_peering_enabled");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    [TerraformArgument("global_mesh_enabled")]
    public TerraformValue<bool> GlobalMeshEnabled
    {
        get => new TerraformReference<bool>(this, "global_mesh_enabled");
    }

    /// <summary>
    /// The hub attribute.
    /// </summary>
    [TerraformArgument("hub")]
    public TerraformList<object> Hub
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "hub").ResolveNodes(ctx));
    }

}
