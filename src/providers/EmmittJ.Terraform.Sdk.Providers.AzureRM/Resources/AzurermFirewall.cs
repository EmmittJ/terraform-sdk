using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }


    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for management_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallManagementIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management_ip_configuration";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }


    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    [TerraformArgument("public_ip_address_id")]
    public required TerraformValue<string> PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for virtual_hub in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallVirtualHubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_hub";



    /// <summary>
    /// The public_ip_count attribute.
    /// </summary>
    [TerraformArgument("public_ip_count")]
    public TerraformValue<double>? PublicIpCount
    {
        get => new TerraformReference<double>(this, "public_ip_count");
        set => SetArgument("public_ip_count", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    [TerraformArgument("virtual_hub_id")]
    public required TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
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
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    [TerraformArgument("dns_proxy_enabled")]
    public TerraformValue<bool> DnsProxyEnabled
    {
        get => new TerraformReference<bool>(this, "dns_proxy_enabled");
        set => SetArgument("dns_proxy_enabled", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformArgument("firewall_policy_id")]
    public TerraformValue<string>? FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
        set => SetArgument("firewall_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    [TerraformArgument("private_ip_ranges")]
    public TerraformSet<string>? PrivateIpRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "private_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuTier is required")]
    [TerraformArgument("sku_tier")]
    public required TerraformValue<string> SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    [TerraformArgument("threat_intel_mode")]
    public TerraformValue<string> ThreatIntelMode
    {
        get => new TerraformReference<string>(this, "threat_intel_mode");
        set => SetArgument("threat_intel_mode", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("ip_configuration")]
    public TerraformList<AzurermFirewallIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for management_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementIpConfiguration block(s) allowed")]
    [TerraformArgument("management_ip_configuration")]
    public TerraformList<AzurermFirewallManagementIpConfigurationBlock> ManagementIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFirewallTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_hub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualHub block(s) allowed")]
    [TerraformArgument("virtual_hub")]
    public TerraformList<AzurermFirewallVirtualHubBlock> VirtualHub { get; set; } = new();

}
