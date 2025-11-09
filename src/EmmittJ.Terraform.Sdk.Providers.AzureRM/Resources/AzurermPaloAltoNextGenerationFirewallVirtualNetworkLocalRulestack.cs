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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    public TerraformProperty<string>? MarketplaceOfferId
    {
        get => GetProperty<TerraformProperty<string>>("marketplace_offer_id");
        set => this.WithProperty("marketplace_offer_id", value);
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
    /// The plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlanId
    {
        get => GetProperty<TerraformProperty<string>>("plan_id");
        set => this.WithProperty("plan_id", value);
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
    /// The rulestack_id attribute.
    /// </summary>
    public TerraformProperty<string>? RulestackId
    {
        get => GetProperty<TerraformProperty<string>>("rulestack_id");
        set => this.WithProperty("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
