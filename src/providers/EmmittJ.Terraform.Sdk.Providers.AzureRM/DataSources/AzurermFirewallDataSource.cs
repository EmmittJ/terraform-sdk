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
        set => SetProperty("read", value);
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
        SetOutput("dns_servers");
        SetOutput("firewall_policy_id");
        SetOutput("ip_configuration");
        SetOutput("location");
        SetOutput("management_ip_configuration");
        SetOutput("sku_name");
        SetOutput("sku_tier");
        SetOutput("tags");
        SetOutput("threat_intel_mode");
        SetOutput("virtual_hub");
        SetOutput("zones");
        SetOutput("dns_proxy_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
