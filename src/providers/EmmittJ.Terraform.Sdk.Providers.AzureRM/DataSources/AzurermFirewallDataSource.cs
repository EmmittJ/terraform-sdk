using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_firewall.
/// </summary>
public class AzurermFirewallDataSource : TerraformDataSource
{
    public AzurermFirewallDataSource(string name) : base("azurerm_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("dns_servers");
        this.WithOutput("firewall_policy_id");
        this.WithOutput("ip_configuration");
        this.WithOutput("location");
        this.WithOutput("management_ip_configuration");
        this.WithOutput("sku_name");
        this.WithOutput("sku_tier");
        this.WithOutput("tags");
        this.WithOutput("threat_intel_mode");
        this.WithOutput("virtual_hub");
        this.WithOutput("zones");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFirewallDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformExpression DnsServers => this["dns_servers"];

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformExpression FirewallPolicyId => this["firewall_policy_id"];

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The management_ip_configuration attribute.
    /// </summary>
    public TerraformExpression ManagementIpConfiguration => this["management_ip_configuration"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformExpression SkuTier => this["sku_tier"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    public TerraformExpression ThreatIntelMode => this["threat_intel_mode"];

    /// <summary>
    /// The virtual_hub attribute.
    /// </summary>
    public TerraformExpression VirtualHub => this["virtual_hub"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
