using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for link in .
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
        get => new TerraformReference<string>(this, "fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
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
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The speed_in_mbps attribute.
    /// </summary>
    public TerraformValue<double>? SpeedInMbps
    {
        get => new TerraformReference<double>(this, "speed_in_mbps");
        set => SetArgument("speed_in_mbps", value);
    }

}

/// <summary>
/// Block type for o365_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteO365PolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "o365_policy";

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "address_cidrs").ResolveNodes(ctx));
        set => SetArgument("address_cidrs", value);
    }

    /// <summary>
    /// The device_model attribute.
    /// </summary>
    public TerraformValue<string>? DeviceModel
    {
        get => new TerraformReference<string>(this, "device_model");
        set => SetArgument("device_model", value);
    }

    /// <summary>
    /// The device_vendor attribute.
    /// </summary>
    public TerraformValue<string>? DeviceVendor
    {
        get => new TerraformReference<string>(this, "device_vendor");
        set => SetArgument("device_vendor", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualWanId is required")]
    public required TerraformValue<string> VirtualWanId
    {
        get => new TerraformReference<string>(this, "virtual_wan_id");
        set => SetArgument("virtual_wan_id", value);
    }

    /// <summary>
    /// Link block (nesting mode: list).
    /// </summary>
    public AzurermVpnSiteLinkBlock? Link
    {
        get => GetArgument<AzurermVpnSiteLinkBlock>("link");
        set => SetArgument("link", value);
    }

    /// <summary>
    /// O365Policy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 O365Policy block(s) allowed")]
    public AzurermVpnSiteO365PolicyBlock? O365Policy
    {
        get => GetArgument<AzurermVpnSiteO365PolicyBlock>("o365_policy");
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
