using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("dns_servers");
        this.DeclareOutput("firewall_policy_id");
        this.DeclareOutput("ip_configuration");
        this.DeclareOutput("location");
        this.DeclareOutput("management_ip_configuration");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("sku_tier");
        this.DeclareOutput("tags");
        this.DeclareOutput("threat_intel_mode");
        this.DeclareOutput("virtual_hub");
        this.DeclareOutput("zones");
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    public bool? DnsProxyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dns_proxy_enabled")?.Value;
        set => this.WithProperty("dns_proxy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
