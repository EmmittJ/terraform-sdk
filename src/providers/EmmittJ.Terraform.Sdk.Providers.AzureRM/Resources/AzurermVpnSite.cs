using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for link in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteLinkBlock : TerraformBlock
{
    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        set => SetProperty("fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProviderName
    {
        set => SetProperty("provider_name", value);
    }

    /// <summary>
    /// The speed_in_mbps attribute.
    /// </summary>
    public TerraformProperty<double>? SpeedInMbps
    {
        set => SetProperty("speed_in_mbps", value);
    }

}

/// <summary>
/// Block type for o365_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnSiteO365PolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnSiteTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_vpn_site resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVpnSite : TerraformResource
{
    public AzurermVpnSite(string name) : base("azurerm_vpn_site", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_cidrs");
        SetOutput("device_model");
        SetOutput("device_vendor");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("virtual_wan_id");
    }

    /// <summary>
    /// The address_cidrs attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AddressCidrs
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("address_cidrs");
        set => SetProperty("address_cidrs", value);
    }

    /// <summary>
    /// The device_model attribute.
    /// </summary>
    public TerraformProperty<string> DeviceModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_model");
        set => SetProperty("device_model", value);
    }

    /// <summary>
    /// The device_vendor attribute.
    /// </summary>
    public TerraformProperty<string> DeviceVendor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_vendor");
        set => SetProperty("device_vendor", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualWanId is required")]
    public required TerraformProperty<string> VirtualWanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_wan_id");
        set => SetProperty("virtual_wan_id", value);
    }

    /// <summary>
    /// Block for link.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVpnSiteLinkBlock>? Link
    {
        set => SetProperty("link", value);
    }

    /// <summary>
    /// Block for o365_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 O365Policy block(s) allowed")]
    public List<AzurermVpnSiteO365PolicyBlock>? O365Policy
    {
        set => SetProperty("o365_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnSiteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
