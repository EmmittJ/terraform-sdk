using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_firewall_policy resource.
/// </summary>
public class AzurermFirewallPolicy : TerraformResource
{
    public AzurermFirewallPolicy(string name) : base("azurerm_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("child_policies");
        this.DeclareOutput("firewalls");
        this.DeclareOutput("rule_collection_groups");
    }

    /// <summary>
    /// The auto_learn_private_ranges_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoLearnPrivateRangesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_learn_private_ranges_enabled");
        set => this.WithProperty("auto_learn_private_ranges_enabled", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? BasePolicyId
    {
        get => GetProperty<TerraformProperty<string>>("base_policy_id");
        set => this.WithProperty("base_policy_id", value);
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
    public TerraformProperty<List<string>>? PrivateIpRanges
    {
        get => GetProperty<TerraformProperty<List<string>>>("private_ip_ranges");
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
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    public TerraformProperty<bool>? SqlRedirectAllowed
    {
        get => GetProperty<TerraformProperty<bool>>("sql_redirect_allowed");
        set => this.WithProperty("sql_redirect_allowed", value);
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
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThreatIntelligenceMode
    {
        get => GetProperty<TerraformProperty<string>>("threat_intelligence_mode");
        set => this.WithProperty("threat_intelligence_mode", value);
    }

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformExpression ChildPolicies => this["child_policies"];

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformExpression Firewalls => this["firewalls"];

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformExpression RuleCollectionGroups => this["rule_collection_groups"];

}
