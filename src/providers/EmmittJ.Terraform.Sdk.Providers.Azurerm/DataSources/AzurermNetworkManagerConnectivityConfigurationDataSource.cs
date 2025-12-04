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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformValue<string> NetworkManagerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_manager_id");
        set => SetArgument("network_manager_id", value);
    }

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AppliesToGroup
        => AsReference("applies_to_group");

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    public TerraformValue<string> ConnectivityTopology
        => AsReference("connectivity_topology");

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeleteExistingPeeringEnabled
        => AsReference("delete_existing_peering_enabled");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool> GlobalMeshEnabled
        => AsReference("global_mesh_enabled");

    /// <summary>
    /// The hub attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Hub
        => AsReference("hub");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
