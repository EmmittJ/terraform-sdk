using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_firewall_policy.
/// </summary>
public class AzurermFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermFirewallPolicyDataSource(string name) : base("azurerm_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("base_policy_id");
        this.DeclareOutput("child_policies");
        this.DeclareOutput("dns");
        this.DeclareOutput("firewalls");
        this.DeclareOutput("location");
        this.DeclareOutput("rule_collection_groups");
        this.DeclareOutput("tags");
        this.DeclareOutput("threat_intelligence_allowlist");
        this.DeclareOutput("threat_intelligence_mode");
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
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformExpression BasePolicyId => this["base_policy_id"];

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformExpression ChildPolicies => this["child_policies"];

    /// <summary>
    /// The dns attribute.
    /// </summary>
    public TerraformExpression Dns => this["dns"];

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformExpression Firewalls => this["firewalls"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformExpression RuleCollectionGroups => this["rule_collection_groups"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    public TerraformExpression ThreatIntelligenceAllowlist => this["threat_intelligence_allowlist"];

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformExpression ThreatIntelligenceMode => this["threat_intelligence_mode"];

}
