using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network_attached_data_network Terraform data source.
/// Retrieves information about a azurerm_mobile_network_attached_data_network.
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetworkDataSource(string name) : TerraformDataSource("azurerm_mobile_network_attached_data_network", name)
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
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    public required TerraformValue<string> MobileNetworkDataNetworkName
    {
        get => new TerraformReference<string>(this, "mobile_network_data_network_name");
        set => SetArgument("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    public required TerraformValue<string> MobileNetworkPacketCoreDataPlaneId
    {
        get => new TerraformReference<string>(this, "mobile_network_packet_core_data_plane_id");
        set => SetArgument("mobile_network_packet_core_data_plane_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
