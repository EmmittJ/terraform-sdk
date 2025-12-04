using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerIpamPoolDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerIpamPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_manager_ipam_pool Terraform data source.
/// Retrieves information about a azurerm_network_manager_ipam_pool.
/// </summary>
public partial class AzurermNetworkManagerIpamPoolDataSource(string name) : TerraformDataSource("azurerm_network_manager_ipam_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformValue<string> NetworkManagerId
    {
        get => GetArgument<TerraformValue<string>>("network_manager_id");
        set => SetArgument("network_manager_id", value);
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformList<string> AddressPrefixes
        => AsReference("address_prefixes");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The parent_pool_name attribute.
    /// </summary>
    public TerraformValue<string> ParentPoolName
        => AsReference("parent_pool_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerIpamPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerIpamPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
