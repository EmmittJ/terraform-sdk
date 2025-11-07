using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_firewall_network_rule_collection resource.
/// </summary>
public class AzurermFirewallNetworkRuleCollection : TerraformResource
{
    public AzurermFirewallNetworkRuleCollection(string name) : base("azurerm_firewall_network_rule_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The azure_firewall_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AzureFirewallName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("azure_firewall_name");
        set => this.WithProperty("azure_firewall_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
