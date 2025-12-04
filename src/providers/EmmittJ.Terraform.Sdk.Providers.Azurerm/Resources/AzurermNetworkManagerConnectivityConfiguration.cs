using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for applies_to_group in AzurermNetworkManagerConnectivityConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "applies_to_group";

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GlobalMeshEnabled
    {
        get => GetArgument<TerraformValue<bool>>("global_mesh_enabled");
        set => SetArgument("global_mesh_enabled", value);
    }

    /// <summary>
    /// The group_connectivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupConnectivity is required")]
    public required TerraformValue<string> GroupConnectivity
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_connectivity");
        set => SetArgument("group_connectivity", value);
    }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    public required TerraformValue<string> NetworkGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_group_id");
        set => SetArgument("network_group_id", value);
    }

    /// <summary>
    /// The use_hub_gateway attribute.
    /// </summary>
    public TerraformValue<bool>? UseHubGateway
    {
        get => GetArgument<TerraformValue<bool>>("use_hub_gateway");
        set => SetArgument("use_hub_gateway", value);
    }

}


/// <summary>
/// Block type for hub in AzurermNetworkManagerConnectivityConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationHubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hub";

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkManagerConnectivityConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_network_manager_connectivity_configuration Terraform resource.
/// Manages a azurerm_network_manager_connectivity_configuration resource.
/// </summary>
public partial class AzurermNetworkManagerConnectivityConfiguration(string name) : TerraformResource("azurerm_network_manager_connectivity_configuration", name)
{
    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectivityTopology is required")]
    public required TerraformValue<string> ConnectivityTopology
    {
        get => GetRequiredArgument<TerraformValue<string>>("connectivity_topology");
        set => SetArgument("connectivity_topology", value);
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteExistingPeeringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("delete_existing_peering_enabled");
        set => SetArgument("delete_existing_peering_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GlobalMeshEnabled
    {
        get => GetArgument<TerraformValue<bool>>("global_mesh_enabled");
        set => SetArgument("global_mesh_enabled", value);
    }

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
    /// AppliesToGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliesToGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AppliesToGroup block(s) required")]
    public required TerraformList<AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock> AppliesToGroup
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock>>("applies_to_group");
        set => SetArgument("applies_to_group", value);
    }

    /// <summary>
    /// Hub block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hub block(s) allowed")]
    public TerraformList<AzurermNetworkManagerConnectivityConfigurationHubBlock>? Hub
    {
        get => GetArgument<TerraformList<AzurermNetworkManagerConnectivityConfigurationHubBlock>>("hub");
        set => SetArgument("hub", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
