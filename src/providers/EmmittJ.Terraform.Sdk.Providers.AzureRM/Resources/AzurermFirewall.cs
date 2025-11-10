using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        set => SetProperty("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for management_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallManagementIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        set => SetProperty("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    public required TerraformProperty<string> PublicIpAddressId
    {
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_hub in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallVirtualHubBlock : TerraformBlock
{
    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        set => SetProperty("private_ip_address", value);
    }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpAddresses
    {
        set => SetProperty("public_ip_addresses", value);
    }

    /// <summary>
    /// The public_ip_count attribute.
    /// </summary>
    public TerraformProperty<double>? PublicIpCount
    {
        set => SetProperty("public_ip_count", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        set => SetProperty("virtual_hub_id", value);
    }

}

/// <summary>
/// Manages a azurerm_firewall resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFirewall : TerraformResource
{
    public AzurermFirewall(string name) : base("azurerm_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_proxy_enabled");
        SetOutput("dns_servers");
        SetOutput("firewall_policy_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("private_ip_ranges");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("sku_tier");
        SetOutput("tags");
        SetOutput("threat_intel_mode");
        SetOutput("zones");
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DnsProxyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dns_proxy_enabled");
        set => SetProperty("dns_proxy_enabled", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>> DnsServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("dns_servers");
        set => SetProperty("dns_servers", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformProperty<string> FirewallPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_policy_id");
        set => SetProperty("firewall_policy_id", value);
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
    /// The private_ip_ranges attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> PrivateIpRanges
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("private_ip_ranges");
        set => SetProperty("private_ip_ranges", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuTier is required")]
    public required TerraformProperty<string> SkuTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_tier");
        set => SetProperty("sku_tier", value);
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
    /// The threat_intel_mode attribute.
    /// </summary>
    public TerraformProperty<string> ThreatIntelMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("threat_intel_mode");
        set => SetProperty("threat_intel_mode", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFirewallIpConfigurationBlock>? IpConfiguration
    {
        set => SetProperty("ip_configuration", value);
    }

    /// <summary>
    /// Block for management_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementIpConfiguration block(s) allowed")]
    public List<AzurermFirewallManagementIpConfigurationBlock>? ManagementIpConfiguration
    {
        set => SetProperty("management_ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_hub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualHub block(s) allowed")]
    public List<AzurermFirewallVirtualHubBlock>? VirtualHub
    {
        set => SetProperty("virtual_hub", value);
    }

}
