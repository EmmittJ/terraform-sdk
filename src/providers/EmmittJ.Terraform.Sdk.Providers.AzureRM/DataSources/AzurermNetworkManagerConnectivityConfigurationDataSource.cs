using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerConnectivityConfigurationDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_network_manager_connectivity_configuration Terraform data source.
/// Retrieves information about a azurerm_network_manager_connectivity_configuration.
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfigurationDataSource(string name) : TerraformDataSource("azurerm_network_manager_connectivity_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformValue<string> NetworkManagerId
    {
        get => new TerraformReference<string>(this, "network_manager_id");
        set => SetArgument("network_manager_id", value);
    }

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AppliesToGroup
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "applies_to_group").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    public TerraformValue<string> ConnectivityTopology
    {
        get => new TerraformReference<string>(this, "connectivity_topology");
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeleteExistingPeeringEnabled
    {
        get => new TerraformReference<bool>(this, "delete_existing_peering_enabled");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool> GlobalMeshEnabled
    {
        get => new TerraformReference<bool>(this, "global_mesh_enabled");
    }

    /// <summary>
    /// The hub attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Hub
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hub").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
