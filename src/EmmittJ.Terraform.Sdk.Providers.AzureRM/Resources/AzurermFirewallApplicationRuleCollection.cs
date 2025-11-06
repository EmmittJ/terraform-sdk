using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_firewall_application_rule_collection resource.
/// </summary>
public class AzurermFirewallApplicationRuleCollection : TerraformResource
{
    public AzurermFirewallApplicationRuleCollection(string name) : base("azurerm_firewall_application_rule_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The azure_firewall_name attribute.
    /// </summary>
    public string? AzureFirewallName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("azure_firewall_name")?.Value;
        set => this.WithProperty("azure_firewall_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
