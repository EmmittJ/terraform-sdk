using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVpnGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_vpn_gateway Terraform data source.
/// Retrieves information about a azurerm_vpn_gateway.
/// </summary>
public partial class AzurermVpnGatewayDataSource(string name) : TerraformDataSource("azurerm_vpn_gateway", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BgpSettings
        => AsReference("bgp_settings");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
        => AsReference("ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    public TerraformValue<double> ScaleUnit
        => AsReference("scale_unit");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualHubId
        => AsReference("virtual_hub_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
