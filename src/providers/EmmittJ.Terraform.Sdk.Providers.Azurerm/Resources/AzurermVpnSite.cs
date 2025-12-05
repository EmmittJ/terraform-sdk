using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for link in AzurermVpnSite.
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteLinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "link";

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string>? Fqdn
    {
        get => GetArgument<TerraformValue<string>>("fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
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
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => GetArgument<TerraformValue<string>>("provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The speed_in_mbps attribute.
    /// </summary>
    public TerraformValue<double>? SpeedInMbps
    {
        get => GetArgument<TerraformValue<double>>("speed_in_mbps");
        set => SetArgument("speed_in_mbps", value);
    }

    /// <summary>
    /// Bgp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bgp block(s) allowed")]
    public TerraformList<AzurermVpnSiteLinkBlockBgpBlock>? Bgp
    {
        get => GetArgument<TerraformList<AzurermVpnSiteLinkBlockBgpBlock>>("bgp");
        set => SetArgument("bgp", value);
    }

}

/// <summary>
/// Block type for bgp in AzurermVpnSiteLinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteLinkBlockBgpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp";

    /// <summary>
    /// The asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformValue<double> Asn
    {
        get => GetRequiredArgument<TerraformValue<double>>("asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The peering_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringAddress is required")]
    public required TerraformValue<string> PeeringAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("peering_address");
        set => SetArgument("peering_address", value);
    }

}


/// <summary>
/// Block type for o365_policy in AzurermVpnSite.
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteO365PolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "o365_policy";

    /// <summary>
    /// TrafficCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficCategory block(s) allowed")]
    public TerraformList<AzurermVpnSiteO365PolicyBlockTrafficCategoryBlock>? TrafficCategory
    {
        get => GetArgument<TerraformList<AzurermVpnSiteO365PolicyBlockTrafficCategoryBlock>>("traffic_category");
        set => SetArgument("traffic_category", value);
    }

}

/// <summary>
/// Block type for traffic_category in AzurermVpnSiteO365PolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteO365PolicyBlockTrafficCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_category";

    /// <summary>
    /// The allow_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AllowEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("allow_endpoint_enabled");
        set => SetArgument("allow_endpoint_enabled", value);
    }

    /// <summary>
    /// The default_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("default_endpoint_enabled");
        set => SetArgument("default_endpoint_enabled", value);
    }

    /// <summary>
    /// The optimize_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OptimizeEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("optimize_endpoint_enabled");
        set => SetArgument("optimize_endpoint_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVpnSite.
/// Nesting mode: single
/// </summary>
public class AzurermVpnSiteTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_vpn_site Terraform resource.
/// Manages a azurerm_vpn_site resource.
/// </summary>
public partial class AzurermVpnSite(string name) : TerraformResource("azurerm_vpn_site", name)
{
    /// <summary>
    /// The address_cidrs attribute.
    /// </summary>
    public TerraformSet<string>? AddressCidrs
    {
        get => GetArgument<TerraformSet<string>>("address_cidrs");
        set => SetArgument("address_cidrs", value);
    }

    /// <summary>
    /// The device_model attribute.
    /// </summary>
    public TerraformValue<string>? DeviceModel
    {
        get => GetArgument<TerraformValue<string>>("device_model");
        set => SetArgument("device_model", value);
    }

    /// <summary>
    /// The device_vendor attribute.
    /// </summary>
    public TerraformValue<string>? DeviceVendor
    {
        get => GetArgument<TerraformValue<string>>("device_vendor");
        set => SetArgument("device_vendor", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualWanId is required")]
    public required TerraformValue<string> VirtualWanId
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_wan_id");
        set => SetArgument("virtual_wan_id", value);
    }

    /// <summary>
    /// Link block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVpnSiteLinkBlock>? Link
    {
        get => GetArgument<TerraformList<AzurermVpnSiteLinkBlock>>("link");
        set => SetArgument("link", value);
    }

    /// <summary>
    /// O365Policy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 O365Policy block(s) allowed")]
    public TerraformList<AzurermVpnSiteO365PolicyBlock>? O365Policy
    {
        get => GetArgument<TerraformList<AzurermVpnSiteO365PolicyBlock>>("o365_policy");
        set => SetArgument("o365_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnSiteTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnSiteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
