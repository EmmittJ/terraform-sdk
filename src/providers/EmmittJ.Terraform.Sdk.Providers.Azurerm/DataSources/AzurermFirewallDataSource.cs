using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermFirewallDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_firewall Terraform data source.
/// Retrieves information about a azurerm_firewall.
/// </summary>
public partial class AzurermFirewallDataSource(string name) : TerraformDataSource("azurerm_firewall", name)
{
    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DnsProxyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dns_proxy_enabled") ?? CreateReference("dns_proxy_enabled");
        set => SetArgument("dns_proxy_enabled", value);
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
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string> DnsServers
        => CreateReference("dns_servers");

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyId
        => CreateReference("firewall_policy_id");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
        => CreateReference("ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The management_ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementIpConfiguration
        => CreateReference("management_ip_configuration");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => CreateReference("sku_name");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
        => CreateReference("sku_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    public TerraformValue<string> ThreatIntelMode
        => CreateReference("threat_intel_mode");

    /// <summary>
    /// The virtual_hub attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VirtualHub
        => CreateReference("virtual_hub");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFirewallDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFirewallDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
