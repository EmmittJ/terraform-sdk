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
    public bool? AutoLearnPrivateRangesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_learn_private_ranges_enabled")?.Value;
        set => this.WithProperty("auto_learn_private_ranges_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public string? BasePolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_policy_id")?.Value;
        set => this.WithProperty("base_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The private_ip_ranges attribute.
    /// </summary>
    public List<string>? PrivateIpRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("private_ip_ranges")?.Value;
        set => this.WithProperty("private_ip_ranges", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_redirect_allowed attribute.
    /// </summary>
    public bool? SqlRedirectAllowed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sql_redirect_allowed")?.Value;
        set => this.WithProperty("sql_redirect_allowed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public string? ThreatIntelligenceMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("threat_intelligence_mode")?.Value;
        set => this.WithProperty("threat_intelligence_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
