using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_firewall_policy_rule_collection_group resource.
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroup : TerraformResource
{
    public AzurermFirewallPolicyRuleCollectionGroup(string name) : base("azurerm_firewall_policy_rule_collection_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

}
