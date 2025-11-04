using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack resource.
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The marketplace_offer_id attribute.
    /// </summary>
    public string? MarketplaceOfferId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("marketplace_offer_id")?.Value;
        set => this.WithProperty("marketplace_offer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The plan_id attribute.
    /// </summary>
    public string? PlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan_id")?.Value;
        set => this.WithProperty("plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The rulestack_id attribute.
    /// </summary>
    public string? RulestackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rulestack_id")?.Value;
        set => this.WithProperty("rulestack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
