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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_firewall.
/// </summary>
public class AzurermFirewallDataSource : TerraformDataSource
{
    public AzurermFirewallDataSource(string name) : base("azurerm_firewall", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFirewallDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformList<string> DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformArgument("firewall_policy_id")]
    public TerraformValue<string> FirewallPolicyId
    {
        get => new TerraformReference<string>(this, "firewall_policy_id");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformArgument("ip_configuration")]
    public TerraformList<object> IpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The management_ip_configuration attribute.
    /// </summary>
    [TerraformArgument("management_ip_configuration")]
    public TerraformList<object> ManagementIpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "management_ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformArgument("sku_tier")]
    public TerraformValue<string> SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    [TerraformArgument("threat_intel_mode")]
    public TerraformValue<string> ThreatIntelMode
    {
        get => new TerraformReference<string>(this, "threat_intel_mode");
    }

    /// <summary>
    /// The virtual_hub attribute.
    /// </summary>
    [TerraformArgument("virtual_hub")]
    public TerraformList<object> VirtualHub
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "virtual_hub").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
