using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_firewall resource.
/// </summary>
public class AzurermFirewall : TerraformResource
{
    public AzurermFirewall(string name) : base("azurerm_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsProxyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dns_proxy_enabled");
        set => this.WithProperty("dns_proxy_enabled", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DnsServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy_id");
        set => this.WithProperty("firewall_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? PrivateIpRanges
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("private_ip_ranges");
        set => this.WithProperty("private_ip_ranges", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformProperty<string>? SkuTier
    {
        get => GetProperty<TerraformProperty<string>>("sku_tier");
        set => this.WithProperty("sku_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThreatIntelMode
    {
        get => GetProperty<TerraformProperty<string>>("threat_intel_mode");
        set => this.WithProperty("threat_intel_mode", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
